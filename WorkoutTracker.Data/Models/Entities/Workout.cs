using System.Collections.Generic;
using WorkoutTracker.Data.Models.Base;

namespace WorkoutTracker.Data.Models
{
    public class Workout : Entity
    {
        public string Name { get; set; }
        public ICollection<Section> Sections { get; set; }
    }
}