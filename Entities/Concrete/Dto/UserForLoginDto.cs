using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto
{
    public class UserForLoginDto:IDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
