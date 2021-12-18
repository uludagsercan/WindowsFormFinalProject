using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete.Entity;
using FluentValidation;
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
    public partial class AdminStudentForm : Form
    {
        IStudentService _stService;
        //;
        private string text;
        public AdminStudentForm(IStudentService studentService)
        {
            InitializeComponent();
            _stService = studentService;
        }

        private void AdminStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = String.Format("Address: " + rTxtAddress.Text + "\n" + "Gender: " + (rFemale.Checked ? rFemale.Text : rMale.Text) + "\n" +
              "Identity Number: " + txtIdentity.Text + "\n" + "Name: " + txtName.Text + "\n" + "Surname: " + txtSurname.Text +
              "\n" + "Student Number: " + txtStNumber.Text + "\n" + "Phone Number: " + txtPhone.Text + "\n" + "Status: " +
              (rActive.Checked ? rActive.Text : rPassive.Text));
            var result = MessageBox.Show(text, "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Save(new Student());
              
                Clear();
            }
            else
            {
                Clear();
            }

        }

        private void Save(Student student)
        {
            string errorsText="";
            try
            {
                student.StudentIdentityNumber = txtIdentity.Text;
                student.StudentMail = txtMail.Text;
                student.StudentName = txtName.Text;
                student.StudentSurname = txtSurname.Text;
                student.StudentStatus = rActive.Checked ? true : false;
                student.StudentGender = rFemale.Checked ? rFemale.Text : rMale.Text;
                student.StudentNumber = txtStNumber.Text;
                student.StudentAddress = rTxtAddress.Text;
                student.StudentPhoneNumber = txtPhone.Text;
                student.CreatedDate = DateTime.Now;
                var saved = _stService.Add(student);
                MessageBox.Show(saved.Message);

            }
            catch (ValidationException e)
            {
               
                
                foreach (var item in e.Errors)
                {
                    errorsText += item.ErrorMessage.ToString();
                    errorsText += "\n";
                }
                //  listBox1.Items.AddRange(e.Errors.ToArray());
                MessageBox.Show(errorsText);
            }
           
            
            
        }
        private void Clear()
        {
            rTxtAddress.Clear();
            txtIdentity.Clear();
            txtName.Clear();
            txtStNumber.Clear();
            txtPhone.Clear();
            txtSurname.Clear();
            txtMail.Clear();

        }
    }
}
