using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class TeamStatDetail
    {
        [DataMember(Name = "averageGamesPlayed")]
        private int _averageGamesPlayed;

        public int AverageGamesPlayed { get {return _averageGamesPlayed ;}}

        [DataMember(Name = "fullId")]
        private string _fullID;

        public string FullID
        {
            get
            {
                return _fullID;
            }
        }

        [DataMember(Name = "losses")]
        private int _losses;

        public int Losses
        {
            get
            {
                return _losses;
            }
        }

        [DataMember(Name = "teamStatType")]
        private string _teamStatType;

        public string TeamStatType
        {
            get
            {
                return _teamStatType;
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
