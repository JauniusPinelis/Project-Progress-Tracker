using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProgressTracker.Models
{
    [Table("project")]
    public class ProjectModel : BaseModel
    {
        public virtual ICollection<TaskModel> Tasks { get; set; }

        public ProjectModel() : base()
        {
            Tasks = new List<TaskModel>();
        }
    }
}