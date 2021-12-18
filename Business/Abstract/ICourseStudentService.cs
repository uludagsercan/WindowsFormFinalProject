using Entities.Concrete.Dto;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseStudentService
    {
        List<CourseForStudent> GetAllByDepId(int id);
        void Add(CourseStudent student);
            
    }
}
