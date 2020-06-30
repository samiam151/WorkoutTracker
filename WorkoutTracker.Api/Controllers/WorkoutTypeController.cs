using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Api.Controllers.Base;
using WorkoutTracker.Data.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class WorkoutTypeController : EntityController<WorkoutType>
    {
        public WorkoutTypeController(DbContext context) : base(context)
        {
        }
    }
}
