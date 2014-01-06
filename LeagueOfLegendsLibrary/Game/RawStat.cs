using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
	public class RawStat
	{
        [DataMember(Name = "id")]
        private int _id;

        /// <summary>
        /// Raw stat ID.
        /// </summary>
        public int id
        {
            get { return _id; }
        }

        [DataMember(Name = "name")]
        private string _name;

        /// <summary>
        /// Raw stat name.
        /// </summary>
        public string name
        {
            get { return _name; }
        }

        [DataMember(Name = "value")]
        private int _value;

        /// <summary>
        /// Raw stat value.
        /// </summary>
        public int value
        {
            get { return _value; }
        }
	}
}
