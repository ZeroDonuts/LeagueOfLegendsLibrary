using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class RuneSlot
    {
        /// <summary>
        /// Rune associated with the rune slot.
        /// </summary>
        [DataMember(Name = "rune")]
        private Rune _rune;

        public Rune rune
        {
            get { return _rune; }
        }

        /// <summary>
        /// Rune slot ID.
        /// </summary>
       [DataMember(Name = "runeSlotId")]
        private int _runeSlotId;

       public int runeSlotId
       {
           get { return _runeSlotId; }
       }
    }
}
