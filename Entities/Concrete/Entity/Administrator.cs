using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entity
{
    public class Administrator:IEntity
    {
        public int AdministratorId { get; set; }
        public string AdministratorName { get; set; }
        public string AdministratorSurname { get; set; }
        public string AdministratorIdentityNumber { get; set; }
        public bool AdministratorStatus { get; set; }
        public string AdministratorNumber { get; set; }
        public string AdministratorGender { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AdministratorEmail { get; set; }
        public string AdministratorAddress { get; set; }
        public string AdministratorPhoneNumber { get; set; }


    }
}
