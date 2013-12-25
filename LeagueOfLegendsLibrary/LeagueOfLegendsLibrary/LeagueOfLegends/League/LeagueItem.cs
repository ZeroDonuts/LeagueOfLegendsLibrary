using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class LeagueItem
    {
        [DataMember(Name="isFreshBlood")]
        public bool isFreshBlood;

        [DataMember(Name = "isHotStreak")]
        public bool isHotStreak;

        [DataMember(Name = "isInactive")]
        public bool isInactive;

        [DataMember(Name = "isVeteran")]
        public bool isVeteran;

        [DataMember(Name = "lastPlayed")]
        public long lastPlayed;

        [DataMember(Name = "leagueName")]
        public string leagueName;

        [DataMember(Name = "leaguePoints")]
        public int leaguePoints;

        [DataMember(Name = "miniSeries")]
        public MiniSeries miniSeries;

        [DataMember(Name = "playerOrTeamId")]
        public string playerOrTeamId;

        [DataMember(Name = "playerOrTeamName")]
        public string playerOrTeamName;

        [DataMember(Name = "queueType")]
        public string queueType;

        [DataMember(Name = "rank")]
        public string rank;

        [DataMember(Name = "tier")]
        public string tier;

        [DataMember(Name = "wins")]
        public int wins;
    }
}
