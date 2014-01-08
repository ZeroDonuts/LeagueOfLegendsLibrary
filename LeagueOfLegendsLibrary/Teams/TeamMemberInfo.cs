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
        private long _inviteDate;

        public DateTime InviteDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_inviteDate);
            }
        }

        [DataMember(Name = "joinDate")]
        private long _joinDate;

        public DateTime JoinDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_joinDate);
            }
        }

        [DataMember(Name = "playerId")]
        private long _playerID;

        public long PlayerID
        {
            get
            {
                return _playerID;
            }
        }

        [DataMember(Name = "status")]
        private string _status;

        public string Status
        {
            get
            {
                return _status;
            }
        }
    }
}
