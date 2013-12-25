using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class PlayerStatsSummary
    {
        /// <summary>
        /// Aggregated stats.
        /// </summary>
        [DataMember(Name = "aggregatedStats")]
        public AggregatedStats aggregatedStats;

        /// <summary>
        /// Number of losses for this queue type. Returned for ranked queue types only
        /// </summary>
        [DataMember(Name = "losses")]
        public int losses;

        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "modifyDate")]
        public long modifyDate;


        /// <summary>
        /// Player stats summary type. 
        /// (legal values: AramUnranked5x5, CoopVsAI, OdinUnranked, RankedPremade3x3, 
        /// RankedPremade5x5, RankedSolo5x5, 
        /// RankedTeam3x3, RankedTeam5x5, 
        /// Unranked, Unranked3x3, OneForAll5x5, FirstBlood1x1, FirstBlood2x2)
        /// </summary>
       [DataMember(Name = "playerStatSummaryType")]
        public string playerStatSummaryType;

        /// <summary>
        /// Number of wins for this queue type.
        /// </summary>
        [DataMember(Name="wins")]
        public int wins;
    }
}
