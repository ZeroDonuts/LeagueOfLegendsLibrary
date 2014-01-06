using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class MatchHistorySummary
    {
        [DataMember(Name = "assists")]
        private int assists;

        [DataMember(Name = "deaths")]
        private int deaths;

        [DataMember(Name = "gameId")]
        private long gameId;

        [DataMember(Name = "invalid")]
        private bool invalid;

        [DataMember(Name = "kills")]
        private int kills;

        [DataMember(Name = "mapId")]
        private int mapID;

        [DataMember(Name = "opposingTeamKills")]
        private int opposingTeamKills;

        [DataMember(Name = "opposingTeamName")]
        private string opposingTeamName;

        [DataMember(Name = "win")]
        private bool win;
    }
}
