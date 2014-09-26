using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name = "MetaDataDto")]
    public class MetaData
    {
        [DataMember(Name = "colloq")]
        private bool _isRune;

        public bool IsRune
        {
            get { return _isRune; }
        }
        [DataMember(Name = "tier")]
        private string _tier;

        public string Tier
        {
            get { return _tier; }
        }

        [DataMember(Name = "type")]
        private string _type;

        public string Type
        {
            get { return _type; }
        }
    }
}
