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
        private string _description;

        public string description
        {
            get { return _description; }
        }
        
        /// <summary>
        /// Rune ID.
        /// </summary>
        [DataMember(Name = "id")]
        private int _id;

        public int id
        {
            get { return _id; }
        }

        /// <summary>
        /// Rune name.
        /// </summary>
        [DataMember(Name = "name")]
        private string _name;

        public string name
        {
            get { return _name; }
        }

        /// <summary>
        /// Rune tier.
        /// </summary>
        [DataMember(Name = "tier")]
        private int _tier;

        public int tier
        {
            get { return _tier; }
        }
    }
}
