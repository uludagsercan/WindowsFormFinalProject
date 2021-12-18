using Core.Entities.Concrete;
using Entities.Concrete.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-H4NELET\SQLEXPRESS; Database=DbManagementSystem; Trusted_Connection=true");
        }
     
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
       
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
   

        public DbSet<User> Users { get; set; }
        public DbSet<UserForStudent> UserForStudents { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        public DbSet<UserForAdmin> UserForAdmins { get; set; }
        public DbSet<UserForStaff> UserForStaffs { get; set; }

        public DbSet<StudentFaculty> StudentFaculties { get; set; }
        public DbSet<StaffFaculty> StaffFaculties { get; set; }
        public DbSet<CourseStaff> CourseStaffs { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }

    }
}
