using System;
using System.Collections.Generic;

namespace sajari
{
    /// <summary>
    /// Token type.
    /// </summary>
    public enum TokenType
    {
        Click,
        PosNeg,
    }

    public class Token
    {
        private TokenType ty;
        private string clickToken;
        private string posToken;
        private string negToken;

        public Token(Sajari.Api.Query.V1.Token token) {
            switch (token.TokenCase) {
                case Sajari.Api.Query.V1.Token.TokenOneofCase.Click:
                    this.ty = TokenType.Click;
                    this.clickToken = token.Click.Token;
                    break;
                case Sajari.Api.Query.V1.Token.TokenOneofCase.PosNeg:
                    this.ty = TokenType.PosNeg;
                    this.posToken = token.PosNeg.Pos;
                    this.negToken = token.PosNeg.Neg;
                    break;
                default:
                    throw new Exception("invalid token type")
            }
        }

        public string ClickToken() {
            return this.clickToken;
        }
    }

    public class Response
    {
        private List<Token> tokens;
        private List<Dictionary<string, List<string>>> results;

        public Response(Sajari.Api.Query.V1.SearchResponse response)
        {
            this.tokens = new List<Token>();
   
            foreach (var x in response.Tokens.Select((value, index) => new { value, index })) {
                this.tokens.Add(new Token(t));
                this.results.Add(response.SearchResponse_.Results.IndexOf(i));
                i++;
            }
        }
    }
}
