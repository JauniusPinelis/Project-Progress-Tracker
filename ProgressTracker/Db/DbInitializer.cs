using ProgressTracker.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProgressTracker.Db
{
    public class DbInitializer : IDatabaseInitializer<ProjectDbContext>
    {
        public void InitializeDatabase(ProjectDbContext context)
        {
            if (!context.Database.Exists() || !context.Database.CompatibleWithModel(true))
            {
                // This probs needs to be changed on production
                context.Database.Delete();
                context.Database.Create();
            }
        }
    }
}