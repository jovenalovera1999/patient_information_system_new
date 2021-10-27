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

        private void btnPrescription_Click(object sender, EventArgs e)
        {

        }
    }
}
