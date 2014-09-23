using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.ChampionInfo
{
    [DataContract(Name="StatsDto")]
    public class Stats
    {
        [DataMember(Name = "armor")]
        private double _armor;

        public double Armor
        {
            get
            {
                return _armor;
            }
        }

        [DataMember(Name = "armorperlevel")]
        private double _armorPerLevel;

        public double ArmorPerLevel
        {
            get
            {
                return _armorPerLevel;
            }
        }

        [DataMember(Name = "attackdamage")]
        private double _attackDamage;

        public double AttackDamage
        {
            get
            {
                return _attackDamage;
            }
        }

        [DataMember(Name = "attackdamageperlevel")]
        private double _attackDamagePerLevel;

        public double AttackDamagePerLevel
        {
            get
            {
                return _attackDamagePerLevel;
            }
        }

        [DataMember(Name = "attackrange")]
        private double _attackRange;

        public double AttackRange
        {
            get
            {
                return _attackRange;
            }
        }

        [DataMember(Name = "attackspeedoffset")]
        private double _attackSpeedOffSet;

        public double AttackSpeedOffSet
        {
            get
            {
                return _attackSpeedOffSet;
            }
        }

        [DataMember(Name = "attackspeedperlevel")]
        private double _attackSpeedPerLevel;

        public double AttackSpeedPerLevel
        {
            get
            {
                return _attackSpeedPerLevel;
            }
        }

        [DataMember(Name = "crit")]
        private double _crit;

        public double Crit
        {
            get
            {
                return _crit;
            }
        }

        [DataMember(Name = "critperlevel")]
        private double _critPerLevel;

        public double CritPerLevel
        {
            get
            {
                return _critPerLevel;
            }
        }

        [DataMember(Name = "hp")]
        private double _hp;

        public double Hp
        {
            get
            {
                return _hp;
            }
        }

        [DataMember(Name = "hpperlevel")]
        private double _hpPerLevel;

        public double HpPerLevel
        {
            get
            {
                return _hpPerLevel;
            }
        }

        [DataMember(Name = "hpregen")]
        private double _hpRegen;

        public double HpRegen
        {
            get
            {
                return _hpRegen;
            }
        }

        [DataMember(Name = "hpregenperlevel")]
        private double _hpRegenPerLevel;

        public double HpRegenPerLevel
        {
            get
            {
                return _hpRegenPerLevel;
            }
        }

        [DataMember(Name = "movespeed")]
        private double _moveSpeed;

        public double MoveSpeed
        {
            get
            {
                return _moveSpeed;
            }
        }

        [DataMember(Name = "mp")]
        private double _mp;

        public double Mp
        {
            get
            {
                return _mp;
            }
        }

        [DataMember(Name = "mpperlevel")]
        private double _mpPerLevel;

        public double MpPerLevel
        {
            get
            {
                return _mpPerLevel;
            }
        }

        [DataMember(Name = "mpregen")]
        private double _mpRegen;

        public double MpRegen
        {
            get
            {
                return _mpRegen;
            }
        }

        [DataMember(Name = "mpregenperlevel")]
        private double _mpRegenPerLevel;

        public double MpRegenPerLevel
        {
            get
            {
                return _mpRegenPerLevel;
            }
        }

        [DataMember(Name = "spellblock")]
        private double _spellBlock;

        public double SpellBlock
        {
            get
            {
                return _spellBlock;
            }
        }

        [DataMember(Name = "spellblockperlevel")]
        private double _spellBlockPerLevel;

        public double SpellBlockPerLevel
        {
            get
            {
                return _spellBlockPerLevel;
            }
        }



    }
}
