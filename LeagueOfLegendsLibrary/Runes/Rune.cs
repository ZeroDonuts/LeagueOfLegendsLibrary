using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract(Name="RuneDto")]
    public class Rune
    {
        [DataMember(Name="colloq")]
        private string _colloq;

        [DataMember(Name="consumeOnFull")]
        private bool _consumeOnFull;

        [DataMember(Name="consumed")]
        private bool _consumed;

        [DataMember(Name="depth")]
        private int _depth;

        [DataMember(Name="description")]
        private string _description;

        [DataMember(Name="from")]
        private List<string> _from;

        [DataMember(Name="group")]
        private string _group;

        [DataMember(Name="hideFromAll")]
        private bool _hideFromAll;

        [DataMember(Name="id")]
        private int _id;

        [DataMember(Name="image")]
        private Image _image;

        [DataMember(Name="inStore")]
        private bool _inStore;

        [DataMember(Name="into")]
        private List<string> _into;

        [DataMember(Name="maps")]
        private Dictionary<string, bool> _maps;

        [DataMember(Name="name")]
        private string _name;

        [DataMember(Name="plaintext")]
        private string _plainText;

        [DataMember(Name="requiredChampion")]
        private string _requiredChampion;


        //rune - metadatadto

        [DataMember(Name="sanitizedDescription")]
        private string _sanitizedDescription;


        [DataMember(Name="specialRecipe")]
        private int _specialRecipe;


        [DataMember(Name="stacks")]
        private int _stacks;

        //stats - basicdatastasdto

        [DataMember(Name="tags")]
        private List<string> _tags;


    }
}
