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

        void autoGenNum()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while(generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtAddDiagnosisID.Text = generateID.ToString();
            this.txtAddSymptomID.Text = generateID.ToString();
            this.txtAddPrescriptionID.Text = generateID.ToString();
        }

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

            this.txtSelectedDiagnosis.Enabled = true;
            this.dateSelectedDiagnosis.Enabled = true;
        }

        private void gridManageSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSelectedSymptom.Text = this.gridManageSymptoms.SelectedCells[1].Value.ToString();
            this.dateSelectedSymptom.Value = DateTime.Parse(this.gridManageSymptoms.SelectedCells[2].Value.ToString());

            this.txtSelectedSymptom.Enabled = true;
            this.dateSelectedSymptom.Enabled = true;
        }

        private void gridManagePrescriptions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSelectedPrescription.Text = this.gridManagePrescriptions.SelectedCells[1].Value.ToString();
            this.dateSelectedPrescription.Value = DateTime.Parse(this.gridManagePrescriptions.SelectedCells[2].Value.ToString());

            this.txtSelectedPrescription.Enabled = true;
            this.dateSelectedPrescription.Enabled = true;
        }

        private void btnNewDiagnosis_Click(object sender, EventArgs e)
        {
            this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtAddDiagnosisID.Enabled = true;
            this.txtAddDiagnosis.Enabled = true;

            this.txtAddDiagnosis.Focus();
        }

        private void btnNewSymptom_Click(object sender, EventArgs e)
        {
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtAddSymptomID.Enabled = true;
            this.txtAddSymptom.Enabled = true;

            this.txtAddSymptom.Focus();
        }

        private void btnNewPrescription_Click(object sender, EventArgs e)
        {
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtAddPrescriptionID.Enabled = true;
            this.txtAddPrescription.Enabled = true;

            this.txtAddPrescription.Focus();
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            if(diagnosis.addDiagnosis(val.PatientID, this.txtAddDiagnosisID.Text, this.txtAddDiagnosis.Text, this.dateAddDiagnosis.Value.Date))
            {
                autoGenNum();
                this.txtAddDiagnosis.ResetText();
                this.txtAddDiagnosis.Focus();
                diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosisRecords);
                diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridManageDiagnosis);
            }
        }

        private void btnAddSymptom_Click(object sender, EventArgs e)
        {
            if(symptoms.addPatientSymptom(val.PatientID, this.txtAddSymptomID.Text, this.txtAddSymptom.Text, this.dateAddSymptom.Value.Date))
            {
                autoGenNum();
                this.txtAddSymptom.ResetText();
                this.txtAddSymptom.Focus();
                symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptomsRecords);
                symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridManageSymptoms);
            }
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            if(prescriptions.addPrescription(val.PatientID, this.txtAddPrescriptionID.Text, this.txtAddPrescription.Text, 
                this.dateAddPrescription.Value.Date))
            {
                autoGenNum();
                this.txtAddPrescription.ResetText();
                this.txtAddPrescription.Focus();
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptionsRecords);
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridManagePrescriptions);
            }
        }

        private void btnUpdateDiagnosis_Click(object sender, EventArgs e)
        {
            if(diagnosis.updateDiagnosis(val.PatientID, this.gridManageDiagnosis.SelectedCells[0].Value.ToString(), this.txtSelectedDiagnosis.Text,
                this.dateSelectedDiagnosis.Value.Date))
            {
                MessageBox.Show(string.Format("{0} updated into {1} successfully!", this.gridManageDiagnosis.SelectedCells[1].Value.ToString(),
                    this.txtSelectedDiagnosis.Text), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosisRecords);
                diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridManageDiagnosis);
                this.txtSelectedDiagnosis.ResetText();
                this.dateSelectedDiagnosis.Value = DateTime.Now.Date;
                this.txtSelectedDiagnosis.Enabled = false;
                this.dateSelectedDiagnosis.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to update {0}!", this.gridManageDiagnosis.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSymptom_Click(object sender, EventArgs e)
        {
            if (symptoms.updateSymptom(val.PatientID, this.gridManageSymptoms.SelectedCells[0].Value.ToString(), this.txtSelectedSymptom.Text,
                this.dateSelectedSymptom.Value.Date))
            {
                MessageBox.Show(string.Format("{0} updated into {1} successfully!", this.gridManageSymptoms.SelectedCells[1].Value.ToString(),
                    this.txtSelectedSymptom.Text), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridManageSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManageSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptomsRecords);
                symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridManageSymptoms);
                this.txtSelectedSymptom.ResetText();
                this.dateSelectedSymptom.Value = DateTime.Now.Date;
                this.txtSelectedSymptom.Enabled = false;
                this.dateSelectedSymptom.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to update {0}!", this.gridManageSymptoms.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePrescription_Click(object sender, EventArgs e)
        {
            if (prescriptions.updatePrescriptions(val.PatientID, this.gridManagePrescriptions.SelectedCells[0].Value.ToString(), 
                this.txtSelectedPrescription.Text, this.dateSelectedPrescription.Value.Date))
            {
                MessageBox.Show(string.Format("{0} updated into {1} successfully!", this.gridManagePrescriptions.SelectedCells[1].Value.ToString(),
                    this.txtSelectedPrescription.Text), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptionsRecords);
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridManagePrescriptions);
                this.txtSelectedPrescription.ResetText();
                this.dateSelectedPrescription.Value = DateTime.Now.Date;
                this.txtSelectedPrescription.Enabled = false;
                this.dateSelectedPrescription.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to update {0}!", this.gridManagePrescriptions.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveDiagnosis_Click(object sender, EventArgs e)
        {
            if(diagnosis.removeDiagnosis(val.PatientID, this.gridManageDiagnosis.SelectedCells[0].Value.ToString()))
            {
                MessageBox.Show(string.Format("{0} successfully removed or deleted!", this.gridManageDiagnosis.SelectedCells[1].Value.ToString()),
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosisRecords);
                diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridManageDiagnosis);
                this.txtSelectedDiagnosis.ResetText();
                this.dateSelectedDiagnosis.Value = DateTime.Now.Date;
                this.txtSelectedDiagnosis.Enabled = false;
                this.dateSelectedDiagnosis.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to remove or delete {0}!", this.gridManageDiagnosis.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSymptom_Click(object sender, EventArgs e)
        {
            if (symptoms.deleteSymptom(val.PatientID, this.gridManageSymptoms.SelectedCells[0].Value.ToString()))
            {
                MessageBox.Show(string.Format("{0} successfully removed or deleted!", this.gridManageSymptoms.SelectedCells[1].Value.ToString()),
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridManageSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManageSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptomsRecords);
                symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridManageSymptoms);
                this.txtSelectedSymptom.ResetText();
                this.dateSelectedSymptom.Value = DateTime.Now.Date;
                this.txtSelectedSymptom.Enabled = false;
                this.dateSelectedSymptom.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to remove or delete {0}!", this.gridManageSymptoms.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemovePrescription_Click(object sender, EventArgs e)
        {
            if (prescriptions.removePrescriptions(val.PatientID, this.gridManagePrescriptions.SelectedCells[0].Value.ToString()))
            {
                MessageBox.Show(string.Format("{0} successfully removed or deleted!", this.gridManagePrescriptions.SelectedCells[1].Value.ToString()),
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptionsRecords);
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridManagePrescriptions);
                this.txtSelectedPrescription.ResetText();
                this.dateSelectedPrescription.Value = DateTime.Now.Date;
                this.txtSelectedPrescription.Enabled = false;
                this.dateSelectedPrescription.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to remove or delete {0}!", this.gridManagePrescriptions.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
