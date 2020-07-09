using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Models
{
    public class Course
    {
        public Guid CourseID { get; set; }

        public string CourseName { get; set; }

        public string CourseDescription { get; set; }

        public string DownloadLink { get; set; }

        public Classroom Classroom { get; set; }
    }
}
