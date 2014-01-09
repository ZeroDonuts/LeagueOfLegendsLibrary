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
    public class RunePageCollection : ICollection<RunePage>, IEnumerator<RunePage>
    {
        [DataMember(Name = "pages")]
        private List<RunePage> _pages;

        /// <summary>
        /// Set of rune pages associated with the summoner.
        /// </summary>
        [Obsolete("Please use indexer instead")]
        public List<RunePage> pages
        {
            get { return _pages; }
        }

        [DataMember(Name = "summonerId")]
        private long _summonerId;

        /// <summary>
        /// Summoner ID.
        /// </summary>
        public long summonerId
        {
            get { return _summonerId; }
        }

        private int _position = -1;

        public IEnumerator<RunePage> GetEnumerator()
        {
            return this;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this;
        }

        public RunePage Current
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

        public void Dispose()
        {
            Reset();
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

        public bool MoveNext()
        {
            _position++;
            return _position < _pages.Count();
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Add(RunePage item)
        {
            _pages.Add(item);
        }

        public void Clear()
        {
            _pages.Clear();
        }

        public bool Contains(RunePage item)
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

        public void CopyTo(RunePage[] array, int arrayIndex)
        {
            try
            {
                foreach (RunePage i in _pages)
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

        public bool Remove(RunePage item)
        {
            return _pages.Remove(item);
        }
    }
}
