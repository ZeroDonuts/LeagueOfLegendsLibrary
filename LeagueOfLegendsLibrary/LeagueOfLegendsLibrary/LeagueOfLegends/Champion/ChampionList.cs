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
    public class ChampionList
    {
        [DataMember(Name = "champions")]
        public List<Champion> champions;
    }
}
