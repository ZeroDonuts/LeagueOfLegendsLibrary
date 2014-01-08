using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class MessageOfDay
    {
        [DataMember(Name = "createDate")]
        private long _createDate;

        public DateTime CreateDate
        {
            get
            {
                return LolInfo.EpochToDateTime(_createDate);
            }
        }

        [DataMember(Name = "message")]
        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
        }

        [DataMember(Name = "version")]
        private int _version;

        public int Version
        {
            get
            {
                return _version;
            }
        }
    }
}
