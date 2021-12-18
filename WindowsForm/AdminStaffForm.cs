using Business.Abstract;
using Core.Utilities.Results.Abstract;
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
    public partial class AdminStaffForm : Form
    {
        IStaffService _sService;
        private string text;
        public AdminStaffForm(IStaffService sService)
        {
            InitializeComponent();
            _sService = sService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = String.Format("Address: " + rTxtAddress.Text + "\n" + "Gender: " + (rFemale.Checked ? rFemale.Text : rMale.Text) + "\n" +
              "Identity Number: " + txtIdentity.Text + "\n" + "Name: " + txtName.Text + "\n" + "Surname: " + txtSurname.Text +
              "\n" + "Staff Number: " + txtStNumber.Text + "\n" + "Phone Number: " + txtPhone.Text + "\n" + "Status: " +
              (rActive.Checked ? rActive.Text : rPassive.Text)+"\n"+"Staff Type: "+txtType);
            var result = MessageBox.Show(text, "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var staffResult=Save();
                MessageBox.Show(staffResult.Message);
                Clear();

            }
            else
            {
                Clear();
            }
        }
        private IResult Save()
        {
           return _sService.Add(new Staff
            {
                StaffName = txtName.Text,
                StaffSurname = txtSurname.Text,
                StaffGender = rMale.Checked ? rMale.Text : rFemale.Text,
                StaffIdentityNumber = txtIdentity.Text,
                CreatedDate = DateTime.Now,
                StaffNumber = txtStNumber.Text,
                StaffStatus = rActive.Checked ? true : false,
                StaffAddress = rTxtAddress.Text,
                StaffPhoneNumber = txtPhone.Text,
                StaffType = txtType.Text
            });
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
            txtType.Clear();
        }
    }
}
