using System;
using System.Collections.Generic;

namespace sajari
{
    public class Response
    {
        private Token[] tokens;

        public Response(Sajari.Api.Query.V1.SearchResponse response)
        {
            foreach (var t in response.Tokens) {
                t.TokenCase.GetType();
            }
        }
    }
}
