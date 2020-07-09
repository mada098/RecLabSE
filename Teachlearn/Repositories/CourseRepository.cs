using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teachlearn.Models;
using Teachlearn.Abstractions;

namespace Teachlearn.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(TeachlearnContext dbContext) : base(dbContext)
        {

        }
        public Course GetCourseByCourseId(Guid courseId)
        {
            var course = dbContext.Courses
                         .Where(c => c.CourseID == courseId)
                         .SingleOrDefault();
            return course;
        }
    }
}
