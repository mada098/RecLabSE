using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Models
{
    public class Assignment
    {
        public Guid AssignmentID { get; set; }
<<<<<<< HEAD

        public string AssignmentName { get; set; }

        public string AssignmentDescription { get; set; }

        public int Grade { get; set; }

        public Classroom Classroom { get; set; }
=======
        public string AssignmentTitle { get; set; }
        public string AssignmentContent { get; set; }
        public DateTime DueDate { get; set; }
        public Grade Grade { get; set; }
        public Class Class { get; set; }

>>>>>>> 721b822073b521b87c9a8cde59179794b36c2fa5
    }
}
