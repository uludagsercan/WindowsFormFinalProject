using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entity
{
    public class StaffFaculty:IEntity
    {
        public int StaffFacultyId { get; set; }
        public int StaffId { get; set; }
        public int DepartmentId { get; set; }
    }
}
