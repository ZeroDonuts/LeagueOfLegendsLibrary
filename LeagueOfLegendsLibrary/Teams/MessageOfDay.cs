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
        private long createDate;

        public DateTime CreateDate
        {
            get
            {
                return LolInfo.EpochToDateTime(createDate);
            }
        }

        [DataMember(Name = "message")]
        private string message;

        [DataMember(Name = "version")]
        private int version;
    }
}
