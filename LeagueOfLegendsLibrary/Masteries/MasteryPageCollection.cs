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
    public class MasteryPageCollection : ICollection<MasteryPage>, IEnumerator<MasteryPage>
    {
        
        [DataMember(Name = "pages")]
        private List<MasteryPage> _pages;

        /// <summary>
        /// Set of mastery pages
        /// </summary>
        [Obsolete("Please use indexer instead")]
        public List<MasteryPage> Pages
        {
            get { return _pages; }
        }


        /// <summary>
        /// gets the mastery page of the specified index
        /// </summary>
        /// <param name="index">index of the page</param>
        /// <returns>page of the index</returns>
        public MasteryPage this[int index]
        {
            get 
            {
                return _pages[index];
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

        public IEnumerator<MasteryPage> GetEnumerator()
        {
            return this;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this;
        }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                try
                {
                    return _pages[_position];
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public MasteryPage Current
        {
            get
            {
                try
                {
                    return _pages[_position];
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
            return _position < _pages.Count;
        }

        public void Dispose()
        {
            Reset();
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Add(MasteryPage item)
        {
            _pages.Add(item);
        }

        public void Clear()
        {
            _pages.Clear();
        }

        public bool Contains(MasteryPage item)
        {
            try
            {
                return _pages.Contains(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CopyTo(MasteryPage[] array, int arrayIndex)
        {
            try
            {
                foreach (MasteryPage i in _pages)
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

        public int Count
        {
            get
            {
                return _pages.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Remove(MasteryPage item)
        {
            return _pages.Remove(item);
        }
    }
}
