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
    public class AuthManager:IAuthService
    {
        private IUserService _userService;
        private IUserForStudentService _uFor;
        
        public AuthManager(IUserService userService,IUserForStudentService userFor)
        {
            _userService = userService;
            _uFor = userFor;
           
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
            var userForStudent = new UserForStudent
            {
                StudentId = userForRegisterDto.Id,
                UserForStudentId = _userService.GetByUsername(userForRegisterDto.Username).Id
            };
            
            _uFor.Add(userForStudent);
            var userOperationClaim = _userService.GetByUsername(user.Username);
            var getOperationClaim = _userService.GetOperation("student");
            _userService.AddUserOperationClaim(new UserOperationClaim { OperationClaimId = getOperationClaim.Id, UserId = userOperationClaim.Id });
            return new SuccessDataResult<User>(user,"Kayıt işlemi başarılı");
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
