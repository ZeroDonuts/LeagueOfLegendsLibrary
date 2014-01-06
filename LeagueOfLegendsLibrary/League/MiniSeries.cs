using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class MiniSeries
    {
        [DataMember(Name = "losses")]
        private int _losses;

        public int Losses
        {
            get
            {
                return _losses;
            }
        }

        [DataMember(Name = "progress")]
        private char[] _progress;

        public char[] Progress
        {
            get
            {
                return _progress;
            }
        }

        [DataMember(Name = "target")]
        private int _target;

        public int Target
        {
            get
            {
                return _target;
            }
        }

        [DataMember(Name = "timeLeftToPlayMillis")]
        private long _timeLeftToPlayMillis;

        public long TimeLeftToPlayMillis
        {
            get
            {
                return _timeLeftToPlayMillis;
            }
        }

        [DataMember(Name = "wins")]
        private int _wins;

        public int Wins
        {
            get
            {
                return _wins;
            }
        }
    }
}
