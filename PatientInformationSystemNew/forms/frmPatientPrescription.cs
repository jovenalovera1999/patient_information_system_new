using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PatientInformationSystemNew.forms
{
    public partial class frmPatientPrescription : Form
    {
        public frmPatientPrescription()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Diagnosis diagnosis = new functions.Diagnosis();
        functions.Symptoms symptoms = new functions.Symptoms();
        functions.Prescription prescriptions = new functions.Prescription();

        private void frmPatientPrescription_Load(object sender, EventArgs e)
        {
            diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosis);
            symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptoms);
            prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptions);
        }

        private void gridPrescriptions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtPrescriptionPreview.Text = this.gridPrescriptions.SelectedCells[1].Value.ToString();
            this.datePrescription.Value = DateTime.Parse(this.gridPrescriptions.SelectedCells[2].Value.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.btnEdit.Enabled = false;
            this.txtPrescriptionPreview.Enabled = true;
            this.datePrescription.Visible = true;
            this.btnUpdatePrescription.Visible = true;
            this.btnRemovePrescription.Visible = true;
            this.txtPrescriptionPreview.Focus();
        }

        private void btnUpdatePrescription_Click(object sender, EventArgs e)
        {
            if(prescriptions.updatePrescriptions(val.PatientID, this.gridPrescriptions.SelectedCells[0].Value.ToString(), 
                this.gridPrescriptions.SelectedCells[1].Value.ToString(), this.datePrescription.Value.Date))
            {
                MessageBox.Show("Prescription successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptions);
                this.txtPrescriptionPreview.Focus();
            }
            else
            {
                MessageBox.Show("Failed to update prescription!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemovePrescription_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this prescription? If yes, then this is your responsible if there is an issue!",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (prescriptions.removePrescriptions(val.PatientID, this.gridPrescriptions.SelectedCells[0].Value.ToString()))
                {
                    MessageBox.Show("Prescription successfully removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptions);
                    this.txtPrescriptionPreview.ResetText();
                    this.datePrescription.Value = DateTime.Now.Date;
                    this.txtPrescriptionPreview.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to remove prescription!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGeneratePrintPrescriptionPreview_Click(object sender, EventArgs e)
        {
            this.rprtPrescription.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pFullName", val.PatientFullName));
            parameters.Add(new ReportParameter("pAge", val.PatientAge.ToString()));
            parameters.Add(new ReportParameter(val.PatientGender.Substring(0, 1)));
            parameters.Add(new ReportParameter("pAddress", val.PatientAddress));
            parameters.Add(new ReportParameter("pDate", this.gridPrescriptions.SelectedCells[2].Value.ToString()));
            parameters.Add(new ReportParameter("pPrescription", this.gridPrescriptions.SelectedCells[1].Value.ToString()));
            this.rprtPrescription.LocalReport.SetParameters(parameters);
            this.rprtPrescription.RefreshReport();
        }
    }
}
