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
    public partial class CourseStaffDetailForm : Form
    {
        IDepartmentService _departmentService;
        IStaffService _staffService;
        IFacultyService _facultyService;
        IStaffFacultyService _staffFacultyService;
        ICourseService _courseService;
        ICourseStaffService _courseStaffService;
       
        public CourseStaffDetailForm(IDepartmentService departmentService, IStaffService staffService, 
            IFacultyService facultyService, IStaffFacultyService staffFacultyService,ICourseService courseService,
            ICourseStaffService courseStaffService)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _staffService = staffService;
            _facultyService = facultyService;
            _staffFacultyService = staffFacultyService;
            _courseService = courseService;
            _courseStaffService = courseStaffService;

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSelectedStaffRow();
        }
        private void GetStaffDetails()
        {
            var staffDetails = (from staffs in _staffService.GetAll()
                               from departments in _departmentService.GetAll()
                               from faculties in _facultyService.GetAll()
                               join staffFaculties in _staffFacultyService.GetAll()
                               on staffs.StaffId equals staffFaculties.StaffId
                               where faculties.FacultyId == departments.DepartmentId
                               select new StaffDetail
                               {
                                   Id = staffs.StaffId,
                                   Department = departments.DepartmentName,
                                   Faculty = faculties.FacultyName,
                                   Name = staffs.StaffName,
                                   Surname = staffs.StaffSurname,
                                   Number=staffs.StaffNumber                                 
                               }).ToList();
            dataGridView1.DataSource = staffDetails;
        }
        private void GetCourses()
        {
            var courses = _courseService.GetAll();
            dataGridView2.DataSource = courses;
        }
        protected override void OnLoad(EventArgs e)
        {
            GetCourses();
            GetStaffDetails();
        }
        private void GetSelectedCourseRow()
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void GetSelectedStaffRow()
        {
            txtStaffId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void AddCourse(CourseStaff staff)
        {
            staff.StaffId = Convert.ToInt32(txtStaffId.Text);
            staff.CourseId = Convert.ToInt32(textBox1.Text);
            _courseStaffService.Add(staff);
        }

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetSelectedCourseRow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCourse(new CourseStaff());
        }
    }
}
