using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WorkoutTracker.Data.Extensions;
using WorkoutTracker.Data.Models.Entities;


namespace WorkoutTracker.Data.Models
{
    public class Context : DbContext
    {
        // public DbSet<Muscle> Muscles { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<MovementsMuscleGroups> MovementsMuscleGroups { get; set; } 
        public DbSet<MovementPattern> MovementPatterns { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<WorkoutType> WorkoutTypes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseNpgsql("Host=localhost;Database=workout_tracker;Username=postgres;Password=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            ConfigureRelationships(modelBuilder);
            SeedData(modelBuilder);
        }

        private void ConfigureRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovementsMuscleGroups>().HasKey(t =>
                new { t.MovementId, t.MusclGroupId }
            );
        }

        private void SeedData(ModelBuilder builder)
        {
            builder.Entity<MovementPattern>().HasData(
                new MovementPattern { Id = 1, Name = "Hinge" },
                new MovementPattern { Id = 2, Name = "Squat" },
                new MovementPattern { Id = 3, Name = "Lunge" },
                new MovementPattern { Id = 4, Name = "Push" },
                new MovementPattern { Id = 5, Name = "Pull" },
                new MovementPattern { Id = 6, Name = "Carry" }
            );

            builder.Entity<Equipment>().HasData(
                new Equipment { Id = 1, Name = "Barbell" },
                new Equipment { Id = 2, Name = "Dumbell" },
                new Equipment { Id = 3, Name = "Jump Rope" },
                new Equipment { Id = 4, Name = "Bench" }
            );

            builder.Entity<WorkoutType>().HasData(
                new WorkoutType { Id = 1, Name = "Full" },
                new WorkoutType { Id = 2, Name = "Strength" },
                new WorkoutType { Id = 3, Name = "Metabolic Conditioning" },
                new WorkoutType { Id = 4, Name = "Active Recovery" }
            );
        }
    }
}