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
        /// Looks up all of the current League of Legends champions. Updated to 1.1
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
    }
}
