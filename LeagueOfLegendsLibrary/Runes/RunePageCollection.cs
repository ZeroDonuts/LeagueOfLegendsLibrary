using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="RunePagesDto")]
    public class RunePageCollection : ICollection<Rune>
    {
        [DataMember(Name="basic")]
        private BasicData _basic;

        [DataMember(Name="data")]
        private Dictionary<string, Rune> _data;

        [DataMember(Name="type")]
        private string _type;

        [DataMember(Name="version")]
        private string _version;

        public Rune this[string index]
        {
            get 
            {
                return _data[index];
            }
        }

        public BasicData Basic
        {
            get
            {
                return _basic;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
        }

        public string Version
        {
            get
            {
                return _version;
            }
        }




        void ICollection<Rune>.Add(Rune item)
        {
            _data.Add(item.name, item);
        }

        void ICollection<Rune>.Clear()
        {
            _data.Clear();
        }

        public bool Contains(Rune item)
        {
            return _data.ContainsValue(item) || _data.ContainsKey(item.name);
        }

        void ICollection<Rune>.CopyTo(Rune[] array, int arrayIndex)
        {
            _data.Values.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get 
            {
                return _data.Count;
            }
        }

        bool ICollection<Rune>.IsReadOnly
        {
            get 
            {
                return true;
            }
        }

        bool ICollection<Rune>.Remove(Rune item)
        {
            return _data.Remove(item.name);
        }

        public IEnumerator<Rune> GetEnumerator()
        {
            return _data.Values.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.Values.AsEnumerable().GetEnumerator();
        }
    }
}
