using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    [DataContract(Name="BlockItemDto")]
    public class BlockItem
    {
        [DataMember(Name = "count")]
        private int _count;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        [DataMember(Name = "id")]
        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        internal BlockItem()
        {

        }
    }
}
