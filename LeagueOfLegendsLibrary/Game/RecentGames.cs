using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class RecentGames
    {
        [DataMember(Name = "games")]
        private List<Game> _games;

        public List<Game> games
        {
            get { return _games; }
        }

        [DataMember(Name = "summonerId")]
        private long _summonerId;

        public long summonerId
        {
            get { return _summonerId; }
        }
    }
}
