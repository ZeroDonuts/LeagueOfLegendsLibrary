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
        public int championId;

        /// <summary>
        /// Date game was played specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "createDate")]
        public long createDate;

        /// <summary>
        /// Human readable string representing date game was played.
        /// </summary>
        [DataMember(Name = "createDateStr")]
        public string createDateStr;

        /// <summary>
        /// Datetime object of the date game was played
        /// </summary>
        public DateTime CreateDateTime
        {
            get
            {
                return LolInfo.EpochToDateTime(createDate);
            }
        }

        /// <summary>
        /// Other players associated with the game.
        /// </summary>
       [DataMember(Name = "fellowPlayers")]
        public List<Player> fellowPlayers;

        /// <summary>
        /// Game ID.
        /// </summary>
        [DataMember(Name = "gameId")]
        public long gameId;

        /// <summary>
        /// Game mode.
        /// </summary>
       [DataMember(Name = "gameMode")]
        public string gameMode;

        /// <summary>
        /// Game type.
        /// </summary>
        [DataMember(Name = "gameType")]
        public string gameType;

        /// <summary>
        /// Invalid flag.
        /// </summary>
        [DataMember(Name = "invalid")]
        public bool invalid;

        /// <summary>
        /// Level.
        /// </summary>
        [DataMember(Name = "level")]
        public int level;

        /// <summary>
        /// Map ID.
        /// </summary>
        [DataMember(Name = "mapId")]
        public int mapId;

        /// <summary>
        /// ID of first summoner spell.
        /// </summary>
        [DataMember(Name = "spell1")]
        public int spell1;

        /// <summary>
        /// ID of second summoner spell.
        /// </summary>
        [DataMember(Name = "spell2")]
        public int spell2;

        /// <summary>
        /// Statistics associated with the game for this summoner.
        /// </summary>
        [DataMember(Name = "statistics")]
        private List<RawStat> statistics;

        /// <summary>
        /// Game sub-type.
        /// </summary>
        [DataMember(Name = "subType")]
        public string subType;

        /// <summary>
        /// Team ID associated with game.
        /// </summary>
        [DataMember(Name = "teamId")]
        public int teamId;

        /// <summary>
        /// Gets the RawStat of the specified ID
        /// </summary>
        /// <param name="stat">RawStatID to be searched</param>
        /// <returns>RawStat object of that ID</returns>
        public RawStat GetStat(RawStatID stat)
        {
            RawStat tempStat;
            for (int i = 0; i < statistics.Count; i++)
            {
                if (stat.ToInt() == statistics[i].id)
                {
                    tempStat = statistics[i];
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
