using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    [DataContract(Name="BlockDto")]
    public class Block
    {
        [DataMember(Name = "items")]
        private List<BlockItem> _blockItems;

        public List<BlockItem> BlockItems
        {
            get
            {
                return _blockItems;
            }
        }

        [DataMember(Name = "recMath")]
        private bool _recMath;

        public bool RecMath
        {
            get
            {
                return _recMath;
            }
        }

        [DataMember(Name = "type")]
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }
        }
    }
}
