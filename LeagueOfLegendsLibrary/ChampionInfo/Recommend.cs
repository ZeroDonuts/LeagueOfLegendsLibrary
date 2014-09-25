using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    /// <summary>
    /// RecommendedItems class 
    /// </summary>
    [DataContract(Name="RecommendedDto")]
    public class RecommendedItems
    {
        [DataMember(Name = "blocks")]
        private List<Block> _blocks;

        /// <summary>
        /// List of Blocks in the recommended list
        /// </summary>
        public List<Block> Blocks
        {
            get
            {
                return _blocks;
            }
        }

        [DataMember(Name = "champion")]
        private string _champion;

        /// <summary>
        /// Champion name of the recommended items
        /// </summary>
        public string Champion
        {
            get
            {
                return _champion;
            }
        }

        [DataMember(Name = "map")]
        private string _map;

        /// <summary>
        /// Map name for the recommended items
        /// </summary>
        public string Map
        {
            get
            {
                return _map;
            }
        }

        [DataMember(Name = "mode")]
        private string _mode;

        /// <summary>
        /// Game mode for the recommended items
        /// </summary>
        public string Mode
        {
            get
            {
                return _mode;
            }
        }

        [DataMember(Name = "priority")]
        private bool _priority;

        public bool Priority
        {
            get
            {
                return _priority;
            }
        }

        [DataMember(Name = "title")]
        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
        }

        [DataMember(Name = "type")]
        private string _type;

        public string Type
        {
            get
            {
                return _type;
            }
        }
    }
}
