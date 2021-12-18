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
    public class OperationClaimManager : IOperationClaimService
    {
        IOperationClaimDal _oClaimDal;

        public OperationClaimManager(IOperationClaimDal oClaimDal)
        {
            _oClaimDal = oClaimDal;
        }

        public OperationClaim GetOperationClaim(string name)
        {
            return _oClaimDal.Get(x => x.Name == name);
        }
    }
}
