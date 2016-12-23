using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProgressTracker.Models
{
    [Table("task")]
    public class TaskModel : BaseModel
    {
        public bool IsCompleted { get; set; }
        public long ProjectId { get; set; }
        public virtual ProjectModel Project { get; set; }

        public TaskModel()
        {
            IsCompleted = false;
        }
    }
}