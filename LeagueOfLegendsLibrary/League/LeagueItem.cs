using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class LeagueItem
    {
        [DataMember(Name="isFreshBlood")]
        private bool _isFreshBlood;
        public bool IsFreshBlood
        {
            get
            {
                return _isFreshBlood;
            }
        }

        [DataMember(Name = "isHotStreak")]
        private bool _isHotStreak;

        public bool IsHotStreak
        {
            get
            {
                return _isHotStreak;
            }
        }

        [DataMember(Name = "isInactive")]
        private bool _isInactive;

        public bool IsInactive
        {
            get
            {
                return _isInactive;
            }
        }

        [DataMember(Name = "isVeteran")]
        private bool _isVeteran;

        public bool IsVeteran
        {
            get
            {
                return _isVeteran;
            }
        }

        [DataMember(Name = "lastPlayed")]
        private long _lastPlayed;

        public long LastPlayed
        {
            get
            {
                return _lastPlayed;
            }
        }

        [DataMember(Name = "leagueName")]
        private string _leagueName;

        public string LeagueName
        {
            get
            {
                return _leagueName;
            }
        }

        [DataMember(Name = "leaguePoints")]
        private int _leaguePoints;

        public int LeaguePoints
        {
            get
            {
                return _leaguePoints;
            }
        }
        //currently bugged when calling infograbber.getleague
        //[DataMember(Name = "miniSeries")]
        private MiniSeries _miniSeries;

        public MiniSeries MiniSeries
        {
            get
            {
                return _miniSeries;
            }
        }

        [DataMember(Name = "playerOrTeamId")]
        private string _playerOrTeamId;

        public string PlayerOrTeamId
        {
            get
            {
                return _playerOrTeamId;
            }
        }

        [DataMember(Name = "playerOrTeamName")]
        private string _playerOrTeamName;

        public string PlayerOrTeamName
        {
            get
            {
                return _playerOrTeamName;
            }
        }

        [DataMember(Name = "queueType")]
        private string _queueType;

        public string QueueType
        {
            get
            {
                return _queueType;
            }
        }

        [DataMember(Name = "rank")]
        private string _rank;

        public string Rank
        {
            get
            {
                return _rank;
            }
        }

        [DataMember(Name = "tier")]
        private string _tier;

        public string Tier
        {
            get
            {
                return _tier;
            }
        }

        [DataMember(Name = "wins")]
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
