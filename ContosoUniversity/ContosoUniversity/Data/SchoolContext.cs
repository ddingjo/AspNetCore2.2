using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Student>().ToTable("Student");
            mb.Entity<Course>().ToTable("Course");
            mb.Entity<Enrollment>().ToTable("Enrollment");
        }
    }
}
