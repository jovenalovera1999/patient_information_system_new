using System;
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
            this.txtPrescriptionPreview.Enabled = true;
            this.datePrescription.Enabled = true;
            this.btnUpdatePrescription.Enabled = true;
            this.btnRemovePrescription.Enabled = true;
            this.txtPrescriptionPreview.Focus();
        }
    }
}
