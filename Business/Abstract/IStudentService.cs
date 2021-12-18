using Core.Utilities.Results.Abstract;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IResult Add(Student student);
        List<Student> GetAll();
        void Update(Student student);
        void Delete(Student student);
        Student Get(int id);
        Student GetByIdentityNumber(string identity);
        Student GetStudentByUserId(int id);
        
    }
}
