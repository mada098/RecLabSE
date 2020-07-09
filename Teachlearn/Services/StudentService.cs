using Teachlearn.Abstractions;
using Teachlearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Services
{
    public class StudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        public Student GetStudentByStudentId(string studentId)
        {
            Guid.TryParse(studentId, out Guid guidStudentId);

            if (guidStudentId == Guid.Empty)
            {
                throw new Exception("");
            }

            var student = studentRepository.GetStudentByStudentId(guidStudentId);

            if (student == null)
            {
                throw new Exception("");
            }

            return student;

        }

    }
}