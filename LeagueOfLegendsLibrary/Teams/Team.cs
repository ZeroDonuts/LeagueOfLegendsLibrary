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
        private long _createDate;

        public DateTime CreateDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_createDate);
            }
        }

        [DataMember(Name = "fullId")]
        private string _fullId;

        public string FullId
        {
            get
            {
                return _fullId;
            }
        }

        [DataMember(Name = "lastGameDate")]
        private long _lastGameDate;

        public DateTime LastGameDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_lastGameDate);
            }
        }

        [DataMember(Name = "lastJoinDate")]
        private long _lastJoinDate;

        public DateTime LastJoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_lastJoinDate);
            }
        }

        [DataMember(Name = "lastJoinedRankedTeamQueueDate")]
        private long _lastJoinedRankedTeamQueueDate;

        public DateTime LastJoinedRankedTeamQueueDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_lastJoinedRankedTeamQueueDate);
            }
        }

        [DataMember(Name = "matchHistory")]
        private List<MatchHistorySummary> _matchHistory;

        public List<MatchHistorySummary> MatchHistory
        {
            get
            {
                return _matchHistory;
            }
        }

        [DataMember(Name = "messageOfDay")]
        private MessageOfDay _messageOfDay;

        public MessageOfDay messageOfDay
        {
            get
            {
                return _messageOfDay;
            }
        }

        [DataMember(Name = "modifyDate")]
        private long _modifyDate;

        public DateTime ModifyDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_modifyDate);
            }
        }

        [DataMember(Name = "name")]
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        [DataMember(Name = "roster")]
        private Roster _roster;

        public Roster Roster
        {
            get
            {
                return _roster;
            }
        }

        [DataMember(Name = "secondLastJoinDate")]
        private long _secondLastJoinDate;

        public DateTime SecondLastJoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_secondLastJoinDate);
            }
        }

        [DataMember(Name = "status")]
        private string _status;

        public string Status
        {
            get
            {
                return _status;
            }
        }

        [DataMember(Name = "tag")]
        private string _tag;

        public string Tag
        {
            get
            {
                return _tag;
            }
        }

        [DataMember(Name = "teamStatSummary")]
        private TeamStatSummary _teamStatSummary;

        public TeamStatSummary TeamStatSummary
        {
            get
            {
                return _teamStatSummary;
            }
        }

        [DataMember(Name = "thirdLastJoinDate")]
        private long _thirdLastJoinDate;

        public DateTime ThirdLastJoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_thirdLastJoinDate);
            }
        }
    }
}
