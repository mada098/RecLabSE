using Teachlearn.Abstractions;
using Teachlearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Services
{
    public class ProfessorService
    {
        private readonly IProfessorRepository professorRepository;

        public ProfessorService(IProfessorRepository professorRepository)
        {
            this.professorRepository = professorRepository;
        }


        public Professor GetProfessorByProfessorId(string professorId)
        {
            Guid.TryParse(professorId, out Guid guidProfessorId);

            if (guidProfessorId == Guid.Empty)
            {
                throw new Exception("");
            }

            var professor = professorRepository.GetProfessorByProfessorId(guidProfessorId);

            if (professor == null)
            {
                throw new Exception("");
            }

            return professor;

        }

    }
}