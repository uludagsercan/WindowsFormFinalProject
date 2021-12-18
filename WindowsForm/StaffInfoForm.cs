using Business.Abstract;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class StaffInfoForm : Form
    {
        IStaffService _sService;
        public StaffInfoForm(IStaffService staffService)
        {
            InitializeComponent();
            _sService = staffService;
        }

        protected override void OnLoad(EventArgs e)
        {
            GetStaff();
        }
        private void GetStaff()
        {
            var staffInfo = _sService.GetStaffByUserId(UserInformation.UserId);
            txtIdentity.Text = staffInfo.StaffIdentityNumber;
            txtMail.Text = staffInfo.StaffMail;
            txtName.Text = staffInfo.StaffName;
            txtPhone.Text = staffInfo.StaffPhoneNumber;
            txtStNumber.Text = staffInfo.StaffNumber;
            txtSurname.Text = staffInfo.StaffSurname;
            txtType.Text = staffInfo.StaffType;
            rTxtAddress.Text = staffInfo.StaffAddress;
            rMale.Checked = staffInfo.StaffGender == rMale.Text ? true : false;
            rFemale.Checked = staffInfo.StaffGender == rFemale.Text ? true : false;
            rActive.Checked = staffInfo.StaffStatus == true ? true : false;
            rPassive.Checked = staffInfo.StaffStatus == false ? true : false;


        }
    }
}
