using Business.Abstract;
using DataAccess.Abstract;
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
    public partial class StudentAddCourseForm : Form
    {
        ICourseStudentService _sService;
        IStudentFacultyService _fService;
        IUserForStudentService _uSDal;
        IStudentService _stSetvice;
        public StudentAddCourseForm(ICourseStudentService sService, IStudentFacultyService fService, IUserForStudentService uSDal,
           IStudentService studentService)
        {
            InitializeComponent();
            _sService = sService;
            _fService = fService;
            _uSDal = uSDal;
            _stSetvice = studentService;
            
        }

        protected override void OnLoad(EventArgs e)
        {
            int id = _uSDal.GetStudentIdByUserId(UserInformation.UserId);
            var list = _sService.GetAllByDepId(_fService.GetDepartemntIdByStudentId(id));

            dataGridView1.DataSource = list;
            AddCheckbox();
        }
        private void AddCheckbox()
        {
            DataGridViewCheckBoxColumn dgvc = new DataGridViewCheckBoxColumn();
            dgvc.HeaderText = "Status";
            dgvc.DataPropertyName = "CourseStatus";
            dgvc.Name = "CourseStatus";
            dgvc.ValueType = typeof(bool);
            dataGridView1.Columns.Add(dgvc);
        }
        private void Save(CourseStudent courseSt)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //Update Edilecek
                courseSt.CourseId = Convert.ToInt32(dataGridView1.Rows[i].Cells["Id"].Value);
                courseSt.CourseStatus = Convert.ToBoolean(dataGridView1.Rows[i].Cells["CourseStatus"].Value);
                courseSt.CreatedDate = DateTime.Now;
                courseSt.StudentId = _stSetvice.GetStudentByUserId(UserInformation.UserId).StudentId;
                _sService.Add(courseSt);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Save(new CourseStudent());
        }
    }
}
