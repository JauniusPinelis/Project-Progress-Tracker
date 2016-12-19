using ProgressTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProgressTracker.Context
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<ProjectModel> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ProjectDbContext>(null);
        }
    }
}