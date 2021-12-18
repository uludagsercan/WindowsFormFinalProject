using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Entity
{
    public class Student:IEntity
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentIdentityNumber { get; set; }
        public string StudentGender { get; set; }
        public bool StudentStatus { get; set; }
        public string StudentNumber { get; set; }
        public string StudentMail { get; set; }
        public DateTime CreatedDate { get; set; }
        public string StudentAddress { get; set; }
        public string StudentPhoneNumber { get; set; }
    }
}