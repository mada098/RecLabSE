using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Models
{
    public class Professor
    {
        public Guid ProfessorID { get; set; }

        public string ProfessorName { get; set; }

        public ICollection<Classroom> Classrooms { get; set; }
    }
}
