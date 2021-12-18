using Business.Abstract;
using Business.Concrete;
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
    public partial class AdminLoginForm : Form
    {
        IAuthAdminService _aAdminService;
        IAdministratorService _adminService;
        IUserService _userService;
        
        public AdminLoginForm(IAuthAdminService aAdminService,IAdministratorService adminService,IUserService userService)
        {
            InitializeComponent();
            _adminService = adminService;
            _aAdminService = aAdminService;
            _userService = userService;
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Register(txtUsename.Text, txtPassword.Text);
        }
        private void Register(string username, string password)
        {
            var userAdmin = _adminService.GetByIdentityNumber(username);
            if (userAdmin != null)
            {
                var registerResult = _aAdminService.Register(new UserForRegisterDto
                {
                    Id = userAdmin.AdministratorId,
                    Password = password,
                    Username = userAdmin.AdministratorNumber
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
            var userResult = _aAdminService.Login(userLoginInfo);
            if (!userResult.Success)
            {
                MessageBox.Show(userResult.Message);
            }
            else
            {
                var getUser = _userService.GetByUsername(username);
                UserInformation.UserId = getUser.Id;
                Form1 f1 = new Form1(_userService.GetClaims(getUser));
                f1.loginPanel1.Visible = false;
                f1.openLayoutPanel(this);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login(txtUsename.Text, txtPassword.Text);
        }
    }
}
