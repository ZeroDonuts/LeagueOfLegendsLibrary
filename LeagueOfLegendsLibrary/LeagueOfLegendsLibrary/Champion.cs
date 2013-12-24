using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class Champion
    {
        private bool _active;

        [DataMember(Name = "active")]
        public bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }


        private int _attackRank;

        [DataMember(Name = "attackRank")]
        public int AttackRank
        {
            get
            {
                return _attackRank;
            }
            set
            {
                _attackRank = value;
            }
        }

        private bool _botEnabled;

        [DataMember(Name = "botEnabled")]
        public bool BotEnabled
        {
            get
            {
                return _botEnabled;
            }
            set
            {
                _botEnabled = value;
            }
        }

        private bool _botMmEnabled;

        [DataMember(Name="botMmEnabled")]
        public bool BotMmEnabled
        {
            get 
            { 
                return _botMmEnabled; 
            }
            set 
            { 
                _botMmEnabled = value; 
            }
        }

        private int _defenseRank;

        [DataMember(Name="defenseRank")]
        public int DefenseRank
        {
            get 
            { 
                return _defenseRank; 
            }
            set 
            {
                _defenseRank = value; 
            }
        }

        private int _difficultyRank;

        [DataMember(Name="difficultyRank")]
        public int DifficultyRank
        {
            get 
            { 
                return _difficultyRank;
            }
            set
            { 
                _difficultyRank = value;
            }
        }


        private bool _freeToPlay;

        [DataMember(Name="freeToPlay")]
        public bool FreeToPlay
        {
            get 
            { 
                return _freeToPlay; 
            }
            set 
            {
                _freeToPlay = value;
            }
        }

        private int _id;

        [DataMember(Name="id")]
        public int Id
        {
            get
            { 
                return _id; 
            }
            set 
            { 
                _id = value;
            }
        }

        private int _magicRank;

        [DataMember(Name="magicRank")]
        public int MagicRank
        {
            get 
            {
                return _magicRank;
            }
            set 
            { 
                _magicRank = value;
            }
        }

        private string _name;

        [DataMember(Name="name")]
        public string Name
        {
            get 
            { 
                return _name;
            }
            set 
            { 
                _name = value; 
            }
        }

        private bool _rankedPlayEnabled;

        [DataMember(Name="rankedPlayEnabled")]
        public bool RankedPlayEnabled
        {
            get 
            { 
                return _rankedPlayEnabled;
            }
            set
            {
                _rankedPlayEnabled = value; 
            }
        }
        
    }
}
