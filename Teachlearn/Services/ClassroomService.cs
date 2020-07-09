using Teachlearn.Abstractions;
using Teachlearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teachlearn.Services
{
    public class ClassroomService
    {
        private readonly IClassroomRepository classroomRepository;

        public ClassroomService(IClassroomRepository classroomRepository)
        {
            this.classroomRepository = classroomRepository;
        }


        public Classroom GetClassroomByClassroomId(string classroomId)
        {
            Guid.TryParse(classroomId, out Guid guidClassroomId);

            if (guidClassroomId == Guid.Empty)
            {
                throw new Exception("");
            }

            var classroom = classroomRepository.GetClassroomByClassroomId(guidClassroomId);

            if (classroom == null)
            {
                throw new Exception("");
            }

            return classroom;

        }

    }
}