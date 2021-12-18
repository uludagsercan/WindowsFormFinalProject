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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;
       
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
           
        }

        public void Add(Department department)
        {
            _departmentDal.Add(department);
        }

        public Department GetByName(string name)
        {
            return _departmentDal.Get(x => x.DepartmentName == name);
        }
        public List<Department> GetAll()
        {
            return _departmentDal.GetAll();
        }
    }
}
