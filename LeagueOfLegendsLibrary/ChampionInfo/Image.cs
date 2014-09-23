using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    [DataContract(Name="ImageDto")]
    public class Image
    {
        [DataMember(Name="full")]
        private string _full;

        public string Full
        {
            get
            {
                return _full;
            }
        }


        [DataMember(Name="group")]
        private string _group;

        public string Group
        {
            get
            {
                return _group;
            }
        }

        [DataMember(Name="h")]
        private int _height;

        public int Height
        {
            get
            {
                return _height;
            }
        }


        [DataMember(Name="sprite")]
        private string _sprite;

        public string Sprite
        {
            get
            {
                return _sprite;
            }
        }

        [DataMember(Name="w")]
        private int _width;

        public int Width
        {
            get
            {
                return _width;
            }
        }

        [DataMember(Name="x")]
        private int _x;

        public int X
        {
            get
            {
                return _x;
            }
        }

        [DataMember(Name="y")]
        private int _y;

        public int Y
        {
            get
            {
                return _y;
            }
        }

    }
}
