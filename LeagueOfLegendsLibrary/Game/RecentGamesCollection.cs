using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="RecentGamesDto")]
    public class RecentGamesCollection : IEnumerable<Game>
    {
        [DataMember(Name = "games")]
        private List<Game> _games;

        [Obsolete("Please use indexer instead")]
        public List<Game> games
        {
            get { return _games; }
        }

        public Game this[int index]
        {
            get 
            {
                if(index < 0 || index >= _games.Count)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }

                return _games[index];
            }
        }

        [DataMember(Name = "summonerId")]
        private long _summonerId;

        public long summonerId
        {
            get { return _summonerId; }
        }

        public IEnumerator<Game> GetEnumerator()
        {
            return _games.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _games.AsEnumerable().GetEnumerator();
        }
    }
}
