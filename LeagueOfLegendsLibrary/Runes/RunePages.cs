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
        public RunePage[] pages;

        /// <summary>
        /// Summoner ID.
        /// </summary>
        public long summonerId;

    }
}
