using Teachlearn.Abstractions;
using Teachlearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Services
{
    public class AssignmentService
    {
        private readonly IAssignmentRepository assignmentRepository;

        public AssignmentService(IAssignmentRepository assignmentRepository)
        {
            this.assignmentRepository = assignmentRepository;
        }


        public Assignment GetAssignmentByAssignmentId(string assignmentId)
        {
            Guid.TryParse(assignmentId, out Guid guidAssignmentId);

            if (guidAssignmentId == Guid.Empty)
            {
                throw new Exception("");
            }

            var assignment = assignmentRepository.GetAssignmentByAssignmentId(guidAssignmentId);

            if (assignment == null)
            {
                throw new Exception("");
            }

            return assignment;

        }

    }
}