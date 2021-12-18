using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entity
{
    public class CourseStudent:IEntity
    {
        public int CourseStudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StudentId { get; set; }
        public bool CourseStatus { get; set; }
    }
}
