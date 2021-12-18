using Business.Abstract;
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
    public partial class FacultyStaffForm : Form
    {
        IStaffService _staffService;
        IFacultyService _facultyService;
        IDepartmentService _departmentService;
        IStaffFacultyService _sfService;
        public FacultyStaffForm(IStaffService staffService, IFacultyService facultyService, IDepartmentService departmentService
            ,IStaffFacultyService sfService)
        {
            InitializeComponent();
            _staffService = staffService;
            _facultyService = facultyService;
            _departmentService = departmentService;
            _sfService = sfService;
        }
        protected override void OnLoad(EventArgs e)
        {
            GetFaculties();
            GetStaffs();
        }
        private void GetFaculties()
        {
            comboFaculties.Items.AddRange(_facultyService.GetAll().Select(x => x.FacultyName).ToArray());
        }
        private void GetDepartments(string name)
        {
            var result = from f in _facultyService.GetAll()
                         join d in _departmentService.GetAll()
                         on f.FacultyName equals name
                         where f.FacultyId == d.FacultyId
                         select new Department
                         {
                             FacultyId = f.FacultyId,
                             DepartmentId = d.DepartmentId,
                             DepartmentName = d.DepartmentName
                         };
            comboDeps.Items.AddRange(result.Select(x => x.DepartmentName).ToArray());
        }
        private void GetStaffs()
        {
            dataGridView1.DataSource = _staffService.GetAll();
        }
        private void GetRowHeaderId()
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtStudentId.Text = id.ToString();
        }
        private void AddStaffFaculty(string depName)
        {
            var depInfo = _departmentService.GetByName(depName);
            var studentFaculty = new StaffFaculty
            {
                
                DepartmentId = depInfo.DepartmentId,
                StaffId = Convert.ToInt32(txtStudentId.Text),
            };
            _sfService.Add(studentFaculty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaffFaculty(comboDeps.GetItemText(comboDeps.SelectedItem));
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetRowHeaderId();
        }

        private void comboFaculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDepartments(comboFaculties.GetItemText(comboFaculties.SelectedItem));
        }
    }
}
