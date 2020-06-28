namespace WorkoutTracker.Data.Models.Base
{
    public class ReferenceData: Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}