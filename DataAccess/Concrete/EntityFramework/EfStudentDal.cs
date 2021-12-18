using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : GenericRepository<Student, Context>, IStudentDal
    {
        public Student GetStudentInfoByUserId(int id)
        {
            using (var context = new Context())
            {
                var studentInfo = (from student in context.Students
                                   from user in context.Users
                                   join userFoStudent in context.UserForStudents
                                   on user.Id equals id
                                   where userFoStudent.StudentId == student.StudentId
                                   select new Student
                                   {
                                       CreatedDate = student.CreatedDate,
                                       StudentAddress=student.StudentAddress,
                                       StudentGender=student.StudentGender,
                                       StudentId=student.StudentId,
                                       StudentIdentityNumber=student.StudentIdentityNumber,
                                       StudentMail=student.StudentMail,
                                       StudentName=student.StudentName,
                                       StudentNumber=student.StudentNumber,
                                       StudentPhoneNumber=student.StudentPhoneNumber,
                                       StudentStatus=student.StudentStatus,
                                       StudentSurname=student.StudentSurname
                                   }).First() ;
                return studentInfo;
            }
        }
    }
}
