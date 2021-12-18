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
    public class StaffFacultyManager : IStaffFacultyService
    {
        IStaffFacultyDal _stfDal;

        public StaffFacultyManager(IStaffFacultyDal stfDal)
        {
            _stfDal = stfDal;
        }

        public void Add(StaffFaculty staffFaculty)
        {
            _stfDal.Add(staffFaculty);
        }
        public List<StaffFaculty> GetAll()
        {
            return _stfDal.GetAll();
        }
    }
}
