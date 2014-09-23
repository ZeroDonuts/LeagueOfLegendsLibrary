using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    [DataContract(Name="PassiveDto")]
    public class Passive
    {
        [DataMember(Name = "description")]
        private string _description;

        public string Description
        {
            get
            {
                return _description;
            }
        }

        [DataMember(Name = "image")]
        private Image _image;

        public Image Image
        {
            get
            {
                return _image;
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

        [DataMember(Name = "sanitizedDescription")]
        private string _sanitizedDescription;

        public string SanitizedDescription
        {
            get
            {
                return _sanitizedDescription;
            }
        }

    }
}
