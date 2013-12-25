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
        /// <summary>
        /// Champion id associated with player.
        /// </summary>
        [DataMember(Name = "championId")]
        public int championId;

        /// <summary>
        /// Summoner id associated with player.
        /// </summary>
        [DataMember(Name = "summonerId")]
        public long summonerId;

        /// <summary>
        /// Team id associated with player.
        /// </summary>
        [DataMember(Name = "teamId")]
        public int teamId;
    }
}
