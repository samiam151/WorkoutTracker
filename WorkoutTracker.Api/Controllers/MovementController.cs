using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Api.Controllers.Base;
using WorkoutTracker.Data.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class MovementController : EntityController<Movement>
    {
        public MovementController(DbContext context) : base(context)
        {
        }
    }
}