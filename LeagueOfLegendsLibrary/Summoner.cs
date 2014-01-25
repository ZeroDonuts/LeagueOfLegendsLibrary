using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class Summoner
    {

        private DataContractJsonSerializer jSerializer;
        private WebClient webClient;

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name = "id")]
        private long _id;
        public long ID
        {
            get
            {
                return _id;
            }
        }
        /// <summary>
        /// Summoner name.
        /// </summary>
        [DataMember(Name = "name")]
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }
        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        [DataMember(Name = "profileIconId")]
        private int _profileIconId;
        public int ProfileIconID
        {
            get
            {
                return _profileIconId;
            }
        }
        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "revisionDate")]
        private long _revisionDate;
        public long RevisionDate
        {
            get
            {
                return _revisionDate;
            }
        }
        /// <summary>
        /// Human readable string representing date summoner was last modified.
        /// </summary>
       [DataMember(Name = "revisionDateStr")]
        private string _revisionDateStr;
       public string RevisionDateStr
       {
           get
           {
               return _revisionDateStr;
           }
       }
        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        [DataMember(Name = "summonerLevel")]
        private long _summonerLevel;
        public long Level
        {
            get
            {
                return _summonerLevel;
            }
        }

        private string _region;

        public string Region
        {
            get { return _region; }
            set { _region = value; }
        }


        /// <summary>
        /// Returns the entire league which a summoner is currently in. Miniseries is slightly bugged at the moment. Updated to 2.3
        /// </summary>
        /// <returns></returns>
        public League GetLeague()
        {
            jSerializer = new DataContractJsonSerializer(typeof(League));
            webClient = new WebClient();
            League league = new League();
            int closeCurlyBraceOffset = 2;
            try
            {
                string thing = string.Format("{0}", webClient.DownloadString(string.Format("http://prod.api.pvp.net/api/lol/{1}/v2.3/league/by-summoner/{0}?api_key={2}", _id, _region, LolInfo.APIKEY)));
                for (int i = 0; i < thing.Length; i++)
                {
                    char currentChar = thing[i];
                    if (currentChar == ':')
                    {
                        thing = thing.Substring(i + 1, thing.Length - closeCurlyBraceOffset - i);
                        break;
                    }
                }
                MemoryStream memStream = new MemoryStream();
                StreamWriter writer = new StreamWriter(memStream);
                writer.Write(thing);
                writer.Flush();
                memStream.Position = 0;

                league = (League)jSerializer.ReadObject(memStream);
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return league;
        }

        /// <summary>
        /// Gets the last 10 played games of the summoner. Updated as of Gamev1.3
        /// </summary>
        /// <returns></returns>
        public RecentGamesCollection GetRecentGames()
        {
            jSerializer = new DataContractJsonSerializer(typeof(RecentGamesCollection));
            webClient = new WebClient();
            RecentGamesCollection games = new RecentGamesCollection();
            try
            {
                games = ((RecentGamesCollection)jSerializer.ReadObject(webClient.OpenRead(string.Format("http://prod.api.pvp.net/api/lol/{0}/v1.3/game/by-summoner/{1}/recent?api_key={2}", _region, _id, LolInfo.APIKEY))));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return games;
        }

        /// <summary>
        /// Gets the mastery pages of a summoner
        /// </summary>
        /// <returns></returns>
        public MasteryPageCollection GetMasteries()
        {
            jSerializer = new DataContractJsonSerializer(typeof(MasteryPageCollection));
            webClient = new WebClient();
            MasteryPageCollection pages = new MasteryPageCollection();
            try
            {
                pages = (MasteryPageCollection)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}/masteries?api_key={2}", _id, _region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return pages;
        }

        /// <summary>
        /// Gets the rune pages of a summoner
        /// </summary>
        /// <returns></returns>
        public RunePageCollection GetRunes()
        {
            jSerializer = new DataContractJsonSerializer(typeof(RunePageCollection));
            webClient = new WebClient();
            RunePageCollection pages = new RunePageCollection();
            try
            {
                pages = (RunePageCollection)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}/runes?api_key={2}", _id, _region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return pages;
        }

        /// <summary>
        /// Gets a comprehensive list of stats for a summoner
        /// </summary>
        /// <param name="season">The season to check for</param>
        /// <returns></returns>
        public PlayerStatsSummaryList GetStatSummary(Season season)
        {
            jSerializer = new DataContractJsonSerializer(typeof(PlayerStatsSummaryList));
            webClient = new WebClient();
            PlayerStatsSummaryList summary = new PlayerStatsSummaryList();
            string seasontxt = "season=" + season;
            try
            {
                summary = (PlayerStatsSummaryList)jSerializer.ReadObject(webClient.OpenRead(string.Format("http://prod.api.pvp.net/api/lol/{1}/v1.2/stats/by-summoner/{0}/summary?{3}&api_key={2}", _id, _region, LolInfo.APIKEY, season.ToString())));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return summary;
        }

        /// <summary>
        /// Gets the ranked teams that the summoner is in.
        /// </summary>
        /// <returns></returns>
        public List<Team> GetTeams()
        {
            jSerializer = new DataContractJsonSerializer(typeof(List<Team>));
            List<Team> teams = new List<Team>();
            try
            {
                teams = (List<Team>)jSerializer.ReadObject(webClient.OpenRead(string.Format("http://prod.api.pvp.net/api/lol/na/v2.2/team/by-summoner/{0}?api_key={1}", _id, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return teams;
        }

    }
}
