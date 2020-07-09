using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Models
{
    public class Stoc   //face legatura intre Student si Classroom
    {  
        [Key]
        public Guid StudentID { get; set; }
        
        public Guid ClassroomID { get; set; }

        public Student Student { get; set; }

        public Classroom Classroom { get; set; }
    }
}