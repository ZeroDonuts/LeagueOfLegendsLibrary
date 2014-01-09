using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;

namespace LeagueOfLegendsLibrary
{
    public static class LolInfo
    {
        public static string APIKEY;
        public static ChampionCollection ChampionCollection = null;

        public static DateTime EpochToDateTime(double epoch)
        {
            DateTime t = new DateTime(1970, 1, 1, 0, 0, 0);
            return t.AddMilliseconds(epoch).ToLocalTime();
        }
    }
}
