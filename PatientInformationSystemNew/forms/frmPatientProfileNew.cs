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
    public partial class frmPatientProfileNew : Form
    {
        public frmPatientProfileNew()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Diagnosis diagnosis = new functions.Diagnosis();
        functions.Symptoms symptoms = new functions.Symptoms();
        functions.Prescription prescriptions = new functions.Prescription();
        functions.Patient patient = new functions.Patient();

        private void frmPatientProfileNew_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 120; i++)
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
            diagnosis.loadDiagnosisRecordsOfPatient(this.txtPatientID.Text, this.gridDiagnosisRecords);
            symptoms.loadSymptomsRecordsOfPatient(this.txtPatientID.Text, this.gridSymptomsRecords);
            prescriptions.loadPrescriptionRecordsOfPatient(this.txtPatientID.Text, this.gridPrescriptionsRecords);
            diagnosis.loadDiagnosisRecordsOfPatient(this.txtPatientID.Text, this.gridManageDiagnosis);
            symptoms.loadSymptomsRecordsOfPatient(this.txtPatientID.Text, this.gridManageSymptoms);
            prescriptions.loadPrescriptionRecordsOfPatient(this.txtPatientID.Text, this.gridManagePrescriptions);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = true;
            this.txtMiddleName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.cmbGender.Enabled = true;
            this.cmbAge.Enabled = true;
            this.txtAddress.Enabled = true;
            this.dateBirthday.Enabled = true;
            this.txtCellphoneNumber.Enabled = true;
            this.txtTelephoneNumber.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtHeight.Enabled = true;
            this.txtWeight.Enabled = true;
            this.txtTemperature.Enabled = true;
            this.txtPulseRate.Enabled = true;
            this.txtBloodPressure.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnEdit.Enabled = false;
            this.txtFirstName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLastName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.cmbGender.Text))
            {
                MessageBox.Show("Gender is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbGender.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.cmbAge.Text))
            {
                MessageBox.Show("Age is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbAge.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAddress.Text))
            {
                MessageBox.Show("Address is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddress.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(this.txtTelephoneNumber.Text) &&
                String.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                MessageBox.Show("Contact information are required! Please input atleast one contact information", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCellphoneNumber.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtWeight.Text))
            {
                MessageBox.Show("Weight is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtWeight.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtTemperature.Text))
            {
                MessageBox.Show("Temperature is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTemperature.Focus();
            }
            else if (patient.updatePatient(this.txtPatientID.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text,
                this.cmbGender.Text, int.Parse(this.cmbAge.Text), this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text,
                this.txtTelephoneNumber.Text, this.txtEmail.Text, double.Parse(this.txtHeight.Text), double.Parse(this.txtWeight.Text),
                double.Parse(this.txtTemperature.Text), double.Parse(this.txtPulseRate.Text), double.Parse(this.txtBloodPressure.Text)))
            {
                MessageBox.Show("Patient successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(patient.getPatient(this.txtPatientID.Text))
                {
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
                }

                this.txtFirstName.Enabled = false;
                this.txtMiddleName.Enabled = false;
                this.txtLastName.Enabled = false;
                this.cmbGender.Enabled = false;
                this.cmbAge.Enabled = false;
                this.txtAddress.Enabled = false;
                this.dateBirthday.Enabled = false;
                this.txtCellphoneNumber.Enabled = false;
                this.txtTelephoneNumber.Enabled = false;
                this.txtEmail.Enabled = false;
                this.txtHeight.Enabled = false;
                this.txtWeight.Enabled = false;
                this.txtTemperature.Enabled = false;
                this.txtPulseRate.Enabled = false;
                this.txtBloodPressure.Enabled = false;
                this.btnEdit.Enabled = true;
                this.btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to update patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridManageDiagnosis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSelectedDiagnosis.Text = this.gridManageDiagnosis.SelectedCells[1].Value.ToString();
            this.dateSelectedDiagnosis.Value = DateTime.Parse(this.gridManageDiagnosis.SelectedCells[2].Value.ToString());
        }

        private void gridManageSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSelectedSymptom.Text = this.gridManageSymptoms.SelectedCells[1].Value.ToString();
            this.dateSelectedSymptom.Value = DateTime.Parse(this.gridManageSymptoms.SelectedCells[2].Value.ToString());
        }

        private void gridManagePrescriptions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSelectedPrescription.Text = this.gridManagePrescriptions.SelectedCells[1].Value.ToString();
            this.dateSelectedPrescription.Value = DateTime.Parse(this.gridManagePrescriptions.SelectedCells[2].Value.ToString());
        }
    }
}
