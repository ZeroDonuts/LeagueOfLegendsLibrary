using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Runtime.Serialization;
using System.IO;

namespace LeagueOfLegendsLibrary.LeagueInfo
{
    [DataContract(Name="LeagueDto")]
    public class League
    {
        [DataMember(Name = "entries")]
        private List<LeagueItem> _entries;

        public List<LeagueItem> Entries
        {
            get
            {
                return _entries;
            }
        }

        [DataMember(Name = "name")]
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        [DataMember(Name = "participantId")]
        private string _participantID;

        public string ParticipantID
        {
            get { return _participantID; }
        }

        [DataMember(Name = "queue")]
        private string _queue;

        public string Queue
        {
            get
            {
                return _queue;
            }
        }

        [DataMember(Name = "tier")]
        private string _tier;

        public string Tier
        {
            get
            {
                return _tier;
            }
        }
    }
}
