using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Models
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }

        public string StudentName { get; set; }

        public ICollection<Stoc> Stocs { get; set; }
    }
}
