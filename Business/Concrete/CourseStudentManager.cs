using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Dto;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseStudentManager : ICourseStudentService
    {
        ICourseStudentDal _courseStudentDal;
     

        public CourseStudentManager(ICourseStudentDal courseStudentDal)
        {
            _courseStudentDal = courseStudentDal;
        }

        public void Add(CourseStudent student)
        {
            _courseStudentDal.Add(student);
        }

        public List<CourseForStudent> GetAllByDepId(int id)
        {
            return _courseStudentDal.GetAllByDepartmentId(id);
        }
    }
}
