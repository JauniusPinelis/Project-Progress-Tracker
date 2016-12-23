using ProgressTracker.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProgressTracker.Context
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<ProjectDbContext>
    {
        protected override void Seed(ProjectDbContext context)
        {
            InitializeDatabase(context);
        }
    }
}