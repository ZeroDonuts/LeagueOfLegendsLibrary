using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name = "GoldDto")]
    public class Gold
    {
        [DataMember(Name = "base")]
        private int _base;

        public int Base
        {
            get
            {
                return _base;
            }
        }

        [DataMember(Name = "purchasable")]
        private bool _purchasable;

        public bool Purchasable
        {
            get
            {
                return _purchasable;
            }
        }

        [DataMember(Name = "sell")]
        private int _sell;

        public int Sell
        {
            get
            {
                return _sell;
            }
        }
    }
}
