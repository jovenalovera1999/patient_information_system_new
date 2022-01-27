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
        functions.Doctor doctor = new functions.Doctor();

        void AutoGenNum()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 11)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtPatientID.Text = string.Format("#STLDM{0}", generateID.ToString());
        }

        void LoadDoctors()
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
                    this.cmbDoctorName.Items.Add(doctors_name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error filling doctors name: " + ex.ToString());
            }
        }

        void LoadAge()
        {
            for (int i = 0; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }
        }

        void LoadForm()
        {
            AutoGenNum();
            LoadAge();
            LoadDoctors();

            this.btnRemoveSymptom.Enabled = false;
            this.dateBirthday.Value = DateTime.Now.Date;
        }

        void AddSymptom()
        {
            int n = this.gridAddPatient.Rows.Add();
            this.gridAddPatient.Rows[n].Cells[0].Value = this.txtSymptoms.Text;
            this.txtSymptoms.ResetText();
            this.txtSymptoms.Focus();
        }

        void RemoveSymptom()
        {
            foreach (DataGridViewRow row in this.gridAddPatient.SelectedRows)
            {
                this.gridAddPatient.Rows.Remove(row);
            }
            this.gridAddPatient.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridAddPatient.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.txtSymptoms.ResetText();
            this.txtSymptoms.Focus();
            this.btnRemoveSymptom.Enabled = false;
        }

        void SelectSymptom()
        {
            this.gridAddPatient.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridAddPatient.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.btnRemoveSymptom.Enabled = true;
        }

        void SaveSymptoms()
        {
            for (int i = 0; i < this.gridAddPatient.Rows.Count; i++)
            {
                try
                {

                    using (MySqlConnection connection = new MySqlConnection(con.conString()))
                    {
                        string sql = @"INSERT INTO pis_db.symptoms(patient_fid, symptoms, status)
                                            VALUES(
                                            @patient_fid,
                                            AES_ENCRYPT(@symptoms, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                            AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang')
                                            );";

                        using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);
                            cmd.Parameters.AddWithValue("@symptoms", this.gridAddPatient.Rows[i].Cells[0].Value);

                            connection.Open();
                            MySqlDataReader dr;
                            dr = cmd.ExecuteReader();
                            dr.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding patient symptoms: " + ex.ToString());
                }
            }
        }

        void ResetAll()
        {
            this.txtFirstName.ResetText();
            this.txtMiddleName.ResetText();
            this.txtLastName.ResetText();
            this.cmbGender.Text = null;
            this.cmbAge.Text = null;
            this.txtAddress.ResetText();
            this.dateBirthday.Value = DateTime.Now.Date;
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
            AutoGenNum();
            this.txtFirstName.Focus();
        }

        void PatientRecordFound()
        {
            MessageBox.Show(string.Format("Patient record found!\r\n\r\n" +
                "Patient ID: {0}\r\n" +
                "First Name: {1}\r\n" +
                "Middle Name: {2}\r\n" +
                "Last Name: {3}\r\n" +
                "Doctor: {4}",
                val.PatientID,
                val.PatientFirstName,
                val.PatientMiddleName,
                val.PatientLastName,
                val.PatientDoctor), "Record Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.txtPatientID.Text = val.PatientID;
        }

        void AddPatient()
        {
            doctor.GetDoctorPrimaryID(this.cmbDoctorName.Text);

            if (duplicate.PatientIDDuplicate(this.txtPatientID.Text))
            {
                MessageBox.Show("Patient ID is already taken!", "Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AutoGenNum();
            }
            else if (String.IsNullOrWhiteSpace(this.txtFirstName.Text))
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
            else if (String.IsNullOrWhiteSpace(this.cmbDoctorName.Text))
            {
                MessageBox.Show("Doctor is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
            else if (duplicate.DuplicatePatientAndPatientDoctor(val.DoctorPrimaryID, this.txtFirstName.Text, this.txtMiddleName.Text,
                this.txtLastName.Text))
            {
                PatientRecordFound();

                if (patient.AddPatientWithFirstAccountExisting(this.txtPatientID.Text, this.txtFirstName.Text, this.txtMiddleName.Text,
                    this.txtLastName.Text, this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date,
                    this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text, this.txtHeight.Text, this.txtWeight.Text,
                    this.txtTemperature.Text, this.txtPulseRate.Text, this.txtBloodPressure.Text, this.cmbDoctorName.Text))
                {
                    SaveSymptoms();
                    MessageBox.Show("Patient successfully added to schedule!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAll();
                }
                else
                {
                    MessageBox.Show("Failed to add patient to schedule!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (patient.AddPatient(this.txtPatientID.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text,
                this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text,
                this.txtTelephoneNumber.Text, this.txtEmail.Text, this.txtHeight.Text, this.txtWeight.Text,
                this.txtTemperature.Text, this.txtPulseRate.Text, this.txtBloodPressure.Text,
                this.cmbDoctorName.Text))
            {
                SaveSymptoms();
                MessageBox.Show("Patient successfully added to schedule!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetAll();
            }
            else
            {
                MessageBox.Show("Failed to add patient to schedule!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BackToPatients()
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

        private void txtCellphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, plus sign, open and close parenthesis, and space
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 43 && e.KeyChar != 40 && e.KeyChar != 41 && e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 plus sign is allowed
            if (e.KeyChar == 43)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 open parenthesis is allowed
            if (e.KeyChar == 40)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 close parenthesis is allowed
            if (e.KeyChar == 41)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, plus sign, open and close parenthesis, and space
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 43 && e.KeyChar != 40 && e.KeyChar != 41 && e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 plus sign is allowed
            if (e.KeyChar == 43)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 open parenthesis is allowed
            if (e.KeyChar == 40)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 close parenthesis is allowed
            if (e.KeyChar == 41)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTemperature_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPulseRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtBloodPressure_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSymptoms_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSymptoms.Text))
            {
                this.btnAddSymptom.Enabled = false;
            }
            else
            {
                this.btnAddSymptom.Enabled = true;
            }
        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void gridAddPatient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectSymptom();
        }

        private void btnAddSymptom_Click(object sender, EventArgs e)
        {
            AddSymptom();
        }

        private void btnRemoveSymptom_Click(object sender, EventArgs e)
        {
            RemoveSymptom();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToPatients();
        }
    }
}
