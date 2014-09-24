using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    [DataContract(Name="ChampionSpellDto")]
    public class ChampionSpell
    {
        [DataMember(Name = "altimages")]
        private List<Image> _altimages;

        public List<Image> Altimages
        {
            get
            {
                return _altimages;
            }
        }

        [DataMember(Name = "cooldown")]
        private List<double> _coolDowns;

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

        public string CostType
        {
            get
            {
                return _costType;
            }
        }

        [DataMember(Name = "description")]
        private string _description;

        public string Description
        {
            get
            {
                return _description;
            }
        }

        [DataMember(Name = "effect")]
        private List<object> _effects; //the api description returns a List<object> but the summary say's it is a list of list of double

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

        public Image Image
        {
            get
            {
                return _image;
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

        [DataMember(Name = "range")]
        private object _range;

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
