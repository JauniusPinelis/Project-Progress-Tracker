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
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "ALTER DATABASE [" + context.Database.Connection.Database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
            InitializeDatabase(context);
        }
    }
}