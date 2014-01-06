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
        
        [DataMember(Name = "current")]
        private bool _current;

        /// <summary>
        /// Indicates if the mastery page is the current mastery page.
        /// </summary>
        public bool Current
        {
            get { return _current; }
        }
        

        
        [DataMember(Name = "name")]
        private string _name;

        /// <summary>
        /// Mastery page name.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }
        

        
        [DataMember(Name = "talents")]
        private List<Talent> _talents;

        /// <summary>
        /// List of mastery page talents associated with the mastery page.
        /// </summary>
        public List<Talent> Talents
        {
            get { return _talents; }
        }
        
    }
}
