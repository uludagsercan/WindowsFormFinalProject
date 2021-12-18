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
    public partial class AdminForm : Form
    {
        IAdministratorService _aService;
        private string text;
        public AdminForm(IAdministratorService service)
        {

            InitializeComponent();
            _aService = service;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private IResult Save()
        {
          
            return _aService.Add(new Administrator
            {
                AdministratorAddress=rTxtAddress.Text,
                AdministratorGender=rFemale.Checked? rFemale.Text:rMale.Text,
                AdministratorIdentityNumber=txtIdentity.Text,
                AdministratorName=txtName.Text,
                AdministratorNumber=txtAdNumber.Text,
                AdministratorPhoneNumber=txtPhone.Text,
                AdministratorStatus=rActive.Checked ?true : false,
                AdministratorSurname=txtSurname.Text,
                AdministratorEmail=txtMail.Text,
                CreatedDate=DateTime.Now
            });
        }
        private void Clear()
        {
            rTxtAddress.Clear();
            txtIdentity.Clear();
            txtName.Clear();
            txtAdNumber.Clear();
            txtPhone.Clear();
            txtSurname.Clear();
            txtMail.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = String.Format("Address: " + rTxtAddress.Text + "\n" + "Gender: " + (rFemale.Checked ? rFemale.Text : rMale.Text) + "\n" +
              "Identity Number: " + txtIdentity.Text + "\n" + "Name: " + txtName.Text + "\n" + "Surname: " + txtSurname.Text +
              "\n" + "Administrator Number: " + txtAdNumber.Text + "\n" + "Phone Number: " + txtPhone.Text + "\n" + "Status: " +
              (rActive.Checked ? rActive.Text : rPassive.Text));
            var result = MessageBox.Show(text, "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                var adminResult=Save();
                MessageBox.Show(adminResult.Message);
                Clear();
            }
            else
            {
                Clear();
            }
            
            
        }
    }
}
