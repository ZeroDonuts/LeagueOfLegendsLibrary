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
        private int _assists;

        public int Assists
        {
            get
            {
                return _assists;
            }
        }

        [DataMember(Name = "deaths")]
        private int _deaths;

        public int Deaths
        {
            get
            {
                return _deaths;
            }
        }

        [DataMember(Name = "gameId")]
        private long _gameId;

        public long GameID
        {
            get
            {
                return _gameId;
            }
        }

        [DataMember(Name = "invalid")]
        private bool _invalid;

        public bool Invalid
        {
            get
            {
                return _invalid;
            }
        }

        [DataMember(Name = "kills")]
        private int _kills;

        public int Kills
        {
            get
            {
                return _kills;
            }
        }

        [DataMember(Name = "mapId")]
        private int _mapId;

        public int MapId
        {
            get
            {
                return _mapId;
            }
        }

        [DataMember(Name = "opposingTeamKills")]
        private int _opposingTeamKills;

        public int OpposingTeamKills
        {
            get
            {
                return _opposingTeamKills;
            }
        }

        [DataMember(Name = "opposingTeamName")]
        private string _opposingTeamName;

        public string OpposingTeamName
        {
            get
            {
                return _opposingTeamName;
            }
        }

        [DataMember(Name = "win")]
        private bool _win;

        public bool Win
        {
            get
            {
                return _win;
            }
        }
    }
}
