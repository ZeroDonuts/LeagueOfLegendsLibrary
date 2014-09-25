using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary.ItemsInfo
{
    [DataContract(Name="ItemListDto")]
    public class ItemList
    {
        [DataMember(Name = "basic")]
        private BasicData _basic;

        public BasicData Basic
        {
            get
            {
                return _basic;
            }
        }

        [DataMember(Name = "data")]
        private Dictionary<string, Item> _data;

        public Dictionary<string, Item> Data
        {
            get
            {
                return _data;
            }
        }

        [DataMember(Name = "groups")]
        private List<Group> _groups;

        public List<Group> Groups
        {
            get
            {
                return _groups;
            }
        }

        [DataMember(Name = "tree")]
        private List<ItemTree> _tree;

        public List<ItemTree> Tree
        {
            get
            {
                return _tree;
            }
        }

        [DataMember(Name = "type")]
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }
        }

        [DataMember(Name = "version")]
        private string _version;

        public string Version
        {
            get
            {
                return _version;
            }
        }
    }
}
