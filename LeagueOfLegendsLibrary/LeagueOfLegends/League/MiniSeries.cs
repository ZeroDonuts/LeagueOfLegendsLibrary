using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class MiniSeries
    {
        [DataMember(Name = "losses")]
        public int losses;

        [DataMember(Name = "progress")]
        public char[] progress;

        [DataMember(Name = "target")]
        public int target;

        [DataMember(Name = "timeLeftToPlayMillis")]
        public long timeLeftToPlayMillis;

        [DataMember(Name = "wins")]
        public int wins;
    }
}
