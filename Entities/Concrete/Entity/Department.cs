using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entity
{
    public class Department:IEntity
    {
        public int DepartmentId { get; set; }
        public String DepartmentName { get; set; }
        public int FacultyId { get; set; }
    }
}
