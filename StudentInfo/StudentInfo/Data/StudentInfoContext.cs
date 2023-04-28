using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentInfo.Models;

namespace StudentInfo.Data
{
    public class StudentInfoContext : DbContext
    {
        public StudentInfoContext (DbContextOptions<StudentInfoContext> options)
            : base(options)
        {
        }

        public DbSet<StudentInfo.Models.Student> Student { get; set; }
    }
}
