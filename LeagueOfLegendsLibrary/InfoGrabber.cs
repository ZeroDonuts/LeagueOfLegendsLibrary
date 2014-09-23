using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.IO;
using System.Threading.Tasks;

using LeagueOfLegendsLibrary.ChampionInfo;

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
        public Summoner LookupSummonerByName(string summonerName, string region)
        {
            DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(Summoner));
            WebClient webClient = new WebClient();
            Summoner tempSummoner = new Summoner();
            
            try
            {
                tempSummoner = (Summoner)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/by-name/{0}?api_key={2}", summonerName, region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            tempSummoner.Region = region;
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
            DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(Summoner));
            WebClient webClient = new WebClient();
            Summoner tempSummoner = new Summoner();
            try
            {
                tempSummoner = (Summoner)jSerializer.ReadObject(webClient.OpenRead(string.Format("https://prod.api.pvp.net/api/lol/{1}/v1.1/summoner/{0}?api_key={2}", summonerID, region, LolInfo.APIKEY)));
            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            tempSummoner.Region = region;
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
            DataContractJsonSerializer jSerializer = new DataContractJsonSerializer(typeof(Summoner));
            WebClient webClient = new WebClient();
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
                summoners[summoners.Count - 1].Region = region;
            }
            return summoners;
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
        /// Looks up all of the current League of Legends champions. Updated to 1.2
        /// </summary>
        /// <param name="region">The region to check</param>
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


                foreach(Champion champion in staticChampCollectionCall)
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

        public Champion getChampion(string region, int id)
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
    }
}
