using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal _uOClaimDal;

        public UserOperationClaimManager(IUserOperationClaimDal uOClaimDal)
        {
            _uOClaimDal = uOClaimDal;
        }

        public void Add(UserOperationClaim userOperationClaim)
        {
            _uOClaimDal.Add(userOperationClaim);
        }
    }
}
