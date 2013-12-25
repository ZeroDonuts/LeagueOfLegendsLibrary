using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class Summoner
    {
        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name = "id")]
        public long id;
        /// <summary>
        /// Summoner name.
        /// </summary>
        [DataMember(Name = "name")]
        public string name;
        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        [DataMember(Name = "profileIconId")]
        public int profileIconId;
        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds.
        /// </summary>
        [DataMember(Name = "revisionDate")]
        public long revisionDate;
        /// <summary>
        /// Human readable string representing date summoner was last modified.
        /// </summary>
       [DataMember(Name = "revisionDateStr")]
        public string revisionDateStr;
        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        [DataMember(Name = "summonerLevel")]
        public long summonerLevel;
        
    }
}
