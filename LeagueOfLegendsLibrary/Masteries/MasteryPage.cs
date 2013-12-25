using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class MasteryPage
    {
        /// <summary>
        /// Indicates if the mastery page is the current mastery page.
        /// </summary>
        [DataMember(Name = "current")]
        public bool current;

        /// <summary>
        /// Mastery page name.
        /// </summary>
        [DataMember(Name = "name")]
        public string name;

        /// <summary>
        /// List of mastery page talents associated with the mastery page.
        /// </summary>
        [DataMember(Name = "talents")]
        public List<Talent> talents;
    }
}
