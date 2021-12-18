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
    public partial class StaffLoginForm : Form
    {
        IStaffService _staffService;
        IAuthStaffService _aSService;
        IUserService _uService;
        public StaffLoginForm(IStaffService staffService,IAuthStaffService aSService,IUserService userService)
        {
            InitializeComponent();
            _staffService = staffService;
            _aSService = aSService;
            _uService = userService;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register(txtUsename.Text,txtPassword.Text);
        }

        private void Register(string username, string password)
        {
            var userStaff = _staffService.GetByIdentityNumber(username);
            if (userStaff != null)
            {
                var registerResult = _aSService.Register(new UserForRegisterDto
                {
                    Id = userStaff.StaffId,
                    Password = password,
                    Username = userStaff.StaffNumber
                }, password);
                if (registerResult.Success)
                {
                    MessageBox.Show(registerResult.Message);
                    txtUsename.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show(registerResult.Message);
                }
            }
        }
        private void Login(string username, string password)
        {
            var userLoginInfo = new UserForLoginDto
            {
                Username = username,
                Password = password
            };
            var userResult = _aSService.Login(userLoginInfo);
            if (!userResult.Success)
            {
                MessageBox.Show(userResult.Message);
            }
            else
            {

                var getUser = _uService.GetByUsername(username);
                UserInformation.UserId = getUser.Id;

                Form1 f1 = new Form1(_uService.GetClaims(getUser));
                f1.openLayoutPanel(this);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login(txtUsename.Text, txtPassword.Text);
        }
    }
}
