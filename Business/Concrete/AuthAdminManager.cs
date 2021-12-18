using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Hashing;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthAdminManager : IAuthAdminService
    {
        private IUserService _userService;
        private IUserForAdminService _uAFor;

        public AuthAdminManager(IUserService userService, IUserForAdminService userFor)
        {
            _userService = userService;
            _uAFor = userFor;

        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Username = userForRegisterDto.Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                UserStatus = true
            };
           
            _userService.Add(user);
            var userForAdmin = new UserForAdmin
            {
                AdministratorId = userForRegisterDto.Id,
                UserForAdminId = _userService.GetByUsername(userForRegisterDto.Username).Id
            };
            _uAFor.Add(userForAdmin);
            var userOperationClaim = _userService.GetByUsername(user.Username);
            var getOperationClaim = _userService.GetOperation("admin");
            _userService.AddUserOperationClaim(new UserOperationClaim { OperationClaimId = getOperationClaim.Id, UserId = userOperationClaim.Id });
            return new SuccessDataResult<User>(user, "Kayıt işlemi başarılı");
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByUsername(userForLoginDto.Username);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>("User Bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>("Kullanıcı adı veya şifre yanlış");
            }

            return new SuccessDataResult<User>(userToCheck, "Giriş işlemi başarılı");
        }
    }
}
