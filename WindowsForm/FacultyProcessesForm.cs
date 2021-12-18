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
    public partial class FacultyProcessesForm : Form
    {
        IFacultyService _facultyService;
        IDepartmentService _deparmentService;

        public FacultyProcessesForm(IFacultyService facultyService, IDepartmentService deparmentService)
        {
            InitializeComponent();
            _facultyService = facultyService;
            _deparmentService = deparmentService;
        }

       

        protected override void OnLoad(EventArgs e)
        {
            GetFaculties();
        }
        private void AddFaculty(Faculty faculty)
        {
            faculty.FacultyName = txtFaculty.Text;
            _facultyService.Add(faculty);
        }
        private void GetFaculties()
        {
            comboFaculties.Items.AddRange(_facultyService.GetAll().Select(x=> x.FacultyName).ToArray());
        }
        private void GetFaculty(string name)
        {
            txtFacultyId.Text = _facultyService.GetByName(name).FacultyId.ToString();
        }

        private void AddDepartment(int id)
        {
            var department = new Department
            {
                DepartmentName = txtDep.Text,
                FacultyId = id
            };
            _deparmentService.Add(department);
        }
        private void comboFaculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFaculty(comboFaculties.GetItemText(comboFaculties.SelectedItem));
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            AddFaculty(new Faculty());
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            AddDepartment(Convert.ToInt32(txtFacultyId.Text));
        }
    }
}
