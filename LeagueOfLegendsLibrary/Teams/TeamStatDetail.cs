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
        private int averageGamesPlayed;

        [DataMember(Name = "fullId")]
        private string fullID;

        [DataMember(Name = "losses")]
        private int losses;

        [DataMember(Name = "teamStatType")]
        private string teamStatType;

        [DataMember(Name = "wins")]
        private int wins;
    }
}
