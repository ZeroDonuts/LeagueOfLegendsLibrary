using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.IO;
using System.Threading.Tasks;

using LeagueOfLegendsLibrary.ChampionInfo;
using LeagueOfLegendsLibrary.GameInfo;
using LeagueOfLegendsLibrary.LeagueInfo;

namespace LeagueOfLegendsLibrary
{
    public class InfoGrabber
    {

        /// <summary>
        /// Looks up the specified summoner in the specified region and returns that summoner
        /// </summary>
        /// <param name="summonerName">The summoner to search for</param>
        /// <param name="region">The server region to check</param>
        /// <returns></returns>
        public Dictionary<string, Summoner> LookupSummonersByName(string region, params string[] names)
        {
            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
            settings.UseSimpleDictionaryFormat = true;

            DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, Summoner>), settings);
            WebClient webClient = new WebClient();
            Summoner tempSummoner = new Summoner();

            string urlToCheck = string.Format("https://na.api.pvp.net/api/lol/{0}/v1.4/summoner/by-name/", region);

            for (int i = 0; i < names.Length; i++)
            {
                urlToCheck += names[i];

                if (i != names.Length - 1)
                {
                    urlToCheck += ",";
                }
            }

            Dictionary<string, Summoner> tempList;

            try
            {
                tempList = (Dictionary<string, Summoner>)jSerializer.ReadObject(webClient.OpenRead(string.Format(urlToCheck + "?api_key={0}", LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            foreach (Summoner s in tempList.Values)
            {
                s.Region = region;
            }

            return tempList;
        }

        public Summoner LookupSummonerByName(string summonerName, string region)
        {
            return LookupSummonersByName(region, summonerName).First().Value;
        }


        /// <summary>
        /// Looks up a group of summoners using their ID's
        /// </summary>
        /// <param name="region">The server region the summoners are in</param>
        /// <param name="summonerIDs">The ID's of the summoners</param>
        /// <returns></returns>
        public Dictionary<string, Summoner> LookupSummonersByID(string region, params long[] summonerIDs)
        {
            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
            settings.UseSimpleDictionaryFormat = true;

            DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(Dictionary<string, Summoner>), settings);
            WebClient webClient = new WebClient();
            Summoner tempSummoner = new Summoner();
            string urlToCheck = string.Format("https://na.api.pvp.net/api/lol/{0}/v1.4/summoner/", region);

            for (int i = 0; i < summonerIDs.Length; i++)
            {
                urlToCheck += summonerIDs[i].ToString();
                if (i != summonerIDs.Length - 1)
                {
                    urlToCheck += ",";
                }

            }

            Dictionary<string, Summoner> tempList;
            try
            {
                tempList = (Dictionary<string, Summoner>)jSerializer.ReadObject(webClient.OpenRead(string.Format(urlToCheck + "?api_key={0}", LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            foreach (Summoner s in tempList.Values)
            {
                s.Region = region;
            }

            return tempList;
        }

        /// <summary>
        /// Looks up the specified summoner by using the ID
        /// </summary>
        /// <param name="summonerID">The ID of the summoner</param>
        /// <param name="region">The server region to check</param>
        /// <returns></returns>
        public Summoner LookupSummonerByID(string region, long summonerID)
        {
            return LookupSummonersByID(region, summonerID).First().Value;
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
        /// Looks up all of the current League of Legends champions.        /// </summary>
        /// <param name="region">The region to check</param>
        /// <remarks>Version 1.2</remarks>
        /// <returns></returns>
        public ChampionCollection GetChampions(string region)
        {
            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
            settings.UseSimpleDictionaryFormat = true;

            DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(ChampionCollection), settings);
            WebClient webClient = new WebClient();
            ChampionCollection staticChampCollectionCall = new ChampionCollection();
            ChampionCollection champCollectionCall = new ChampionCollection();
            try
            {

                champCollectionCall = (ChampionCollection)jSerializer.ReadObject(webClient.OpenRead(String.Format("https://{0}.api.pvp.net/api/lol/{0}/v1.2/champion?api_key={1}", region, LolInfo.APIKEY)));
                staticChampCollectionCall = (ChampionCollection)jSerializer.ReadObject(webClient.OpenRead(String.Format("https://{0}.api.pvp.net/api/lol/static-data/{0}/v1.2/champion?champData=all&api_key={1}", region, LolInfo.APIKEY)));


                foreach (Champion champion in staticChampCollectionCall)
                {
                    Champion info = champCollectionCall.Find(champion.Id);

                    champion.Active = info.Active;
                    champion.BotEnabled = info.BotEnabled;
                    champion.BotMmEnabled = info.BotMmEnabled;
                    champion.FreeToPlay = info.FreeToPlay;
                    champion.RankedPlayEnabled = info.RankedPlayEnabled;
                }
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }

            return staticChampCollectionCall;
        }


        /// <summary>
        /// Looks up a champion with the specified id.
        /// </summary>
        /// <param name="region">The region to check</param>
        /// <param name="id">id of the champion to look up</param>
        /// <remarks>Version 1.2</remarks>
        /// <returns></returns>
        public Champion GetChampion(string region, int id)
        {

            Champion championCall = new Champion();
            Champion staticChampionCall = new Champion();

            DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(Champion));
            WebClient webClient = new WebClient();
            try
            {
                championCall = (Champion)jSerializer.ReadObject(webClient.OpenRead(String.Format("https://{0}.api.pvp.net/api/lol/{0}/v1.2/champion/{1}?api_key={2}", region, id, LolInfo.APIKEY)));
                staticChampionCall = (Champion)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://{0}.api.pvp.net/api/lol/static-data/{0}/v1.2/champion/{1}?champData=all&api_key={2}", region, id, LolInfo.APIKEY)));

                staticChampionCall.Active = championCall.Active;
                staticChampionCall.BotEnabled = championCall.BotEnabled;
                staticChampionCall.BotMmEnabled = championCall.BotMmEnabled;
                staticChampionCall.FreeToPlay = championCall.FreeToPlay;
                staticChampionCall.RankedPlayEnabled = championCall.RankedPlayEnabled;


            }
            catch (WebException e)
            {
                throw;
            }
            return staticChampionCall;
        }

        /// <summary>
        /// Looks up the most recent match history of a summoner
        /// </summary>
        /// <param name="region">The region to check</param>
        /// <param name="summonerID">Id of the summoner</param>
        /// <remarks>Version 1.3</remarks>
        /// <returns></returns>
        public RecentGamesCollection GetRecentGames(string region, long summonerID)
        {
            RecentGamesCollection games = new RecentGamesCollection();

            DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(RecentGamesCollection));
            WebClient webClient = new WebClient();

            try
            {
                games = (RecentGamesCollection)jSerializer.ReadObject(webClient.OpenRead(String.Format("https://{0}.api.pvp.net/api/lol/{0}/v1.3/game/by-summoner/{1}/recent?api_key={2}", region, summonerID, LolInfo.APIKEY)));
            }
            catch
            {
                throw;
            }


            return games;
        }


        /// <summary>
        /// Gets the leagues of the specified summoners
        /// </summary>
        /// <param name="region">region to look at</param>
        /// <param name="summonerIds">summoners to find</param>
        /// <remarks>Version 2.5</remarks>
        /// <returns></returns>
        public LeagueGroups GetLeague(string region, params long[] summonerIds)
        {
            LeagueGroups leagueGroups = new LeagueGroups();

            string ids = "";
            for (int i = 0; i < summonerIds.Length; i++)
            {
                ids += summonerIds[i].ToString();

                if(i != summonerIds.Length - 1)
                {
                    ids += ",";
                }
            }

            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
            settings.UseSimpleDictionaryFormat = true;

            DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(LeagueGroups), settings);
            WebClient webClient = new WebClient();

            try
            {
                leagueGroups = (LeagueGroups)jSerializer.ReadObject(webClient.OpenRead(String.Format("https://{0}.api.pvp.net/api/lol/{0}/v2.5/league/by-summoner/{1}/entry?api_key={2}", region, ids, LolInfo.APIKEY)));
            }
            catch
            {
                throw;
            }

            return leagueGroups;
        }
    }
}
