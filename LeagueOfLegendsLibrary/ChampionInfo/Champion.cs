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

        public string[] GetAllyTips()
        {
            return _allyTips.ToArray<string>();
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

        public string[] GetEnemyTips()
        {
            return _enemyTips.ToArray<string>();
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

        public Recommend[] GetRecommendedList()
        {
            return _recommends.ToArray<Recommend>();
        }

        [DataMember(Name = "skins")]
        private List<Skin> _skins;

        public Skin[] GetSkins()
        {
            return _skins.ToArray<Skin>();
        }

        [DataMember(Name = "spells")]
        private List<ChampionSpell> _spells;

        public ChampionSpell[] GetSpells()
        {
            return _spells.ToArray<ChampionSpell>();
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

        public string[] GetTags()
        {
            return _tags.ToArray<string>();
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

        internal Champion()
        {

        }
    }
}
