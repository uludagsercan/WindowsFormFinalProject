using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Dto;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFacultyDal : GenericRepository<Faculty, Context>, IFacultyDal
    {

        //public List<FacultyDto> GetAllById()
        //{
        //    using(Context c = new Context())
        //    {
        //        var listofFaculty = from f in c.Faculties
        //                            join d in c.Departments
        //                            on f.FacultyId equals d.FacultyId
        //                            select new FacultyDto
        //                            {
        //                                FacultyDtoId = d.DepartmentId,
        //                                FacultyName = f.FacultyName,
        //                                DepartmentName = d.DepartmentName
        //                            };
        //        return listofFaculty.ToList();
        //    }
            
        //}

      
    }
}
