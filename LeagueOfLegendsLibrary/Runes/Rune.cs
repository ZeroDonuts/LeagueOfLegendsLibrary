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
        [DataMember(Name = "description")]
        private string _description;

        /// <summary>
        /// Rune description.
        /// </summary>
        public string description
        {
            get { return _description; }
        }

        [DataMember(Name = "id")]
        private int _id;

        /// <summary>
        /// Rune ID.
        /// </summary>
        public int id
        {
            get { return _id; }
        }

        [DataMember(Name = "name")]
        private string _name;

        /// <summary>
        /// Rune name.
        /// </summary>
        public string name
        {
            get { return _name; }
        }

        [DataMember(Name = "tier")]
        private int _tier;

        /// <summary>
        /// Rune tier.
        /// </summary>
        public int tier
        {
            get { return _tier; }
        }
    }
}
