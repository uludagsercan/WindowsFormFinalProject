using Autofac;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Concrete;
using Business.DependencyResolvers.AutoFac;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        private static IContainer _container;
        IUserService _userService;
        private static List<OperationClaim> _claims;
        public Form1(IContainer container)
        {
            InitializeComponent();
            customizeDesign();
            _container = container;
            //  loginPanel1.Visible = false;

        }
        public Form1(List<OperationClaim> claims)
        {
            //   InitializeComponent();
            InitializeComponent();
            customizeDesign();
            _userService = _container.Resolve<IUserService>();
            _claims = claims;

        }


        private void customizeDesign()
        {
            subPanel1.Visible = false;
            subPanelStudent.Visible = false;
            subPanelStaff.Visible = false;
            subPanelFaculties.Visible = false;
        }
        private void hideSubMenu()
        {

            if (subPanel1.Visible == true)
            {
                subPanel1.Visible = false;
            }
            if (subPanelStudent.Visible == true)
            {
                subPanelStudent.Visible = false;
            }
            if (subPanelStaff.Visible == true)
            {
                subPanelStaff.Visible = false;
            }
            if (subPanelFaculties.Visible == true)
            {
                subPanelFaculties.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
            

        }

        private Form activeForm = null;
        public void openLayoutPanel(Form childForm)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            layoutPanel.Controls.Add(childForm);
            layoutPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void fakultelerBtn_Click(object sender, EventArgs e)
        {
            if (_claims != null)
            {
                var getClaim = _claims.Find(x => x.Name == "admin");
                if (_claims.Contains(getClaim))
                {
                    showSubMenu(subPanel1);
                }
            }

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnStudent_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new AdminStudentForm(_container.Resolve<IStudentService>()));
        }
        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            openLayoutPanel(new AdminForm(_container.Resolve<IAdministratorService>()));
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new AdminStaffForm(_container.Resolve<IStaffService>()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new StudentLoginForm(_container.Resolve<IUserService>(), _container.Resolve<IStudentService>()
                , _container.Resolve<IAuthService>(),
                _container.Resolve<IOperationClaimService>()));
        }
        private void layoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new AdminLoginForm(_container.Resolve<IAuthAdminService>(), _container.Resolve<IAdministratorService>()
                , _container.Resolve<IUserService>()));
        }

        private void loginPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new StaffLoginForm(_container.Resolve<IStaffService>(), _container.Resolve<IAuthStaffService>(),_container.Resolve<IUserService>()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new AdminInfoForm(_container.Resolve<IAdministratorService>()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new StudentInfoForm(_container.Resolve<IStudentService>()));
        }

        private void btnSt_Click(object sender, EventArgs e)
        {
            if (_claims != null)
            {
                var getClaim = _claims.Find(x => x.Name=="student");
                if (_claims.Contains(getClaim))
                {
                    showSubMenu(subPanelStudent);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_claims != null)
            {
                var getClaim = _claims.Find(x => x.Name == "teacher");
                if (_claims.Contains(getClaim))
                {
                    showSubMenu(subPanelStaff);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new StaffInfoForm(_container.Resolve<IStaffService>()));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_claims != null)
            {
                var getClaim = _claims.Find(x => x.Name == "admin");
                if (_claims.Contains(getClaim))
                {
                    showSubMenu(subPanelFaculties);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new FacultyProcessesForm(_container.Resolve<IFacultyService>(),_container.Resolve<IDepartmentService>()));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new FacultyStudentForm(_container.Resolve<IStudentService>(),_container.Resolve<IFacultyService>(),
                _container.Resolve<IDepartmentService>(),_container.Resolve<IStudentFacultyService>()));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new FacultyStaffForm(_container.Resolve<IStaffService>(), _container.Resolve<IFacultyService>(),
                _container.Resolve<IDepartmentService>()
                , _container.Resolve<IStaffFacultyService>()));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new CourseAddForm(_container.Resolve<ICourseService>()));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new CourseStaffDetailForm(_container.Resolve<IDepartmentService>(), _container.Resolve<IStaffService>(),
                _container.Resolve<IFacultyService>(), _container.Resolve<IStaffFacultyService>(),_container.Resolve<ICourseService>(),
                _container.Resolve<ICourseStaffService>()));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openLayoutPanel(new StudentAddCourseForm(_container.Resolve<ICourseStudentService>(),_container.Resolve<IStudentFacultyService>()
                ,_container.Resolve<IUserForStudentService>(),_container.Resolve<IStudentService>()));
        }
    }
}
