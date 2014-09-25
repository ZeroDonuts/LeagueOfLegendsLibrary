using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary.ItemsInfo
{
    [DataContract(Name="GroupDto")]
    public class Group
    {
        [DataMember(Name = "MaxGroupOwnable")]
        private string _maxGroupOwnable;

        public string MaxGroupOwnable
        {
            get
            {
                return _maxGroupOwnable;
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
    }
}
