﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace sajari
{
    private static Random random = new Random();
    private static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    /// <summary>
    /// Tracking type.
    /// </summary>
    public enum TrackingType
    {
        None,
        Click,
        PosNeg,
    }

    /// <summary>
    /// Tracking.
    /// </summary>
    public class Tracking
    {
        private string field;
        private TrackingType type;

        private string queryID;
        private int seq;

        private Dictionary<string, string> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:sajari.Tracking"/> class.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="field">Field.</param>
        public Tracking(TrackingType type, string field)
        {
            this.type = type;
            this.field = field;
        }

        /// <summary>
        /// Reset the query tracking.
        /// </summary>
        public void Reset() {
            this.queryID = RandomString(20);
            this.seq = 0;
        }

        /// <summary>
        /// Next this instance.
        /// </summary>
        public void Next() {
            this.seq++;
        }

        public Sajari.Api.Query.V1.SearchRequest.Types.Tracking Proto()
        {
            Sajari.Api.Query.V1.SearchRequest.Types.Tracking.Types.Type type;
            switch (this.type) {
                case TrackingType.None:
                    type = Sajari.Api.Query.V1.SearchRequest.Types.Tracking.Types.Type.None;
                    
            }

            return new Sajari.Api.Query.V1.SearchRequest.Types.Tracking {
                Field = field,
                QueryId = queryID,
                Sequence = seq,
            };
        }
    }
}
