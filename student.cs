using System;
using System.Data.Entity;

namespace CodeFirstStudentApp
{
    // This is your model
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // This is your DbContext
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
