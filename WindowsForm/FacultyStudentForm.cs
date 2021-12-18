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
    public partial class FacultyStudentForm : Form
    {
        IStudentService _studetnService;
        IFacultyService _facultyService;
        IDepartmentService _departmentService;
        IStudentFacultyService _sFService;
        public FacultyStudentForm(IStudentService studentService)
        {
            InitializeComponent();
            _studetnService = studentService;

        }

        public FacultyStudentForm(IStudentService studetnService, IFacultyService facultyService, IDepartmentService departmentService
            ,IStudentFacultyService sFService) : this(studetnService)
        {
            _facultyService = facultyService;
            _departmentService = departmentService;
            _sFService = sFService;
        }

        protected override void OnLoad(EventArgs e)
        {
            customize();
            GetFaculties();
        }
        private void customize()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Student Id";
            dataGridView1.Columns[0].Name = "StudentId";
            dataGridView1.Columns[0].DataPropertyName = "StudentId";

            dataGridView1.Columns[1].HeaderText = "Student Name";
            dataGridView1.Columns[1].Name = "StudentName";
            dataGridView1.Columns[1].DataPropertyName = "StudentName";

            dataGridView1.Columns[2].HeaderText = "Student Surname";
            dataGridView1.Columns[2].Name = "StudentSurname";
            dataGridView1.Columns[2].DataPropertyName = "StudentSurname";

            dataGridView1.Columns[3].HeaderText = "Identity Number";
            dataGridView1.Columns[3].Name = "StudentIdentityNumber";
            dataGridView1.Columns[3].DataPropertyName = "StudentIdentityNumber";

            dataGridView1.Columns[4].HeaderText = "Student Number";
            dataGridView1.Columns[4].Name = "StudentNumber";
            dataGridView1.Columns[4].DataPropertyName = "StudentNumber";


            dataGridView1.DataSource = _studetnService.GetAll();

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetRowHeaderId();
        }
        private void GetRowHeaderId()
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtStudentId.Text = id.ToString();
        }
        private void AddStudentFaculty(string depName)
        {
            var depInfo = _departmentService.GetByName(depName);
            var studentFaculty = new StudentFaculty
            {
                DepartmentId = depInfo.DepartmentId,
                StudentId = Convert.ToInt32(txtStudentId.Text),
            };
            _sFService.Add(studentFaculty);
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

        private void comboFaculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDepartments(comboFaculties.GetItemText(comboFaculties.SelectedItem));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentFaculty(comboDeps.GetItemText(comboDeps.SelectedItem));
        }
    }
}

