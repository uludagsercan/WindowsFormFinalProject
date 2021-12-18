using Core.Utilities.Results.Abstract;
using Entities.Concrete.Dto;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFacultyService
    {
        IResult Add(Faculty faculty);
        List<Faculty> GetAll();

        Faculty GetByName(string name);
    }
}
