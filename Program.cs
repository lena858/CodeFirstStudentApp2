using System;
using System.Data.Entity;

namespace CodeFirstStudentApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // إنشاء طالب جديد
                var student = new Student { StudentName = "Lena" };

                // إضافة الطالب لقاعدة البيانات
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student has been added successfully!");
                Console.ReadLine();
            }
        }
    }

    // الكلاس Student
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    // الكلاس DbContext
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
