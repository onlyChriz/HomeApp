using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeApp.API.Models;

namespace HomeApp.API.Data
{
    public class HomeAppContext : DbContext
    {
        public HomeAppContext(DbContextOptions<HomeAppContext> options)
            : base(options)
        { }

        public DbSet<ToDoTask> ToDoTask { get; set; }

    }
}
