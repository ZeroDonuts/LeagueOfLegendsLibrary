using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary.Items
{
    [DataContract(Name = "BasicDataStatsDto")]
    class BasicDataStats
    {
        [DataMember(Name = "FlatArmorMod")]
        private double _flatArmorMod;

        public double FlatArmorMod
        {
            get
            {
                return _flatArmorMod;
            }
        }

        [DataMember(Name = "FlatAttackSpeedMod")]
        private double _flatAttackSpeedMod;

        public double FlatAttackSpeedMod
        {
            get
            {
                return _flatAttackSpeedMod;
            }
        }

        [DataMember(Name = "FlatBlockMod")]
        private double _flatBlockMod;

        public double FlatBlockMod
        {
            get
            {
                return _flatBlockMod;
            }
        }

        [DataMember(Name = "FlatCritChanceMod")]
        private double _flatCritChanceMod;

        public double FlatCritChanceMod
        {
            get
            {
                return _flatCritChanceMod;
            }
        }

        [DataMember(Name = "FlatCritDamageMod")]
        private double _flatCritDamageMod;

        public double FlatCritDamageMod
        {
            get
            {
                return _flatCritDamageMod;
            }
        }

        [DataMember(Name = "FlatEXPBonus")]
        private double _flatEXPBonus;

        public double FlatEXPBonus
        {
            get
            {
                return _flatEXPBonus;
            }
        }

        [DataMember(Name = "FlatEnergyPoolMod")]
        private double _flatEnergyPoolMod;

        public double FlatEnergyPoolMod
        {
            get
            {
                return _flatEnergyPoolMod;
            }
        }

        [DataMember(Name = "FlatEnergyRegenMod")]
        private double _flatEnergyRegenMod;

        public double FlatEnergyRegenMod
        {
            get
            {
                return _flatEnergyRegenMod;
            }
        }
        [DataMember(Name = "FlatHPPoolMod")]
        private double _flatHPPoolMod;

        public double FlatHPPoolMod
        {
            get
            {
                return _flatHPPoolMod;
            }
        }

        [DataMember(Name = "FlatHPRegenMod")]
        private double _flatHPRegenMod;

        public double FlatHPRegenMod
        {
            get
            {
                return _flatHPRegenMod;
            }
        }

        [DataMember(Name = "FlatMPPoolMod")]
        private double _flatMPPoolMod;

        public double FlatMPPoolMod
        {
            get
            {
                return _flatMPPoolMod;
            }
        }

        [DataMember(Name = "FlatMPRegenMod")]
        private double _flatMPRegenMod;

        public double FlatMPRegenMod
        {
            get
            {
                return _flatMPRegenMod;
            }
        }

        [DataMember(Name = "FlatMagicDamageMod")]
        private double _flatMagicDamageMod;

        public double FlatMagicDamageMod
        {
            get
            {
                return _flatMagicDamageMod;
            }
        }

        [DataMember(Name = "FlatMovementSpeedMod")]
        private double _flatMovementSpeedMod;

        public double FlatMovementSpeedMod
        {
            get
            {
                return _flatMovementSpeedMod;
            }
        }

        [DataMember(Name = "FlatPhysicalDamageMod")]
        private double _flatPhysicalDamageMod;

        public double FlatPhysicalDamageMod
        {
            get
            {
                return _flatPhysicalDamageMod;
            }
        }

        [DataMember(Name = "FlatSpellBlockMod")]
        private double _flatSpellBlockMod;

        public double FlatSpellBlockMod
        {
            get
            {
                return _flatSpellBlockMod;
            }
        }

        [DataMember(Name = "PercentArmorMod")]
        private double _PercentArmorMod;

        public double PercentArmorMod
        {
            get
            {
                return _PercentArmorMod;
            }
        }

        [DataMember(Name = "PercentAttackSpeedMod")]
        private double _PercentAttackSpeedMod;

        public double PercentAttackSpeedMod
        {
            get
            {
                return _PercentAttackSpeedMod;
            }
        }

        [DataMember(Name = "PercentBlockMod")]
        private double _PercentBlockMod;

        public double PercentBlockMod
        {
            get
            {
                return _PercentBlockMod;
            }
        }

        [DataMember(Name = "PercentCritChanceMod")]
        private double _PercentCritChanceMod;

        public double PercentCritChanceMod
        {
            get
            {
                return _PercentCritChanceMod;
            }
        }

        [DataMember(Name = "PercentCritDamageMod")]
        private double _PercentCritDamageMod;

        public double PercentCritDamageMod
        {
            get
            {
                return _PercentCritDamageMod;
            }
        }

        [DataMember(Name = "PercentEXPBonus")]
        private double _PercentEXPBonus;

        public double PercentEXPBonus
        {
            get
            {
                return _PercentEXPBonus;
            }
        }

        [DataMember(Name = "PercentEnergyPoolMod")]
        private double _PercentEnergyPoolMod;

        public double PercentEnergyPoolMod
        {
            get
            {
                return _PercentEnergyPoolMod;
            }
        }

        [DataMember(Name = "PercentEnergyRegenMod")]
        private double _PercentEnergyRegenMod;

        public double PercentEnergyRegenMod
        {
            get
            {
                return _PercentEnergyRegenMod;
            }
        }
        [DataMember(Name = "PercentHPPoolMod")]
        private double _PercentHPPoolMod;

        public double PercentHPPoolMod
        {
            get
            {
                return _PercentHPPoolMod;
            }
        }

        [DataMember(Name = "PercentHPRegenMod")]
        private double _PercentHPRegenMod;

        public double PercentHPRegenMod
        {
            get
            {
                return _PercentHPRegenMod;
            }
        }

        [DataMember(Name = "PercentLifeStealMod")]
        private double _PercentLifeStealMod;

        public double PercentLifeStealMod
        {
            get
            {
                return _PercentLifeStealMod;
            }
        }

        [DataMember(Name = "PercentMPPoolMod")]
        private double _PercentMPPoolMod;

        public double PercentMPPoolMod
        {
            get
            {
                return _PercentMPPoolMod;
            }
        }

        [DataMember(Name = "PercentMPRegenMod")]
        private double _PercentMPRegenMod;

        public double PercentMPRegenMod
        {
            get
            {
                return _PercentMPRegenMod;
            }
        }

        [DataMember(Name = "PercentMagicDamageMod")]
        private double _PercentMagicDamageMod;

        public double PercentMagicDamageMod
        {
            get
            {
                return _PercentMagicDamageMod;
            }
        }

        [DataMember(Name = "PercentMovementSpeedMod")]
        private double _PercentMovementSpeedMod;

        public double PercentMovementSpeedMod
        {
            get
            {
                return _PercentMovementSpeedMod;
            }
        }

        [DataMember(Name = "PercentPhysicalDamageMod")]
        private double _PercentPhysicalDamageMod;

        public double PercentPhysicalDamageMod
        {
            get
            {
                return _PercentPhysicalDamageMod;
            }
        }

        [DataMember(Name = "PercentSpellBlockMod")]
        private double _PercentSpellBlockMod;

        public double PercentSpellBlockMod
        {
            get
            {
                return _PercentSpellBlockMod;
            }
        }

        [DataMember(Name = "PercentSpellVampMod")]
        private double _PercentSpellVampMod;

        public double PercentSpellVampMod
        {
            get
            {
                return _PercentSpellVampMod;
            }
        }
        //still need to do everything with an "r" in front of it. 

    }
}
