using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using WorkoutTracker.Data.Models.Base;

namespace WorkoutTracker.Data.Models
{
    public class Section : Entity
    {
        public WorkoutType Type { get; set; }
        public ICollection<MovementSet> Movements { get; set; }
    }
}