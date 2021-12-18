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
    public interface IAdministratorService
    {
        IResult Add(Administrator administrator);
        void Update(Administrator administrator);
        void Delete(Administrator administrator);
        List<Administrator> GetAll();
        Administrator GetById(int id);

        Administrator GetAdminInfoById(int id);
        Administrator GetByIdentityNumber(string username);
    }
}
