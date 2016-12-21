using ProgressTracker.Db;
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
        public DbSet<TaskModel> Tasks { get; set; }

        public ProjectDbContext() : base ("ProjectDbContext")
        {
            // This will need to be removed of actual production
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ProjectDbContext>(null);
        }
    }
}