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

    public class EfAdministratorDal : GenericRepository<Administrator, Context>, IAdministratorDal
    {
        public Administrator GetAdminInfo(int id)
        {
            using (var context = new Context())
            {
                var adminInfo = (from user in context.Users
                                 from administrator in context.Administrators
                                 join userAdmin in context.UserForAdmins
                                 on user.Id equals id
                                 where administrator.AdministratorId == userAdmin.AdministratorId
                                 select new Administrator
                                 {
                                     AdministratorName = administrator.AdministratorName,
                                     AdministratorAddress = administrator.AdministratorAddress,
                                     AdministratorEmail=administrator.AdministratorEmail,
                                     AdministratorGender=administrator.AdministratorGender,
                                     AdministratorIdentityNumber=administrator.AdministratorIdentityNumber,
                                     AdministratorNumber=administrator.AdministratorNumber,
                                     AdministratorPhoneNumber=administrator.AdministratorPhoneNumber,
                                     AdministratorStatus=administrator.AdministratorStatus,
                                     AdministratorSurname=administrator.AdministratorSurname,
                                     CreatedDate=administrator.CreatedDate
                                 }).First();
                ;
                return adminInfo;
            }

        }
    }
}
