using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WorkoutTracker.Data.Models.Base
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}