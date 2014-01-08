using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="RunePageDto")]
    public class RunePage
    {
        [DataMember(Name = "current")]
        private bool _current;

        /// <summary>
        /// Indicated if the page is the current page.
        /// </summary>
        public bool current
        {
            get { return _current; }
        }

        [DataMember(Name = "id")]
        private long _id;

        /// <summary>
        /// Rune page ID.
        /// </summary>
        public long id
        {
            get { return _id; }
        }

        [DataMember(Name = "name")]
        private string _name;

        /// <summary>
        /// Rune page name.
        /// </summary>
        public string name
        {
            get { return _name; }
        }

        [DataMember(Name = "slots")]
        private List<RuneSlot> _slots;

        /// <summary>
        /// List of rune slots associated with the rune page.
        /// </summary>
        public List<RuneSlot> slots
        {
            get { return _slots; }
        }
    }
}
