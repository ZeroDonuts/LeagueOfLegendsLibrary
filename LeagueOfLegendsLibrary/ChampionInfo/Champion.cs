using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace LeagueOfLegendsLibrary.ChampionInfo
{
    
    /// <summary>
    /// A class that represents a champion object.
    /// </summary>
    [DataContract(Name="ChampionDto")]
    public class Champion
    {
        [DataMember(Name = "active")]
        private bool _active;

        /// <summary>
        /// Gets whether the champion is currently active in the game
        /// </summary>
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

        /// <summary>
        /// Gets whether the champion is available in bot games
        /// </summary>
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

        /// <summary>
        /// Gets whether the champion is available in bot match making games
        /// </summary>
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
        
        /// <summary>
        /// Gets whether the champion is currently free to play
        /// </summary>
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
        
        /// <summary>
        /// Gets the internal id of the champion
        /// </summary>
        public int Id
        {
            get
            { 
                return _id; 
            }
        }

        [DataMember(Name = "name")]
        private string _name;
        
        /// <summary>
        /// Gets the name of the champion
        /// </summary>
        public string Name
        {
            get 
            { 
                return _name;
            }
        }

        [DataMember(Name = "rankedPlayEnabled")]
        private bool _rankedPlayEnabled;
        

        /// <summary>
        /// Gets whether the champion is available for rank play
        /// </summary>
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

        /// <summary>
        /// Gets all tips for playing with the champion as an ally
        /// </summary>
        /// <returns></returns>
        public string[] GetAllyTips()
        {
            return _allyTips.ToArray<string>();
        }
        
        [DataMember(Name = "blurb")]
        private string _blurb;

        /// <summary>
        /// Gets the blurb of the champion
        /// </summary>
        public string Blurb
        {
            get
            {
                return _blurb;
            }
        }

        [DataMember(Name = "enemytips")]
        private List<string> _enemyTips;

        /// <summary>
        /// Gets all tips for the champion as the enemy
        /// </summary>
        /// <returns></returns>
        public string[] GetEnemyTips()
        {
            return _enemyTips.ToArray<string>();
        }


        [DataMember(Name="image")]
        private Image _image;

        /// <summary>
        /// Gets image information of the champion
        /// </summary>
        public Image Image
        {
            get
            {
                return _image;
            }
        }

        [DataMember(Name="info")]
        private Info _info;

        /// <summary>
        /// Gets basic status information of the champion
        /// </summary>
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

        /// <summary>
        /// Gets the lore of the champion
        /// </summary>
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

        /// <summary>
        /// Gets the passive information of the champion
        /// </summary>
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

        /// <summary>
        /// Gets all the skins for the champion
        /// </summary>
        /// <returns></returns>
        public Skin[] GetSkins()
        {
            return _skins.ToArray<Skin>();
        }

        [DataMember(Name = "spells")]
        private List<ChampionSpell> _spells;

        /// <summary>
        /// Gets all the skills for the champion
        /// </summary>
        /// <returns></returns>
        public ChampionSpell[] GetSpells()
        {
            return _spells.ToArray<ChampionSpell>();
        }

        [DataMember(Name = "stats")]
        private Stats _stats;

        /// <summary>
        /// Gets all the detailed stats of the champion
        /// </summary>
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

        /// <summary>
        /// Gets the title of the champion
        /// </summary>
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
