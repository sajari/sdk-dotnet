using System;
using sajari;
using System.Collections.Generic;

namespace pipelinesearch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var keyID = Environment.GetEnvironmentVariable("AUTH_KEY_ID");
            var keySecret = Environment.GetEnvironmentVariable("AUTH_KEY_SECRET");
            var c = new sajari.Client("sajariptyltd", "sajari-com", new sajari.KeySecret(keyID, keySecret));
            var p = c.Pipeline("website");
            var d = new Dictionary<string, string> {
                { "q", "gss" },
            };
            p.Search(d, new Tracking());
            Console.WriteLine("Hello");
        }
    }
}
