using Teachlearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Abstractions
{
    public interface IProfessorRepository
    {
        IEnumerable<Professor> GetAll();
        Professor GetProfessorByProfessorId(Guid ProfessorId);
        Professor Add(Professor itemToAdd);
        bool Delete(Professor itemToDelete);
        Professor Update(Professor itemToUpdate);
    }
}