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
    public partial class StudentInfoForm : Form
    {
        IStudentService _studentService;
        public StudentInfoForm(IStudentService studentService)
        {
            InitializeComponent();
            _studentService = studentService;
        }
        protected override void OnLoad(EventArgs e)
        {
            GetStudentInfo();
        }
        private void GetStudentInfo()
        {
            var studentInfo = _studentService.GetStudentByUserId(UserInformation.UserId);
            txtIdentity.Text = studentInfo.StudentIdentityNumber;
            txtMail.Text = studentInfo.StudentMail;
            txtName.Text = studentInfo.StudentName;
            txtPhone.Text = studentInfo.StudentPhoneNumber;
            txtStNumber.Text = studentInfo.StudentNumber;
            txtSurname.Text = studentInfo.StudentSurname;
            rTxtAddress.Text = studentInfo.StudentAddress;
            rMale.Checked = studentInfo.StudentGender == rMale.Text ? true : false;
            rFemale.Checked = studentInfo.StudentGender == rFemale.Text ? true : false;
            rActive.Checked = studentInfo.StudentStatus == true ? true : false;
            rPassive.Checked = studentInfo.StudentStatus == false ? true : false;
        }
    }
}
