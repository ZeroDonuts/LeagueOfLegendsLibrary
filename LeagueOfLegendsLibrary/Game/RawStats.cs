using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary.GameInfo
{
    [DataContract(Name = "RawStatsDto")]
    public class RawStats
    {
        [DataMember(Name = "assists")]
        private int _assists;

        
        public int Assists
        {
            get { return _assists; }
        }

        [DataMember(Name = "barracksKilled")]
        private int _barracksKilled;


        public int BarracksKilled
        {
            get { return _barracksKilled; }
        }

        [DataMember(Name = "championsKilled")]
        private int _championsKilled;


        public int ChampionsKilled
        {
            get { return _championsKilled; }
        }

        [DataMember(Name = "combatPlayerScore")]
        private int _combatPlayerScore;


        public int CombatPlayerScore
        {
            get { return _combatPlayerScore; }
        }

        [DataMember(Name = "consumablesPurchased")]
        private int _consumablesPurchased;


        public int ConsumablesPurchased
        {
            get { return _consumablesPurchased; }
        }

        [DataMember(Name = "damageDealtPlayer")]
        private int _damageDealtPlayer;


        public int DamageDealtPlayer
        {
            get { return _damageDealtPlayer; }
        }

        [DataMember(Name = "doubleKills")]
        private int _doubleKills;


        public int DoubleKills
        {
            get { return _doubleKills; }
        }

        [DataMember(Name = "firstBlood")]
        private int _firstBlood;


        public int FirstBlood
        {
            get { return _firstBlood; }
        }

        [DataMember(Name = "gold")]
        private int _gold;


        public int Gold
        {
            get { return _gold; }
        }

        [DataMember(Name = "goldEarned")]
        private int _goldEarned;


        public int GoldEarned
        {
            get { return _goldEarned; }
        }

        [DataMember(Name = "goldSpent")]
        private int _goldSpent;


        public int GoldSpent
        {
            get { return _goldSpent; }
        }

        [DataMember(Name = "item0")]
        private int _item0;


        public int Item0
        {
            get { return _item0; }
        }

        [DataMember(Name = "item1")]
        private int _item1;


        public int Item1
        {
            get { return _item1; }
        }

        [DataMember(Name = "item2")]
        private int _item2;


        public int Item2
        {
            get { return _item2; }
        }

        [DataMember(Name = "item3")]
        private int _item3;


        public int Item3
        {
            get { return _item3; }
        }

        [DataMember(Name = "item4")]
        private int _item4;


        public int Item4
        {
            get { return _item4; }
        }

        [DataMember(Name = "item5")]
        private int _item5;


        public int Item5
        {
            get { return _item5; }
        }

        [DataMember(Name = "item6")]
        private int _item6;


        public int Item6
        {
            get { return _item6; }
        }

        [DataMember(Name = "itemsPurchased")]
        private int _itemsPurchased;


        public int ItemsPurchased
        {
            get { return _itemsPurchased; }
        }

        [DataMember(Name = "killingSprees")]
        private int _killingSprees;


        public int KillingSprees
        {
            get { return _killingSprees; }
        }

        [DataMember(Name = "largestCriticalStrike")]
        private int _largestCriticalStrike;


        public int LargestCriticalStrike
        {
            get { return _largestCriticalStrike; }
        }

        [DataMember(Name = "largestKillingSpree")]
        private int _largestKillingSpree;


        public int LargestKillingSpree
        {
            get { return _largestKillingSpree; }
        }

        [DataMember(Name = "largestMultiKill")]
        private int _largestMultiKill;


        public int LargestMultiKill
        {
            get { return _largestMultiKill; }
        }
        /// <summary>
        /// Number of tier 3 items built.
        /// </summary>
        [DataMember(Name = "legendaryItemsCreated")]
        private int _legendaryItemsCreated;


        public int LegendaryItemsCreated
        {
            get { return _legendaryItemsCreated; }
        }

        [DataMember(Name = "level")]
        private int _level;


        public int Level
        {
            get { return _level; }
        }

        [DataMember(Name = "magicDamageDealtPlayer")]
        private int _magicDamageDealtPlayer;


        public int MagicDamageDealtPlayer
        {
            get { return _magicDamageDealtPlayer; }
        }

        [DataMember(Name = "magicDamageDealtToChampions")]
        private int _magicDamageDealtToChampions;


        public int MagicDamageDealtToChampions
        {
            get { return _magicDamageDealtToChampions; }
        }

        [DataMember(Name = "magicDamageTaken")]
        private int _magicDamageTaken;

        public int MagicDamageTaken
        {
            get { return _magicDamageTaken; }
        }

        [DataMember(Name = "minionsDenied")]
        private int _minionsDenied;


        public int MinionsDenied
        {
            get { return _minionsDenied; }
        }

        [DataMember(Name = "minionsKilled")]
        private int _minionsKilled;


        public int MinionsKilled
        {
            get { return _minionsKilled; }
        }

        [DataMember(Name = "neutralMinionsKilled")]
        private int _neutralMinionsKilled;


        public int NeutralMinionsKilled
        {
            get { return _neutralMinionsKilled; }
        }

        [DataMember(Name = "neutralMinionsKilledEnemyJungle")]
        private int _neutralMinionsKilledEnemyJungle;


        public int NeutralMinionsKilledEnemyJungle
        {
            get { return _neutralMinionsKilledEnemyJungle; }
        }

        [DataMember(Name = "neutralMinionsKilledYourJungle")]
        private int _neutralMinionsKilledYourJungle;


        public int NeutralMinionsKilledYourJungle
        {
            get { return _neutralMinionsKilledYourJungle; }
        }
        /// <summary>
        /// Flag specifying if the summoner got the killing blow on the nexus.
        /// </summary>
        [DataMember(Name = "nexusKilled")]
        private bool _nexusKilled;


        public bool NexusKilled
        {
            get { return _nexusKilled; }
        }

        [DataMember(Name = "nodeCapture")]
        private int _nodeCapture;


        public int NodeCapture
        {
            get { return _nodeCapture; }
        }

        [DataMember(Name = "nodeCaptureAssist")]
        private int _nodeCaptureAssist;


        public int NodeCaptureAssist
        {
            get { return _nodeCaptureAssist; }
        }

        [DataMember(Name = "nodeNeutralize")]
        private int _nodeNeutralize;


        public int NodeNeutralize
        {
            get { return _nodeNeutralize; }
        }

        [DataMember(Name = "nodeNeutralizeAssist")]
        private int _nodeNeutralizeAssist;


        public int NodeNeutralizeAssist
        {
            get { return _nodeNeutralizeAssist; }
        }

        [DataMember(Name = "numDeaths")]
        private int _deaths;


        public int Deaths
        {
            get { return _deaths; }
        }

        [DataMember(Name = "numItemsBought")]
        private int _numItemsBought;


        public int NumItemsBought
        {
            get { return _numItemsBought; }
        }

        [DataMember(Name = "objectivePlayerScore")]
        private int _objectivePlayerScore;


        public int ObjectivePlayerScore
        {
            get { return _objectivePlayerScore; }
        }

        [DataMember(Name = "pentaKills")]
        private int _pentaKills;


        public int PentaKills
        {
            get { return _pentaKills; }
        }

        [DataMember(Name = "physicalDamageDealtPlayer")]
        private int _physicalDamageDealtPlayer;


        public int PhysicalDamageDealtPlayer
        {
            get { return _physicalDamageDealtPlayer; }
        }

        [DataMember(Name = "physicalDamageDealtToChampions")]
        private int _physicalDamageDealtToChampions;


        public int PhysicalDamageDealtToChampions
        {
            get { return _physicalDamageDealtToChampions; }
        }

        [DataMember(Name = "physicalDamageTaken")]
        private int _physicalDamageTaken;


        public int PhysicalDamageTaken
        {
            get { return _physicalDamageTaken; }
        }

        [DataMember(Name = "quadraKills")]
        private int _quadraKills;


        public int QuadraKills
        {
            get { return _quadraKills; }
        }

        [DataMember(Name = "sightWardsBought")]
        private int _sightWardsBought;


        public int SightWardsBought
        {
            get { return _sightWardsBought; }
        }
        /// <summary>
        /// Number of times first champion spell was cast.
        /// </summary>
        [DataMember(Name = "spell1Cast")]
        private int _spell1Cast;


        public int Spell1Cast
        {
            get { return _spell1Cast; }
        }
        /// <summary>
        /// Number of times second champion spell was cast.
        /// </summary>
        [DataMember(Name = "spell2Cast")]
        private int _spell2Cast;


        public int Spell2Cast
        {
            get { return _spell2Cast; }
        }
        /// <summary>
        /// Number of times third champion spell was cast.
        /// </summary>
        [DataMember(Name = "spell3Cast")]
        private int _spell3Cast;


        public int Spell3Cast
        {
            get { return _spell3Cast; }
        }
        /// <summary>
        /// Number of times fourth champion spell was cast.
        /// </summary>
        [DataMember(Name = "spell4Cast")]
        private int _spell4Cast;


        public int Spell4Cast
        {
            get { return _spell4Cast; }
        }

        [DataMember(Name = "summonSpell1Cast")]
        private int _summonSpell1Cast;


        public int SummonSpell1Cast
        {
            get { return _summonSpell1Cast; }
        }

        [DataMember(Name = "summonSpell2Cast")]
        private int _summonSpell2Cast;


        public int SummonSpell2Cast
        {
            get { return _summonSpell2Cast; }
        }

        [DataMember(Name = "superMonsterKilled")]
        private int _superMonsterKilled;


        public int SuperMonsterKilled
        {
            get { return _superMonsterKilled; }
        }

        [DataMember(Name = "team")]
        private int _team;


        public int Team
        {
            get { return _team; }
        }

        [DataMember(Name = "teamObjective")]
        private int _teamObjective;


        public int TeamObjective
        {
            get { return _teamObjective; }
        }

        [DataMember(Name = "timePlayed")]
        private int _timePlayed;


        public int TimePlayed
        {
            get { return _timePlayed; }
        }

        [DataMember(Name = "totalDamageDealt")]
        private int _totalDamageDealt;


        public int TotalDamageDealt
        {
            get { return _totalDamageDealt; }
        }

        [DataMember(Name = "totalDamageDealtToChampions")]
        private int _totalDamageDealtToChampions;


        public int TotalDamageDealtToChampions
        {
            get { return _totalDamageDealtToChampions; }
        }

        [DataMember(Name = "totalDamageTaken")]
        private int _totalDamageTaken;


        public int TotalDamageTaken
        {
            get { return _totalDamageTaken; }
        }

        [DataMember(Name = "totalHeal")]
        private int _totalHeal;


        public int TotalHeal
        {
            get { return _totalHeal; }
        }

        [DataMember(Name = "totalPlayerScore")]
        private int _totalPlayerScore;


        public int TotalPlayerScore
        {
            get { return _totalPlayerScore; }
        }

        [DataMember(Name = "totalScoreRank")]
        private int _totalScoreRank;


        public int TotalScoreRank
        {
            get { return _totalScoreRank; }
        }

        [DataMember(Name = "totalTimeCrowdControlDealt")]
        private int _totalTimeCrowdControlDealt;


        public int TotalTimeCrowdControlDealt
        {
            get { return _totalTimeCrowdControlDealt; }
        }

        [DataMember(Name = "totalUnitsHealed")]
        private int _totalUnitsHealed;


        public int TotalUnitsHealed
        {
            get { return _totalUnitsHealed; }
        }

        [DataMember(Name = "tripleKills")]
        private int _tripleKills;


        public int TripleKills
        {
            get { return _tripleKills; }
        }

        [DataMember(Name = "trueDamageDealtPlayer")]
        private int _trueDamageDealtPlayer;


        public int TrueDamageDealtPlayer
        {
            get { return _trueDamageDealtPlayer; }
        }

        [DataMember(Name = "trueDamageDealtToChampions")]
        private int _trueDamageDealtToChampions;


        public int TrueDamageDealtToChampions
        {
            get { return _trueDamageDealtToChampions; }
        }

        [DataMember(Name = "trueDamageTaken")]
        private int _trueDamageTaken;


        public int TrueDamageTaken
        {
            get { return _trueDamageTaken; }
        }

        [DataMember(Name = "turretsKilled")]
        private int _turretsKilled;


        public int TurretsKilled
        {
            get { return _turretsKilled; }
        }

        [DataMember(Name = "unrealKills")]
        private int _unrealKills;


        public int UnrealKills
        {
            get { return _unrealKills; }
        }

        [DataMember(Name = "victoryPointTotal")]
        private int _victoryPointTotal;


        public int VictoryPointTotal
        {
            get { return _victoryPointTotal; }
        }

        [DataMember(Name = "visionWardsbought")]
        private int _visionWardsBought;


        public int VisionWardsBought
        {
            get { return _visionWardsBought; }
        }

        [DataMember(Name = "wardKilled")]
        private int _wardsKilled;


        public int WardsKilled
        {
            get { return _wardsKilled; }
        }

        [DataMember(Name = "wardPlaced")]
        private int _wardsPlaced;


        public int WardsPlaced
        {
            get { return _wardsPlaced; }
        }

        [DataMember(Name = "win")]
        private bool _win;


        public bool Win
        {
            get { return _win; }
        }
    }
}
