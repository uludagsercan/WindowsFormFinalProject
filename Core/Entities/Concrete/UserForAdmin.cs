using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class UserForAdmin:IEntity
    {
        public int UserForAdminId { get; set; }
        public int AdministratorId { get; set; }
    }
}
