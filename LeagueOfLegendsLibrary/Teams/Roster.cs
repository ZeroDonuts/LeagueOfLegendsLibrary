using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class Roster
    {
        [DataMember(Name = "memberList")]
        private List<TeamMemberInfo> memberList;

        [DataMember(Name = "ownerId")]
        private long ownerID;
    }
}
