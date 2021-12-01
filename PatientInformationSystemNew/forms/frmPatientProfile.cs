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
using MySql.Data.MySqlClient;

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
        functions.Prescription prescriptions = new functions.Prescription();
        functions.Patient patient = new functions.Patient();
        functions.PaymentTransactions payment = new functions.PaymentTransactions();
        functions.Duplicate duplicate = new functions.Duplicate();
        functions.VitalSigns vital_signs = new functions.VitalSigns();
        functions.Doctor doctor = new functions.Doctor();

        void DoctorsName()
        {
            string sql = @"SELECT CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ')')
                            FROM pis_db.users
                            WHERE CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Doctor'";
            MySqlConnection connection = new MySqlConnection(con.conString());
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader myReader;

            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string doctors_name = myReader.GetString("CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ')')");
                    this.cmbNameDoctors.Items.Add(doctors_name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error filling doctors name: " + ex.ToString());
            }
        }

        void AutoGenNumVitalSigns()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while(generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtVitalSignsID.Text = generateID.ToString();
        }

        void AutoGenNumDoctor()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtIDDoctors.Text = generateID.ToString();
        }

        void AutoGenNumDiagnosis()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtDiagnosisID.Text = generateID.ToString();
        }

        void AutoGenNumSymptoms()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtSymptomsID.Text = generateID.ToString();
        }

        void AutoGenNumPrescription()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtPrescriptionsID.Text = generateID.ToString();
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
            this.txtGender.Text = val.PatientGender;
            this.txtAge.Text = val.PatientAge;
            this.cmbGender.Text = val.PatientGender;
            this.cmbAge.Text = val.PatientAge;
            this.txtAddress.Text = val.PatientAddress;
            this.txtBirthday.Text = val.PatientBirthday.ToString("D");
            this.dateBirthday.Value = val.PatientBirthday;
            this.txtCellphoneNumber.Text = val.PatientCellphoneNumer;
            this.txtTelephoneNumber.Text = val.PatientTelephoneNumber;
            this.txtEmail.Text = val.PatientEmail;
            this.txtFullName.Text = val.PatientFullName;
            this.cmbDiscount.Text = "None";

            vital_signs.LoadVitalSigns(val.PatientFullName, this.gridVitalSigns);
            doctor.LoadPatientDoctor(val.PatientFullName, this.gridDoctorsRecords);
            diagnosis.LoadDiagnosisRecordsOfPatient(val.PatientFullName, this.gridDiagnosis);
            symptoms.LoadSymptomsRecordsOfPatient(val.PatientFullName, this.gridSymptoms);
            prescriptions.LoadPrescriptionRecordsOfPatient(val.PatientFullName, this.gridPrescriptions);
            prescriptions.LoadPrescriptionRecordsOfPatient(val.PatientFullName, this.gridPrintPrescription);

            DoctorsName();

            this.dateVitalSigns.Value = DateTime.Now.Date;
            this.dateDoctors.Value = DateTime.Now.Date;
            this.dateDiagnosis.Value = DateTime.Now.Date;
            this.dateSymptoms.Value = DateTime.Now.Date;
            this.datePrescriptions.Value = DateTime.Now.Date;
        }

        // Cell Mouse Click Once

        private void gridVitalSigns_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridVitalSigns.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridVitalSigns.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtVitalSignsID.Text = this.gridVitalSigns.SelectedCells[0].Value.ToString();
            this.txtHeight.Text = this.gridVitalSigns.SelectedCells[1].Value.ToString();
            this.txtWeight.Text = this.gridVitalSigns.SelectedCells[2].Value.ToString();
            this.txtTemperature.Text = this.gridVitalSigns.SelectedCells[3].Value.ToString();
            this.txtPulseRate.Text = this.gridVitalSigns.SelectedCells[4].Value.ToString();
            this.txtBloodPressure.Text = this.gridVitalSigns.SelectedCells[5].Value.ToString();
            this.dateVitalSigns.Value = DateTime.Parse(this.gridVitalSigns.SelectedCells[6].Value.ToString());

            this.btnEditVitalSigns.Enabled = true;
        }

        private void gridDoctorsRecords_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridDoctorsRecords.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridDoctorsRecords.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtIDDoctors.Text = this.gridDoctorsRecords.SelectedCells[0].Value.ToString();
            this.cmbNameDoctors.Text = this.gridDoctorsRecords.SelectedCells[2].Value.ToString();
            this.dateDoctors.Value = DateTime.Parse(this.gridDoctorsRecords.SelectedCells[3].Value.ToString());

            this.btnEditDoctors.Enabled = true;
        }

        private void gridDiagnosis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtDiagnosisID.Text = this.gridDiagnosis.SelectedCells[0].Value.ToString();
            this.txtDiagnosis.Text = this.gridDiagnosis.SelectedCells[1].Value.ToString();
            this.dateDiagnosis.Value = DateTime.Parse(this.gridDiagnosis.SelectedCells[2].Value.ToString());

            this.btnEditDiagnosis.Enabled = true;
        }

        private void gridSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSymptomsID.Text = this.gridSymptoms.SelectedCells[0].Value.ToString();
            this.txtSymptoms.Text = this.gridSymptoms.SelectedCells[1].Value.ToString();
            this.dateSymptoms.Value = DateTime.Parse(this.gridSymptoms.SelectedCells[2].Value.ToString());

            this.btnEditSymptoms.Enabled = true;
        }

        private void gridPrescriptions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtPrescriptionsID.Text = this.gridPrescriptions.SelectedCells[0].Value.ToString();
            this.txtPrescriptions.Text = this.gridPrescriptions.SelectedCells[1].Value.ToString();

            this.btnEditPrescriptions.Enabled = true;
        }

        // Edit

        private void btnEditPersonalInfo_Click(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = true;
            this.txtMiddleName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.cmbGender.Visible = true;
            this.cmbAge.Visible = true;
            this.txtAddress.Enabled = true;
            this.dateBirthday.Visible = true;
            this.txtCellphoneNumber.Enabled = true;
            this.txtTelephoneNumber.Enabled = true;
            this.txtEmail.Enabled = true;
            this.btnSavePersonalInfo.Enabled = true;

            this.txtGender.Visible = false;
            this.txtAge.Visible = false;
            this.txtBirthday.Visible = false;
            this.btnEditPersonalInfo.Enabled = false;
        }

        private void btnEditVitalSigns_Click(object sender, EventArgs e)
        {
            this.btnAddVitalSigns.Visible = false;
            this.btnCancelVitalSigns.Visible = false;

            this.txtHeight.Enabled = true;
            this.txtWeight.Enabled = true;
            this.txtTemperature.Enabled = true;
            this.txtPulseRate.Enabled = true;
            this.txtBloodPressure.Enabled = true;
            this.dateVitalSigns.Enabled = true;

            this.btnSaveVitalSigns.Visible = true;
            this.btnRemoveVitalSigns.Visible = true;

            this.btnNewVitalSigns.Enabled = true;
            this.btnEditVitalSigns.Enabled = false;

            this.txtHeight.Focus();
        }

        private void btnEditDoctors_Click(object sender, EventArgs e)
        {
            this.btnAddDoctor.Visible = false;
            this.btnCancelDoctors.Visible = false;

            this.cmbNameDoctors.Enabled = true;
            this.dateDoctors.Enabled = true;

            this.btnSaveDoctors.Visible = true;
            this.btnRemoveVitalSigns.Visible = true;

            this.btnNewDoctors.Enabled = true;
            this.btnEditDoctors.Enabled = false;

            this.cmbNameDoctors.Focus();
        }

        private void btnEditDiagnosis_Click(object sender, EventArgs e)
        {
            this.btnAddDiagnosis.Visible = false;
            this.btnCancelDiagnosis.Visible = false;

            this.txtDiagnosis.Enabled = true;
            this.dateDiagnosis.Enabled = true;

            this.btnSaveDiagnosis.Visible = true;
            this.btnRemoveDiagnosis.Visible = true;

            this.btnNewDiagnosis.Enabled = true;
            this.btnEditDiagnosis.Enabled = false;

            this.txtDiagnosis.Focus();
        }

        private void btnEditSymptoms_Click(object sender, EventArgs e)
        {
            this.btnAddSymptoms.Visible = false;
            this.btnCancelSymptoms.Visible = false;

            this.txtSymptoms.Enabled = true;
            this.dateSymptoms.Enabled = true;

            this.btnSaveSymptoms.Visible = true;
            this.btnRemoveSymptoms.Visible = true;

            this.btnNewSymptoms.Enabled = true;
            this.btnEditSymptoms.Enabled = false;

            this.txtSymptoms.Focus();
        }

        private void btnEditPrescriptions_Click(object sender, EventArgs e)
        {
            this.btnAddPrescriptions.Visible = false;
            this.btnCancelPrescriptions.Visible = false;

            this.txtPrescriptions.Enabled = true;
            this.datePrescriptions.Enabled = true;

            this.btnSavePrescriptions.Visible = true;
            this.btnRemovePrescriptions.Visible = true;

            this.btnNewPrescriptions.Enabled = true;
            this.btnEditPrescriptions.Enabled = false;
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {

        }

        // New

        private void btnNewVitalSigns_Click(object sender, EventArgs e)
        {
            this.gridVitalSigns.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridVitalSigns.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtVitalSignsID.ResetText();
            this.txtHeight.ResetText();
            this.txtWeight.ResetText();
            this.txtTemperature.ResetText();
            this.txtPulseRate.ResetText();
            this.txtBloodPressure.ResetText();
            this.dateVitalSigns.Value = DateTime.Now.Date;

            vital_signs.LoadEachPatientVitalSigns(val.PatientPrimaryID, this.gridVitalSigns);
            AutoGenNumVitalSigns();

            this.btnAddVitalSigns.Visible = true;
            this.btnCancelVitalSigns.Visible = true;

            this.btnNewVitalSigns.Enabled = false;
            this.btnEditVitalSigns.Enabled = false;
            this.btnSaveVitalSigns.Visible = false;
            this.btnRemoveVitalSigns.Visible = false;

            this.txtHeight.Enabled = true;
            this.txtWeight.Enabled = true;
            this.txtTemperature.Enabled = true;
            this.txtPulseRate.Enabled = true;
            this.txtBloodPressure.Enabled = true;
            this.dateVitalSigns.Enabled = true;

            this.txtHeight.Focus();
        }

        private void btnNewDoctors_Click(object sender, EventArgs e)
        {
            this.gridDoctorsRecords.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridDoctorsRecords.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtIDDoctors.ResetText();
            this.cmbNameDoctors.Text = null;
            this.dateDoctors.Value = DateTime.Now.Date;

            doctor.LoadEachPatientDoctor(val.PatientPrimaryID, this.gridDoctorsRecords);
            AutoGenNumDoctor();

            this.btnAddDoctor.Visible = true;
            this.btnCancelDoctors.Visible = true;

            this.btnNewDoctors.Enabled = false;
            this.btnEditDoctors.Enabled = false;
            this.btnSaveDoctors.Visible = false;
            this.btnRemoveDoctors.Visible = false;

            this.cmbNameDoctors.Enabled = true;
            this.dateDoctors.Enabled = true;

            this.cmbNameDoctors.Focus();
        }

        private void btnNewDiagnosis_Click(object sender, EventArgs e)
        {
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtDiagnosisID.ResetText();
            this.txtDiagnosis.ResetText();
            this.dateDiagnosis.Value = DateTime.Now.Date;

            diagnosis.LoadEachPatientDiagnosis(val.PatientPrimaryID, this.gridDiagnosis);
            AutoGenNumDiagnosis();

            this.btnAddDiagnosis.Visible = true;
            this.btnCancelDiagnosis.Visible = true;
            this.txtDiagnosisID.Enabled = true;

            this.btnNewDiagnosis.Enabled = false;
            this.btnEditDoctors.Enabled = false;
            this.btnSaveDiagnosis.Enabled = false;
            this.btnRemoveDiagnosis.Enabled = false;

            this.txtDiagnosis.Enabled = true;
            this.dateDiagnosis.Enabled = true;

            this.txtDiagnosis.Focus();
        }

        private void btnNewSymptoms_Click(object sender, EventArgs e)
        {
            this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtSymptomsID.ResetText();
            this.txtSymptoms.ResetText();
            this.dateSymptoms.Value = DateTime.Now.Date;

            symptoms.LoadSymptomsRecordsOfEachPatient(val.PatientPrimaryID, this.gridSymptoms);
            AutoGenNumSymptoms();

            this.btnAddSymptoms.Visible = true;
            this.btnCancelSymptoms.Visible = true;

            this.btnNewSymptoms.Enabled = false;
            this.btnEditSymptoms.Enabled = false;
            this.btnSaveSymptoms.Visible = false;
            this.btnRemoveSymptoms.Visible = false;

            this.txtSymptoms.Enabled = true;
            this.dateSymptoms.Enabled = true;

            this.txtSymptoms.Focus();
        }

        private void btnNewPrescriptions_Click(object sender, EventArgs e)
        {
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtPrescriptionsID.ResetText();
            this.txtPrescriptions.ResetText();

            prescriptions.LoadPrescriptionRecordsOfEachPatient(val.PatientPrimaryID, this.gridPrescriptions);
            AutoGenNumPrescription();

            this.btnAddPrescriptions.Visible = true;
            this.btnCancelPrescriptions.Visible = true;

            this.btnNewPrescriptions.Enabled = false;
            this.btnEditPrescriptions.Enabled = false;
            this.btnSavePrescriptions.Visible = false;
            this.btnRemovePrescriptions.Visible = false;

            this.txtPrescriptions.Enabled = true;
            this.datePrescriptions.Enabled = true;

            this.txtPrescriptions.Focus();
        }

        // Add

        private void btnAddVitalSigns_Click(object sender, EventArgs e)
        {
            if (duplicate.VitalSignsIDDuplicate(val.PatientFullName, this.txtVitalSignsID.Text))
            {
                MessageBox.Show("Vital Signs ID is already taken! Generating a new ID!", "Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoGenNumVitalSigns();
            }
            else if(vital_signs.AddPatientVitalSigns(val.PatientPrimaryID, val.PatientFullName, this.txtVitalSignsID.Text, this.txtHeight.Text,
                this.txtWeight.Text, this.txtTemperature.Text, this.txtPulseRate.Text, this.txtBloodPressure.Text, this.dateVitalSigns.Value.Date))
            {
                MessageBox.Show("Vital signs successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                vital_signs.LoadEachPatientVitalSigns(val.PatientPrimaryID, this.gridVitalSigns);

                AutoGenNumVitalSigns();
                this.txtHeight.ResetText();
                this.txtWeight.ResetText();
                this.txtTemperature.ResetText();
                this.txtPulseRate.ResetText();
                this.txtBloodPressure.ResetText();
                this.dateVitalSigns.Value = DateTime.Now.Date;

                this.txtHeight.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add vital signs!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            doctor.GetDoctorID(this.cmbNameDoctors.Text);

            if(duplicate.DoctorDuplicateID(val.PatientFullName, this.txtIDDoctors.Text))
            {
                MessageBox.Show("Doctor ID is already taken! Generating a new ID!", "Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoGenNumDoctor();
            }
            else if(duplicate.DoctorDuplicate(val.PatientPrimaryID, this.cmbNameDoctors.Text))
            {
                MessageBox.Show("Doctor is already exist!", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.cmbNameDoctors.Text = null;
                this.cmbNameDoctors.Focus();
            }
            else if(doctor.AddDoctor(val.PatientPrimaryID, val.PatientFullName, this.txtIDDoctors.Text, val.DoctorID, this.cmbNameDoctors.Text,
                this.dateDoctors.Value.Date))
            {
                MessageBox.Show("Doctor successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                doctor.LoadEachPatientDoctor(val.PatientPrimaryID, this.gridDiagnosis);

                AutoGenNumDoctor();
                this.cmbNameDoctors.Text = null;
                this.dateDoctors.Value = DateTime.Now.Date;
            }
            else
            {
                MessageBox.Show("Failed to add doctor", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            if(duplicate.DiagnosisIDDuplicate(val.PatientFullName, this.txtDiagnosisID.Text))
            {
                MessageBox.Show("Diagnosis ID is already taken! Generating a new ID!", "Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoGenNumDiagnosis();
            }
            else if(duplicate.DiagnosisNameDuplicate(val.PatientPrimaryID, this.txtDiagnosis.Text))
            {
                MessageBox.Show("Diagnosis is already exist!", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtDiagnosis.ResetText();
                this.txtDiagnosis.Focus();
            }
            else if(diagnosis.AddDiagnosis(val.PatientPrimaryID, val.PatientFullName, this.txtDiagnosisID.Text, this.txtDiagnosis.Text,
                this.dateDiagnosis.Value.Date))
            {
                MessageBox.Show("Diagnosis successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                diagnosis.LoadEachPatientDiagnosis(val.PatientPrimaryID, this.gridDiagnosis);

                AutoGenNumDiagnosis();
                this.txtDiagnosis.ResetText();
                this.dateDiagnosis.Value = DateTime.Now.Date;

                this.txtDiagnosis.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add diagnosis!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSymptoms_Click(object sender, EventArgs e)
        {
            if(duplicate.SymptomsIDDuplicate(val.PatientFullName, this.txtSymptomsID.Text))
            {
                MessageBox.Show("Symptom ID is already taken! Generating a new ID!", "Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoGenNumSymptoms();
            }
            else if(duplicate.SymptomNameDuplicate(val.PatientPrimaryID, this.txtSymptoms.Text))
            {
                MessageBox.Show("Symptom is already exist!", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.txtSymptoms.ResetText();
                this.txtSymptoms.Focus();
            }
            else if(symptoms.AddPatientSymptom(val.PatientPrimaryID, val.PatientFullName, this.txtSymptomsID.Text, this.txtSymptoms.Text,
                this.dateSymptoms.Value.Date))
            {
                MessageBox.Show("Symptom successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                symptoms.LoadSymptomsRecordsOfEachPatient(val.PatientPrimaryID, this.gridSymptoms);

                AutoGenNumSymptoms();
                this.txtSymptoms.ResetText();
                this.dateSymptoms.Value = DateTime.Now.Date;

                this.txtSymptoms.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPrescriptions_Click(object sender, EventArgs e)
        {
            if(duplicate.PrescriptionIDDuplicate(val.PatientFullName, this.txtPrescriptionsID.Text))
            {
                MessageBox.Show("Prescription ID is already taken! Generating a new ID! Generating a new ID!", "Already Taken", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                AutoGenNumPrescription();
            }
            else if(duplicate.PrescriptionNameDuplicate(val.PatientPrimaryID, this.txtPrescriptions.Text))
            {
                MessageBox.Show("Prescription is already exist", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.txtPrescriptions.ResetText();
                this.txtPrescriptions.Focus();
            }
            else if(prescriptions.AddPrescription(val.PatientPrimaryID, val.PatientFullName, this.txtPrescriptionsID.Text, this.txtPrescriptions.Text,
                this.datePrescriptions.Value.Date))
            {
                MessageBox.Show("Prescription successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                prescriptions.LoadPrescriptionRecordsOfEachPatient(val.PatientPrimaryID, this.gridPrescriptions);

                AutoGenNumPrescription();
                this.txtPrescriptions.ResetText();
                this.datePrescriptions.Value = DateTime.Now.Date;

                this.txtPrescriptions.Focus();
            }

        }

        // Cancel

        private void btnCancelVitalSigns_Click(object sender, EventArgs e)
        {
            this.txtVitalSignsID.ResetText();
            this.txtHeight.ResetText();
            this.txtWeight.ResetText();
            this.txtTemperature.ResetText();
            this.txtPulseRate.ResetText();
            this.txtBloodPressure.ResetText();

            this.txtHeight.Enabled = false;
            this.txtWeight.Enabled = false;
            this.txtTemperature.Enabled = false;
            this.txtPulseRate.Enabled = false;
            this.txtBloodPressure.Enabled = false;
            this.btnAddVitalSigns.Visible = false;
            this.btnCancelVitalSigns.Visible = false;

            this.btnNewVitalSigns.Enabled = true;
        }

        private void btnCancelDoctors_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelDiagnosis_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelSymptoms_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelPrescriptions_Click(object sender, EventArgs e)
        {

        }

        // Save

        private void btnSavePersonalInfo_Click(object sender, EventArgs e)
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
            else if (patient.UpdatePatient(val.PatientPrimaryID, val.PatientPrimaryID, this.txtPatientID.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text,
                this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text,
                this.txtTelephoneNumber.Text, this.txtEmail.Text))
            {
                MessageBox.Show("Patient successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (patient.GetPatient(this.txtPatientID.Text))
                {
                    this.txtPatientID.Text = val.PatientID;
                    this.txtFirstName.Text = val.PatientFirstName;
                    this.txtMiddleName.Text = val.PatientMiddleName;
                    this.txtLastName.Text = val.PatientLastName;
                    this.txtGender.Text = val.PatientGender;
                    this.cmbGender.Text = val.PatientGender;
                    this.txtAge.Text = val.PatientAge;
                    this.cmbAge.Text = val.PatientAge;
                    this.txtAddress.Text = val.PatientAddress;
                    this.txtBirthday.Text = val.PatientBirthday.ToString("D");
                    this.dateBirthday.Value = val.PatientBirthday;
                    this.txtCellphoneNumber.Text = val.PatientCellphoneNumer;
                    this.txtTelephoneNumber.Text = val.PatientTelephoneNumber;
                    this.txtEmail.Text = val.PatientEmail;
                }

                vital_signs.LoadVitalSigns(val.PatientFullName, this.gridVitalSigns);
                doctor.LoadPatientDoctor(val.PatientFullName, this.gridDoctorsRecords);

                this.txtFirstName.Enabled = false;
                this.txtMiddleName.Enabled = false;
                this.txtLastName.Enabled = false;
                this.cmbGender.Visible = false;
                this.cmbAge.Visible = false;
                this.txtAddress.Enabled = false;
                this.dateBirthday.Visible = false;
                this.txtCellphoneNumber.Enabled = false;
                this.txtTelephoneNumber.Enabled = false;
                this.txtEmail.Enabled = false;
                this.btnSavePersonalInfo.Enabled = false;

                this.txtGender.Visible = true;
                this.txtAge.Visible = true;
                this.txtBirthday.Visible = true;
                this.btnEditPersonalInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to update patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveVitalSigns_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveDoctors_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveDiagnosis_Click(object sender, EventArgs e)
        {

        }

        private void btnSymptoms_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePrescriptions_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtTotalMedicalFee.Text))
            {
                MessageBox.Show("Please input total medical fee first!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTotalMedicalFee.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                MessageBox.Show("Please input amount first!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTotalMedicalFee.Focus();
            }
            else if(payment.updatePaymentTransaction(val.PatientID, this.txtReceiptNo.Text, this.txtTotalMedicalFee.Text, this.cmbDiscount.Text,
                this.txtAmount.Text, this.txtTotalAmountPaid.Text, this.txtChange.Text))
            {
                MessageBox.Show("Payment successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridPaymentHistory.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridPaymentHistory.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                this.txtTotalMedicalFee.Enabled = false;
                this.cmbDiscount.Enabled = false;
                this.txtAmount.Enabled = false;
                this.btnTransact.Visible = false;
                this.btnSavePayment.Enabled = false;

                payment.loadPatientPaymentHistory(this.txtPatientID.Text, this.gridPaymentHistory);
            }
            else
            {
                MessageBox.Show("Failed to update payment!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Key Press

        private void txtCellphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        // Text Changed

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(this.txtWeight.Text) && String.IsNullOrWhiteSpace(this.txtTemperature.Text))
            {
                this.btnAddVitalSigns.Enabled = false;
                this.btnSaveVitalSigns.Enabled = false;
            }
            else if (!String.IsNullOrWhiteSpace(this.txtTemperature.Text) && String.IsNullOrWhiteSpace(this.txtWeight.Text))
            {
                this.btnAddVitalSigns.Enabled = false;
                this.btnSaveVitalSigns.Enabled = false;
            }
            else
            {
                this.btnAddVitalSigns.Enabled = true;
                this.btnSaveVitalSigns.Enabled = true;
            }
        }

        private void txtTemperature_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.txtTemperature.Text) && String.IsNullOrWhiteSpace(this.txtWeight.Text))
            {
                this.btnAddVitalSigns.Enabled = false;
                this.btnSaveVitalSigns.Enabled = false;
            }
            else if (!String.IsNullOrWhiteSpace(this.txtWeight.Text) && String.IsNullOrWhiteSpace(this.txtTemperature.Text))
            {
                this.btnAddVitalSigns.Enabled = false;
                this.btnSaveVitalSigns.Enabled = false;
            }
            else
            {
                this.btnAddVitalSigns.Enabled = true;
                this.btnSaveVitalSigns.Enabled = true;
            }
        }

        private void cmbNameDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.cmbNameDoctors.Text))
            {
                this.btnAddDoctor.Enabled = false;
                this.btnSaveDoctors.Enabled = false;
            }
            else
            {
                this.btnAddDoctor.Enabled = true;
                this.btnSaveDoctors.Enabled = true;
            }
        }

        private void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtDiagnosis.Text))
            {
                this.btnAddDiagnosis.Enabled = false;
                this.btnSaveDiagnosis.Enabled = false;
            }
            else
            {
                this.btnAddDiagnosis.Enabled = true;
                this.btnSaveDiagnosis.Enabled = true;
            }
        }

        private void txtSymptoms_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtSymptoms.Text))
            {
                this.btnAddSymptoms.Enabled = false;
                this.btnSaveSymptoms.Enabled = false;
            }
            else
            {
                this.btnAddSymptoms.Enabled = true;
                this.btnSaveSymptoms.Enabled = true;
            }
        }

        private void txtPRescriptions_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtPrescriptions.Text))
            {
                this.btnAddPrescriptions.Enabled = false;
                this.btnSavePrescriptions.Enabled = false;
            }
            else
            {
                this.btnAddPrescriptions.Enabled = true;
                this.btnSavePrescriptions.Enabled = true;
            }
        }

        // Transact

        private void btnTransact_Click(object sender, EventArgs e)
        {
            double pwd = .20;
            double senior_citizen = .20;
            double vip = .15;
            double discount;
            double discounted;
            double total;

            if (String.IsNullOrWhiteSpace(this.txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt number is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtTotalMedicalFee.Text))
            {
                MessageBox.Show("Input total medical fee first before transact!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                MessageBox.Show("Input amount first!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.cmbDiscount.Text == "None")
                {
                    total = (double.Parse(this.txtAmount.Text) - double.Parse(this.txtTotalMedicalFee.Text));

                    this.txtTotalAmountPaid.Text = this.txtTotalMedicalFee.Text;
                    this.txtChange.Text = total.ToString();
                }
                else if (this.cmbDiscount.Text == "PWD")
                {
                    discount = (double.Parse(this.txtTotalMedicalFee.Text) * pwd);
                    discounted = (double.Parse(this.txtTotalMedicalFee.Text) - discount);
                    total = (double.Parse(this.txtAmount.Text) - discounted);

                    this.txtTotalAmountPaid.Text = discounted.ToString();
                    this.txtChange.Text = total.ToString();
                }
                else if (this.cmbDiscount.Text == "Senior Citizen")
                {
                    discount = (double.Parse(this.txtTotalMedicalFee.Text) * senior_citizen);
                    discounted = (double.Parse(this.txtTotalMedicalFee.Text) - discount);
                    total = (double.Parse(this.txtAmount.Text) - discounted);

                    this.txtTotalAmountPaid.Text = discounted.ToString();
                    this.txtChange.Text = total.ToString();
                }
                else if (this.cmbDiscount.Text == "VIP")
                {
                    discount = (double.Parse(this.txtTotalMedicalFee.Text) * vip);
                    discounted = (double.Parse(this.txtTotalMedicalFee.Text) - discount);
                    total = (double.Parse(this.txtAmount.Text) - discounted);

                    this.txtTotalAmountPaid.Text = discounted.ToString();
                    this.txtChange.Text = total.ToString();
                }
                DateTime date = DateTime.Parse(this.gridPaymentHistory.SelectedCells[6].Value.ToString());

                this.rprtReceipt.Clear();

                ReportParameterCollection parameters = new ReportParameterCollection();
                parameters.Add(new ReportParameter("pName", this.txtFullName.Text));
                parameters.Add(new ReportParameter("pReceiptNo", this.txtReceiptNo.Text));
                parameters.Add(new ReportParameter("pDate", date.ToString("MM/dd/yy")));
                parameters.Add(new ReportParameter("pTotalMedicalFee", this.txtTotalMedicalFee.Text));
                parameters.Add(new ReportParameter("pDiscount", this.cmbDiscount.Text));
                parameters.Add(new ReportParameter("pAmount", this.txtAmount.Text));
                parameters.Add(new ReportParameter("pTotalAmountPaid", this.txtTotalAmountPaid.Text));
                parameters.Add(new ReportParameter("pChange", this.txtChange.Text));
                parameters.Add(new ReportParameter("pCashier", val.UserFullName));

                this.rprtReceipt.LocalReport.SetParameters(parameters);
                this.rprtReceipt.RefreshReport();
            }
            this.btnSavePayment.Enabled = true;
        }

        // Back

        private void btnBackToPatientsInPeronalInfo_Click(object sender, EventArgs e)
        {
            forms.frmPatients frmPatients = new forms.frmPatients();
            frmPatients.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatients);
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
            this.Close();
        }

        private void btnBackToPatientsVitalSigns_Click(object sender, EventArgs e)
        {
            forms.frmPatients frmPatients = new forms.frmPatients();
            frmPatients.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatients);
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
            this.Close();
        }

        private void btnBackToPatientsDoctors_Click(object sender, EventArgs e)
        {
            forms.frmPatients frmPatients = new forms.frmPatients();
            frmPatients.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatients);
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
            this.Close();
        }

        private void btnBackToPatientsInDiagnosis_Click_1(object sender, EventArgs e)
        {
            forms.frmPatients frmPatients = new forms.frmPatients();
            frmPatients.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatients);
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
            this.Close();
        }

        private void btnBackToPatientsInSymptoms_Click(object sender, EventArgs e)
        {
            forms.frmPatients frmPatients = new forms.frmPatients();
            frmPatients.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatients);
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
            this.Close();
        }

        private void btnBackToPatientsInPrintPrescription_Click(object sender, EventArgs e)
        {
            forms.frmPatients frmPatients = new forms.frmPatients();
            frmPatients.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatients);
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
            this.Close();
        }

        private void btnBackToPatientsInPrescriptions_Click(object sender, EventArgs e)
        {
            forms.frmPatients frmPatients = new forms.frmPatients();
            frmPatients.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatients);
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
            this.Close();
        }

        private void btnBackToPatientsInPaymentHistory_Click(object sender, EventArgs e)
        {
            forms.frmPatients frmPatients = new forms.frmPatients();
            frmPatients.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatients);
            frmPatients.Dock = DockStyle.Fill;
            frmPatients.Show();
            this.Close();
        }
    }
}
