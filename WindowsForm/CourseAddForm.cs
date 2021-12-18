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
    public partial class CourseAddForm : Form
    {
        //IDepartmentService _departmentService;
        //IStaffService _staffService;
        //IFacultyService _facultyService;
        //IStaffFacultyService _staffFacultyService;
        ICourseService _courseService;

        public CourseAddForm(ICourseService courseService)
        {
            InitializeComponent();
            _courseService = courseService;
            //_departmentService = departmentService;
            //_staffService = staffService;
            //_facultyService = facultyService;
            //_staffFacultyService = staffFacultyService;
        }
        protected override void OnLoad(EventArgs e)
        {
            //GetStaffDetails();
        }

        private void AddCourse(Course course)
        {
            course.CourseCode = txtCode.Text;
            course.CourseName = txtName.Text;
            course.CourseDesc = txtDesc.Text;
            _courseService.Add(course);
        }
    

        private void CourseAddForm_Load(object sender, EventArgs e)
        {

        }
        private void ClearComponents()
        {
            txtCode.Clear();
            txtName.Clear();
            txtDesc.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string txt = String.Format(txtCode.Text + "\n" + txtDesc.Text + "\n" + txtName.Text);
            var result = MessageBox.Show(txt, "Comfirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                AddCourse(new Course());
                ClearComponents();
            }
        }
    }
}
