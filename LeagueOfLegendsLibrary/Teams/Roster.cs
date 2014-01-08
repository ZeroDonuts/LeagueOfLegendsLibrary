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
        private List<TeamMemberInfo> _memberList;

        public List<TeamMemberInfo> MemberList
        {
            get
            {
                return _memberList;
            }
        }

        [DataMember(Name = "ownerId")]
        private long _ownerID;

        public long OwnerID
        {
            get
            {
                return _ownerID;
            }
        }
    }
}
