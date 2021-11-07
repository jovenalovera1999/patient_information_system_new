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
using Microsoft.Reporting.WinForms;

namespace PatientInformationSystemNew.forms
{
    public partial class frmConsultation : Form
    {
        public frmConsultation()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Symptoms symptoms = new functions.Symptoms();
        functions.Duplicate duplicate = new functions.Duplicate();
        functions.Patient patient = new functions.Patient();
        functions.Diagnosis diagnosis = new functions.Diagnosis();
        functions.Prescription prescriptions = new functions.Prescription();

        private void frmConsultationNew_Load(object sender, EventArgs e)
        {
            this.txtPatientID.Text = val.PatientID;
            this.txtPatientID.Text = val.PatientID;
            this.txtFirstName.Text = val.PatientFirstName;
            this.txtMiddleName.Text = val.PatientMiddleName;
            this.txtLastName.Text = val.PatientLastName;
            this.txtGender.Text = val.PatientGender;
            this.txtAge.Text = val.PatientAge.ToString();
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
            symptoms.loadSymptomsInConsultation(this.txtPatientID.Text, DateTime.Now.Date, this.gridSymptoms);
            diagnosis.loadDiagnosisRecordsOfPatient(this.txtPatientID.Text, this.gridDiagnosisRecords);
            symptoms.loadSymptomsRecordsOfPatient(this.txtPatientID.Text, this.gridDiagnosisRecords);
            prescriptions.loadPrescriptionRecordsOfPatient(this.txtPatientID.Text, this.gridDiagnosisRecords);
        }

