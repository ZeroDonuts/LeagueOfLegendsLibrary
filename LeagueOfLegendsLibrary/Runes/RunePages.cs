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
        /// <summary>
        /// Set of rune pages associated with the summoner.
        /// </summary>
        private RunePage[] _pages;

        public RunePage[] pages
        {
            get { return _pages; }
        }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        private long _summonerId;

        public long summonerId
        {
            get { return _summonerId; }
        }

    }
}
