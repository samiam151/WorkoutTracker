using WorkoutTracker.Data.Models.Base;

namespace WorkoutTracker.Data.Models
{
    public class MovementsMuscleGroups : Entity
    {
        public int MovementId { get; set; }
        public Movement Movement { get; set; }
        
        public int MusclGroupId { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}