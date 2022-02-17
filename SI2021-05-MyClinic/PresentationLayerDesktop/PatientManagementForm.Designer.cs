﻿
namespace PresentationLayerDesktop
{
    partial class PatientManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientManagementForm));
            this.dataGridView_PatientList = new System.Windows.Forms.DataGridView();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_PersonalNumber = new System.Windows.Forms.Label();
            this.label_HealthInsuranceNumber = new System.Windows.Forms.Label();
            this.label_DateOfBirth = new System.Windows.Forms.Label();
            this.label_PlaceOfBirth = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.label_Weight = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_PersonalNumber = new System.Windows.Forms.TextBox();
            this.textBox_HealthInsuranceNumber = new System.Windows.Forms.TextBox();
            this.textBox_PlaceOfBirth = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.button_UpdatePatient = new System.Windows.Forms.Button();
            this.button_InsertPatient = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.dateTimePicker_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.button_InsertReport = new System.Windows.Forms.Button();
            this.button_ViewReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_PatientList
            // 
            this.dataGridView_PatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PatientList.Location = new System.Drawing.Point(24, 26);
            this.dataGridView_PatientList.Name = "dataGridView_PatientList";
            this.dataGridView_PatientList.RowHeadersWidth = 51;
            this.dataGridView_PatientList.RowTemplate.Height = 24;
            this.dataGridView_PatientList.Size = new System.Drawing.Size(1027, 444);
            this.dataGridView_PatientList.TabIndex = 0;
            this.dataGridView_PatientList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PatientList_CellClick);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.Location = new System.Drawing.Point(20, 500);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(85, 18);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastName.Location = new System.Drawing.Point(21, 527);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(84, 18);
            this.label_LastName.TabIndex = 2;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_PersonalNumber
            // 
            this.label_PersonalNumber.AutoSize = true;
            this.label_PersonalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PersonalNumber.Location = new System.Drawing.Point(21, 555);
            this.label_PersonalNumber.Name = "label_PersonalNumber";
            this.label_PersonalNumber.Size = new System.Drawing.Size(128, 18);
            this.label_PersonalNumber.TabIndex = 3;
            this.label_PersonalNumber.Text = "Personal Number:";
            // 
            // label_HealthInsuranceNumber
            // 
            this.label_HealthInsuranceNumber.AutoSize = true;
            this.label_HealthInsuranceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HealthInsuranceNumber.Location = new System.Drawing.Point(327, 496);
            this.label_HealthInsuranceNumber.Name = "label_HealthInsuranceNumber";
            this.label_HealthInsuranceNumber.Size = new System.Drawing.Size(179, 18);
            this.label_HealthInsuranceNumber.TabIndex = 4;
            this.label_HealthInsuranceNumber.Text = "Health Insurance Number:";
            // 
            // label_DateOfBirth
            // 
            this.label_DateOfBirth.AutoSize = true;
            this.label_DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateOfBirth.Location = new System.Drawing.Point(327, 525);
            this.label_DateOfBirth.Name = "label_DateOfBirth";
            this.label_DateOfBirth.Size = new System.Drawing.Size(94, 18);
            this.label_DateOfBirth.TabIndex = 5;
            this.label_DateOfBirth.Text = "Date of Birth:";
            // 
            // label_PlaceOfBirth
            // 
            this.label_PlaceOfBirth.AutoSize = true;
            this.label_PlaceOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlaceOfBirth.Location = new System.Drawing.Point(327, 553);
            this.label_PlaceOfBirth.Name = "label_PlaceOfBirth";
            this.label_PlaceOfBirth.Size = new System.Drawing.Size(100, 18);
            this.label_PlaceOfBirth.TabIndex = 6;
            this.label_PlaceOfBirth.Text = "Place of Birth:";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PhoneNumber.Location = new System.Drawing.Point(713, 492);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(112, 18);
            this.label_PhoneNumber.TabIndex = 8;
            this.label_PhoneNumber.Text = "Phone Number:";
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Weight.Location = new System.Drawing.Point(713, 521);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(58, 18);
            this.label_Weight.TabIndex = 9;
            this.label_Weight.Text = "Weight:";
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Height.Location = new System.Drawing.Point(713, 546);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(54, 18);
            this.label_Height.TabIndex = 10;
            this.label_Height.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(976, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(976, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "cm";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(159, 496);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(137, 22);
            this.textBox_FirstName.TabIndex = 13;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(159, 522);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(137, 22);
            this.textBox_LastName.TabIndex = 14;
            // 
            // textBox_PersonalNumber
            // 
            this.textBox_PersonalNumber.Location = new System.Drawing.Point(159, 551);
            this.textBox_PersonalNumber.Name = "textBox_PersonalNumber";
            this.textBox_PersonalNumber.Size = new System.Drawing.Size(137, 22);
            this.textBox_PersonalNumber.TabIndex = 15;
            // 
            // textBox_HealthInsuranceNumber
            // 
            this.textBox_HealthInsuranceNumber.Location = new System.Drawing.Point(548, 491);
            this.textBox_HealthInsuranceNumber.Name = "textBox_HealthInsuranceNumber";
            this.textBox_HealthInsuranceNumber.Size = new System.Drawing.Size(137, 22);
            this.textBox_HealthInsuranceNumber.TabIndex = 16;
            // 
            // textBox_PlaceOfBirth
            // 
            this.textBox_PlaceOfBirth.Location = new System.Drawing.Point(548, 548);
            this.textBox_PlaceOfBirth.Name = "textBox_PlaceOfBirth";
            this.textBox_PlaceOfBirth.Size = new System.Drawing.Size(137, 22);
            this.textBox_PlaceOfBirth.TabIndex = 17;
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(862, 488);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(137, 22);
            this.textBox_PhoneNumber.TabIndex = 19;
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(862, 513);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(108, 22);
            this.textBox_Weight.TabIndex = 20;
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(862, 542);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(108, 22);
            this.textBox_Height.TabIndex = 21;
            // 
            // button_UpdatePatient
            // 
            this.button_UpdatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_UpdatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdatePatient.ForeColor = System.Drawing.Color.White;
            this.button_UpdatePatient.Location = new System.Drawing.Point(247, 609);
            this.button_UpdatePatient.Name = "button_UpdatePatient";
            this.button_UpdatePatient.Size = new System.Drawing.Size(144, 47);
            this.button_UpdatePatient.TabIndex = 23;
            this.button_UpdatePatient.Text = "Update Patient";
            this.button_UpdatePatient.UseVisualStyleBackColor = false;
            this.button_UpdatePatient.Click += new System.EventHandler(this.button_UpdatePatient_Click);
            // 
            // button_InsertPatient
            // 
            this.button_InsertPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_InsertPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InsertPatient.ForeColor = System.Drawing.Color.White;
            this.button_InsertPatient.Location = new System.Drawing.Point(24, 609);
            this.button_InsertPatient.Name = "button_InsertPatient";
            this.button_InsertPatient.Size = new System.Drawing.Size(144, 47);
            this.button_InsertPatient.TabIndex = 24;
            this.button_InsertPatient.Text = "Insert New Patient";
            this.button_InsertPatient.UseVisualStyleBackColor = false;
            this.button_InsertPatient.Click += new System.EventHandler(this.button_InsertPatient_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.Location = new System.Drawing.Point(898, 609);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(144, 47);
            this.button_Close.TabIndex = 25;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // dateTimePicker_DateOfBirth
            // 
            this.dateTimePicker_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateOfBirth.Location = new System.Drawing.Point(548, 519);
            this.dateTimePicker_DateOfBirth.Name = "dateTimePicker_DateOfBirth";
            this.dateTimePicker_DateOfBirth.Size = new System.Drawing.Size(137, 22);
            this.dateTimePicker_DateOfBirth.TabIndex = 26;
            // 
            // button_InsertReport
            // 
            this.button_InsertReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_InsertReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InsertReport.ForeColor = System.Drawing.Color.White;
            this.button_InsertReport.Location = new System.Drawing.Point(472, 610);
            this.button_InsertReport.Name = "button_InsertReport";
            this.button_InsertReport.Size = new System.Drawing.Size(144, 47);
            this.button_InsertReport.TabIndex = 27;
            this.button_InsertReport.Text = "Insert Report";
            this.button_InsertReport.UseVisualStyleBackColor = false;
            this.button_InsertReport.Click += new System.EventHandler(this.button_InsertReport_Click);
            // 
            // button_ViewReport
            // 
            this.button_ViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button_ViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewReport.ForeColor = System.Drawing.Color.White;
            this.button_ViewReport.Location = new System.Drawing.Point(695, 609);
            this.button_ViewReport.Name = "button_ViewReport";
            this.button_ViewReport.Size = new System.Drawing.Size(144, 47);
            this.button_ViewReport.TabIndex = 28;
            this.button_ViewReport.Text = "View Reports";
            this.button_ViewReport.UseVisualStyleBackColor = false;
            this.button_ViewReport.Click += new System.EventHandler(this.button_ViewReport_Click);
            // 
            // PatientManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 673);
            this.Controls.Add(this.button_ViewReport);
            this.Controls.Add(this.button_InsertReport);
            this.Controls.Add(this.dateTimePicker_DateOfBirth);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_InsertPatient);
            this.Controls.Add(this.button_UpdatePatient);
            this.Controls.Add(this.textBox_Height);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.textBox_PlaceOfBirth);
            this.Controls.Add(this.textBox_HealthInsuranceNumber);
            this.Controls.Add(this.textBox_PersonalNumber);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Height);
            this.Controls.Add(this.label_Weight);
            this.Controls.Add(this.label_PhoneNumber);
            this.Controls.Add(this.label_PlaceOfBirth);
            this.Controls.Add(this.label_DateOfBirth);
            this.Controls.Add(this.label_HealthInsuranceNumber);
            this.Controls.Add(this.label_PersonalNumber);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.dataGridView_PatientList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Management";
            this.Load += new System.EventHandler(this.PatientManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_PatientList;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_PersonalNumber;
        private System.Windows.Forms.Label label_HealthInsuranceNumber;
        private System.Windows.Forms.Label label_DateOfBirth;
        private System.Windows.Forms.Label label_PlaceOfBirth;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label_Weight;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_PersonalNumber;
        private System.Windows.Forms.TextBox textBox_HealthInsuranceNumber;
        private System.Windows.Forms.TextBox textBox_PlaceOfBirth;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.Button button_UpdatePatient;
        private System.Windows.Forms.Button button_InsertPatient;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirth;
        private System.Windows.Forms.Button button_InsertReport;
        private System.Windows.Forms.Button button_ViewReport;
    }
}