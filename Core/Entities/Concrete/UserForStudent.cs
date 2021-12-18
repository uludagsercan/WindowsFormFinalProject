using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class UserForStudent:IEntity
    {
        public int UserForStudentId { get; set; }
        public int StudentId { get; set; }
    }
}
