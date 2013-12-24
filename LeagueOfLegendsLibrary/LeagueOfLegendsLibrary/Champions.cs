using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class Champions
    {
        private IEnumerable<Champion> _championsList;

        [DataMember(Name="champions")]
        public IEnumerable<Champion> ChampionsList
        {
            get
            {
                return _championsList;
            }
            set
            {
                _championsList = value;
            }
        }

        public Champions()
        {
            _championsList = new List<Champion>();
        }
    }
}
