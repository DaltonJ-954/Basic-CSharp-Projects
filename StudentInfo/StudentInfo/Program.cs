using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace StudentInfo
{
    class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new Context())
            {
                Console.WriteLine("Enter the name of a student.");
                var student1 = Console.ReadLine();
                Console.WriteLine("Enter the student date of birth.");
                var dob1 = Console.ReadLine();
                Console.WriteLine("Enter the email of a student.");
                var email1 = Console.ReadLine();


                var newStudent = new Student { Name = student1, DOB = dob1, Email = email1 };
                db.Students.Add(newStudent);
                db.SaveChanges();

                if (true)
                {
                   
                }
                db.Dispose();
            }
            Console.ReadKey();
        }
    }
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
    }

    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
