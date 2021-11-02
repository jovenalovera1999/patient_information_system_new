﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientInformationSystemNew.forms
{
    public partial class frmDoctorsPatientsList : Form
    {
        public frmDoctorsPatientsList()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void frmDoctorsPatientsList_Load(object sender, EventArgs e)
        {
            patient.loadDoctorPatients(val.DoctorFirstName, val.DoctorLastName, val.DoctorSpecialization, this.gridPatients);
        }

        private void gridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPatients.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPatients.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            string first_name = this.gridPatients.SelectedCells[1].Value.ToString();
            string middle_name = this.gridPatients.SelectedCells[2].Value.ToString();
            string last_name = this.gridPatients.SelectedCells[3].Value.ToString();

            this.txtPatientID.Text = this.gridPatients.SelectedCells[0].Value.ToString();
            if(String.IsNullOrWhiteSpace(middle_name))
            {
                this.txtPatientName.Text = string.Format("{0} {1}", first_name, last_name);
            }
            else
            {
                this.txtPatientName.Text = string.Format("{0} {1}. {2}", first_name, middle_name, last_name);
            }
        }

        private void gridPatients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(patient.getPatient(this.gridPatients.SelectedCells[0].Value.ToString()))
            {
                forms.frmDoctorsPatientProfile frmDoctorsPatientProfile = new forms.frmDoctorsPatientProfile();
                frmDoctorsPatientProfile.Show();
                this.Close();
                Application.OpenForms["frmDashboard"].Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(patient.getPatient(this.txtPatientID.Text))
            {
                forms.frmDoctorsPatientProfile frmDoctorsPatientProfile = new forms.frmDoctorsPatientProfile();
                frmDoctorsPatientProfile.Show();
                this.Close();
                Application.OpenForms["frmDashboard"].Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            forms.frmDoctorProfile frmDoctorProfile = new forms.frmDoctorProfile();
            frmDoctorProfile.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmDoctorProfile);
            frmDoctorProfile.Dock = DockStyle.Fill;
            frmDoctorProfile.Show();
            this.Close();
        }
    }
}
