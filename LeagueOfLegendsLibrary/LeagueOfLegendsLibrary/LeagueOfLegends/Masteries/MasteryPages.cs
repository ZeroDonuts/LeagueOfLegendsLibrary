using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Runtime.Serialization;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class MasteryPages
    {
        /// <summary>
        /// List of msatery pages associated with the summoner.
        /// </summary>
        [DataMember(Name = "pages")]
        public List<MasteryPage> pages;

        /// <summary>
        /// Summoner ID.
        /// </summary>
        [DataMember(Name = "summonerId")]
        public long summonerId;
    }
}
