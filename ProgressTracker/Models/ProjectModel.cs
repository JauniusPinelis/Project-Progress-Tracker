using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProgressTracker.Models
{
    [Table("project")]
    public class ProjectModel : BaseObject
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public long TimeSpentInMinutes { get; set; }

        public ProjectModel()
        {
            StartTime = DateTime.Now;
            TimeSpentInMinutes = 0;
        }
    }
}