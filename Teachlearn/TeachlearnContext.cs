using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teachlearn.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Teachlearn 
{ 
    public class TeachlearnContext : IdentityDbContext<IdentityUser>
    {
        public TeachlearnContext(DbContextOptions<TeachlearnContext> options)
            : base(options)
        { }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
