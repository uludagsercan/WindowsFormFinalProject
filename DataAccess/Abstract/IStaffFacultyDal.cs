using Core.DataAccess.Abstract.EntityFramework;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IStaffFacultyDal:IEntityRepository<StaffFaculty>
    {
    }
}
