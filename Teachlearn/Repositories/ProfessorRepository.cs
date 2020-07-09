using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teachlearn.Models;
using Teachlearn.Abstractions;

namespace Teachlearn.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(TeachlearnContext dbContext) : base(dbContext)
        {

        }
        public Professor GetProfessorByProfessorId(Guid professorId)
        {
            var professor = dbContext.Professors
                         .Where(c => c.ProfessorID == professorId)
                         .SingleOrDefault();
            return professor;
        }
    }
}
