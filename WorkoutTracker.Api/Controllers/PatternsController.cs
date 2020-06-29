﻿using System;
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
    [Route("api/[controller]")]
    public class PatternsController : EntityController<MovementPattern>
    {
        public PatternsController(DbContext context) : base(context)
        {
        }
    }
}
