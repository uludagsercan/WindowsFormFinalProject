using Core.Utilities.Results.Abstract;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStaffService
    {
        IResult Add(Staff staff);
        void Delete(Staff staff);
        void Update(Staff staff);
        Staff GetById(int id);
        Staff GetByIdentityNumber(string username);
        Staff GetStaffByUserId(int id);

        Staff GetByName(string name);
        List<Staff> GetAll();
    }
}
