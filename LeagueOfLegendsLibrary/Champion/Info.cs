using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="InfoDto")]
    public class Info
    {
        [DataMember(Name="attack")]
        private int _attack;

        public int Attack
        {
            get
            {
                return _attack;
            }
        }

        [DataMember(Name = "defense")]
        private int _defense;

        
        public int Defense
        {
            get
            {
                return _defense;
            }
        }

        [DataMember(Name = "difficulty")]
        private int _difficulty;

        public int Difficulty
        {
            get
            {
                return _difficulty;
            }
        }

        [DataMember(Name = "magic")]
        private int _magic;

        public int Magic
        {
            get
            {
                return _magic;
            }
        }
        
    }
}
