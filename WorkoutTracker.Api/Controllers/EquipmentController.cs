using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkoutTracker.Api.Controllers.Base;
using WorkoutTracker.Data.Models;

namespace WorkoutTracker.Api.Controllers
{
    public class EquipmentController : EntityController<Equipment>
    {
        public EquipmentController(DbContext context) : base(context)
        {
        }
    }
}
