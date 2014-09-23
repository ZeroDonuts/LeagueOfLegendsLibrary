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
    public class ChampionCollection : IEnumerable<Champion>
    {
        
        [DataMember(Name = "data")]
        private Dictionary<string, Champion> _data;

        [DataMember(Name = "champions")]
        internal List<Champion> _championsList;
        

        /// <summary>
        /// gets a champion using the name
        /// </summary>
        /// <param name="name">name of the champion</param>
        /// <returns>champion with the specified name</returns>
        public Champion this[string name]
        {
            get 
            {
               if(_data.ContainsKey(name))
               {
                   return _data[name];
               }

                throw new IndexOutOfRangeException(String.Format("{0} could not be found in the list", name));
            }
        }

        internal Champion Find(string name)
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

        internal Champion Find(int id)
        {
            foreach (Champion champion in _championsList)
            {
                if (champion.Id == id)
                {
                    return champion;
                }
            }

            throw new IndexOutOfRangeException(String.Format("{0} could not be found in the list", id));
        }

        public ChampionCollection()
        {
            _championsList = new List<Champion>();
        }

        public IEnumerator<Champion> GetEnumerator()
        {
            return _data.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _data.Values.AsEnumerable().GetEnumerator();   
        }
    }
}
