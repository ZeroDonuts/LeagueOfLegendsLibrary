using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Runtime.Serialization;
using System.Collections;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class MasteryPages : IEnumerable, IEnumerator
    {
        
        [DataMember(Name = "pages")]
        private List<MasteryPage> _masteryPages;

        /// <summary>
        /// gets the mastery page of the specified index
        /// </summary>
        /// <param name="index">index of the page</param>
        /// <returns>page of the index</returns>
        public MasteryPage this[int index]
        {
            get 
            {
                return _masteryPages[index];
            }
        }

        
        [DataMember(Name = "summonerId")]
        private int _id;

        /// <summary>
        /// Summoner ID.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }
        

        private int _position = -1;

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current
        {
            get 
            {
                try
                {
                    return _masteryPages[_position];
                }
                catch (Exception e)
                {
                    throw new InvalidOperationException("", e);
                }
            }
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _masteryPages.Count;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
