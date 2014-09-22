using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="RecommendedDto")]
    public class Recommend
    {
        //missing BlockDto

        [DataMember(Name = "champion")]
        private string _champion;

        public string Champion
        {
            get
            {
                return _champion;
            }
        }

        [DataMember(Name = "map")]
        private string _map;

        public string Map
        {
            get
            {
                return _map;
            }
        }

        [DataMember(Name = "mode")]
        private string _mode;

        public string Mode
        {
            get
            {
                return _mode;
            }
        }

        [DataMember(Name = "priority")]
        private bool _priority;

        public bool Priority
        {
            get
            {
                return _priority;
            }
        }

        [DataMember(Name = "title")]
        private string _title;

        public string Title
        {
            get
            {
                return _title;
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
