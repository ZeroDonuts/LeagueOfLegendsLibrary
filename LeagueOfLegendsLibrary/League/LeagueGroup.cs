using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueOfLegendsLibrary
{
    public class LeagueGroup
    {
        private Dictionary<long, League> _league;

        public Dictionary<long, League> League
        {
            get
            {
                return _league;
            }
        }
    }
}
