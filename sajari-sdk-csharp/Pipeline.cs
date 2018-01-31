using System;
using System.Collections.Generic;
using Grpc.Core;

namespace sajari
{
    partial class Client
    {
        /// <summary>
        /// Pipeline.
        /// </summary>
		public class Pipeline
        {
            private string name;
            private Client client;

            protected Pipeline(Client client, string name)
            {
                this.name = name;
                this.client = client;
            }

            private Sajari.Api.Pipeline.V1.Pipeline pipeline()
            {
                return new Sajari.Api.Pipeline.V1.Pipeline { Name = this.name };
            }

            public Response Search(Dictionary<string, string> values, Tracking tracking)
            {
                var searchRequest = new Sajari.Api.Pipeline.V1.SearchRequest
                {
                    Pipeline = this.pipeline(),
                    Tracking = tracking.Proto(),
                };

                foreach (var item in values)
                {
                    searchRequest.Values.Add(item.Key, item.Value);
                }

                Channel channel = new Channel(Client.API_ROOT, new Grpc.Core.SslCredentials());
                var c = new Sajari.Api.Pipeline.V1.Query.QueryClient(channel);

                try
                {
                    var resp = c.Search(searchRequest, client.Metadata());
                    foreach (var r in resp.SearchResponse_.Results)
                    {
                        Console.Write("Score: ");
                        Console.WriteLine(r.Score);
                        foreach (var v in r.Values)
                        {
                            Console.Write("    ");
                            Console.Write(v.Key);
                            Console.Write(": ");
                            Console.WriteLine(v.Value);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("DONE");
                return null;
            }
        }
    }
}
