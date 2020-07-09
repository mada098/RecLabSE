using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teachlearn.Models;
using Teachlearn.Abstractions;

namespace Teachlearn.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(TeachlearnContext dbContext) : base(dbContext)
        {

        }
        public Student GetStudentByStudentId(Guid studentId)
        {
            var student = dbContext.Students
                         .Where(c => c.StudentID == studentId)
                         .SingleOrDefault();
            return student;
        }
    }
}
