using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="ChampionDto")]
    public class Champion
    {
        [DataMember(Name = "active")]
        private bool _active;
        
        public bool Active
        {
            get
            {
                return _active;
            }
        }

        [DataMember(Name = "attackRank")]
        private int _attackRank;
        
        public int AttackRank
        {
            get
            {
                return _attackRank;
            }
        }


        [DataMember(Name = "botEnabled")]
        private bool _botEnabled;
        
        public bool BotEnabled
        {
            get
            {
                return _botEnabled;
            }
        }


        [DataMember(Name = "botMmEnabled")]
        private bool _botMmEnabled;
       
        public bool BotMmEnabled
        {
            get 
            { 
                return _botMmEnabled; 
            }
        }

        [DataMember(Name = "defenseRank")]
        private int _defenseRank;
        
        public int DefenseRank
        {
            get 
            { 
                return _defenseRank; 
            }
        }

        [DataMember(Name = "difficultyRank")]
        private int _difficultyRank;

        
        public int DifficultyRank
        {
            get 
            { 
                return _difficultyRank;
            }
        }

        [DataMember(Name = "freeToPlay")]
        private bool _freeToPlay;
        
        public bool FreeToPlay
        {
            get 
            { 
                return _freeToPlay; 
            }
        }

        [DataMember(Name = "id")]
        private int _id;
        
        public int Id
        {
            get
            { 
                return _id; 
            }
        }

        [DataMember(Name = "magicRank")]
        private int _magicRank;

        
        public int MagicRank
        {
            get 
            {
                return _magicRank;
            }
        }

        [DataMember(Name = "name")]
        private string _name;
        
        public string Name
        {
            get 
            { 
                return _name;
            }
        }

        [DataMember(Name = "rankedPlayEnabled")]
        private bool _rankedPlayEnabled;
        
        public bool RankedPlayEnabled
        {
            get 
            { 
                return _rankedPlayEnabled;
            }
        }
        
    }
}
