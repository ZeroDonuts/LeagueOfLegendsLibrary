using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace LeagueOfLegendsLibrary.ChampionInfo
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
            internal set
            {
                _active = value;
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
            internal set
            {
                _botEnabled = value;
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
            internal set
            {
                _botMmEnabled = value;
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
            internal set
            {
                _freeToPlay = value;
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
            internal set
            {
                _rankedPlayEnabled = value;
            }
        }

        [DataMember(Name = "allytips")]
        private List<string> _allyTips;

        public List<string> AllyTips
        {
            get
            {
                return _allyTips;
            }
        }
        
        [DataMember(Name = "blurb")]
        private string _blurb;

        public string Blurb
        {
            get
            {
                return _blurb;
            }
        }

        [DataMember(Name = "enemytips")]
        private List<string> _enemyTips;

        public List<string> EnemyTips
        {
            get
            {
                return _enemyTips;
            }
        }

        [DataMember(Name="image")]
        private Image _image;

        public Image Image
        {
            get
            {
                return _image;
            }
        }

        [DataMember(Name="info")]
        private Info _info;

        public Info Info
        {
            get
            {
                return _info;
            }
        }

        [DataMember(Name = "key")]
        private string _key;

        public string Key
        {
            get
            {
                return _key;
            }
        }

        [DataMember(Name = "lore")]
        private string _lore;

        public string Lore
        {
            get
            {
                return _lore;
            }
        }

        [DataMember(Name = "partype")]
        private string _partype;

        public string Partype
        {
            get
            {
                return _partype;
            }
        }

        [DataMember(Name = "passive")]
        private Passive _passive;

        public Passive Passive
        {
            get
            {
                return _passive;
            }
        }

        [DataMember(Name = "recommended")]
        private List<Recommend> _recommends;

        public List<Recommend> Recommends
        {
            get
            {
                return _recommends;
            }
        }

        [DataMember(Name = "skins")]
        private List<Skin> _skins;

        public List<Skin> Skins
        {
            get
            {
                return _skins;
            }
        }

        [DataMember(Name = "spells")]
        private List<ChampionSpell> _spells;

        public List<ChampionSpell> Spells
        {
            get
            {
                return _spells;
            }
        }

        [DataMember(Name = "stats")]
        private Stats _stats;

        public Stats Stats
        {
            get
            {
                return _stats;
            }
        }

        [DataMember(Name = "tags")]
        private List<string> _tags;

        public List<string> Tags
        {
            get
            {
                return _tags;
            }
        }

        [DataMember(Name = "title")]
        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
        }
    }
}
