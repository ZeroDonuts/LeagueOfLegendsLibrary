using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class RecentGames
    {
        [DataMember(Name = "games")]
        public List<Game> games;

        [DataMember(Name = "summonerId")]
        public long summonerId;
    }
}
