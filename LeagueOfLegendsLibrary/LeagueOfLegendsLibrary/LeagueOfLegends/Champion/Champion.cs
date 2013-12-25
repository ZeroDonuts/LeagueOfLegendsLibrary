using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class Champion
    {
        /// <summary>
        /// Indicates if the champion is active.
        /// </summary>
        [DataMember(Name = "active")]
        public bool active;

        /// <summary>
        /// Champion attack rank.
        /// </summary>
        [DataMember(Name = "attackRank")]
        public int attackRank;

        /// <summary>
        /// Bot enabled flag (for custom games).
        /// </summary>
        [DataMember(Name = "botEnabled")] 
        public bool botEnabled;

        /// <summary>
        /// Bot Match Made enabled flag (for Co-op vs. AI games).
        /// </summary>
        [DataMember(Name = "botMmEnabled")]
        public bool botMmEnabled;

        /// <summary>
        /// Champion defense rank.
        /// </summary>
        [DataMember(Name = "defenseRank")]
        public int defenseRank;

        /// <summary>
        /// Champion difficulty rank.
        /// </summary>
        [DataMember(Name = "difficultyRank")]
        public int difficultyRank;

        /// <summary>
        /// Indicates if the champion is free to play. Free to play champions are rotated periodically.
        /// </summary>
        [DataMember(Name = "freeToPlay")]
        public bool freeToPlay;

        /// <summary>
        /// Champion ID.
        /// </summary>
        [DataMember(Name = "id")]
        public long id;

        /// <summary>
        /// Champion magic rank.
        /// </summary>
        [DataMember(Name = "magicRank")]
        public int magicRank;

        /// <summary>
        /// Champion name.
        /// </summary>
        [DataMember(Name = "name")]
        public string name;

        /// <summary>
        /// Ranked play enabled flag.
        /// </summary>
        [DataMember(Name = "rankedPlayEnabled")]
        public bool rankedPlayEnabled;


    }
}
