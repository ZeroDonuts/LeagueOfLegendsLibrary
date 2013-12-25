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
        public int id;

        /// <summary>
        /// Raw stat name.
        /// </summary>
        [DataMember(Name = "name")]
        public string name;

        /// <summary>
        /// Raw stat value.
        /// </summary>
        [DataMember(Name = "value")]
        public int value;
	}
}
