using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entity
{
    public class Staff:IEntity
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffSurname { get; set; }
        public string StaffGender { get; set; }
        public string StaffIdentityNumber { get; set; }
        public bool StaffStatus { get; set; }
        public string StaffNumber { get; set; }
        public string StaffType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string  StaffMail { get; set; }
        public string StaffAddress { get; set; }
        public string StaffPhoneNumber { get; set; }
    }
}
