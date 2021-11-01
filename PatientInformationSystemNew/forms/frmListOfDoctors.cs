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
    public partial class frmListOfDoctors : Form
    {
        public frmListOfDoctors()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Doctor doctor = new functions.Doctor();

        private void frmListOfDoctors_Load(object sender, EventArgs e)
        {
            doctor.loadDoctors(this.gridDoctors);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(doctor.getDoctor(this.txtDoctorID.Text))
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

        private void btnMedicalStaff_Click(object sender, EventArgs e)
        {

        }

        private void gridDoctors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridDoctors.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridDoctors.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            string first_name = this.gridDoctors.SelectedCells[1].Value.ToString();
            string middle_name = this.gridDoctors.SelectedCells[2].Value.ToString();
            string last_name = this.gridDoctors.SelectedCells[3].Value.ToString();

            this.txtDoctorID.Text = this.gridDoctors.SelectedCells[0].Value.ToString();
            if(String.IsNullOrWhiteSpace(middle_name))
            {
                this.txtDoctorName.Text = string.Format("{0} {1}", first_name, last_name);
            }
            else
            {
                this.txtDoctorName.Text = string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name);
            }
        }

        private void gridDoctors_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (doctor.getDoctor(this.gridDoctors.SelectedCells[0].Value.ToString()))
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
}
