using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class TeamStatSummary
    {
        [DataMember(Name = "fullId")]
        private string _fullID;

        public string FullID
        {
            get
            {
                return _fullID;
            }
        }

        [DataMember(Name = "teamStatDetails")]
        private HashSet<TeamStatDetail> _teamStatDetails;
        public HashSet<TeamStatDetail> TeamStatDetails { get { return _teamStatDetails; }}
        
    }
}
