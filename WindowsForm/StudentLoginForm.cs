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
    public partial class StudentLoginForm : Form
    {
        IUserService _uService;
        IStudentService _sService;
        IAuthService _auth;
        IOperationClaimService _oClaimService;
        public StudentLoginForm(IUserService uService,IStudentService studentService,IAuthService authService,
            IOperationClaimService oClaimService)
        {
            InitializeComponent();
            _uService = uService;
            _sService = studentService;
            _auth = authService;
            _oClaimService = oClaimService;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Login(txtUsename.Text,txtPassword.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register(txtUsename.Text, txtPassword.Text);
        }
        private void Register(string username,string password)
        {
            var userStudent = _sService.GetByIdentityNumber(username);
            if (userStudent != null)
            {
                var registerResult = _auth.Register(new UserForRegisterDto
                {
                    Id = userStudent.StudentId,
                    Password = password,
                    Username = userStudent.StudentNumber
                }, password) ;

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
            var userResult = _auth.Login(userLoginInfo);
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
    }
}
