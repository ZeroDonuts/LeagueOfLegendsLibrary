using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="RecentGamesDto")]
    public class RecentGamesCollection : IEnumerable<Game>, IEnumerator<Game>
    {
        [DataMember(Name = "games")]
        private List<Game> _games;

        public List<Game> games
        {
            get { return _games; }
        }


        public Game this[int index]
        {
            get 
            {
                try
                {
                    return _games[index];
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }


        [DataMember(Name = "summonerId")]
        private long _summonerId;

        public long summonerId
        {
            get { return _summonerId; }
        }


        int _position = -1;

        public IEnumerator<Game> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public Game Current
        {
            get 
            {
                try
                {
                    return _games[_position];
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public void Dispose()
        {
            //TODO:
        }

        object IEnumerator.Current
        {
            get 
            {
                try
                {
                    return _games[_position];
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
            return _position < _games.Count;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
