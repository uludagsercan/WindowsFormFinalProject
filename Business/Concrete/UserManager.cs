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
   public class UserManager: IUserService
    {
        IUserDal _userDal;
        private IOperationClaimService _oClaimService;
        IUserOperationClaimService _uOClaimService;
        public UserManager(IUserDal userDal,IOperationClaimService oClaimService,IUserOperationClaimService userOperationClaim)
        {
            _userDal = userDal;
            _oClaimService = oClaimService;
            _uOClaimService = userOperationClaim;
        }

        //public List<OperationClaim> GetClaims(User user)
        //{
        //    return _userDal.GetClaims(user);
        //}
        public void Add(User user)
        {
            _userDal.Add(user);
        }
        public void AddUserOperationClaim(UserOperationClaim claim)
        {
            _uOClaimService.Add(claim);
        }
        public User GetByUsername(string username)
        {
            return _userDal.Get(u => u.Username == username);
        }
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public OperationClaim GetOperation(string name)
        {
            return _oClaimService.GetOperationClaim(name);
        }
    }
}
