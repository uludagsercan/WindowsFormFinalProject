using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        List<Course> GetAll();
    }
}
