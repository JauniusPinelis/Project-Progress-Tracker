using ProgressTracker.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProgressTracker.Models
{
    [Table("task")]
    public class TaskModel : BaseModel
    {
        [DisplayName("Is completed")]
        public bool IsCompleted { get; set; }

        [DisplayName("Project")]
        public long ProjectId { get; set; }

        public virtual ProjectModel Project { get; set; }

        public List<ProjectModel> AvailableProjects { get; private set; }

        public TaskModel (ProjectDbContext db)
        {
            IsCompleted = false;
            AvailableProjects = db.Projects.ToList();
        }
    }
}