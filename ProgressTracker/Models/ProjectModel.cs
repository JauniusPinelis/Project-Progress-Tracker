using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProgressTracker.Models
{
    [Table("project")]
    public class ProjectModel
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public long TimeSpentInMinutes { get; set; }

        public long HoursSpent { get
            {
                return TimeSpentInMinutes / 60;
            }
            set
            {
                TimeSpentInMinutes = value / 60;
            }

        }

        public ProjectModel()
        {

            StartTime = DateTime.Now;
            TimeSpentInMinutes = 0;
        }
    }
}