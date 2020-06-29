using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Api.Controllers.Base;
using WorkoutTracker.Data.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class MuscleController : EntityController<Muscle>
    {
        public MuscleController(DbContext context) : base(context)
        {
        }
    }
}