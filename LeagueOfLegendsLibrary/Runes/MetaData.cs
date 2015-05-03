using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary.Runes
{
    [DataContract(Name="MetaDataDto")]
    public class MetaData
    {
        [DataMember(Name="isRune")]
        private bool _isRune;

        [DataMember(Name="tier")]
        private string _tier;

        [DataMember(Name="type")]
        private string _type;

        public bool IsRune
        {
            get
            {
                return _isRune;
            }
        }

        public string Tier
        {
            get
            {
                return _tier;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
        }

    }
}
