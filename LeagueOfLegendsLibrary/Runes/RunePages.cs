using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;

namespace LeagueOfLegendsLibrary
{
    public class RunePages
    {
        private RunePage[] _pages;

        /// <summary>
        /// Set of rune pages associated with the summoner.
        /// </summary>
        public RunePage[] pages
        {
            get { return _pages; }
        }

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
