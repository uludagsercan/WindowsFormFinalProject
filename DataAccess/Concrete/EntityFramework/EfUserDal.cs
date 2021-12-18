using Core.DataAccess.Concrete.EntityFramework;
using Core.Entities.Concrete;
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
    public class EfUserDal : GenericRepository<User, Context>, IUserDal
    {
        //Operation claim işlemleri buraya yazılacak
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context=new Context())
            {
                var getClaims = (from operationClaims in context.OperationClaims
                                 join userOperationClaims in context.UserOperationClaims
                                 on operationClaims.Id equals userOperationClaims.OperationClaimId
                                 where user.Id == userOperationClaims.UserId
                                 select new OperationClaim {Id=operationClaims.Id, Name= operationClaims.Name}).ToList();
                return getClaims;
            }
        }
       
    }
}
