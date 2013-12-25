using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Runtime.Serialization;
using System.IO;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class League
    {
        [DataMember(Name = "entries")]
        public List<LeagueItem> entries;

        [DataMember(Name = "name")]
        public string name;

        [DataMember(Name = "queue")]
        public string queue;

        [DataMember(Name = "tier")]
        public string tier;
    }
}
