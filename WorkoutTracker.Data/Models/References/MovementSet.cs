using System;
using System.Collections.Generic;
using WorkoutTracker.Data.Models.Base;
using WorkoutTracker.Data.Models.Interfaces;

namespace WorkoutTracker.Data.Models
{
    public class MovementSet : ReferenceData, IDescribable
    {
        public Movement Movement { get; set; }
        public TimeSpan? Duration { get; set; }
        public int Repetitions { get; set; }
        public string Description { get; set; }
    }
}