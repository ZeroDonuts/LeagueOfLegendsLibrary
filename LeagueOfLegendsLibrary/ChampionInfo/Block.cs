using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    [DataContract(Name="BlockDto")]
    public class Block : IEnumerable<BlockItem>
    {
        [DataMember(Name = "items")]
        private List<BlockItem> _blockItems;

        /// <summary>
        /// Gets a blockitem from the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public BlockItem this[int index]
        {
            get 
            {
                return _blockItems[index];
            }
        }

        /// <summary>
        /// Gets how many BlockItems in the collection
        /// </summary>
        public int Count
        {
            get
            {
                return _blockItems.Count;
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

        /// <summary>
        /// Gets the type of the block
        /// </summary>
        public string Type
        {
            get
            {
                return _type;
            }
        }

        internal Block()
        {

        }

        public IEnumerator<BlockItem> GetEnumerator()
        {
            return _blockItems.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _blockItems.AsEnumerable().GetEnumerator();
        }
    }
}
