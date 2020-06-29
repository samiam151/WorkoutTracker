using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Api.Controllers.Base;
using WorkoutTracker.Data.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class MovementSetController : EntityController<MovementSet>
    {
        public MovementSetController(DbContext context) : base(context)
        {
        }
    }
}