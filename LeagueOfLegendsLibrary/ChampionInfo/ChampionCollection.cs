using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    /// <summary>
    /// a collection of champions 
    /// </summary>
    [DataContract(Name="ChampionListDto")]
    public class ChampionCollection : ICollection<Champion>
    {
        
        [DataMember(Name = "data")]
        private Dictionary<string, Champion> _keys;

        public Dictionary<string, Champion> Keys
        {
            get
            {
                return _keys;
            }
        }


        [DataMember(Name = "champions")]
        private List<Champion> _championsList;
        
        /// <summary>
        /// List of Champions in League of Legends
        /// </summary>
        [Obsolete("Please use indexer instead or the FindById Method")]
        public List<Champion> ChampionsList
        {
            get
            {
                return _championsList;
            }
        }

        /// <summary>
        /// gets a champion using the name
        /// </summary>
        /// <param name="name">name of the champion</param>
        /// <returns>champion with the specified name</returns>
        public Champion this[string name]
        {
            get 
            {
                foreach (Champion champion in _championsList)
                {
                    if (name.Equals(champion.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return champion;
                    }
                }

                throw new IndexOutOfRangeException(String.Format("{0} could not be found in the list", name));
            }
        }

        public ChampionCollection()
        {
            _championsList = new List<Champion>();
        }


        private int _position = -1;
        

        public void Dispose()
        {
            Reset();
        }



        public bool MoveNext()
        {
            _position++;
            return _position < _championsList.Count;
        }

        public void Reset()
        {
            _position = -1;
        }


        public void Clear()
        {
            _championsList.Clear();
        }

        
        public int Count
        {
            get 
            {
                return _championsList.Count;    
            }
        }

        public bool IsReadOnly
        {
            get 
            {
                return false;
            }
        }

        public void Add(Champion item)
        {
            _championsList.Add(item);
        }

        public bool Contains(Champion item)
        {
            return _championsList.Contains(item);
        }

        public void CopyTo(Champion[] array, int arrayIndex)
        {
            _championsList.CopyTo(array, arrayIndex);
        }

        public bool Remove(Champion item)
        {
            return _championsList.Remove(item);
        }

        public IEnumerator<Champion> GetEnumerator()
        {
            return _championsList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _championsList.AsEnumerable().GetEnumerator();
        }
    }
}
