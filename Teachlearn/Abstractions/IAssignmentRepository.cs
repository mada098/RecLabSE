using Teachlearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Abstractions
{
    public interface IAssignmentRepository
    {
        IEnumerable<Assignment> GetAll();
        Assignment GetAssignmentByAssignmentId(Guid AssignmentId);
        Assignment Add(Assignment itemToAdd);
        bool Delete(Assignment itemToDelete);
        Assignment Update(Assignment itemToUpdate);
    }
}