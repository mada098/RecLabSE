using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Models
{
    public class Classroom
    {
        [Key]
        public Guid ClassroomID { get; set; }
        public string ClassroomName { get; set; }
        public Professor Professor { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Stoc> Stocs { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
