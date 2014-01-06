using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class RunePage
    {
        /// <summary>
        /// Indicated if the page is the current page.
        /// </summary>
        [DataMember(Name = "current")]
        private bool _current;

        public bool current
        {
            get { return _current; }
        }

        /// <summary>
        /// Rune page ID.
        /// </summary>
        [DataMember(Name = "id")]
        private long _id;

        public long id
        {
            get { return _id; }
        }

        /// <summary>
        /// Rune page name.
        /// </summary>
        [DataMember(Name = "name")]
        private string _name;

        public string name
        {
            get { return _name; }
        }

        /// <summary>
        /// List of rune slots associated with the rune page.
        /// </summary>
        [DataMember(Name = "slots")]
        private List<RuneSlot> _slots;

        public List<RuneSlot> slots
        {
            get { return _slots; }
        }
    }
}
