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
    public class UserForStudentManager : IUserForStudentService
    {
        IUserForStudentDal _uFSDal;
        public UserForStudentManager(IUserForStudentDal userFor)
        {
            _uFSDal = userFor;
        }
        public void Add(UserForStudent parameter)
        {
            _uFSDal.Add(parameter);
        }
        public int GetStudentIdByUserId(int id)
        {
            return _uFSDal.Get(x => x.UserForStudentId == id).StudentId;
        }
    }
}
