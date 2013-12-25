using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;

namespace LeagueOfLegendsLibrary
{
    public class InfoGrabber
    {
        private DataContractJsonSerializer jSerializer;
        private WebClient webClient = new WebClient();

        /// <summary>
        /// Looks up the specified summoner in the specified region and returns that summoner
        /// </summary>
        /// <param name="summonerName">The summoner to search for</param>
        /// <param name="region">The server region the summoner is in</param>
        /// <returns></returns>
        public Summoner LookupSummonerByName(string summonerName, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(Summoner));
            Summoner tempSummoner = new Summoner();
            try
            {
                tempSummoner = (Summoner)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/by-name/{0}?{2}", summonerName, region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return tempSummoner;
        }

        public Summoner LookupSummonerByID(long summonerID, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(Summoner));
            Summoner tempSummoner = new Summoner();
            try
            {
                tempSummoner = (Summoner)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}?{2}", summonerID, region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return tempSummoner;
        }

        public List<Summoner> LookupSummonersByID(string region, params long[] summonerIDs)
        {
            jSerializer = new DataContractJsonSerializer(typeof(Summoner));
            List<Summoner> summoners = new List<Summoner>();
            for (int i = 0; i < summonerIDs.Length; i++)
            {
                try
                {
                    summoners.Add((Summoner)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}?{2}", summonerIDs[i], region, LolInfo.APIKEY))));
                }
                catch (WebException e)
                {
                    throw new Exception(e.Message);
                }
            }
            return summoners;
        }

        public Dictionary<string, League> GetLeague(long summonerID, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, League>));
            Dictionary<string, League> league = new Dictionary<string, League>();

            try
            {
                league = (Dictionary<string, League>)jSerializer.ReadObject(webClient.OpenRead(string.Format("http://prod.api.pvp.net/api/lol/{1}/v2.2/league/by-summoner/{0}?{2}", summonerID, region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return league;
        }

        public List<Champion> GetChampions(string region, bool f2p)
        {
            jSerializer = new DataContractJsonSerializer(typeof(Champions));

            string freeChamp = f2p ? "freeToPlay=true&" : "";
            List<Champion> champs = new List<Champion>();
            try
            {
                champs = ((Champions)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{0}/v1.1/champion?{1}{2}", region, freeChamp, LolInfo.APIKEY)))).ChampionsList.ToList<Champion>();
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return champs;
        }

        public List<Game> GetRecentGames(string region, long summonerID)
        {
            jSerializer = new DataContractJsonSerializer(typeof(RecentGames));
            List<Game> games = new List<Game>();
            try
            {
                games = ((RecentGames)jSerializer.ReadObject(webClient.OpenRead(string.Format("http://prod.api.pvp.net/api/lol/{0}/v1.1/game/by-summoner/{1}/recent?{2}", region, summonerID, LolInfo.APIKEY)))).games;
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return games;
        }

        public MasteryPages GetSummonerMasteries(long summonerID, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(MasteryPages));
            MasteryPages pages = new MasteryPages();
            try
            {
                pages = (MasteryPages)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}/masteries?{2}", summonerID, region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return pages;
        }

        public RunePages GetSummonerRunes(long summonerID, string region)
        {
            jSerializer = new DataContractJsonSerializer(typeof(RunePages));
            RunePages pages = new RunePages();
            try
            {
                pages = (RunePages)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}/runes?{2}", summonerID, region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return pages;

        }

        public PlayerStatsSummaryList GetSummonerSummary(long summonerID, string region, string season)
        {
            jSerializer = new DataContractJsonSerializer(typeof(PlayerStatsSummaryList));
            PlayerStatsSummaryList summary = new PlayerStatsSummaryList();
            string seasontxt = "season=" + season;
            try
            {
                summary = (PlayerStatsSummaryList)jSerializer.ReadObject(webClient.OpenRead(string.Format("http://prod.api.pvp.net/api/lol/{1}/v1.2/stats/by-summoner/{0}/summary?{3}&{2}", summonerID, region, LolInfo.APIKEY, season)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            return summary;
        }
    }
}
