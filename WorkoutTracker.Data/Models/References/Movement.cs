using System;
using System.Collections.Generic;
using WorkoutTracker.Data.Models.Base;
using WorkoutTracker.Data.Models.Entities;
using WorkoutTracker.Data.Models.Interfaces;

namespace WorkoutTracker.Data.Models
{
    public class Movement : ReferenceData, IDescribable
    {
        public int Repetitions { get; set; }
        public TimeSpan? Duration { get; set; }
        public ICollection<MovementsMuscleGroups> MovementsMuscleGroups { get; set; }
        public string Description { get; set; }
        public MovementPattern Pattern { get; set; }
    }
}