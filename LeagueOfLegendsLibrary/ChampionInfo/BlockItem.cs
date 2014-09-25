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

        /// <summary>
        /// Count of the block
        /// </summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }

        [DataMember(Name = "id")]
        private int _id;

        /// <summary>
        /// Id of the block
        /// </summary>
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
