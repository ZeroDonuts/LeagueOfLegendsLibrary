using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.IO;

namespace LeagueOfLegendsLibrary
{
    public class InfoGrabber
    {
        private DataContractJsonSerializer jSerializer;
        private WebClient webClient;

        public InfoGrabber()
        {
            webClient = new WebClient();
        }

        /// <summary>
        /// Looks up the specified summoner in the specified region and returns that summoner
        /// </summary>
        /// <param name="summonerName">The summoner to search for</param>
        /// <param name="region">The server region to check</param>
        /// <returns></returns>
        public Summoner LookupSummonerByName(string summonerName, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(Summoner));
            Summoner tempSummoner = new Summoner();
            try
            {
                tempSummoner = (Summoner)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/by-name/{0}?api_key={2}", summonerName, region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return tempSummoner;
        }

        /// <summary>
        /// Looks up the specified summoner by using the ID
        /// </summary>
        /// <param name="summonerID">The ID of the summoner</param>
        /// <param name="region">The server region to check</param>
        /// <returns></returns>
        public Summoner LookupSummonerByID(long summonerID, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(Summoner));
            Summoner tempSummoner = new Summoner();
            try
            {
                tempSummoner = (Summoner)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}?api_key={2}", summonerID, region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return tempSummoner;
        }

        /// <summary>
        /// Looks up a group of summoners using their ID's
        /// </summary>
        /// <param name="region">The server region the summoners are in</param>
        /// <param name="summonerIDs">The ID's of the summoners</param>
        /// <returns></returns>
        public List<Summoner> LookupSummonersByID(string region, params long[] summonerIDs)
        {
            jSerializer = new DataContractJsonSerializer(typeof(Summoner));
            List<Summoner> summoners = new List<Summoner>();
            for (int i = 0; i < summonerIDs.Length; i++)
            {
                try
                {
                    summoners.Add((Summoner)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}?api_key={2}", summonerIDs[i], region, LolInfo.APIKEY))));
                }
                catch (WebException e)
                {
                    throw new Exception(e.Message);
                }
            }
            return summoners;
        }

        /// <summary>
        /// Returns the entire league which a summoner is currently in. Miniseries is slightly bugged at the moment.
        /// </summary>
        /// <param name="summonerID">The ID of the summoner</param>
        /// <param name="region">The server region to check</param>
        /// <returns></returns>
        public League GetLeague(long summonerID, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(League));
            League league = new League();
            int closeCurlyBraceOffset = 2;
            try
            {
                string thing = string.Format("{0}", webClient.DownloadString(string.Format("http://prod.api.pvp.net/api/lol/{1}/v2.3/league/by-summoner/{0}?api_key={2}", summonerID, region, LolInfo.APIKEY)));
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

        public Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        /// Looks up all of the current League of Legends champions
        /// </summary>
        /// <param name="region">The region to check</param>
        /// <param name="onlyFreeToPlayChamps">Determines whether to only get a list of free to play champions</param>
        /// <returns></returns>
        public ChampionCollection GetChampions(string region, bool onlyFreeToPlayChamps = false)
        {
            jSerializer = new DataContractJsonSerializer(typeof(ChampionCollection));

            string freeChamp = onlyFreeToPlayChamps ? "freeToPlay=true&" : "";
            ChampionCollection champs = new ChampionCollection();
            try
            {
                champs = ((ChampionCollection)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{0}/v1.1/champion?{1}api_key={2}", region, freeChamp, LolInfo.APIKEY))));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return champs;
        }

        /// <summary>
        ///// Gets the last 10 played games of the summoner. Updated as of Gamev1.3
        /// </summary>
        /// <param name="region">The server region to check</param>
        /// <param name="summonerID">The ID of the summoner</param>
        /// <returns></returns>
        public RecentGamesCollection GetRecentGames(string region, long summonerID)
        {
            jSerializer = new DataContractJsonSerializer(typeof(RecentGamesCollection));
            RecentGamesCollection games = new RecentGamesCollection();
            try
            {
                games = ((RecentGamesCollection)jSerializer.ReadObject(webClient.OpenRead(string.Format("http://prod.api.pvp.net/api/lol/{0}/v1.3/game/by-summoner/{1}/recent?api_key={2}", region, summonerID, LolInfo.APIKEY))));
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
        /// <param name="summonerID">The ID of the summoner</param>
        /// <param name="region">The server region to check</param>
        /// <returns></returns>
        public MasteryPageCollection GetSummonerMasteries(long summonerID, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(MasteryPageCollection));
            MasteryPageCollection pages = new MasteryPageCollection();
            try
            {
                pages = (MasteryPageCollection)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}/masteries?api_key={2}", summonerID, region, LolInfo.APIKEY)));
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
        /// <param name="summonerID">The ID of the summoner</param>
        /// <param name="region">The server region to check</param>
        /// <returns></returns>
        public RunePageCollection GetSummonerRunes(long summonerID, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(RunePageCollection));
            RunePageCollection pages = new RunePageCollection();
            try
            {
                pages = (RunePageCollection)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}/runes?api_key={2}", summonerID, region, LolInfo.APIKEY)));
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
        /// <param name="summonerID">The ID of the summoner</param>
        /// <param name="region">The server region to check</param>
        /// <param name="season">The season to check for</param>
        /// <returns></returns>
        public PlayerStatsSummaryList GetSummonerSummary(long summonerID, string region, string season)
        {
            jSerializer = new DataContractJsonSerializer(typeof(PlayerStatsSummaryList));
            PlayerStatsSummaryList summary = new PlayerStatsSummaryList();
            string seasontxt = "season=" + season;
            try
            {
                summary = (PlayerStatsSummaryList)jSerializer.ReadObject(webClient.OpenRead(string.Format("http://prod.api.pvp.net/api/lol/{1}/v1.2/stats/by-summoner/{0}/summary?{3}&api_key={2}", summonerID, region, LolInfo.APIKEY, season)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return summary;
        }

        public List<Team> GetTeams(long summonerID)
        {
            jSerializer = new DataContractJsonSerializer(typeof(List<Team>));
            List<Team> teams = new List<Team>();
            try
            {
                teams = (List<Team>)jSerializer.ReadObject(webClient.OpenRead(string.Format("http://prod.api.pvp.net/api/lol/na/v2.2/team/by-summoner/{0}?api_key={1}", summonerID, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return teams;
        }
    }
}
