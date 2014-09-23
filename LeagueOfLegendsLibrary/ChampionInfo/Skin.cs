using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    [DataContract(Name="SkinDto")]
    public class Skin
    {
        [DataMember(Name = "id")]
        private int _id;

        public int Id
        {
            get
            {
                return _id;
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


        [DataMember(Name = "num")]
        private int _num;

        public int Num
        {
            get
            {
                return _num;
            }
        }
    }
}
