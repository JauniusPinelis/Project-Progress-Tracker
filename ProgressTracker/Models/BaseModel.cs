using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgressTracker.Models
{
    public class BaseModel
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DisplayName("Time spent in minutes")]
        public long TimeSpentInMinutes { get; set; }
        [DisplayName("Last modified date")]
        public DateTime LastModified { get; set; }
        [DisplayName("Starting date")]
        public DateTime StartDate { get; set; }

        public BaseModel()
        {
            LastModified = DateTime.Now;
            TimeSpentInMinutes = 0;
        }
    }
}