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
    public partial class frmAddPatient : Form
    {
        public frmAddPatient()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();
        functions.Duplicate duplicate = new functions.Duplicate();

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

                while(myReader.Read())
                {
                    string doctors_name = myReader.GetString("CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR), ' ', CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR), ' ', '(',CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR), ')')");
                    this.cmbDoctorName.Items.Add(doctors_name);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error filling doctors name: " + ex.ToString());
            }
        }

        void autoGenNum()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 11)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtPatientID.Text = generateID.ToString();
        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            autoGenNum();
            this.dateBirthday.Value = DateTime.Now.Date;
            for (int i = 0; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }
            this.btnRemoveSymptom.Enabled = false;
            doctorsName();
        }

        private void gridAddPatient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridAddPatient.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridAddPatient.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.btnRemoveSymptom.Enabled = true;
        }

        private void btnAddSymptom_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            var generateID = new StringBuilder();
            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }

            int n = this.gridAddPatient.Rows.Add();
            if (duplicate.symptomsIDDuplicate(this.txtPatientID.Text, generateID.ToString()))
            {
                MessageBox.Show("Symptoms ID is already exist! Please try add symptoms again!", "Already Exist", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                this.txtSymptoms.Focus();
            }
            else
            {
                this.gridAddPatient.Rows[n].Cells[0].Value = generateID;
                this.gridAddPatient.Rows[n].Cells[1].Value = this.txtSymptoms.Text;
                this.txtSymptoms.ResetText();
                this.txtSymptoms.Focus();
            }
        }

        private void btnRemoveSymptom_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.gridAddPatient.SelectedRows)
            {
                this.gridAddPatient.Rows.Remove(row);
            }
            this.gridAddPatient.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridAddPatient.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.txtSymptoms.ResetText();
            this.txtSymptoms.Focus();
            this.btnRemoveSymptom.Enabled = false;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLastName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.cmbGender.Text))
            {
                MessageBox.Show("Gender is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbGender.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.cmbAge.Text))
            {
                MessageBox.Show("Age is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbAge.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtAddress.Text))
            {
                MessageBox.Show("Address is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddress.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(this.txtTelephoneNumber.Text) && 
                String.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                MessageBox.Show("Contact information are required! Please input atleast one contact information", "Required", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCellphoneNumber.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtWeight.Text))
            {
                MessageBox.Show("Weight is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtWeight.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtTemperature.Text))
            {
                MessageBox.Show("Temperature is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTemperature.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.cmbDoctorName.Text))
            {
                MessageBox.Show("Doctor is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
            else if(patient.addPatient(this.txtPatientID.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text, 
                this.cmbGender.Text, int.Parse(this.cmbAge.Text), this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text, 
                this.txtTelephoneNumber.Text, this.txtEmail.Text, double.Parse(this.txtHeight.Text), double.Parse(this.txtWeight.Text), 
                double.Parse(this.txtTemperature.Text), double.Parse(this.txtPulseRate.Text), double.Parse(this.txtBloodPressure.Text), 
                this.cmbDoctorName.Text))
            {
                for(int i = 0; i < this.gridAddPatient.Rows.Count; i++)
                {
                    try
                    {

                        using(MySqlConnection connection = new MySqlConnection(con.conString()))
                        {
                            string sql = @"INSERT INTO patient_information_db.symptoms(patient_id, symptoms_id, symptoms, date)
                                            VALUES(
                                            AES_ENCRYPT(@patient_id, 'jovencutegwapo123'),
                                            AES_ENCRYPT(@symptoms_id, 'jovencutegwapo123'),
                                            AES_ENCRYPT(@symptoms, 'jovencutegwapo123'),
                                            @date
                                            );";

                            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                            {
                                cmd.Parameters.AddWithValue("@patient_id", this.txtPatientID.Text);
                                cmd.Parameters.AddWithValue("@symptoms_id", this.gridAddPatient.Rows[i].Cells[0].Value);
                                cmd.Parameters.AddWithValue("@symptoms", this.gridAddPatient.Rows[i].Cells[1].Value);
                                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                                connection.Open();
                                cmd.ExecuteReader();
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error adding patient symptoms: " + ex.ToString());
                    }
                }

                MessageBox.Show("Patient successfully added to schedule!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtFirstName.ResetText();
                this.txtMiddleName.ResetText();
                this.txtLastName.ResetText();
                this.cmbGender.Text = null;
                this.cmbAge.Text = null;
                this.txtAddress.ResetText();
                this.dateBirthday.Value = DateTime.Now;
                this.txtCellphoneNumber.ResetText();
                this.txtTelephoneNumber.ResetText();
                this.txtEmail.ResetText();
                this.txtHeight.ResetText();
                this.txtWeight.ResetText();
                this.txtTemperature.ResetText();
                this.txtPulseRate.ResetText();
                this.txtBloodPressure.ResetText();
                this.cmbDoctorName.Text = null;
                this.gridAddPatient.Rows.Clear();
                autoGenNum();
                this.txtFirstName.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add patient to schedule!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
