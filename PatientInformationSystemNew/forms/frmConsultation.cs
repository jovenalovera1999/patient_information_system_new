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
            this.txtAge.Text = val.PatientAge;
            this.txtAddress.Text = val.PatientAddress;
            this.dateBirthday.Value = val.PatientBirthday;
            this.txtCellphoneNumber.Text = val.PatientCellphoneNumer;
            this.txtTelephoneNumber.Text = val.PatientTelephoneNumber;
            this.txtEmail.Text = val.PatientEmail;
            this.txtHeight.Text = val.PatientHeight;
            this.txtWeight.Text = val.PatientWeight;
            this.txtTemperature.Text = val.PatientTemperature;
            this.txtPulseRate.Text = val.PatientPulseRate;
            this.txtBloodPressure.Text = val.PatientBloodPressure;

            symptoms.LoadSymptomsInConsultation(val.PatientPrimaryID, this.gridSymptoms);

            diagnosis.LoadDiagnosis(val.PatientPrimaryID, this.gridDiagnosisRecord);
            symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptomsRecord);
            prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptionsRecord);
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

        private void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtDiagnosis.Text))
            {
                this.btnAddDiagnosis.Enabled = false;
            }
            else
            {
                this.btnAddDiagnosis.Enabled = true;
            }
        }

        private void txtSymptoms_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSymptoms.Text))
            {
                this.btnAddSymptoms.Enabled = false;
            }
            else
            {
                this.btnAddSymptoms.Enabled = true;
            }
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            int n = this.gridDiagnosis.Rows.Add();
            this.gridDiagnosis.Rows[n].Cells[0].Value = this.txtDiagnosis.Text;

            this.txtDiagnosis.ResetText();
            this.txtDiagnosis.Focus();

            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.btnSaveDiagnosis.Enabled = true;

            this.btnRemoveDiagnosis.Enabled = false;
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
            
            if(this.gridDiagnosis.Rows.Count == 0)
            {
                this.btnSaveDiagnosis.Enabled = false;
            }

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
            if (symptoms.AddSymptomInConsultation(val.PatientPrimaryID, this.txtSymptoms.Text))
            {
                this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                symptoms.LoadSymptomsInConsultation(val.PatientPrimaryID, this.gridSymptoms);
                symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptomsRecord);

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
            Random number = new Random();
            var generateID = new StringBuilder();

            while(generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }

            if(duplicate.UpdateHistoryIDDuplicate(generateID.ToString()))
            {
                MessageBox.Show("Update ID is already taken! Please click again!", "Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (symptoms.UpdateSymptomInConsultation(int.Parse(this.gridSymptoms.SelectedCells[0].Value.ToString()),
                this.txtSymptoms.Text, generateID.ToString(), val.UserFullName,
                string.Format("Updated Patient {0} Symptom! Set Symptom from {1} to {2}!", val.PatientFullName,
                this.gridSymptoms.SelectedCells[1].Value.ToString(), this.txtSymptoms.Text)))
            {
                MessageBox.Show("Symptom updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                this.btnUpdateSymptoms.Enabled = false;
                this.btnRemoveSymptoms.Enabled = false;

                symptoms.LoadSymptomsInConsultation(val.PatientPrimaryID, this.gridSymptoms);
                symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptomsRecord);

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
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }

            if (duplicate.UpdateHistoryIDDuplicate(generateID.ToString()))
            {
                MessageBox.Show("Update ID is already taken! Please click again!", "Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (symptoms.RemoveSymptomInConsultation(int.Parse(this.gridSymptoms.SelectedCells[0].Value.ToString()), generateID.ToString(),
                val.UserFullName, string.Format("Removed Patient {0} Symptom! {1} has been removed!", val.PatientFullName,
                this.gridSymptoms.SelectedCells[1].Value.ToString())))
            {
                MessageBox.Show("Symptom removed!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                this.btnUpdateSymptoms.Enabled = false;
                this.btnRemoveSymptoms.Enabled = false;

                symptoms.LoadSymptomsInConsultation(val.PatientPrimaryID, this.gridSymptoms);
                symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptomsRecord);

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
                MessageBox.Show("Add diagnosis first before clicking diagnosis save and proceed!", "Input First", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.txtDiagnosis.Focus();
            }
            else
            {
                for (int i = 0; i < this.gridDiagnosis.Rows.Count; i++)
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(con.conString()))
                        {
                            string sql = @"UPDATE pis_db.diagnosis
                                            SET status = 'Removed'
                                            WHERE diagnosis = AES_ENCRYPT(@diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang') AND status = 'In Consultation';

                                            INSERT INTO pis_db.diagnosis(patient_fid, diagnosis, status)
                                            VALUES(
                                            @patient_fid,
                                            AES_ENCRYPT(@diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                            'In Consultation'
                                            );";

                            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                            {
                                cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);
                                cmd.Parameters.AddWithValue("@diagnosis", this.gridDiagnosis.Rows[i].Cells[0].Value);

                                connection.Open();
                                MySqlDataReader dr;
                                dr = cmd.ExecuteReader();
                                dr.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error saving diagnosis: " + ex.ToString());
                    }
                }
                MessageBox.Show("Diagnosis successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                diagnosis.LoadDiagnosis(val.PatientPrimaryID, this.gridDiagnosisRecord);

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
            else if(this.btnSaveDiagnosis.Enabled == true || !String.IsNullOrWhiteSpace(this.txtDiagnosis.Text))
            {
                MessageBox.Show("Please save diagnosis first!", "Save First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnSaveDiagnosis.Focus();
            }
            else if (patient.SavePatientCompleteConsultation(val.PatientPrimaryID, this.txtPatientID.Text, val.PatientPrimaryID, val.PatientFullName,
                this.txtPrescription.Text))
            {
                MessageBox.Show("Patient successfully saved!", "Success", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

                prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptionsRecord);

                this.btnSavePrescription.Enabled = false;
                this.btnBack.Enabled = false;
                this.btnAnotherBack.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to save patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (patient.BackPatientToScheduleFromConsultation(this.txtPatientID.Text, val.PatientPrimaryID))
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
                if (patient.BackPatientToScheduleFromConsultation(this.txtPatientID.Text, val.PatientPrimaryID))
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
