using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace PatientInformationSystemNew.forms
{
    public partial class frmCreatePrescription : Form
    {
        public frmCreatePrescription()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Diagnosis diagnosis = new functions.Diagnosis();
        functions.Symptoms symptoms = new functions.Symptoms();
        functions.Prescription prescription = new functions.Prescription();
        functions.Patient patient = new functions.Patient();

        private void frmCreatePrescription_Load(object sender, EventArgs e)
        {
            this.dateRecords.Value = DateTime.Now;
            diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosis);
            symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptoms);
            prescription.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptions);
        }

        private void dateRecords_ValueChanged(object sender, EventArgs e)
        {
            diagnosis.loadDiagnosisRecordsOfPatientByDate(val.PatientID, this.dateRecords.Value.Date, this.gridDiagnosis);
            symptoms.loadSymptomsRecordsOfPatientByDate(val.PatientID, this.dateRecords.Value.Date, this.gridSymptoms);
            prescription.loadPrescriptionRecordsOfPatientByDate(val.PatientID, this.dateRecords.Value.Date, this.gridPrescriptions);
        }

        private void gridPrescriptions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.gridPrescriptions.SelectedCells[1].Value = this.txtPrescriptionPreview.Text;
        }

        private void btnGeneratePrintNewPrescription_Click(object sender, EventArgs e)
        {
            this.rprtPrescription.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            if(String.IsNullOrWhiteSpace(val.PatientMiddleName))
            {
                parameters.Add(new ReportParameter("pFullName", string.Format("{0} {1}", val.PatientFirstName, val.PatientLastName)));
            }
            else
            {
                parameters.Add(new ReportParameter("pFullName", string.Format("{0} {1}. {2}", val.PatientFirstName, val.PatientMiddleName[0],
                    val.PatientLastName)));
            }
            parameters.Add(new ReportParameter("pAge", val.PatientAge.ToString()));
            parameters.Add(new ReportParameter("pSex", val.PatientGender.Substring(0, 1)));
            parameters.Add(new ReportParameter("pAddress", val.PatientAddress));
            parameters.Add(new ReportParameter("pDate", DateTime.Now.ToString("MM/dd/yy")));
            parameters.Add(new ReportParameter("pPrescription", this.txtCreateNewPrescription.Text));
            this.rprtPrescription.LocalReport.SetParameters(parameters);
            this.rprtPrescription.RefreshReport();
        }

        private void btnGeneratePrintPrescriptionPreview_Click(object sender, EventArgs e)
        {
            this.rprtPrescription.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            if (String.IsNullOrWhiteSpace(val.PatientMiddleName))
            {
                parameters.Add(new ReportParameter("pFullName", string.Format("{0} {1}", val.PatientFirstName, val.PatientLastName)));
            }
            else
            {
                parameters.Add(new ReportParameter("pFullName", string.Format("{0} {1}. {2}", val.PatientFirstName, val.PatientMiddleName[0], 
                    val.PatientLastName)));
            }
            parameters.Add(new ReportParameter("pAge", val.PatientAge.ToString()));
            parameters.Add(new ReportParameter("pSex", val.PatientGender.Substring(0, 1)));
            parameters.Add(new ReportParameter("pAddress", val.PatientAddress));
            parameters.Add(new ReportParameter("pDate", DateTime.Now.ToString("MM/dd/yy")));
            parameters.Add(new ReportParameter("pPrescription", this.txtPrescriptionPreview.Text));
            this.rprtPrescription.LocalReport.SetParameters(parameters);
            this.rprtPrescription.RefreshReport();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            var generateID = new StringBuilder();
            while(generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }

            if (String.IsNullOrWhiteSpace(this.txtCreateNewPrescription.Text))
            {
                MessageBox.Show("Please input prescription first before proceed!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCreateNewPrescription.Focus();
            }
            else if(patient.savePrescriptionAndTransferPatientToPatients(val.PatientID, generateID.ToString(), this.txtCreateNewPrescription.Text, 
                DateTime.Now, val.PatientFirstName, val.PatientMiddleName, val.PatientLastName, val.PatientGender, val.PatientAge, val.PatientAddress, 
                val.PatientBirthday, val.PatientCellphoneNumer, val.PatientTelephoneNumber, val.PatientEmail, val.PatientHeight, 
                val.PatientWeight, val.PatientTemperature, val.PatientPulseRate, val.PatientBloodPressure, val.PatientDoctor))
            {
                MessageBox.Show("Prescription successfully saved and patient successfully transfered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save prescription and transfer patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            forms.frmDashboard frmDashboard = new forms.frmDashboard();
            frmDashboard.Show();
            forms.frmSchedule frmSchedule = new forms.frmSchedule();
            frmSchedule.TopLevel = false;
            forms.frmDashboard dashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)dashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmSchedule);
            frmSchedule.Dock = DockStyle.Fill;
            frmSchedule.Show();
            this.Close();
        }
    }
}
