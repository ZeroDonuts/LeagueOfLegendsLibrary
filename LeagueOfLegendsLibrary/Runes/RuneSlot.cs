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
        [DataMember(Name = "rune")]
        private Rune _rune;

        /// <summary>
        /// Rune associated with the rune slot.
        /// </summary>
        public Rune rune
        {
            get { return _rune; }
        }

       [DataMember(Name = "runeSlotId")]
        private int _runeSlotId;


       /// <summary>
       /// Rune slot ID.
       /// </summary>
       public int runeSlotId
       {
           get { return _runeSlotId; }
       }
    }
}
