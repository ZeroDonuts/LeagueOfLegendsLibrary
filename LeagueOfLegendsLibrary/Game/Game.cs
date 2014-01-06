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
    [DataContract]
    public class Game
    {
        /// <summary>
        /// Champion ID associated with game.
        /// </summary>
        [DataMember(Name = "championId")]
        private int _championId;

        public int championId
        {
            get { return _championId; }
        }

        /// <summary>
        /// Date game was played specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "createDate")]
        private long _createDate;

        public long createDate
        {
            get { return _createDate; }
        }
        /// <summary>
        /// Human readable string representing date game was played.
        /// </summary>
        [DataMember(Name = "createDateStr")]
        private string _createDateStr;

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

        /// <summary>
        /// Other players associated with the game.
        /// </summary>
        [DataMember(Name = "fellowPlayers")]
        private List<Player> _fellowPlayers;

        public List<Player> fellowPlayers
        {
            get { return _fellowPlayers; }
        }

        /// <summary>
        /// Game ID.
        /// </summary>
        [DataMember(Name = "gameId")]
        private long _gameId;

        public long gameId
        {
            get { return _gameId; }
        }

        /// <summary>
        /// Game mode.
        /// </summary>
        [DataMember(Name = "gameMode")]
        private string _gameMode;

        public string gameMode
        {
            get { return _gameMode; }
        }

        /// <summary>
        /// Game type.
        /// </summary>
        [DataMember(Name = "gameType")]
        private string _gameType;

        public string gameType
        {
            get { return _gameType; }
        }

        /// <summary>
        /// Invalid flag.
        /// </summary>
        [DataMember(Name = "invalid")]
        private bool _invalid;

        public bool invalid
        {
            get { return _invalid; }
        }

        /// <summary>
        /// Level.
        /// </summary>
        [DataMember(Name = "level")]
        private int _level;

        public int level
        {
            get { return _level; }
        }

        /// <summary>
        /// Map ID.
        /// </summary>
        [DataMember(Name = "mapId")]
        private int _mapId;

        public int mapId
        {
            get { return _mapId; }
        }

        /// <summary>
        /// ID of first summoner spell.
        /// </summary>
        [DataMember(Name = "spell1")]
        private int _spell1;

        public int spell1
        {
            get { return _spell1; }
        }

        /// <summary>
        /// ID of second summoner spell.
        /// </summary>
        [DataMember(Name = "spell2")]
        private int _spell2;

        public int spell2
        {
            get { return _spell2; }
        }

        /// <summary>
        /// Statistics associated with the game for this summoner.
        /// </summary>
        [DataMember(Name = "statistics")]
        private List<RawStat> statistics;

        /// <summary>
        /// Game sub-type.
        /// </summary>
        [DataMember(Name = "subType")]
        private string _subType;

        public int subType
        {
            get { return _subType; }
        }

        /// <summary>
        /// Team ID associated with game.
        /// </summary>
        [DataMember(Name = "teamId")]
        private int _teamId;

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
