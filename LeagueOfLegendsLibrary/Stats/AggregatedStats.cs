using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LeagueOfLegendsLibrary
{
    [DataContract]
    public class AggregatedStats
    {
        [DataMember(Name = "averageAssists")]
        public int averageAssists;

        [DataMember(Name = "averageChampionsKilled")]
        public int averageChampionsKilled;

        [DataMember(Name = "averageCombatPlayerScore")]
        public int averageCombatPlayerScore;

        [DataMember(Name = "averageNodeCapture")]
        public int averageNodeCapture;

        [DataMember(Name = "averageNodeCaptureAssist")]
        public int averageNodeCaptureAssist;

        [DataMember(Name = "averageNodeNeutralize")]
        public int averageNodeNeutralize;

        [DataMember(Name = "averageNodeNeutralizeAssist")]
        public int averageNodeNeutralizeAssist;

        [DataMember(Name = "averageNumDeaths")]
        public int averageNumDeaths;

        [DataMember(Name = "averageObjectivePlayerScore")]
        public int averageObjectivePlayerScore;

        [DataMember(Name = "averageTeamObjective")]
        public int averageTeamObjective;

        [DataMember(Name = "averageTotalPlayerScore")]
        public int averageTotalPlayerScore;

        [DataMember(Name = "botGamesPlayed")]
        public int botGamesPlayed;

        [DataMember(Name = "killingSpree")]
        public int killingSpree;

        [DataMember(Name = "maxAssists")]
        public int maxAssists;

        [DataMember(Name = "maxChampionsKilled")]
        public int maxChampionsKilled;

        [DataMember(Name = "maxCombatPlayerScore")]
        public int maxCombatPlayerScore;

        [DataMember(Name = "maxLargestCriticalStrike")]
        public int maxLargestCriticalStrike;

        [DataMember(Name = "maxLargestKillingSpree")]
        public int maxLargestKillingSpree;

        [DataMember(Name = "maxNodeCapture")]
        public int maxNodeCapture;

        [DataMember(Name = "maxNodeCaptureAssist")]
        public int maxNodeCaptureAssist;

        [DataMember(Name = "maxNodeNeutralize")]
        public int maxNodeNeutralize;

        [DataMember(Name = "maxNodeNeutralizeAssist")]
        public int maxNodeNeutralizeAssist;

        [DataMember(Name = "maxObjectivePlayerScore")]
        public int maxObjectivePlayerScore;

        [DataMember(Name = "maxTeamObjective")]
        public int maxTeamObjective;

        [DataMember(Name = "maxTimePlayed")]
        public int maxTimePlayed;

        [DataMember(Name = "maxTimeSpentLiving")]
        public int maxTimeSpentLiving;

        [DataMember(Name = "maxTotalPlayerScore")]
        public int maxTotalPlayerScore;

        [DataMember(Name = "mostChampionKillsPerSession")]
        public int mostChampionKillsPerSession;

        [DataMember(Name = "mostSpellsCast")]
        public int mostSpellsCast;

        [DataMember(Name = "normalGamesPlayed")]
        public int normalGamesPlayed;

        [DataMember(Name = "rankedPremadeGamesPlayed")]
        public int rankedPremadeGamesPlayed;

        [DataMember(Name = "rankedSoloGamesPlayed")]
        public int rankedSoloGamesPlayed;

        [DataMember(Name = "totalAssists")]
        public int totalAssists;

        [DataMember(Name = "totalChampionKills")]
        public int totalChampionKills;

        [DataMember(Name = "totalDamageDealt")]
        public int totalDamageDealt;

        [DataMember(Name = "totalDamageTaken")]
        public int totalDamageTaken;

        [DataMember(Name = "totalDoubleKills")]
        public int totalDoubleKills;

        [DataMember(Name = "totalFirstBlood")]
        public int totalFirstBlood;

        [DataMember(Name = "totalGoldEarned")]
        public int totalGoldEarned;

        [DataMember(Name = "totalHeal")]
        public int totalHeal;

        [DataMember(Name = "totalMagicDamageDealt")]
        public int totalMagicDamageDealt;

        [DataMember(Name = "totalMinionKills")]
        public int totalMinionKills;

        [DataMember(Name = "totalNeutralMinionsKilled")]
        public int totalNeutralMinionsKilled;

        [DataMember(Name = "totalNodeCapture")]
        public int totalNodeCapture;

        [DataMember(Name = "totalNodeNeutralize")]
        public int totalNodeNeutralize;

        [DataMember(Name = "totalPentaKills")]
        public int totalPentaKills;

        [DataMember(Name = "totalPhysicalDamageDealt")]
        public int totalPhysicalDamageDealt;

        [DataMember(Name = "totalQuadraKills")]
        public int totalQuadraKills;

        [DataMember(Name = "totalSessionsLost")]
        public int totalSessionsLost;

        [DataMember(Name = "totalSessionsPlayed")]
        public int totalSessionsPlayed;

        [DataMember(Name = "totalSessionsWon")]
        public int totalSessionsWon;

        [DataMember(Name = "totalTripleKills")]
        public int totalTripleKills;

        [DataMember(Name = "totalTurretsKilled")]
        public int totalTurretsKilled;

        [DataMember(Name = "totalUnrealKills")]
        public int totalUnrealKills;
    }
}
