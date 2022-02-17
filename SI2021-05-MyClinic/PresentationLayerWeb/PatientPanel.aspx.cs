﻿using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class PatientPanel : System.Web.UI.Page
    {
        private IAdminBusiness adminBusiness;
        private IDoctorBusiness doctorBusiness;
        private IPatientBusiness patientBusiness;
        public PatientPanel() { }
        public PatientPanel(IAdminBusiness _adminBusiness)
        {
            adminBusiness = _adminBusiness;
        }
        public PatientPanel(IDoctorBusiness _doctorBusiness)
        {
            doctorBusiness = _doctorBusiness;
        }
        public PatientPanel(IPatientBusiness _patientBusiness)
        {
            patientBusiness = _patientBusiness;
        }
        public PatientPanel(IAdminBusiness _adminBusiness, IDoctorBusiness _doctorBusiness, IPatientBusiness _patientBusiness)
        {
            adminBusiness = _adminBusiness;
            doctorBusiness = _doctorBusiness;
            patientBusiness = _patientBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Patient"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            var patient = (Patient)Session["Patient"];
            TextBox_Id.Text = patient.Id.ToString();
            TextBox_FirstName.Text = patient.FirstName;
            TextBox_LastName.Text = patient.LastName;
            TextBox_PersonalNumber.Text = patient.PersonalNumber;
            TextBox_HealthInsuranceNumber.Text = patient.HealthInsuranceNumber;
            TextBox_PhoneNumber.Text = patient.PhoneNumber;
            TextBox_DateOfBirth.Text = patient.DateOfBirth.ToString();
            TextBox_PlaceOfBirth.Text = patient.PlaceOfBirth;
            TextBox_Email.Text = patient.Email;
            TextBox_Weight.Text = patient.Weight;
            TextBox_Height.Text = patient.Height;
        }

        protected void Button_Logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        protected void Button_CalculateBMI_Click(object sender, EventArgs e)
        {
            if (TextBox_Height.Text == "" || TextBox_Weight.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to weight and height')", true);
            }
            else
            {
                string result = patientBusiness.CalculateBMI(TextBox_Weight.Text, TextBox_Height.Text);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + result + "')", true);
            }
        }
        protected void Button_UpdateSelf_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Management.aspx");
        }

        protected void Button_ShowReports_Click(object sender, EventArgs e)
        {
            if (TextBox_Id.Text == "" || TextBox_FirstName.Text == "" || TextBox_LastName.Text == "" || TextBox_PersonalNumber.Text == "" ||
                TextBox_PhoneNumber.Text == "" || TextBox_HealthInsuranceNumber.Text == "" || TextBox_PlaceOfBirth.Text == "" ||
                TextBox_DateOfBirth.Text == "" || TextBox_Weight.Text == "" || TextBox_Height.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('You have to select a patient!')", true);
            }
            else
            {
                var patient  = (Patient)Session["Patient"];
                patient.Id = Convert.ToInt32(TextBox_Id.Text);

                TextBox_ViewReports.Visible = true;
                List<string> reportList = patientBusiness.GetReportData(patient.Id);

                foreach (String s in reportList)
                {
                    TextBox_ViewReports.Text = String.Join(Environment.NewLine, reportList);
                }
            }
        }
    }
}