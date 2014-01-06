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
        private string fullID;

        [DataMember(Name = "teamStatDetails")]
        private HashSet<TeamStatDetail> teamStatDetails;
        
    }
}
