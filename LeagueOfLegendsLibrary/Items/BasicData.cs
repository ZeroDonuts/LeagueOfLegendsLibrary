using LeagueOfLegendsLibrary.ChampionInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="BasicDataDto")]
    public class BasicData
    {
        [DataMember(Name = "colloq")]
        private string _colloq;

        public string Colloq
        {
            get
            {
                return _colloq;
            }
        }

        [DataMember(Name = "consumeOnFull")]
        private bool _consumeOnFull;

        public bool ConsumeOnFull
        {
            get
            {
                return _consumeOnFull;
            }
        }

        [DataMember(Name = "consumed")]
        private bool _consumed;

        public bool Consumed
        {
            get
            {
                return _consumed;
            }
        }

        [DataMember(Name = "depth")]
        private int _depth;

        public int Depth
        {
            get
            {
                return _depth;
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

        [DataMember(Name = "from")]
        private List<string> _from;

        public List<string> From
        {
            get
            {
                return _from;
            }
        }

        //gold

        [DataMember(Name = "group")]
        private string _group;

        public string Group
        {
            get
            {
                return _group;
            }
        }

        [DataMember(Name = "hideFromAll")]
        private bool _hideFromAll;

        public bool HideFromAll
        {
            get
            {
                return _hideFromAll;
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

        [DataMember(Name = "image")]
        private Image _image;

        public Image Image
        {
            get
            {
                return _image;
            }
        }

        [DataMember(Name = "inStore")]
        private bool _inStore;

        public bool InStore
        {
            get
            {
                return _inStore;
            }
        }

        [DataMember(Name = "into")]
        private List<string> _into;

        public List<string> Into
        {
            get
            {
                return _into;
            }
        }

        [DataMember(Name = "maps")]
        private Dictionary<string, bool> _maps;

        public Dictionary<string, bool> Maps
        {
            get
            {
                return _maps;
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

        [DataMember(Name = "plaintext")]
        private string _plainText;

        public string PlainText
        {
            get
            {
                return _plainText;
            }
        }

        [DataMember(Name = "requiredChampion")]
        private string _requiredChampion;

        public string RequiredChampion
        {
            get
            {
                return _requiredChampion;
            }
        }

        

        //rune

        [DataMember(Name = "sanitizedDescription")]
        private string _sanitizedDescription;

        public string SanitizedDescription
        {
            get
            {
                return _sanitizedDescription;
            }
        }

        [DataMember(Name = "specialRecipe")]
        private int _specialRecipe;

        public int SpecialRecipe
        {
            get
            {
                return _specialRecipe;
            }
        }

        [DataMember(Name = "stacks")]
        private int _stacks;

        public int Stacks
        {
            get
            {
                return _stacks;
            }
        }

        //stats

        [DataMember(Name = "tags")]
        private List<string> _tags;

        public List<string> Tags
        {
            get
            {
                return _tags;
            }
        }

    }
}
