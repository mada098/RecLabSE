using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teachlearn.Models;
using Teachlearn.Abstractions;

namespace Teachlearn.Repositories
{
    public class ClassroomRepository : BaseRepository<Classroom>, IClassroomRepository
    {
        public ClassroomRepository(TeachlearnContext dbContext) : base(dbContext)
        {

        }
        public Classroom GetClassroomByClassroomId(Guid classroomId)
        {
            var classroom = dbContext.Classrooms
                         .Where(c => c.ClassroomID == classroomId)
                         .SingleOrDefault();
            return classroom;
        }
    }
}
