using Teachlearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Abstractions
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetStudentByStudentId(Guid StudentId);
        Student Add(Student itemToAdd);
        bool Delete(Student itemToDelete);
        Student Update(Student itemToUpdate);
    }
}