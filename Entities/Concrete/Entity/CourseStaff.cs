using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entity
{
    public class CourseStaff:IEntity
    {
        public int CourseStaffId { get; set; }
        public int CourseId { get; set; }
        public int StaffId { get; set; }
    }
}
