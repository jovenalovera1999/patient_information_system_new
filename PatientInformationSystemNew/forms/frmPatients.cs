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
    public partial class frmPatients : Form
    {
        public frmPatients()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void frmPatient_Load(object sender, EventArgs e)
        {
            patient.loadPatientsInPatients(this.gridPatients);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(patient.getPatientFromPatients(this.txtPatientID.Text))
            {
                forms.frmPatientProfile frmPatientProfile = new forms.frmPatientProfile();
                frmPatientProfile.Show();
                this.Close();
                Application.OpenForms["frmDashboard"].Close();
            }
        }

        private void btnPaymentTransaction_Click(object sender, EventArgs e)
        {
            forms.frmPaymentTransaction frmPaymentTransaction = new forms.frmPaymentTransaction();
            frmPaymentTransaction.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPaymentTransaction);
            frmPaymentTransaction.Dock = DockStyle.Fill;
            frmPaymentTransaction.Show();
            this.Close();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            forms.frmAddPatient frmAddPatient = new forms.frmAddPatient();
            frmAddPatient.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmAddPatient);
            frmAddPatient.Dock = DockStyle.Fill;
            frmAddPatient.Show();
            this.Close();
        }

        private void gridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPatients.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPatients.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtPatientID.Text = this.gridPatients.SelectedCells[0].Value.ToString();
            this.btnSelect.Enabled = true;
        }

        private void gridPatients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(patient.getPatientFromPatients(this.gridPatients.SelectedCells[0].Value.ToString()))
            {
                forms.frmPatientProfile frmPatientProfile = new forms.frmPatientProfile();
                frmPatientProfile.Show();
                this.Close();
                Application.OpenForms["frmDashboard"].Close();
            }
        }
    }
}