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
    public partial class frmDoctorsPatientProfile : Form
    {
        public frmDoctorsPatientProfile()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();
        functions.Diagnosis diagnosis = new functions.Diagnosis();
        functions.Symptoms symptoms = new functions.Symptoms();

        void doctorsName()
        {
            string sql = @"SELECT CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR), ' ', CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR), ' ', '(',CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR), ')')
                            FROM patient_information_db.users
                            WHERE CAST(AES_DECRYPT(role, 'jovencutegwapo123') AS CHAR) = 'Doctor'";
            MySqlConnection connection = new MySqlConnection(con.conString());
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader myReader;

            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string doctors_name = myReader.GetString("CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR), ' ', CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR), ' ', '(',CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR), ')')");
                    this.cmbDoctorName.Items.Add(doctors_name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error filling doctors name: " + ex.ToString());
            }
        }

        private void frmDoctorsPatientProfile_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }
            doctorsName();
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

        private void btnManageDiagnosisSymptoms_Click(object sender, EventArgs e)
        {

        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
