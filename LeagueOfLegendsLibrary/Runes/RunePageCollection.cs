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
    public class RunePageCollection : IEnumerable<RunePage>, IEnumerator<RunePage>
    {
        [DataMember(Name = "pages")]
        private RunePage[] _pages;

        /// <summary>
        /// Set of rune pages associated with the summoner.
        /// </summary>
        public RunePage[] pages
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
    }
}
