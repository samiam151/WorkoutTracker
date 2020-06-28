using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Data.Extensions;
using WorkoutTracker.Data.Models.Entities;

// using WorkoutTracker.Data.Models.Entities;

namespace WorkoutTracker.Data.Models
{
    public class Context : DbContext
    {
        public DbSet<Muscle> Muscles { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<MovementsMuscleGroups> MovementsMuscleGroups { get; set; } 
        public DbSet<MovementPattern> MovementPatterns { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseNpgsql("Host=localhost;Database=workout_tracker;Username=postgres;Password=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.ConfigureRelationships();
            modelBuilder.SeedData();
        }
    }
}