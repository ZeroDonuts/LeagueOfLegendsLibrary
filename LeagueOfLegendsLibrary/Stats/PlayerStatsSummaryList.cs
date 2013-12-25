using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class PlayerStatsSummaryList
    {
        /// <summary>
        /// List of player stats summaries associated with the summoner.
        /// </summary>
        [DataMember(Name="playerStatSummaries")]
        public List<PlayerStatsSummary> playerStatSummaries;

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name="summonerId")]
        public long summonerId;
    }
}
