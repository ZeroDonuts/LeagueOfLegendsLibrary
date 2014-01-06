using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class Team
    {
        [DataMember(Name = "createDate")]
        private long createDate;
        public DateTime CreateDate 
        {
            get
            {
                return LolInfo.EpochToDateTime(createDate);
            }
        }

        [DataMember(Name = "fullId")]
        private string fullId;

        [DataMember(Name = "lastGameDate")]
        private long lastGameDate;
        public DateTime LastGameDate
        {
            get
            {
                return LolInfo.EpochToDateTime(lastGameDate);
            }
        }

        [DataMember(Name = "lastJoinDate")]
        private long lastJoinDate;

        public DateTime LastJoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(lastJoinDate);
            }
        }

        [DataMember(Name = "lastJoinedRankedTeamQueueDate")]
        private long lastJoinedRankedTeamQueueDate;

        public DateTime LastJoinedRankedTeamQueueDate
        {
            get
            {
                return LolInfo.EpochToDateTime(lastJoinedRankedTeamQueueDate);
            }
        }

        [DataMember(Name = "matchHistory")]
        private List<MatchHistorySummary> matchHistory;

        [DataMember(Name = "messageOfDay")]
        private MessageOfDay messageOfDay;

        [DataMember(Name = "modifyDate")]
        private long modifyDate;

        public DateTime ModifyDate
        {
            get
            {
                return LolInfo.EpochToDateTime(modifyDate);
            }
        }

        [DataMember(Name = "name")]
        private string name;

        [DataMember(Name = "roster")]
        private Roster roster;

        [DataMember(Name = "secondLastJoinDate")]
        private long secondLastJoinDate;

        public DateTime SecondLastJoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(secondLastJoinDate);
            }
        }

        [DataMember(Name = "status")]
        private string status;

        [DataMember(Name = "tag")]
        private string tag;
        
        [DataMember(Name = "teamStatSummary")]
        private TeamStatSummary teamStatSummary;

        [DataMember(Name = "thirdLastJoinDate")]
        private long thirdLastJoinDate;

        public DateTime ThirdLastJoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(thirdLastJoinDate);
            }
        }
    }
}
