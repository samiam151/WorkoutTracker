using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace WorkoutTracker.Data.Extensions
{
    public static class DbContextExtensions
    {
        public static DbSet<T> ResolveDbSet<T>(this DbContext context) where T: class
        {
            throw new NotImplementedException();
        }
    }
}