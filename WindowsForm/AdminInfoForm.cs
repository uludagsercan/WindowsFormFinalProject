using Business.Abstract;
using Entities.Concrete.Dto;
using Entities.Concrete.Entity;
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
    public partial class AdminInfoForm : Form
    {
        IAdministratorService _aService;

        public AdminInfoForm(IAdministratorService aService)
        {
            InitializeComponent();
            _aService = aService;
        }
        protected override void OnLoad(EventArgs e)
        {
            GetAdminInfo();
        }
        private void GetAdminInfo()
        {
            var admin = _aService.GetAdminInfoById(UserInformation.UserId);
            txtAdNumber.Text = admin.AdministratorNumber.ToString();
            txtIdentity.Text = admin.AdministratorIdentityNumber.ToString();
            txtMail.Text = admin.AdministratorEmail;
            txtName.Text = admin.AdministratorName;
            txtPhone.Text = admin.AdministratorPhoneNumber;
            txtSurname.Text = admin.AdministratorSurname;
            rTxtAddress.Text = admin.AdministratorAddress;
            rMale.Checked = admin.AdministratorGender == "Male" ? true : false;
            rFemale.Checked= admin.AdministratorGender == "Male" ? true : false;
            rActive.Checked = admin.AdministratorStatus == true ? true : false;
            rPassive.Checked = admin.AdministratorStatus == true ? true : false;
        }

    }
}
