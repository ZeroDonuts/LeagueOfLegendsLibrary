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
        /// <summary>
        /// Raw stat ID.
        /// </summary>
        [DataMember(Name = "id")]
        private int _id;

        public int id
        {
            get { return _id; }
        }

        /// <summary>
        /// Raw stat name.
        /// </summary>
        [DataMember(Name = "name")]
        private string _name;

        public string name
        {
            get { return _name; }
        }

        /// <summary>
        /// Raw stat value.
        /// </summary>
        [DataMember(Name = "value")]
        private int _value;

        public int value
        {
            get { return _value; }
        }
	}
}
