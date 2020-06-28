using WorkoutTracker.Data.Models.Base;
using WorkoutTracker.Data.Models.Interfaces;

namespace WorkoutTracker.Data.Models
{
    public class MovementPattern : ReferenceData, IDescribable
    {
        public string Description { get; set; }
    }
}