using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class ChampionCollection
    {
        private List<Champion> _championsList;

        [DataMember(Name="champions")]
        public List<Champion> ChampionsList
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

        public Champion GetChampionByID(long id)
        {
            Champion tempChamp = null;
            for (int i = 0; i < _championsList.Count; i++)
            {
                if (id == _championsList[i].Id)
                {
                    tempChamp = _championsList[i];
                }
            }
            return tempChamp;
            
        }

        public ChampionCollection()
        {
            _championsList = new List<Champion>();
        }
    }
}
