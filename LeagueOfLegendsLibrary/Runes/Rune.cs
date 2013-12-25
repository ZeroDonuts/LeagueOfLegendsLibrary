using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class Rune
    {
        /// <summary>
        /// Rune description.
        /// </summary>
        [DataMember(Name = "description")]
        public string description;
        
        /// <summary>
        /// Rune ID.
        /// </summary>
        [DataMember(Name = "id")]
        public int id;

        /// <summary>
        /// Rune name.
        /// </summary>
        [DataMember(Name = "name")]
        public string name;

        /// <summary>
        /// Rune tier.
        /// </summary>
        [DataMember(Name = "tier")]
        public int tier;
    }
}
