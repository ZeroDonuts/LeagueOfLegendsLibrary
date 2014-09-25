using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    /// <summary>
    /// A class that represents the skills champions can have
    /// </summary>
    [DataContract(Name="ChampionSpellDto")]
    public class ChampionSpell
    {
        [DataMember(Name = "altimages")]
        private List<Image> _altimages;

        /// <summary>
        /// Gets all the alternate images of the skill
        /// </summary>
        public List<Image> Altimages
        {
            get
            {
                return _altimages;
            }
        }

        [DataMember(Name = "cooldown")]
        private List<double> _coolDowns;

        /// <summary>
        /// Gets all the cooldowns of the skill
        /// </summary>
        public List<double> CoolDowns
        {
            get
            {
                return _coolDowns;
            }
        }

        [DataMember(Name = "cooldownBurn")]
        private string _coolDownBurn;

        public string CoolDownBurn
        {
            get
            {
                return _coolDownBurn;
            }
        }

        [DataMember(Name = "cost")]
        private List<int> _costs;

        /// <summary>
        /// Gets the cost of the spell
        /// </summary>
        public List<int> Costs
        {
            get
            {
                return _costs;
            }
        }

        [DataMember(Name = "costBurn")]
        private string _costBurn;

        public string CostBurn
        {
            get
            {
                return _costBurn;
            }
        }

        [DataMember(Name = "costType")]
        private string _costType;

        /// <summary>
        /// Gets the cost type of the skill
        /// </summary>
        public string CostType
        {
            get
            {
                return _costType;
            }
        }

        [DataMember(Name = "description")]
        private string _description;

        /// <summary>
        /// Gets the Description of the skill
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
        }

        [DataMember(Name = "effect")]
        private List<object> _effects; 


        /// <summary>
        /// the api description returns a List<object> but the summary say's it is a list of list of double
        /// </summary>
        public List<object> Effects
        {
            get
            {
                return _effects;
            }
        }

        [DataMember(Name = "effectBurn")]
        private List<string> _effectBurns;

        public List<string> EffectBurns
        {
            get
            {
                return _effectBurns;
            }
        }

        [DataMember(Name = "image")]
        private Image _image;

        /// <summary>
        /// Gets the image information of the skill
        /// </summary>
        public Image Image
        {
            get
            {
                return _image;
            }
        }

        [DataMember(Name = "key")]
        private string _key;

        /// <summary>
        /// Gets the key of the skill
        /// </summary>
        public string Key
        {
            get
            {
                return _key;
            }
        }

        [DataMember(Name = "range")]
        private object _range;

        /// <summary>
        /// Gets the range of the skill
        /// it will either be a list of double of all the ranges
        /// or a string saying "Self"
        /// </summary>
        public object Range
        {
            get
            {
                return _range;
            }
        }

        [DataMember(Name = "rangeBurn")]
        private string _rangeBurn;

        public string RangeBurn
        {
            get
            {
                return _rangeBurn;
            }
        }

        [DataMember(Name = "resource")]
        private string _resource;

        /// <summary>
        /// Gets the resource of the skill
        /// </summary>
        public string Resource
        {
            get
            {
                return _resource;
            }
        }

        [DataMember(Name = "sanitizedDescription")]
        private string _sanitizedDescription;

        public string SanitizedDescription
        {
            get
            {
                return _sanitizedDescription;
            }
        }

        [DataMember(Name = "sanitizedTooltip")]
        private string _sanitizedToolTip;

        
        public string SanitizedToolTip
        {
            get
            {
                return _sanitizedToolTip;
            }
        }

        [DataMember(Name = "tooltip")]
        private string _toolTip;

        /// <summary>
        /// Gets the tool tip of the skill
        /// </summary>
        public string ToolTip
        {
            get
            {
                return _toolTip;
            }
        }

        [DataMember(Name = "vars")]
        private List<SpellVars> _vars;

        public List<SpellVars> Vars
        {
            get
            {
                return _vars;
            }
        }
    }

}
