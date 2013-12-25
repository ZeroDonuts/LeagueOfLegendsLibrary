using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class Talent
    {
        /// <summary>
        /// Talent id.
        /// </summary>
        [DataMember(Name = "id")]
        public int id;

        /// <summary>
        /// Talent name.
        /// </summary>
        [DataMember(Name = "name")]
        public string name;

        /// <summary>
        /// Talent rank.
        /// </summary>
        [DataMember(Name = "rank")]
        public int rank;
    }
}
