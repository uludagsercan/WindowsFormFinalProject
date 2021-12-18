using Business.Abstract;
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
    public class StaffManager : IStaffService
    {
        IStaffDal _staffDal;
        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }
        public IResult Add(Staff staff)
        {
            _staffDal.Add(staff);
            return new SuccessResult("Kayıt işlemi başarılıdır");
        }

        public void Delete(Staff staff)
        {
            _staffDal.Delete(staff);
        }

        public List<Staff> GetAll()
        {
            return _staffDal.GetAll();
        }

        public Staff GetById(int id)
        {
            return _staffDal.Get(x => x.StaffId == id);
        }

        public Staff GetByIdentityNumber(string username)
        {
            return _staffDal.Get(x => x.StaffIdentityNumber == username);
        }

        public Staff GetByName(string name)
        {
            return _staffDal.Get(x => x.StaffNumber == name);
        }

        public Staff GetStaffByUserId(int id)
        {
            return _staffDal.GetStaffDetail(id);
        }

        public void Update(Staff staff)
        {
            _staffDal.Update(staff);
        }
    }
}
