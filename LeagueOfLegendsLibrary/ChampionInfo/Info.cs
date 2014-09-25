using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    /// <summary>
    /// A class that represents basic champion information
    /// </summary>
    [DataContract(Name="InfoDto")]
    public class Info
    {
        [DataMember(Name="attack")]
        private int _attack;

        /// <summary>
        /// Gets the basic Attack level of the champion
        /// </summary>
        public int Attack
        {
            get
            {
                return _attack;
            }
        }

        [DataMember(Name = "defense")]
        private int _defense;

        /// <summary>
        /// Gets the basic Defense level of the champion
        /// </summary>
        public int Defense
        {
            get
            {
                return _defense;
            }
        }

        [DataMember(Name = "difficulty")]
        private int _difficulty;

        /// <summary>
        /// Gets the Difficulty level of the champion
        /// </summary>
        public int Difficulty
        {
            get
            {
                return _difficulty;
            }
        }

        [DataMember(Name = "magic")]
        private int _magic;

        /// <summary>
        /// Gets the basic Magic level of the champion
        /// </summary>
        public int Magic
        {
            get
            {
                return _magic;
            }
        }
        
    }
}
