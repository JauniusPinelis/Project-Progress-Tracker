using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgressTracker.Models
{
    public class BaseObject
    {
        public DateTime LastModified { get; set; }

        public BaseObject()
        {
            LastModified = DateTime.Now;
        }
    }
}