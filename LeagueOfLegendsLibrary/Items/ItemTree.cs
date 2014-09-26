using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="ItemTreeDto")]
    public class ItemTree
    {
        [DataMember(Name = "header")]
        private string _header;

        public string Header
        {
            get
            {
                return _header;
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
    }
}
