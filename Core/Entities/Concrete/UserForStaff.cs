using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class UserForStaff:IEntity
    {
        public int UserForStaffId { get; set; }
        public int StaffId { get; set; }
    }
}
