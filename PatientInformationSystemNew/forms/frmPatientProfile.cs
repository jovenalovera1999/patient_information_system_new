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
    public partial class frmPatientProfile : Form
    {
        public frmPatientProfile()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Diagnosis diagnosis = new functions.Diagnosis();
        functions.Symptoms symptoms = new functions.Symptoms();

        private void frmPatientProfile_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }
            this.txtPatientID.Text = val.PatientID;
            this.txtFirstName.Text = val.PatientFirstName;
            this.txtMiddleName.Text = val.PatientMiddleName;
            this.txtLastName.Text = val.PatientLastName;
            this.cmbGender.Text = val.PatientGender;
            this.cmbAge.Text = val.PatientAge.ToString();
            this.txtAddress.Text = val.PatientAddress;
            this.dateBirthday.Value = val.PatientBirthday;
            this.txtCellphoneNumber.Text = val.PatientCellphoneNumer;
            this.txtTelephoneNumber.Text = val.PatientTelephoneNumber;
            this.txtEmail.Text = val.PatientEmail;
            this.txtHeight.Text = val.PatientHeight.ToString();
            this.txtWeight.Text = val.PatientWeight.ToString();
            this.txtTemperature.Text = val.PatientTemperature.ToString();
            this.txtPulseRate.Text = val.PatientPulseRate.ToString();
            this.txtBloodPressure.Text = val.PatientBloodPressure.ToString();
            this.cmbDoctorName.Text = val.PatientDoctor;
            diagnosis.loadDiagnosisRecordsOfPatient(this.txtPatientID.Text, this.gridDiagnosis);
            symptoms.loadSymptomsRecordsOfPatient(this.txtPatientID.Text, this.gridSymptoms);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            forms.frmDashboard frmDashboard = new forms.frmDashboard();
            frmDashboard.Show();
            forms.frmPatients frmPatients = new forms.frmPatients();
            frmPatients.TopLevel = false;
            forms.frmDashboard dashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)dashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatients);
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
            this.Close();
        }

        private void btnManageDiagnosis_Click(object sender, EventArgs e)
        {
            forms.frmManageDiagnosisSymptoms frmManageDiagnosis = new forms.frmManageDiagnosisSymptoms();
            frmManageDiagnosis.Show();
        }

        private void btnManageSymptoms_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
