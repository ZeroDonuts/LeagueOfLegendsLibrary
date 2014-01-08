using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Runtime.Serialization;
using ZeroLibrary;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="GameDto")]
    public class Game
    {
        [DataMember(Name = "championId")]
        private int _championId;

        /// <summary>
        /// Champion ID associated with game.
        /// </summary>
        public int championId
        {
            get { return _championId; }
        }

        [DataMember(Name = "createDate")]
        private long _createDate;

        /// <summary>
        /// Date game was played specified as epoch milliseconds.
        /// </summary>
        public long createDate
        {
            get { return _createDate; }
        }

        [DataMember(Name = "createDateStr")]
        private string _createDateStr;

        /// <summary>
        /// Human readable string representing date game was played.
        /// </summary>
        public string createDateStr
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
        public List<Player> fellowPlayers
        {
            get { return _fellowPlayers; }
        }

        [DataMember(Name = "gameId")]
        private long _gameId;

        /// <summary>
        /// Game ID.
        /// </summary>
        public long gameId
        {
            get { return _gameId; }
        }

        [DataMember(Name = "gameMode")]
        private string _gameMode;

        /// <summary>
        /// Game mode.
        /// </summary>
        public string gameMode
        {
            get { return _gameMode; }
        }

        [DataMember(Name = "gameType")]
        private string _gameType;

        /// <summary>
        /// Game type.
        /// </summary>
        public string gameType
        {
            get { return _gameType; }
        }

        [DataMember(Name = "invalid")]
        private bool _invalid;

        /// <summary>
        /// Invalid flag.
        /// </summary>
        public bool invalid
        {
            get { return _invalid; }
        }

        [DataMember(Name = "level")]
        private int _level;

        /// <summary>
        /// Level.
        /// </summary>
        public int level
        {
            get { return _level; }
        }

        [DataMember(Name = "mapId")]
        private int _mapId;

        /// <summary>
        /// Map ID.
        /// </summary>
        public int mapId
        {
            get { return _mapId; }
        }

        [DataMember(Name = "spell1")]
        private int _spell1;

        /// <summary>
        /// ID of first summoner spell.
        /// </summary>
        public int spell1
        {
            get { return _spell1; }
        }

        [DataMember(Name = "spell2")]
        private int _spell2;

        /// <summary>
        /// ID of second summoner spell.
        /// </summary>
        public int spell2
        {
            get { return _spell2; }
        }

        [DataMember(Name = "statistics")]
        private List<RawStat> statistics;

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

        /// <summary>
        /// Gets the RawStat of the specified ID
        /// </summary>
        /// <param name="stat">RawStatID to be searched</param>
        /// <returns>RawStat object of that ID</returns>
        public RawStat GetStat(RawStatID stat)
        {
            for (int i = 0; i < statistics.Count; i++)
            {
                if (stat.ToInt() == statistics[i].id)
                {
                    return statistics[i];
                }
            }
            throw new KeyNotFoundException("RawStatID not found");
        }

        /// <summary>
        /// Gets the RawStat of the match result
        /// </summary>
        /// <returns>RawStat of the match result</returns>
        public RawStat GetMatchResult()
        {
            RawStat matchResult;

            try
            {
                matchResult = GetStat(RawStatID.MatchWon);
            }
            catch
            {
                matchResult = GetStat(RawStatID.MatchLost);
            }

            return matchResult;
        }
    }
}
