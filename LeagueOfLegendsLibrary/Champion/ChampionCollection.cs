using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace LeagueOfLegendsLibrary
{
    /// <summary>
    /// a collection of champions 
    /// </summary>
    [DataContract(Name="ChampionListDto")]
    public class ChampionCollection : IEnumerator<Champion>, ICollection<Champion>
    {
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

        /// <summary>
        /// gets the champion by index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>champion with the specified index</returns>
        public Champion this[int index]
        {
            get
            {
                try
                {
                    return _championsList[index];
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// finds champion by Id
        /// </summary>
        /// <param name="id">id of the champion</param>
        /// <returns>champion of the specified id</returns>
        public Champion FindById(int id)
        {
            foreach (Champion champion in _championsList)
            {
                if (champion.Id == id)
                {
                    return champion;
                }
            }

            throw new IndexOutOfRangeException(String.Format("Could not find Id: {0}", id));
        }

        public ChampionCollection()
        {
            _championsList = new List<Champion>();
        }


        private int _position = -1;



        public IEnumerator<Champion> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public Champion Current
        {
            get 
            {
                try
                {
                    return _championsList[_position];
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public void Dispose()
        {
            Reset();
        }

        object IEnumerator.Current
        {
            get 
            {
                try
                {
                    return _championsList[_position];
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
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

        public void Add(Champion item)
        {
            _championsList.Add(item);
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

        public bool Contains(Champion item)
        {
            return _championsList.Contains(item);
        }

        public void CopyTo(Champion[] array, int arrayIndex)
        {
            try
            {
                foreach (Champion i in _championsList)
                {
                    array.SetValue(i, arrayIndex);
                    arrayIndex++;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Remove(Champion item)
        {
            return _championsList.Remove(item);
        }
    }
}
