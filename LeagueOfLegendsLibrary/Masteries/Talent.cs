using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class Talent
    {
        
        [DataMember(Name = "id")]
        private int _id;

        /// <summary>
        /// Talent id.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }
        

        
        [DataMember(Name = "name")]
        private string _name;

        /// <summary>
        /// Talent name.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }
        

        
        [DataMember(Name = "rank")]
        private int _rank;

        /// <summary>
        /// Talent rank.
        /// </summary>
        public int Rank
        {
            get { return Rank; }
        }
        
    }
}
