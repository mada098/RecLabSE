using Teachlearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Abstractions
{
    public interface IClassroomRepository
    {
        IEnumerable<Classroom> GetAll();
        Classroom GetClassroomByClassroomId(Guid ClassroomId);
        Classroom Add(Classroom itemToAdd);
        bool Delete(Classroom itemToDelete);
        Classroom Update(Classroom itemToUpdate);
    }
}