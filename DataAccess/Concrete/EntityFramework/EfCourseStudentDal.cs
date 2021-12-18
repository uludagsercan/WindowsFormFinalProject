using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Dto;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCourseStudentDal:GenericRepository<CourseStudent,Context>,ICourseStudentDal
    {
        public List<CourseForStudent> GetAllByDepartmentId(int id)
        {
            using (var context = new Context())
            {
                var result = from course in context.Courses
                             from staff in context.Staffs
                             from stafFaculties in context.StaffFaculties
                             join courseStaff in context.CourseStaffs
                             on course.CourseId equals courseStaff.CourseId
                             where stafFaculties.DepartmentId == id
                             select new CourseForStudent
                             {
                                 Code = course.CourseCode,
                                 Id=course.CourseId,
                                 Lecture=course.CourseName,
                                 Staff=staff.StaffName            
                             };
                return result.ToList();
            }
           
        } 
    }
}
