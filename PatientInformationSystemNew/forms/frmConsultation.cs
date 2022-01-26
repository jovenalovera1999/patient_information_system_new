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
            LoadForm();
        }

        private void gridDiagnosis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectDiagnosis();
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            AddDiagnosis();
        }

        private void btnRemoveDiagnosis_Click(object sender, EventArgs e)
        {
            RemoveDiagnosis();
        }

        private void gridSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectSymptom();
        }

        private void btnAddSymptoms_Click(object sender, EventArgs e)
        {
            AddSymptom();
        }

        private void btnUpdateSymptoms_Click(object sender, EventArgs e)
        {
            UpdateSymptom();
        }

        private void btnRemoveSymptoms_Click(object sender, EventArgs e)
        {
            RemoveSymptom();
        }

        private void btnSaveDiagnosis_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSavePrescription_Click(object sender, EventArgs e)
        {
            SavePrescription();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            PrintPrescription();
        }

        private void btnDoneConsulting_Click(object sender, EventArgs e)
        {
            DoneConsulting();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToSchedule();
        }

        private void btnAnotherBack_Click(object sender, EventArgs e)
        {
            BackToSchedule();
        }

        void LoadPatientDetails()
        {
            this.txtPatientID.Text = val.PatientID;
            this.txtFirstName.Text = val.PatientFirstName;
            this.txtMiddleName.Text = val.PatientMiddleName;
            this.txtLastName.Text = val.PatientLastName;
            this.txtGender.Text = val.PatientGender;
            this.txtAge.Text = val.PatientAge;
            this.txtAddress.Text = val.PatientAddress;
            this.txtBirthday.Text = val.PatientBirthday.ToString("D");
            this.txtCellphoneNumber.Text = val.PatientCellphoneNumer;
            this.txtTelephoneNumber.Text = val.PatientTelephoneNumber;
            this.txtEmail.Text = val.PatientEmail;
            this.txtHeight.Text = val.PatientHeight;
            this.txtWeight.Text = val.PatientWeight;
            this.txtTemperature.Text = val.PatientTemperature;
            this.txtPulseRate.Text = val.PatientPulseRate;
            this.txtBloodPressure.Text = val.PatientBloodPressure;
        }

        void LoadForm()
        {
            LoadPatientDetails();

            symptoms.LoadSymptomsInConsultation(val.PatientPrimaryID, this.gridSymptoms);
            symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptomsRecord);
            diagnosis.LoadDiagnosis(val.PatientPrimaryID, this.gridDiagnosisRecord);
            prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptionsRecord);
        }

        void ResetDiagnosis()
        {
            this.txtDiagnosis.ResetText();
            this.txtDiagnosis.Focus();

            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        void SelectDiagnosis()
        {
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.btnRemoveDiagnosis.Enabled = true;
        }

        void AddDiagnosis()
        {
            int n = this.gridDiagnosis.Rows.Add();
            this.gridDiagnosis.Rows[n].Cells[0].Value = this.txtDiagnosis.Text;

            ResetDiagnosis();
        }

        void RemoveDiagnosis()
        {
            foreach (DataGridViewRow row in this.gridDiagnosis.SelectedRows)
            {
                this.gridDiagnosis.Rows.Remove(row);
            }

            this.btnRemoveDiagnosis.Enabled = false;
            ResetDiagnosis();
        }

        void SaveDiagnosis()
        {
            for (int i = 0; i < this.gridDiagnosis.Rows.Count; i++)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(con.conString()))
                    {
                        string sql = @"DELETE FROM pis_db.diagnosis
                                       WHERE
                                       patient_fid = @patient_fid AND
                                       CAST(AES_DECRYPT(diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @diagnosis AND
                                       CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                       INSERT INTO pis_db.diagnosis(patient_fid, diagnosis)
                                       VALUES(
                                       @patient_fid,
                                       AES_ENCRYPT(@diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang')
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
        }

        void ResetSymptoms()
        {
            this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.btnUpdateSymptoms.Enabled = false;
            this.btnRemoveSymptoms.Enabled = false;

            symptoms.LoadSymptomsInConsultation(val.PatientPrimaryID, this.gridSymptoms);
            symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptomsRecord);

            this.txtSymptoms.ResetText();
            this.txtSymptoms.Focus();
        }

        void SelectSymptom()
        {
            this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.btnUpdateSymptoms.Enabled = true;
            this.btnRemoveSymptoms.Enabled = true;

            this.txtSymptoms.Focus();
        }

        void AddSymptom()
        {
            if (symptoms.AddSymptomInConsultation(val.PatientPrimaryID, this.txtSymptoms.Text))
            {
                ResetSymptoms();
            }
            else
            {
                MessageBox.Show("Failed to add patient symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateSymptom()
        {
            if (symptoms.UpdateSymptomInConsultation(int.Parse(this.gridSymptoms.SelectedCells[0].Value.ToString()), this.txtSymptoms.Text))
            {
                MessageBox.Show("Symptom updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetSymptoms();
            }
            else
            {
                MessageBox.Show("Failed to update patient symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void RemoveSymptom()
        {
            if (symptoms.RemoveSymptomInConsultation(int.Parse(this.gridSymptoms.SelectedCells[0].Value.ToString())))
            {
                MessageBox.Show("Symptom removed!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetSymptoms();
            }
            else
            {
                MessageBox.Show("Failed to delete patient symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SavePrescription()
        {
            if (String.IsNullOrWhiteSpace(this.txtPrescription.Text))
            {
                MessageBox.Show("Please input prescription first before proceed!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPrescription.Focus();
            }
            else if (patient.SavePrescription(val.PatientPrimaryID, this.txtPrescription.Text))
            {
                MessageBox.Show("Prescription successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptionsRecord);
                
                this.txtPrescription.Focus();
                this.btnDoneConsulting.Enabled = true;

                this.txtDiagnosis.ResetText();
                this.txtSymptoms.ResetText();

                this.btnRemoveDiagnosis.Enabled = false;
                this.btnUpdateSymptoms.Enabled = false;
                this.btnRemoveSymptoms.Enabled = false;

                this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Failed to save prescription!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void PrintPrescription()
        {
            this.rprtPrescription.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pFullName", val.PatientFullName));
            parameters.Add(new ReportParameter("pAge", this.txtAge.Text));
            parameters.Add(new ReportParameter("pSex", this.txtGender.Text.Substring(0, 1)));
            parameters.Add(new ReportParameter("pAddress", this.txtAddress.Text));
            parameters.Add(new ReportParameter("pDate", DateTime.Now.Date.ToString("MM/dd/yy")));
            parameters.Add(new ReportParameter("pPrescription", this.txtPrescription.Text));
            this.rprtPrescription.LocalReport.SetParameters(parameters);
            this.rprtPrescription.RefreshReport();
        }

        void OpenFormSchedule()
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

        void DoneConsulting()
        {
            if (MessageBox.Show("Done Consulting? This form will automatically close once clicked yes!", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(duplicate.DuplicatePatientInGeneral(this.txtPatientID.Text))
                {
                    if(patient.DoneConsultingWithFirstAccountExisting(this.txtPatientID.Text, val.PatientPrimaryID, val.PatientFullName))
                    {
                        SaveDiagnosis();
                        MessageBox.Show("Patient successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OpenFormSchedule();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(patient.DoneConsulting(this.txtPatientID.Text, val.PatientPrimaryID, val.PatientFullName))
                {
                    SaveDiagnosis();
                    MessageBox.Show("Patient successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenFormSchedule();
                }
                else
                {
                    MessageBox.Show("Failed to save patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void BackToSchedule()
        {
            if (MessageBox.Show("Are you sure you want to go back? The changes in symptoms will be saved!", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (patient.BackPatientToScheduleFromConsultation(this.txtPatientID.Text, val.PatientPrimaryID))
                {
                    OpenFormSchedule();
                }
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

        private void tabConsultation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabConsultation.SelectedIndex == 1)
            {
                this.txtDiagnosis.Focus();
            }
        }
    }
}
