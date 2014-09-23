using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    /// <summary>
    /// Game class as represented by Gamev1.3
    /// </summary>
    [DataContract(Name="GameDto")]
    public class Game
    {
        [DataMember(Name = "championId")]
        private int _championId;

        /// <summary>
        /// Champion ID associated with game.
        /// </summary>
        public int ChampionId
        {
            get { return _championId; }
        }

        [DataMember(Name = "createDate")]
        private long _createDate;

        /// <summary>
        /// Date game was played specified as epoch milliseconds.
        /// </summary>
        public long CreateDate
        {
            get { return _createDate; }
        }

        [DataMember(Name = "createDateStr")]
        private string _createDateStr;

        /// <summary>
        /// Human readable string representing date game was played.
        /// </summary>
        public string CreateDateStr
        {
            get { return _createDateStr; }
        }

        /// <summary>
        /// Datetime object of the date game was played
        /// </summary>
        public DateTime CreateDateTime
        {
            get
            {
                return LolInfo.EpochToDateTime(_createDate);
            }
        }

        [DataMember(Name = "fellowPlayers")]
        private List<Player> _fellowPlayers;

        /// <summary>
        /// Other players associated with the game.
        /// </summary>
        public List<Player> FellowPlayers
        {
            get { return _fellowPlayers; }
        }

        [DataMember(Name = "gameId")]
        private long _gameId;

        /// <summary>
        /// Game ID.
        /// </summary>
        public long GameId
        {
            get { return _gameId; }
        }

        [DataMember(Name = "gameMode")]
        private string _gameMode;

        /// <summary>
        /// Game mode.
        /// </summary>
        public string GameMode
        {
            get { return _gameMode; }
        }

        [DataMember(Name = "gameType")]
        private string _gameType;

        /// <summary>
        /// Game type.
        /// </summary>
        public string GameType
        {
            get { return _gameType; }
        }

        [DataMember(Name = "invalid")]
        private bool _invalid;

        /// <summary>
        /// Invalid flag.
        /// </summary>
        public bool Invalid
        {
            get { return _invalid; }
        }

        [DataMember(Name = "level")]
        private int _level;

        /// <summary>
        /// Level.
        /// </summary>
        public int Level
        {
            get { return _level; }
        }

        [DataMember(Name = "mapId")]
        private int _mapId;

        /// <summary>
        /// Map ID.
        /// </summary>
        public int MapId
        {
            get { return _mapId; }
        }

        [DataMember(Name = "spell1")]
        private int _spell1;

        /// <summary>
        /// ID of first summoner spell.
        /// </summary>
        public int Spell1
        {
            get { return _spell1; }
        }

        [DataMember(Name = "spell2")]
        private int _spell2;

        /// <summary>
        /// ID of second summoner spell.
        /// </summary>
        public int Spell2
        {
            get { return _spell2; }
        }

        [DataMember(Name = "stats")]
        private RawStats _stats;

        public RawStats Statistics
        {
            get
            {
                return _stats;
            }
        }

        /// <summary>
        /// Statistics associated with the game for this summoner.
        /// </summary>
        [DataMember(Name = "subType")]
        private string _subType;

        /// <summary>
        /// Game sub-type.
        /// </summary>
        public string subType
        {
            get { return _subType; }
        }

        [DataMember(Name = "teamId")]
        private int _teamId;

        /// <summary>
        /// Team ID associated with game.
        /// </summary>
        public int teamId
        {
            get { return _teamId; }
        }
    }
}