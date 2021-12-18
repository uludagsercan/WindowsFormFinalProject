using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentFacultyManager : IStudentFacultyService
    {
        IStudentFacultyDal _studentFacultyDal;

        public StudentFacultyManager(IStudentFacultyDal studentFacultyDal)
        {
            _studentFacultyDal = studentFacultyDal;
        }

        public void Add(StudentFaculty parameter)
        {
             _studentFacultyDal.Add(parameter);
        }

        public int GetDepartemntIdByStudentId(int id)
        {
            return _studentFacultyDal.Get(x => x.StudentId == id).DepartmentId;
        }
    }
}
