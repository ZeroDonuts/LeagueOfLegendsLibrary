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
        private AggregatedStats _aggregatedStats;

        public AggregatedStats AggregatedStats
        {
            get
            {
                return _aggregatedStats;
            }
        }

        /// <summary>
        /// Number of losses for this queue type. Returned for ranked queue types only
        /// </summary>
        [DataMember(Name = "losses")]
        private int _losses;

        public int Losses
        {
            get
            {
                return _losses;
            }
        }

        /// <summary>
        /// Date stats were last modified specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "modifyDate")]
        private long _modifyDate;

        public long ModifyDate
        {
            get
            {
                return _modifyDate;
            }
        }


        /// <summary>
        /// Player stats summary type. 
        /// (legal values: AramUnranked5x5, CoopVsAI, OdinUnranked, RankedPremade3x3, 
        /// RankedPremade5x5, RankedSolo5x5, 
        /// RankedTeam3x3, RankedTeam5x5, 
        /// Unranked, Unranked3x3, OneForAll5x5, FirstBlood1x1, FirstBlood2x2)
        /// </summary>
       [DataMember(Name = "playerStatSummaryType")]
        private string _playerStatSummaryType;

       public string PlayerStatsSummaryType
       {
           get
           {
               return _playerStatSummaryType;
           }
       }

        /// <summary>
        /// Number of wins for this queue type.
        /// </summary>
        [DataMember(Name="wins")]
        private int _wins;

        public int Wins
        {
            get
            {
                return _wins;
            }
        }
    }
}
