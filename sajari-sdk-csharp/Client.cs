using System;
using System.Collections.Generic;
using Grpc.Core;

namespace sajari
{
    public interface ICredentials
    {
        string Credentials();
    }

    public class KeySecret : ICredentials
    {
        private string key, secret;

        public KeySecret(string key, string secret)
        {
            this.key = key;
            this.secret = secret;
        }

        public string Credentials()
        {
            return String.Format("keysecret {0} {1}", this.key, this.secret);
        }
    }

    /// <summary>   
    /// Client makes requests to the Sajari API.
    /// </summary>
    public partial class Client
    {
        public const string API_ROOT = "api.sajari.com:443";
        public const string USER_AGENT = "sajari-sdk-csharp alpha";

        private string project;
        private string collection;

        private ICredentials creds;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:sajarisdkcsharp.Client"/> class.
        /// </summary>
        /// <param name="project">Project.</param>
        /// <param name="collection">Collection.</param>
        /// <param name="creds">Creds.</param>
        public Client(string project, string collection, ICredentials creds)
        {
            this.project = project;
            this.collection = collection;

            this.creds = creds;
        }

        private Metadata Metadata()
        {
            var m = new Metadata
            {
                { "project", this.project },
                { "collection", this.collection },
                { "authorization", this.creds.Credentials() },
                { "useragent", USER_AGENT }
            };
            return m;
        }

        /// <summary>
        /// Pipeline creates a new Pipeline with specified name.
        /// </summary>
        /// <returns>The pipeline.</returns>
        /// <param name="name">Name.</param>
        public Pipeline Pipeline(string name)
        {
            return new Pipeline(this, name);
        }
    }
}
