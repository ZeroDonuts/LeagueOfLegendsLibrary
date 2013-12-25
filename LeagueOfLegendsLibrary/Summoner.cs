using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class Summoner
    {
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
        
    }
}
