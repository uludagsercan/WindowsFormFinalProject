using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto
{
    public class CourseForStudent:IDto
    {
        public int Id { get; set; }
        
        public string Code { get; set; }
        public string Lecture { get; set; }
        public string Staff { get; set; }
       
    }
}
