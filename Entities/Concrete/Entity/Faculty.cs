using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entity
{
    public class Faculty:IEntity
    {
        public int FacultyId { get; set; }
        public String FacultyName { get; set; }

    }
}
