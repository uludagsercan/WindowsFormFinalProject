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
    public class UserForAdminManager : IUserForAdminService
    {
        IUserForAdminDal _uFAdminDal;

        public UserForAdminManager(IUserForAdminDal uFAdminDal)
        {
            _uFAdminDal = uFAdminDal;
        }

        public void Add(UserForAdmin parameter)
        {
            _uFAdminDal.Add(parameter);
        }
    }
}
