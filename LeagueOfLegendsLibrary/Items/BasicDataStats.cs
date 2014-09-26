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
        [DataMember(Name = "rFlatArmorModPerLevel")]
        private double _rFlatArmorModPerLevel;

        public double FlatArmorModPerLevel
        {
            get
            {
                return _rFlatArmorModPerLevel;
            }
        }

        [DataMember(Name = "rFlatArmorPenetrationMod")]
        private double _rFlatArmorPenetrationMod;

        public double FlatArmorPenetrationMod
        {
            get
            {
                return _rFlatArmorPenetrationMod;
            }
        }

        [DataMember(Name = "rFlatArmorPenetrationModPerLevel")]
        private double _rFlatArmorPenetrationModPerLevel;

        public double FlatArmorPenetrationModPerLevel
        {
            get
            {
                return _rFlatArmorPenetrationModPerLevel;
            }
        }

        [DataMember(Name = "rFlatCritChanceModPerLevel")]
        private double _rFlatCritChanceModPerLevel;

        public double FlatCritChanceModPerLevel
        {
            get
            {
                return _rFlatCritChanceModPerLevel;
            }
        }

        [DataMember(Name = "rFlatCritDamageModPerLevel")]
        private double _rFlatCritDamageModPerLevel;

        public double FlatCritDamageModPerLevel
        {
            get
            {
                return _rFlatCritDamageModPerLevel;
            }
        }

        [DataMember(Name = "rFlatDodgeMod")]
        private double _rFlatDodgeMod;

        public double FlatDodgeMod
        {
            get
            {
                return _rFlatDodgeMod;
            }
        }

        [DataMember(Name = "rFlatDodgeModPerLevel")]
        private double _rFlatDodgeModPerLevel;

        public double FlatDodgeModPerLevel
        {
            get
            {
                return _rFlatDodgeModPerLevel;
            }
        }

        [DataMember(Name = "rFlatEnergyModPerLevel")]
        private double _rFlatEnergyModPerLevel;

        public double FlatEnergyModPerLevel
        {
            get
            {
                return _rFlatEnergyModPerLevel;
            }
        }

        [DataMember(Name = "rFlatEnergyRegenModPerLevel")]
        private double _rFlatEnergyRegenModPerLevel;

        public double FlatEnergyRegenModPerLevel
        {
            get
            {
                return _rFlatEnergyRegenModPerLevel;
            }
        }

        [DataMember(Name = "rFlatGoldPer10Mod")]
        private double _rFlatGoldPer10Mod;

        public double FlatGoldPer10Mod
        {
            get
            {
                return _rFlatGoldPer10Mod;
            }
        }

        [DataMember(Name = "rFlatHPModPerLevel")]
        private double _rFlatHPModPerLevel;

        public double FlatHPModPerLevel
        {
            get
            {
                return _rFlatHPModPerLevel;
            }
        }

        [DataMember(Name = "rFlatHPRegenModPerLevel")]
        private double _rFlatHPRegenModPerLevel;

        public double FlatHPRegenModPerLevel
        {
            get
            {
                return _rFlatHPRegenModPerLevel;
            }
        }

        [DataMember(Name = "rFlatMPModPerLevel")]
        private double _rFlatMPModPerLevel;

        public double FlatMPModPerLevel
        {
            get
            {
                return _rFlatMPModPerLevel;
            }
        }
        [DataMember(Name = "rFlatMPRegenModPerLevel")]
        private double _rFlatMPRegenModPerLevel;

        public double FlatMPRegenModPerLevel
        {
            get
            {
                return _rFlatMPRegenModPerLevel;
            }
        }

        [DataMember(Name = "rFlatMagicPenetrationMod")]
        private double _rFlatMagicPenetrationMod;

        public double FlatMagicPenetrationMod
        {
            get
            {
                return _rFlatMagicPenetrationMod;
            }
        }

        [DataMember(Name = "rFlatMagicPenetrationModPerLevel")]
        private double _rFlatMagicPenetrationModPerLevel;

        public double FlatMagicPenetrationModPerLevel
        {
            get
            {
                return _rFlatMagicPenetrationModPerLevel;
            }
        }

        [DataMember(Name = "rFlatMovementSpeedModPerLevel")]
        private double _rFlatMovementSpeedModPerLevel;

        public double FlatMovementSpeedModPerLevel
        {
            get
            {
                return _rFlatMovementSpeedModPerLevel;
            }
        }

        [DataMember(Name = "rFlatPhysicalDamageModPerLevel")]
        private double _rFlatPhysicalDamageModPerLevel;

        public double FlatPhysicalDamageModPerLevel
        {
            get
            {
                return _rFlatPhysicalDamageModPerLevel;
            }
        }

        [DataMember(Name = "rFlatSpellBlockModPerLevel")]
        private double _rFlatSpellBlockModPerLevel;

        public double FlatSpellBlockModPerLevel
        {
            get
            {
                return _rFlatSpellBlockModPerLevel;
            }
        }

        [DataMember(Name = "rFlatTimeDeadMod")]
        private double _rFlatTimeDeadMod;

        public double FlatTimeDeadMod
        {
            get
            {
                return _rFlatTimeDeadMod;
            }
        }

        [DataMember(Name = "rFlatTimeDeadModPerLevel")]
        private double _rFlatTimeDeadModPerLevel;

        public double FlatTimeDeadModPerLevel
        {
            get
            {
                return _rFlatTimeDeadModPerLevel;
            }
        }

        [DataMember(Name = "rPercentArmorPenetrationMod")]
        private double _rPercentArmorPenetrationMod;

        public double PercentArmorPenetrationMod
        {
            get
            {
                return _rPercentArmorPenetrationMod;
            }
        }

        [DataMember(Name = "rPercentArmorPenetrationModPerLevel")]
        private double _rPercentArmorPenetrationModPerLevel;

        public double PercentArmorPenetrationModPerLevel
        {
            get
            {
                return _rPercentArmorPenetrationModPerLevel;
            }
        }

        [DataMember(Name = "rPercentAttackSpeedModPerLevel")]
        private double _rPercentAttackSpeedModPerLevel;

        public double PercentAttackSpeedModPerLevel
        {
            get
            {
                return _rPercentAttackSpeedModPerLevel;
            }
        }

        [DataMember(Name = "rPercentCooldownMod")]
        private double _rPercentCooldownMod;

        public double PercentCooldownMod
        {
            get
            {
                return _rPercentCooldownMod;
            }
        }

        [DataMember(Name = "rPercentCooldownModPerLevel")]
        private double _rPercentCooldownModPerLevel;

        public double PercentCooldownModPerLevel
        {
            get
            {
                return _rPercentCooldownModPerLevel;
            }
        }

        [DataMember(Name = "rPercentMagicPenetrationMod")]
        private double _rPercentMagicPenetrationMod;

        public double PercentMagicPenetrationMod
        {
            get
            {
                return _rPercentMagicPenetrationMod;
            }
        }

        [DataMember(Name = "rPercentMagicPenetrationModPerLevel")]
        private double _rPercentMagicPenetrationModPerLevel;

        public double PercentMagicPenetrationModPerLevel
        {
            get
            {
                return _rPercentMagicPenetrationModPerLevel;
            }
        }

        [DataMember(Name = "rPercentMovementSpeedModPerLevel")]
        private double _rPercentMovementSpeedModPerLevel;

        public double PercentMovementSpeedModPerLevel
        {
            get
            {
                return _rPercentMovementSpeedModPerLevel;
            }
        }

        [DataMember(Name = "rPercentTimeDeadMod")]
        private double _rPercentTimeDeadMod;

        public double PercentTimeDeadMod
        {
            get
            {
                return _rPercentTimeDeadMod;
            }
        }

        [DataMember(Name = "rPercentTimeDeadModPerLevel")]
        private double _rPercentTimeDeadModPerLevel;

        public double PercentTimeDeadModPerLevel
        {
            get
            {
                return _rPercentTimeDeadModPerLevel;
            }
        }


    }
}
