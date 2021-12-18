using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff, Context>, IStaffDal
    {
        public Staff GetStaffDetail(int id)
        {
            using (var context = new Context())
            {
                var staffDetail = (from staff in context.Staffs
                                   from user in context.Users
                                   join userForStaff in context.UserForStaffs
                                   on user.Id equals id
                                   where userForStaff.StaffId == staff.StaffId
                                   select new Staff
                                   {
                                       StaffId=staff.StaffId,
                                       CreatedDate=staff.CreatedDate,
                                       StaffAddress=staff.StaffAddress,
                                       StaffGender=staff.StaffGender,
                                       StaffIdentityNumber=staff.StaffIdentityNumber,
                                       StaffName=staff.StaffName,
                                       StaffNumber=staff.StaffNumber,
                                       StaffPhoneNumber=staff.StaffPhoneNumber,
                                       StaffStatus=staff.StaffStatus,
                                       StaffSurname=staff.StaffSurname,
                                       StaffType=staff.StaffType,
                                       StaffMail=staff.StaffMail
                                       
                                   }).First();
                return staffDetail;
            }
        }
    }
}
