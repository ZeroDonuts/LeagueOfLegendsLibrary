using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    [DataContract(Name="SpellVarsDto")]
    public class SpellVars
    {
        [DataMember(Name = "coeff")]
        private List<double> _coeff;

        public List<double> Coeff
        {
            get
            {
                return _coeff;
            }
        }

        [DataMember(Name = "dyn")]
        private string _dyn;

        public string Dyn
        {
            get
            {
                return _dyn;
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

        [DataMember(Name = "link")]
        private string _link;

        public string Link
        {
            get
            {
                return _link;
            }
        }

        [DataMember(Name = "ranksWith")]
        private string _ranksWith;

        public string RanksWith
        {
            get
            {
                return _ranksWith;
            }
        }
    }
}
