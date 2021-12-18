using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserForStaffManager : IUserForStaffService
    {
        IUserForStaffDal _uForStaffService;

        public UserForStaffManager(IUserForStaffDal uForStaffService)
        {
            _uForStaffService = uForStaffService;
        }

        public void Add(UserForStaff userForStaff)
        {
            _uForStaffService.Add(userForStaff);
        }
    }
}
