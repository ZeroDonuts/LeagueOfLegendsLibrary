using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLibrary.Runes
{
    [DataContract(Name="BasicDataStatsDto")]
    public class BasicDataStats
    {
        [DataMember(Name= "FlatArmorMod")]
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

        [DataMember(Name = "FlatBlockMod")]
        private double _flatBlockMod;

        [DataMember(Name = "FlatCritChanceMod")]
        private double _flatCritChacneMod;

        [DataMember(Name = "FlatCritDamageMod")] 
        private double _flatCritDamageMod;
        
        [DataMember(Name = "FlatEXPBonus")]
        private double _flatEXPBonus;
        
        [DataMember(Name = "FlatEnergyPoolMod")]
        private double _flatEnergyPoolMod;
        
        [DataMember(Name = "FlatEnergyRegenMod")]
        private double _flatEnergyRegenMod;
        
        [DataMember(Name = "FlatHPPoolMod")]
        private double _flatHPPoolMod;
             
        [DataMember(Name = "FlatHPRegenMod")]
        private double _flatHPRegenMod;

        [DataMember(Name = "FlatMPPoolMod")]
        private double _flatMPPoolmod;

        [DataMember(Name = "FlatMPRegenMod")]
        private double _flatMPRegenMod;

        [DataMember(Name = "FlatMagicDamageMod")]
        private double _flatMagicDamageMod;

        [DataMember(Name = "FlatMovementSpeedMod")]
        private double _flatMovementSpeedMod;

        [DataMember(Name = "FlatPhysicalDamageMod")]
        private double _flatPhysicalDamageMod;

        [DataMember(Name = "FlatSpellBlockMod")]
        private double _flatSpellBlockMod;

        [DataMember(Name = "PercentArmorMod")]
        private double _percentArmourMod;

        [DataMember(Name = "PercentAttackSpeedMod")]
        private double _percentAttackSpeedMod;

        [DataMember(Name = "PercentBlockMod")]
        private double _percentBlockMod;

        [DataMember(Name = "PercentCritChanceMod")]
        private double _percentCritChanceMod;

        [DataMember(Name = "PercentCritDamageMod")]
        private double _PercentCritDamageMod;

        [DataMember(Name = "PercentDodgeMod")]
        private double _percentDodgeMod;

        [DataMember(Name = "PercentEXPBonus")]
        private double _percentEXPBonus;

        [DataMember(Name = "PercentHPPoolMod")]
        private double _percentHPPoolMod;

        [DataMember(Name = "PercentHPRegenMod")]
        private double _percentHPRegenMod;

        [DataMember(Name = "PercentLifeStealMod")]
        private double _percentLifeStealMod;

        [DataMember(Name = "PercentMPPoolMod")]
        private double _percentMPPoolMod;

        [DataMember(Name = "PercentMPRegenMod")]
        private double _percentMPRegenMod;
        
        [DataMember(Name = "PercentMagicDamageMod")]
        private double _percentMagicDamageMod;

        [DataMember(Name = "PercentMovementSpeedMod")]
        private double _percentMovementSpeedMod;

        [DataMember(Name = "PercentPhysicalDamageMod")]
        private double _percemtPhysicalDamageMod;

        [DataMember(Name = "PercentSpellBlockMod")]
        private double _percentSpellBlockMod;

        [DataMember(Name = "PercentSpellVampMod")]
        private double _percentSpellVampMod;

        [DataMember(Name = "rFlatArmourModPerLevel")]
        private double _rFlatArmourModperLevel;

        [DataMember(Name = "rFlatArmorPenetrationMod")]
        private double _rFlatArmorPenetrationMod;

        [DataMember(Name = "rFlatArmorPenetrationModPerLevel")]
        private double _rFlatArmorPenetrationModPerLevel;

        [DataMember(Name = "rFlatCritChanceModPerLevel")]
        private double _rFlatCritChanceModPerLevel;

        [DataMember(Name = "rFlatCritDamageModPerLevel")]
        private double _rFlatCritDamageModPerLevel;

        [DataMember(Name = "rFlatDodgeMod")]
        private double _rFlatDodgeMod;

        [DataMember(Name = "rFlatDodgeModPerLevel")]
        private double _rFlatDodgeModPerLevel;

        [DataMember(Name = "rFlatEnergyModPerLevel")]
        private double _rFlatEnergyModPerLevel;

        [DataMember(Name = "rFlatEnergyRegenModPerLevel")]
        private double _rFlatEnergyRegenModPerLevel;

        [DataMember(Name = "rFlatGoldPer10Mod")]
        private double _rFlatGoldPer10Mod;

        [DataMember(Name = "rFlatHPModPerLevel")]
        private double _rFlatHPModPerLevel;

        [DataMember(Name = "rFlatHPRegenModPerLevel")]
        private double _rFlatHPRegenModPerLevel;

        [DataMember(Name = "rFlatMPModPerLevel")]
        private double _rFlatMPModPerLevel;

        [DataMember(Name = "rFlatMPRegenModPerLevel")]
        private double _rFlatMPRegenModPerLevel;

        [DataMember(Name = "rFlatMagicDamageModPerLevel")]
        private double _rFlatMagicDamageModPerLevel;

        [DataMember(Name = "rFlatMagicPenetrationMod")]
        private double _rFlatMagicPenetrationMod;

        [DataMember(Name = "rFlatMagicPenetrationModPerLevel")]
        private double _rFlatMagicPenetrationModPerLevel;

        [DataMember(Name = "rFlatMovementSpeedModPerLevel")]
        private double _rFlatMovementSpeedModPerLevel;

        [DataMember(Name = "rFlatPhysicalDamageModPerLevel")]
        private double _rFlatPhysicalDamageModPerLevel;

        [DataMember(Name = "rFlatSpellBlockModPerLevel")]
        private double _rFlatSpellBlockModPerLevel;

        [DataMember(Name = "rFlatTimeDeadMod")]
        private double _rFlatTimeDeadMod;

        [DataMember(Name = "rFlatTimeDeadModPerLevel")]
        private double _rFlatTimeDeadModPerLevel;

        [DataMember(Name = "rPercentArmorPenetrationMod")]
        private double _rPercentArmorPenetrationMod;

        [DataMember(Name = "rPercentArmorPenetrationModPerLevel")]
        private double _rPercentArmorPenetrationModPerLevel;

        [DataMember(Name = "rPercentAttackSpeedModPerLevel")]
        private double _rPercentAttackSpeedModPerLevel;

        [DataMember(Name = "rPercentCooldownMod")]
        private double _rPercentCooldownMod;

        [DataMember(Name = "rPercentCooldownModPerLevel")]
        private double _rPercentCooldownModPerLevel;

        [DataMember(Name = "rPercentMagicPenetrationMod")]
        private double _rPercentMagicPenetrationMod;

        [DataMember(Name = "rPercentMagicPenetrationModPerLevel")]
        private double _rPercentMagicPenetrationModPerLevel;

        [DataMember(Name = "rPercentMovementSpeedModPerLevel")]
        private double _rPercentMovementSpeedModPerLevel;

        [DataMember(Name = "rPercentTimeDeadMod")]
        private double _rPercentTimeDeadMod;

        [DataMember(Name = "rPercentTimeDeadModPerLevel")]
        private double _rPercentTimeDeadModPerLevel;











    }
}
