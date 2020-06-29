using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Api.Controllers.Base;
using WorkoutTracker.Data.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class MuscleGroupController : EntityController<MuscleGroup>
    {
        public MuscleGroupController(DbContext context) : base(context)
        {
        }
    }
}