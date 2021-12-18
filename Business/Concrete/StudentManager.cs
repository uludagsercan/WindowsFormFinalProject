using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;
        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        [ValidationAspect(typeof(StudentValidator))]
        public IResult Add(Student student)
        {      
            _studentDal.Add(student);
            return new SuccessResult("Kayıt işlemi başarılıdır");
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public Student Get(int id)
        {
            return _studentDal.Get(x => x.StudentId == id);
        }
        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public Student GetByIdentityNumber(string identity)
        {
            return _studentDal.Get(x => x.StudentIdentityNumber == identity);
        }

        public Student GetStudentByUserId(int id)
        {
            return _studentDal.GetStudentInfoByUserId(id);
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }
    }
}
