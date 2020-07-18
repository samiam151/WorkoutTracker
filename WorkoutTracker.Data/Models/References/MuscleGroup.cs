using System.Collections;
using System.Collections.Generic;
using WorkoutTracker.Data.Models.Base;
using WorkoutTracker.Data.Models.Interfaces;

namespace WorkoutTracker.Data.Models
{
    public class MuscleGroup: ReferenceData, IDescribable
    {
        public string Description { get; set; }
        public ICollection<MovementsMuscleGroups> MovementsMuscleGroups { get; set; }
    }
}