        private void gridDiagnosis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.txtDiagnosis.Enabled == false)
            {
                this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            }
            else
            {
                this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
                this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.White;

                this.btnRemoveDiagnosis.Enabled = true;

                this.txtDiagnosis.Text = this.gridDiagnosis.SelectedCells[1].Value.ToString();
            }
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }

            int n = this.gridDiagnosis.Rows.Add();
            this.gridDiagnosis.Rows[n].Cells[0].Value = generateID;
            this.gridDiagnosis.Rows[n].Cells[1].Value = this.txtDiagnosis.Text;
            this.txtDiagnosis.ResetText();
            this.txtDiagnosis.Focus();

            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.btnSaveDiagnosis.Enabled = true;
        }

        private void btnRemoveDiagnosis_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.gridDiagnosis.SelectedRows)
            {
                this.gridDiagnosis.Rows.Remove(row);
            }
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            this.btnRemoveDiagnosis.Enabled = false;

            this.txtDiagnosis.ResetText();
            this.txtDiagnosis.Focus();
        }

        private void gridSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.btnUpdateSymptoms.Enabled = true;
            this.btnRemoveSymptoms.Enabled = true;

            this.txtSymptoms.Text = this.gridSymptoms.SelectedCells[1].Value.ToString();
        }

        private void btnAddSymptoms_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }

            if (duplicate.symptomsIDDuplicate(this.txtPatientID.Text, generateID.ToString()))
            {
                MessageBox.Show("Duplicate ID detected! Please try again!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDiagnosis.Focus();
            }
            else if (symptoms.addPatientSymptom(this.txtPatientID.Text, generateID.ToString(), this.txtSymptoms.Text, DateTime.Now.Date))
            {
                this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                symptoms.loadSymptomsInConsultation(this.txtPatientID.Text, DateTime.Now.Date, this.gridSymptoms);
                this.txtSymptoms.ResetText();
                this.txtSymptoms.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add patient symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSymptoms_Click(object sender, EventArgs e)
        {
            if (symptoms.updateSymptom(this.txtPatientID.Text, this.gridSymptoms.SelectedCells[0].Value.ToString(), this.txtSymptoms.Text,
                DateTime.Now.Date))
            {
                MessageBox.Show("Symptom updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                this.btnUpdateSymptoms.Enabled = false;
                this.btnRemoveSymptoms.Enabled = false;
                symptoms.loadSymptomsInConsultation(this.txtPatientID.Text, DateTime.Now.Date, this.gridSymptoms);

                this.txtSymptoms.ResetText();
                this.txtSymptoms.Focus();
            }
            else
            {
                MessageBox.Show("Failed to update patient symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSymptoms_Click(object sender, EventArgs e)
        {
            if (symptoms.deleteSymptom(this.txtPatientID.Text, this.gridSymptoms.SelectedCells[0].Value.ToString()))
            {
                MessageBox.Show("Symptom removed!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                this.btnUpdateSymptoms.Enabled = false;
                this.btnRemoveSymptoms.Enabled = false;
                symptoms.loadSymptomsInConsultation(this.txtPatientID.Text, DateTime.Now, this.gridSymptoms);

                this.txtSymptoms.ResetText();
                this.txtSymptoms.Focus();
            }
            else
            {
                MessageBox.Show("Failed to delete patient symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveDiagnosis_Click(object sender, EventArgs e)
        {
            if (this.gridDiagnosis.Rows.Count == 0)
            {
                MessageBox.Show("Input diagnosis first before clicking diagnosis save and proceed!", "Input First", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.txtDiagnosis.Focus();
            }
            else
            {
                for (int i = 0; i < this.gridDiagnosis.Rows.Count; i++)
                {
                    try
                    {
                        Random number = new Random();
                        var generateID = new StringBuilder();
                        while (generateID.Length < 5)
                        {
                            generateID.Append(number.Next(10).ToString());
                        }

                        using (MySqlConnection connection = new MySqlConnection(con.conString()))
                        {
                            string sql = @"DELETE FROM patient_information_db.diagnosis
                                            WHERE
                                            CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                            CAST(AES_DECRYPT(diagnosis_id, 'jovencutegwapo123') AS CHAR) = @diagnosis_id AND
                                            date = @date;

                                            INSERT INTO patient_information_db.diagnosis(patient_id, diagnosis_id, diagnosis, date)
                                            VALUES(
                                            AES_ENCRYPT(@patient_id, 'jovencutegwapo123'), 
                                            AES_ENCRYPT(@diagnosis_id, 'jovencutegwapo123'), 
                                            AES_ENCRYPT(@diagnosis, 'jovencutegwapo123'), 
                                            @date
                                            );";

                            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                            {
                                cmd.Parameters.AddWithValue("@patient_id", this.txtPatientID.Text);
                                cmd.Parameters.AddWithValue("@diagnosis_id", this.gridDiagnosis.Rows[i].Cells[0].Value);
                                cmd.Parameters.AddWithValue("@diagnosis", this.gridDiagnosis.Rows[i].Cells[1].Value);
                                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                                connection.Open();
                                cmd.ExecuteReader();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error saving diagnosis: " + ex.ToString());
                    }
                }
                MessageBox.Show("Diagnosis successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnSaveDiagnosis.Enabled = false;
                this.txtPrescription.Focus();
            }
        }

        private void btnSavePrescription_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            var generateID = new StringBuilder();
            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }

            if (String.IsNullOrWhiteSpace(this.txtPrescription.Text))
            {
                MessageBox.Show("Please input prescription first before proceed!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPrescription.Focus();
            }
            else if(this.btnSaveDiagnosis.Enabled == true)
            {
                MessageBox.Show("Please save diagnosis first!", "Save First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnSaveDiagnosis.Focus();
            }
            else if (patient.savePrescriptionAndTransferPatientToPatients(this.txtPatientID.Text, generateID.ToString(), this.txtPrescription.Text,
                DateTime.Now.Date, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text, this.txtGender.Text, int.Parse(this.txtAge.Text),
                this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text,
                double.Parse(this.txtHeight.Text), double.Parse(this.txtWeight.Text), double.Parse(this.txtTemperature.Text), double.Parse(this.txtPulseRate.Text), 
                double.Parse(this.txtBloodPressure.Text), val.PatientDoctor))
            {
                MessageBox.Show("Prescription successfully saved and patient successfully transfered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnSavePrescription.Enabled = false;
                this.btnBack.Enabled = false;
                this.btnAnotherBack.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to save prescription and transfer patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrescription_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtPrescription.Text))
            {
                this.btnGenerate.Enabled = false;
                this.btnSavePrescription.Enabled = false;
            }
            else
            {
                this.btnGenerate.Enabled = true;
                this.btnSavePrescription.Enabled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.rprtPrescription.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pFullName", val.PatientFullName));
            parameters.Add(new ReportParameter("pAge", this.txtAge.Text));
            parameters.Add(new ReportParameter("pSex", this.txtGender.Text.Substring(0, 1)));
            parameters.Add(new ReportParameter("pAddress", this.txtAddress.Text));
            parameters.Add(new ReportParameter("pDate", DateTime.Now.Date.ToString("MM/dd/yyyy")));
            parameters.Add(new ReportParameter("pPrescription", this.txtPrescription.Text));
            this.rprtPrescription.LocalReport.SetParameters(parameters);
            this.rprtPrescription.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back? The changes in symptoms will be saved!", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (patient.backPatientToScheduleFromConsultation(this.txtPatientID.Text))
                {
                    forms.frmSchedule frmSchedule = new forms.frmSchedule();
                    frmSchedule.TopLevel = false;
                    forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
                    Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
                    pnlDashboardBody.Controls.Add(frmSchedule);
                    frmSchedule.Dock = DockStyle.Fill;
                    frmSchedule.Show();
                    this.Close();
                }
            }
        }

        private void btnAnotherBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to go back? The changes in symptoms will be saved!", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (patient.backPatientToScheduleFromConsultation(this.txtPatientID.Text))
                {
                    forms.frmSchedule frmSchedule = new forms.frmSchedule();
                    frmSchedule.TopLevel = false;
                    forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
                    Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
                    pnlDashboardBody.Controls.Add(frmSchedule);
                    frmSchedule.Dock = DockStyle.Fill;
                    frmSchedule.Show();
                    this.Close();
                }
            }
        }
    }
}
