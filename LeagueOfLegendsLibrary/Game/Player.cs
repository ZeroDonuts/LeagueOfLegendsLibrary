using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class Player
    {
        [DataMember(Name = "championId")]
        private int _championId;

        /// <summary>
        /// Champion id associated with player.
        /// </summary>
        public int championId
        {
            get { return _championId; }
        }

        [DataMember(Name = "summonerId")]
        private long _summonerId;

        /// <summary>
        /// Summoner id associated with player.
        /// </summary>
        public long summonerId
        {
            get { return _summonerId; }
        }

        [DataMember(Name = "teamId")]
        private int _teamId;

        /// <summary>
        /// Team id associated with player.
        /// </summary>
        public int teamId
        {
            get { return _teamId; }
        }
    }
}
