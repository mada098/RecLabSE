using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Models
{
    public class Assignment
    {
        public Guid AssignmentID { get; set; }

        public string AssignmentName { get; set; }

        public string AssignmentDescription { get; set; }

        public int Grade { get; set; }

        public Classroom Classroom { get; set; }
    }
}
