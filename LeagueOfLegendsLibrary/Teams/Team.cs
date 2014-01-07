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

        public DateTime createDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_createDate);
            }
        }

        [DataMember(Name = "fullId")]
        private string _fullId;

        public string fullId
        {
            get
            {
                return _fullId;
            }
        }

        [DataMember(Name = "lastGameDate")]
        private long _lastGameDate;

        public DateTime lastGameDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_lastGameDate);
            }
        }

        [DataMember(Name = "lastJoinDate")]
        private long _lastJoinDate;

        public DateTime lastJoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_lastJoinDate);
            }
        }

        [DataMember(Name = "lastJoinedRankedTeamQueueDate")]
        private long _lastJoinedRankedTeamQueueDate;

        public DateTime lastJoinedRankedTeamQueueDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_lastJoinedRankedTeamQueueDate);
            }
        }

        [DataMember(Name = "matchHistory")]
        private List<MatchHistorySummary> _matchHistory;

        public List<MatchHistorySummary> matchHistory
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

        public DateTime modifyDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_modifyDate);
            }
        }

        [DataMember(Name = "name")]
        private string _name;

        public string name
        {
            get
            {
                return _name;
            }
        }

        [DataMember(Name = "roster")]
        private Roster _roster;

        public Roster roster
        {
            get
            {
                return _roster;
            }
        }

        [DataMember(Name = "secondLastJoinDate")]
        private long _secondLastJoinDate;

        public DateTime secondLastJoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_secondLastJoinDate);
            }
        }

        [DataMember(Name = "status")]
        private string _status;

        public string status
        {
            get
            {
                return _status;
            }
        }

        [DataMember(Name = "tag")]
        private string _tag;

        public string tag
        {
            get
            {
                return _tag;
            }
        }

        [DataMember(Name = "teamStatSummary")]
        private TeamStatSummary _teamStatSummary;

        public TeamStatSummary teamStatSummary
        {
            get
            {
                return _teamStatSummary;
            }
        }

        [DataMember(Name = "thirdLastJoinDate")]
        private long _thirdLastJoinDate;

        public DateTime thirdLastJoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_thirdLastJoinDate);
            }
        }
    }
}
