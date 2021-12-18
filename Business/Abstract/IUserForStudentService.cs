using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserForStudentService
    {
        void Add(UserForStudent parameter);
        int GetStudentIdByUserId(int id);
    }
}
