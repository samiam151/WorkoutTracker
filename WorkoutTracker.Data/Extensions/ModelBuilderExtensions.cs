using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WorkoutTracker.Data.Models;
using WorkoutTracker.Data.Models.Entities;

namespace WorkoutTracker.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigureRelationships(this ModelBuilder modelBuilder)
        {        
            modelBuilder.Entity<MovementsMuscleGroups>().HasKey(t => 
                new { t.MovementId, t.MusclGroupId} 
            );
        }
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovementPattern>().HasData(
                new MovementPattern { Id = 1, Name = "Hinge"},
                new MovementPattern { Id = 2, Name = "Squat"},
                new MovementPattern { Id = 3, Name = "Lunge"},
                new MovementPattern { Id = 4, Name = "Push"},
                new MovementPattern { Id = 5, Name = "Pull"},
                new MovementPattern { Id = 6, Name = "Carry"}
            );

            modelBuilder.Entity<Equipment>().HasData(
                new Equipment { Id = 1, Name = "Barbell" },
                new Equipment { Id = 2, Name = "Dumbell" },
                new Equipment { Id = 3, Name = "Jump Rope" },
                new Equipment { Id = 4, Name = "Bench" }
            );

            modelBuilder.Entity<WorkoutType>().HasData(
                new WorkoutType { Id = 1, Name = "Full" },
                new WorkoutType { Id = 2, Name = "Strength" },
                new WorkoutType { Id = 3, Name = "Metabolic Conditioning" },
                new WorkoutType { Id = 4, Name = "Active Recovery" }
            );
        }
    }
}