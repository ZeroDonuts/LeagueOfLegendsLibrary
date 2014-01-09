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
    public class ChampionCollection : IEnumerable<Champion>, IEnumerator<Champion>
    {
        [DataMember(Name = "champions")]
        private List<Champion> _championsList;
        
        /// <summary>
        /// List of Champions in League of Legends
        /// </summary>
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
        /// gets the champion using the id
        /// </summary>
        /// <param name="id">id of the champion</param>
        /// <returns>champion with the specified id</returns>
        public Champion this[int id]
        {
            get
            {
                foreach (Champion champion in _championsList)
                {
                    if (champion.Id == id)
                    {
                        return champion;
                    }
                }

                throw new IndexOutOfRangeException(String.Format("Id:{0} could not be found in the list", id));
            }
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
    }
}
