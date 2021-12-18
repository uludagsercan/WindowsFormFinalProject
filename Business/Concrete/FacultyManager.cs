using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
    public class FacultyManager : IFacultyService
    {
        IFacultyDal _facultyDal;
        public FacultyManager(IFacultyDal facultyDal)
        {
            _facultyDal = facultyDal;
        }
        public IResult Add(Faculty faculty)
        {
            _facultyDal.Add(faculty);
            return new SuccessResult("Kayıt Oluşturuldu");
        }

        public List<Faculty> GetAll()
        {
            return _facultyDal.GetAll();
        }
        public Faculty GetByName(string name)
        {
            return _facultyDal.Get(x => x.FacultyName == name);
        }

    }
}
