using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class TeamMemberInfo
    {
        [DataMember(Name = "inviteDate")]
        private long inviteDate;

        public DateTime InviteDate
        {
            get
            {
                return LolInfo.EpochToDateTime(inviteDate);
            }
        }

        [DataMember(Name = "joinDate")]
        private long joinDate;

        public DateTime JoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(joinDate);
            }
        }

        [DataMember(Name = "playerId")]
        private long playerID;

        [DataMember(Name = "status")]
        private string status;
    }
}
