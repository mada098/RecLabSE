using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Models
{
    public class Course
    {
        public Guid CourseID { get; set; }
<<<<<<< HEAD

        public string CourseName { get; set; }

        public string CourseDescription { get; set; }

        public string DownloadLink { get; set; }

        public Classroom Classroom { get; set; }
=======
        public string CourseTitle { get; set; }
        public string CourseContent { get; set; }
        public Class Class { get; set; }
>>>>>>> 721b822073b521b87c9a8cde59179794b36c2fa5
    }
}
