using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class RunePages
    {
        [DataMember(Name = "pages")]
        private RunePage[] _pages;

        /// <summary>
        /// Set of rune pages associated with the summoner.
        /// </summary>
        public RunePage[] pages
        {
            get { return _pages; }
        }

        [DataMember(Name = "summonerId")]
        private long _summonerId;

        /// <summary>
        /// Summoner ID.
        /// </summary>
        public long summonerId
        {
            get { return _summonerId; }
        }

    }
}
