using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teachlearn.Models;
using Teachlearn.Abstractions;

namespace Teachlearn.Repositories
{
    public class AssignmentRepository : BaseRepository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(TeachlearnContext dbContext) : base(dbContext)
        {

        }
        public Assignment GetAssignmentByAssignmentId(Guid assignmentId)
        {
            var assignment = dbContext.Assignments
                         .Where(c => c.AssignmentID == assignmentId)
                         .SingleOrDefault();
            return assignment;
        }
    }
}
