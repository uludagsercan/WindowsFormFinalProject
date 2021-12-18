using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Dto;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdministratorManager : IAdministratorService
    {
        IAdministratorDal _aDal;

        public AdministratorManager(IAdministratorDal aDal)
        {
            _aDal = aDal;
        }

        public IResult Add(Administrator administrator)
        {

            _aDal.Add(administrator);
            return new SuccessResult("Ekleme işlemi başarılıdır.");
        }

        public void Delete(Administrator administrator)
        {
            _aDal.Delete(administrator);
        }

        public List<Administrator> GetAll()
        {
            return _aDal.GetAll();
        }

        public Administrator GetById(int id)
        {
            return _aDal.Get(x => x.AdministratorId == id);
        }

        public Administrator GetByIdentityNumber(string username)
        {
            return _aDal.Get(x=> x.AdministratorIdentityNumber==username);
        }

        public void Update(Administrator administrator)
        {
            _aDal.Update(administrator);
        }

        public Administrator GetAdminInfoById(int id)
        {
            return _aDal.GetAdminInfo(id);
        }
    }
}
