﻿using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerDesktop
{
    public partial class ReportViewForm : Form
    {
        IPatientBusiness patientBusiness;
        Patient patient;
        Doctor doctor;
        public ReportViewForm(IPatientBusiness _patientBusiness, Patient _patient, Doctor _doctor)
        {
            patientBusiness = _patientBusiness;
            patient = _patient;
            doctor = _doctor;
            InitializeComponent();
        }
        public PatientManagementForm RefPatientManagementForm { get; set; }
        public PatientForm RefPatientForm { get; set; }

        private void ReportViewForm_Load(object sender, EventArgs e)
        {
            textBox_PatientFullName.Text = patient.FirstName + " " + patient.LastName;
            textBox_PatientPersonalNumber.Text = patient.PersonalNumber;
            listBox_ReportList.HorizontalScrollbar = true;
            List<string> reportList = patientBusiness.GetReportData(patient.Id);
            for (int i = 0; i < reportList.Count(); i++)
            {
                listBox_ReportList.Items.Add(reportList[i]);
            }


        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            if (doctor == null)
            {
                this.RefPatientForm.Show();
            }
            else
            {
                this.RefPatientManagementForm.Show();
            }
            this.Close();
        }
    }
}
