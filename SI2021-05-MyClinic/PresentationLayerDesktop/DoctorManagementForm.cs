﻿using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerDesktop
{
    public partial class DoctorManagementForm : Form
    {
        private readonly IAdminBusiness adminBusiness;
        public DoctorManagementForm(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
            InitializeComponent();
        }

        private void DoctorManagementForm_Load(object sender, EventArgs e)
        {
            List<Doctor> doctorList = adminBusiness.GetAllDoctors();
            dataGridView_DoctorList.DataSource = doctorList;
        }
        public AdminForm RefAdminForm { get; set; }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.RefAdminForm.Show();
            this.Close();
            RefAdminForm.Refresh();
        }

        private void dataGridView_DoctorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dataGridView_DoctorList.Rows[e.RowIndex];
                textBox_Id.Text = row.Cells[0].Value.ToString();
                if(row.Cells[1].Value.ToString() == "True")
                    comboBox_Status.SelectedIndex = 0;
                else
                    comboBox_Status.SelectedIndex = 1;
                textBox_FirstName.Text = row.Cells[2].Value.ToString();
                textBox_LastName.Text = row.Cells[3].Value.ToString();
                textBox_PersonalNumber.Text = row.Cells[4].Value.ToString();
                textBox_PhoneNumber.Text = row.Cells[5].Value.ToString();
                textBox_DateEmployed.Text = row.Cells[6].Value.ToString();
                textBox_Specialization.Text = row.Cells[7].Value.ToString();
                textBox_Department.Text = row.Cells[8].Value.ToString();
                textBox_Email.Text = row.Cells[9].Value.ToString();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "" || textBox_LastName.Text == "" || textBox_PersonalNumber.Text == "" ||
                textBox_PhoneNumber.Text == "" || textBox_Specialization.Text == "" || textBox_Department.Text == "" ||
                textBox_Email.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                MessageBox.Show("E-mail entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Focus();
                return;
            }
            else if (!Regex.Match(textBox_FirstName.Text, @"^[A-Z]+[A-Za-z\s]{1,15}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("First name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_LastName.Text, @"^[A-Z]+[A-Za-z\s-]{1,30}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("Last name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_LastName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_PhoneNumber.Text, @"^[0][6]\d{7,8}$").Success)
            {
                MessageBox.Show("Phone number entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PhoneNumber.Focus();
                return;
            }
            else if (!Regex.Match(textBox_PersonalNumber.Text, @"^(\d{13})?$").Success)
            {
                MessageBox.Show("Personal number entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PersonalNumber.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Specialization.Text, @"^[a-zA-Z\s]{1,30}$").Success)
            {
                MessageBox.Show("Specialization cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Specialization.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Department.Text, @"^[a-zA-Z\s]{1,20}$").Success)
            {
                MessageBox.Show("Department cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Department.Focus();
                return;
            }
            Doctor doctor = new Doctor();
            doctor.Id = Convert.ToInt32(textBox_Id.Text);
            doctor.FirstName = textBox_FirstName.Text;
            doctor.LastName = textBox_LastName.Text;
            doctor.PersonalNumber = textBox_PersonalNumber.Text;
            doctor.PhoneNumber = textBox_PhoneNumber.Text;
            doctor.Specialization = textBox_Specialization.Text;
            doctor.Department = textBox_Department.Text;
            doctor.DateEmployed = DateTime.Parse(textBox_DateEmployed.Text);
            doctor.Email = textBox_Email.Text;
            if (comboBox_Status.SelectedItem.ToString() == "Active")
                    doctor.Status = true;
                else
                    doctor.Status = false;
            List<Doctor> temp = adminBusiness.GetAllDoctors().Where(doc => doc.Id == Convert.ToInt32(textBox_Id.Text)).ToList();
            doctor.Password = temp[0].Password;
            string result = adminBusiness.UpdateDoctor(doctor);
            MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView_DoctorList.DataSource = adminBusiness.GetAllDoctors();
        }

        private void button_InsertNewDoctor_Click(object sender, EventArgs e)
        {
            InsertDoctorForm insertDoctorForm = new InsertDoctorForm(adminBusiness);
            insertDoctorForm.RefDoctorManagementForm = this;
            insertDoctorForm.FormClosed += new FormClosedEventHandler(FormClose);
            insertDoctorForm.Show();
        }
        private void FormClose(object sender, EventArgs e)
        {
            dataGridView_DoctorList.DataSource = adminBusiness.GetAllDoctors();
            this.Refresh();
        }
    }
}
