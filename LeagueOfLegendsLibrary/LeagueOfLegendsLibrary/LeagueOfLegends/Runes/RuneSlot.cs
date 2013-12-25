using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class RuneSlot
    {
        /// <summary>
        /// Rune associated with the rune slot.
        /// </summary>
        [DataMember(Name = "rune")]
        public Rune rune;

        /// <summary>
        /// Rune slot ID.
        /// </summary>
       [DataMember(Name = "runeSlotId")]
        public int runeSlotId;
    }
}
