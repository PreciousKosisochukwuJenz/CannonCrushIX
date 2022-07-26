using Assets.Scripts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Models
{
    public class Map
    {
        public List<Stage> Stages { get; set; } = new List<Stage>();
        public int CurrentStageId { get; set; } = 1;
        public int TotalStages { get; set; }
    }

    public class Stage
    {
        public int StageId { get; set; }
        public string StageName { get; set; } = String.Empty;
        public ProgresStatus ProgressStatus = ProgresStatus.IDLE;
        public int TotalLevels { get; set;}
        public List<Level> Levels { get; set; } = new List<Level>();

    }

    public class Level
    {
        public int LevelId { get; set; }
        public string LevelName { get; set; } = String.Empty;
        public int MinimumRating { get; set; }
        public int ProgressReward { get; set; }
    }
    class LevelRequirementModel
    {
        public int TargetPairsForBoxTypeA;
        public int TargetPairsForBoxTypeB;
        public int TargetPairsForBoxTypeC;
        public int TargetPairsForBoxTypeD;
        public int TargetScore;
    }
}
