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
        public int AverageAssists
        {
            get
            {
                if (_totalSessionsPlayed > 0)
                {
                    return _totalAssists / __totalSessionsPlayed;
                }
                return 0;
            }
        }

        public int AverageChampionsKilled
        {
            get
            {
                if (_totalSessionsPlayed > 0)
                {
                    return _totalChampionKills / _totalSessionsPlayed;
                }
                return 0;
            }
        }

        [DataMember(Name = "averageCombatPlayerScore")]
        private int _averageCombatPlayerScore;
        //fix this
        public int AverageCombatPlayerScore
        {
            get
            {
                return _averageCombatPlayerScore;
            }
        }

        [DataMember(Name = "averageNodeCapture")]
        private int _averageNodeCapture;

        public int AverageNodeCapture
        {
            get
            {
                if (_totalSessionsPlayed > 0)
                {
                    return _totalNodeCapture / _totalSessionsPlayed;
                }
                return 0;
            }
        }

        [DataMember(Name = "averageNodeCaptureAssist")]
        private int _averageNodeCaptureAssist;
        //fix this
        public int AverageNodeCaptureAssist
        {
            get
            {
                return _averageNodeCaptureAssist;
            }
        }

        [DataMember(Name = "averageNodeNeutralize")]
        private int averageNodeNeutralize;

        public int AverageNodeNeutralize
        {
            get
            {
                if (_totalSessionsPlayed > 0)
                {
                    return _totalNodeNeutralize / _totalSessionsPlayed;
                }
                return 0;
            }
        }

        [DataMember(Name = "averageNodeNeutralizeAssist")]
        private int _averageNodeNeutralizeAssist;
        //fix this
        public int AverageNodeNeutralizeAssist
        {
            get
            {
                return _averageNodeNeutralizeAssist;
            }
        }

        [DataMember(Name = "averageNumDeaths")]
        private int _averageNumDeaths;
        //fix this
        public int AverageNumberOfDeaths
        {
            get
            {
                return _averageNumDeaths;
            }
        }

        [DataMember(Name = "averageObjectivePlayerScore")]
        private int _averageObjectivePlayerScore;
        //fix this
        public int AverageObjectivePlayerScore
        {
            get
            {
                return _averageObjectivePlayerScore;
            }
        }

        [DataMember(Name = "averageTeamObjective")]
        private int _averageTeamObjective;
        //fix this
        public int AverageTeamObjective
        {
            get
            {
                return _averageTeamObjective;
            }
        }

        [DataMember(Name = "averageTotalPlayerScore")]
        private int _averageTotalPlayerScore;

        public int AverageTotalPlayerScore
        {
            get
            {
                return _averageTotalPlayerScore;
            }
        }

        [DataMember(Name = "botGamesPlayed")]
        private int botGamesPlayed;

        public int BotGamesPlayed
        {
            get
            {
                return _totalSessionsPlayed;
            }
        }

        [DataMember(Name = "killingSpree")]
        private int _killingSpree;

        public int KillingSpree
        {
            get
            {
                return _killingSpree;
            }
        }

        [DataMember(Name = "maxAssists")]
        private int _maxAssists;

        public int MaxAssists
        {
            get
            {
                return _maxAssists;
            }
        }

        [DataMember(Name = "maxChampionsKilled")]
        private int _maxChampionsKilled;

        public int MaxChampionsKilled
        {
            get
            {
                return _maxChampionsKilled;
            }
        }

        [DataMember(Name = "maxCombatPlayerScore")]
        private int _maxCombatPlayerScore;

        public int MaxCombatPlayerScore
        {
            get
            {
                return _maxCombatPlayerScore;
            }
        }

        [DataMember(Name = "maxLargestCriticalStrike")]
        private int _maxLargestCriticalStrike;

        public int MaxLargestCriticalStrike
        {
            get
            {
                return _maxLargestCriticalStrike;
            }
        }

        [DataMember(Name = "maxLargestKillingSpree")]
        private int _maxLargestKillingSpree;

        public int MaxLargestKillingSpree
        {
            get
            {
                return _maxLargestKillingSpree;
            }
        }

        [DataMember(Name = "maxNodeCapture")]
        private int _maxNodeCapture;

        public int MaxNodeCapture
        {
            get
            {
                return _maxNodeCapture;
            }
        }

        [DataMember(Name = "maxNodeCaptureAssist")]
        private int _maxNodeCaptureAssist;

        public int MaxNodeCaptureAssist
        {
            get
            {
                return _maxNodeCaptureAssist;
            }
        }

        [DataMember(Name = "maxNodeNeutralize")]
        private int _maxNodeNeutralize;

        public int MaxNodeNeutralize
        {
            get
            {
                return _maxNodeNeutralize;
                
            }
        }

        [DataMember(Name = "maxNodeNeutralizeAssist")]
        private int _maxNodeNeutralizeAssist;

        public int MaxNodeNeutralizeAssist
        {
            get
            {
                return _maxNodeNeutralizeAssist;
            }
        }

        [DataMember(Name = "maxObjectivePlayerScore")]
        private int _maxObjectivePlayerScore;

        public int MaxObjectivePlayerScore
        {
            get
            {
                return _maxObjectivePlayerScore;
            }
        }

        [DataMember(Name = "maxTeamObjective")]
        private int _maxTeamObjective;

        public int MaxTeamObjective
        {
            get
            {
                return _maxTeamObjective;
            }
        }

        [DataMember(Name = "maxTimePlayed")]
        private int _maxTimePlayed;

        public int MaxTimePlayed
        {
            get
            {
                return _maxTimePlayed;
            }
        }

        [DataMember(Name = "maxTimeSpentLiving")]
        private int _maxTimeSpentLiving;

        public int MaxTimeSpentLiving
        {
            get
            {
                return _maxTimeSpentLiving;
            }
        }

        [DataMember(Name = "maxTotalPlayerScore")]
        private int _maxTotalPlayerScore;

        public int MaxTotalPlayerScore
        {
            get
            {
                return _maxTotalPlayerScore;
            }
        }

        [DataMember(Name = "mostChampionKillsPerSession")]
        private int _mostChampionKillsPerSession;

        public int MostChampionKillsPerSession
        {
            get
            {
                return _mostChampionKillsPerSession;
            }
        }

        [DataMember(Name = "mostSpellsCast")]
        private int _mostSpellsCast;

        public int MostSpellsCast
        {
            get
            {
                return _mostSpellsCast;
            }
        }

        [DataMember(Name = "normalGamesPlayed")]
        private int _normalGamesPlayed;

        public int NormalGamesPlayed
        {
            get
            {
                return _normalGamesPlayed;
            }
        }

        [DataMember(Name = "rankedPremadeGamesPlayed")]
        private int _rankedPremadeGamesPlayed;

        public int RankedPremadeGamesPlayed
        {
            get
            {
                return _rankedPremadeGamesPlayed;
            }
        }

        [DataMember(Name = "rankedSoloGamesPlayed")]
        private int _rankedSoloGamesPlayed;

        public int RankedSoloGamesPlayed
        {
            get
            {
                return _rankedSoloGamesPlayed;
            }
        }

        [DataMember(Name = "totalAssists")]
        private int _totalAssists;

        public int TotalAssists
        {
            get
            {
                return _totalAssists;
                
            }
        }

        [DataMember(Name = "totalChampionKills")]
        private int _totalChampionKills;

        public int TotalChampionKills
        {
            get
            {
                
                return _totalChampionKills;
            }
        }

        [DataMember(Name = "totalDamageDealt")]
        private int _totalDamageDealt;

        public int TotalDamageDealt
        {
            get
            {
                return _totalDamageDealt;
                
            }
        }

        [DataMember(Name = "totalDamageTaken")]
        private int _totalDamageTaken;

        public int TotalDamageTaken
        {
            get
            {
                return _totalDamageTaken;
            }
        }

        [DataMember(Name = "totalDoubleKills")]
        private int _totalDoubleKills;

        public int TotalDoubleKills
        {
            get
            {
                return _totalDoubleKills;
            }
        }

        [DataMember(Name = "totalFirstBlood")]
        private int _totalFirstBlood;

        public int TotalFirstBlood
        {
            get
            {
                return _totalFirstBlood;
            }
        }

        [DataMember(Name = "totalGoldEarned")]
        private int _totalGoldEarned;

        public int TotalGoldEarned
        {
            get
            {
                return _totalGoldEarned;
            }
        }

        [DataMember(Name = "totalHeal")]
        private int _totalHeal;

        public int TotalHeal
        {
            get
            {
                return _totalHeal;
            }
        }

        [DataMember(Name = "totalMagicDamageDealt")]
        private int _totalMagicDamageDealt;

        public int TotalMagicDamageDealt
        {
            get
            {
                return _totalMagicDamageDealt;
            }
        }

        [DataMember(Name = "totalMinionKills")]
        private int _totalMinionKills;

        public int TotalMinionKills
        {
            get
            {
                return _totalMinionKills;
            }
        }

        [DataMember(Name = "totalNeutralMinionsKilled")]
        private int _totalNeutralMinionsKilled;

        public int TotalNeutralMinionsKilled
        {
            get
            {
                return _totalNeutralMinionsKilled;
            }
        }

        [DataMember(Name = "totalNodeCapture")]
        private int _totalNodeCapture;

        public int TotalNodeCapture
        {
            get
            {
                return _totalNodeCapture;
            }
        }

        [DataMember(Name = "totalNodeNeutralize")]
        private int _totalNodeNeutralize;

        public int TotalNodeNeutralize
        {
            get
            {
                return _totalNodeNeutralize;
            }
        }

        [DataMember(Name = "totalPentaKills")]
        private int _totalPentaKills;

        public int TotalPentaKills
        {
            get
            {
                return _totalPentaKills;
            }
        }

        [DataMember(Name = "totalPhysicalDamageDealt")]
        private int _totalPhysicalDamageDealt;

        public int TotalPhysicalDamageDealt
        {
            get
            {
                return _totalPhysicalDamageDealt;
            }
        }

        [DataMember(Name = "totalQuadraKills")]
        private int _totalQuadraKills;

        public int TotalQuadraKills
        {
            get
            {
                return _totalQuadraKills;
            }
        }

        [DataMember(Name = "totalSessionsLost")]
        private int _totalSessionsLost;

        public int TotalSessionsLost
        {
            get
            {
                return _totalSessionsLost;
            }
        }

        [DataMember(Name = "_totalSessionsPlayed")]
        private int __totalSessionsPlayed;

        public int _totalSessionsPlayed
        {
            get
            {
                return __totalSessionsPlayed;
            }
        }

        [DataMember(Name = "totalSessionsWon")]
        private int _totalSessionsWon;

        public int TotalSessionsWon
        {
            get
            {
                return _totalSessionsWon;
            }
        }

        [DataMember(Name = "totalTripleKills")]
        private int _totalTripleKills;

        public int TotalTripleKills
        {
            get
            {
                return _totalTripleKills;
            }
        }

        [DataMember(Name = "totalTurretsKilled")]
        private int _totalTurretsKilled;

        public int TotalTurretsKilled
        {
            get
            {
                return _totalTurretsKilled;
            }
        }

        [DataMember(Name = "totalUnrealKills")]
        private int _totalUnrealKills;

        public int TotalUnrealKills
        {
            get
            {
                return _totalUnrealKills;
            }
        }
    }
}
