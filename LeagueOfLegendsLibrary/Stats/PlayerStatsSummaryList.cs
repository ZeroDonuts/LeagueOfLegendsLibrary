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
        /// List of player stats summaries associated with the summoner. Updated to Statsv1.2
        /// </summary>
        [DataMember(Name="playerStatSummaries")]
        private List<PlayerStatsSummary> _playerStatSummaries;

        public List<PlayerStatsSummary> PlayerStatSummaries
        {
            get
            {
                return _playerStatSummaries;
            }
        }

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name="summonerId")]
        private long _summonerId;

        public long AverageNodeNeutralize
        {
            get
            {
                return _summonerId;
            }
        }
    }
}
