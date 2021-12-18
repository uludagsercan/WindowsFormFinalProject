using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entity
{
    public class StudentFaculty:IEntity
    {
        public int StudentFacultyId { get; set; }
        public int StudentId { get; set; }
        public int DepartmentId { get; set; }
    }
}
