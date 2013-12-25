using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BLib.LeagueOfLegends
{
    [DataContract]
    public class RunePage
    {
        /// <summary>
        /// Indicated if the page is the current page.
        /// </summary>
        [DataMember(Name = "current")]
        public bool current;

        /// <summary>
        /// Rune page ID.
        /// </summary>
        [DataMember(Name = "id")]
        public long id;

        /// <summary>
        /// Rune page name.
        /// </summary>
        [DataMember(Name = "name")]
        public string name;

        /// <summary>
        /// List of rune slots associated with the rune page.
        /// </summary>
        [DataMember(Name = "slots")]
        public List<RuneSlot> slots;
    }
}
