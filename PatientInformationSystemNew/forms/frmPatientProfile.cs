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
        functions.VitalSigns vital_signs = new functions.VitalSigns();
        functions.Doctor doctor = new functions.Doctor();

        void LoadPatientDetails()
        {
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
            this.txtDoctor.Text = val.PatientDoctor;
            this.txtFullName.Text = val.PatientFullName;
        }

        void LoadFromVitalSignsToPaymentHistory()
        {
            vital_signs.LoadVitalSigns(val.PatientPrimaryID, this.gridVitalSigns);
            diagnosis.LoadDiagnosis(val.PatientPrimaryID, this.gridDiagnosis);
            symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptoms);
            prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptions);
            payment.LoadPaymentHistory(val.PatientPrimaryID, this.gridPaymentHistory);
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

        // Key Press

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
            // Allows 0-9, backspace, decimal and slash
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 47))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 slash is allowed
            if (e.KeyChar == 47)
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
            // Allows 0-9, backspace, decimal and slash
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 47))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 slash is allowed
            if (e.KeyChar == 47)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtReceiptNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTotalMedicalFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        // Text Changed

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.txtWeight.Text) && String.IsNullOrWhiteSpace(this.txtTemperature.Text))
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

        private void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtDiagnosis.Text))
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
            if (String.IsNullOrWhiteSpace(this.txtSymptoms.Text))
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

        private void txtPrescriptions_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtPrescriptions.Text))
            {
                this.btnAddPrescriptions.Enabled = false;
                this.btnSavePrescriptions.Enabled = false;
                this.btnPrintPrescriptions.Enabled = false;
            }
            else
            {
                this.btnAddPrescriptions.Enabled = true;
                this.btnSavePrescriptions.Enabled = true;
                this.btnPrintPrescriptions.Enabled = true;
            }
        }

        private void txtReceiptNo_TextChanged(object sender, EventArgs e)
        {
            if (this.btnSavePayment.Enabled == true)
            {
                this.btnSavePayment.Enabled = false;
            }
        }

        private void txtTotalMedicalFee_TextChanged(object sender, EventArgs e)
        {
            if (this.btnSavePayment.Enabled == true)
            {
                this.btnSavePayment.Enabled = false;
            }
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.btnSavePayment.Enabled == true)
            {
                this.btnSavePayment.Enabled = false;
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (this.btnSavePayment.Enabled == true)
            {
                this.btnSavePayment.Enabled = false;
            }
        }

        private void frmPatientProfileNew_Load(object sender, EventArgs e)
        {
            if (val.UserRole == "Doctor")
            {
                this.lblDoctor.Visible = false;
                this.txtDoctor.Visible = false;
            }

            for (int i = 0; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }

            this.dateVitalSigns.Value = DateTime.Now;
            this.dateDiagnosis.Value = DateTime.Now;
            this.dateSymptoms.Value = DateTime.Now;
            this.datePrescriptions.Value = DateTime.Now;

            LoadPatientDetails();
            LoadFromVitalSignsToPaymentHistory();
        }

        // Cell Mouse Click Once

        private void gridVitalSigns_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridVitalSigns.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridVitalSigns.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtHeight.Text = this.gridVitalSigns.SelectedCells[1].Value.ToString();
            this.txtWeight.Text = this.gridVitalSigns.SelectedCells[2].Value.ToString();
            this.txtTemperature.Text = this.gridVitalSigns.SelectedCells[3].Value.ToString();
            this.txtPulseRate.Text = this.gridVitalSigns.SelectedCells[4].Value.ToString();
            this.txtBloodPressure.Text = this.gridVitalSigns.SelectedCells[5].Value.ToString();
            this.dateVitalSigns.Value = DateTime.Parse(this.gridVitalSigns.SelectedCells[6].Value.ToString());

            this.btnEditVitalSigns.Enabled = true;
        }

        private void gridDiagnosis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtDiagnosis.Text = this.gridDiagnosis.SelectedCells[1].Value.ToString();
            this.dateDiagnosis.Value = DateTime.Parse(this.gridDiagnosis.SelectedCells[2].Value.ToString());

            this.btnEditDiagnosis.Enabled = true;
        }

        private void gridSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSymptoms.Text = this.gridSymptoms.SelectedCells[1].Value.ToString();
            this.dateSymptoms.Value = DateTime.Parse(this.gridSymptoms.SelectedCells[2].Value.ToString());

            this.btnEditSymptoms.Enabled = true;
        }

        private void gridPrescriptions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtPrescriptions.Text = this.gridPrescriptions.SelectedCells[1].Value.ToString();
            this.datePrescriptions.Value = DateTime.Parse(this.gridPrescriptions.SelectedCells[2].Value.ToString());

            this.btnEditPrescriptions.Enabled = true;
        }

        private void gridPaymentHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPaymentHistory.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridPaymentHistory.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtReceiptNo.Text = this.gridPaymentHistory.SelectedCells[1].Value.ToString();
            this.txtTotalMedicalFee.Text = this.gridPaymentHistory.SelectedCells[2].Value.ToString();
            this.cmbDiscount.Text = this.gridPaymentHistory.SelectedCells[3].Value.ToString();
            this.txtAmount.Text = this.gridPaymentHistory.SelectedCells[4].Value.ToString();
            this.txtTotalAmountPaid.Text = this.gridPaymentHistory.SelectedCells[5].Value.ToString();
            this.txtChange.Text = this.gridPaymentHistory.SelectedCells[6].Value.ToString();

            this.btnSavePayment.Enabled = false;
            this.btnEditPayment.Enabled = true;
            this.btnPrintPaymentHistory.Enabled = true;
        }

        // Edit

        private void btnEditPersonalInfo_Click(object sender, EventArgs e)
        {
            this.txtFirstName.ReadOnly = false;
            this.txtMiddleName.ReadOnly = false;
            this.txtLastName.ReadOnly = false;
            this.txtGender.Visible = false;
            this.txtAge.Visible = false;
            this.txtAddress.ReadOnly = false;
            this.txtBirthday.Visible = false;
            this.txtCellphoneNumber.ReadOnly = false;
            this.txtTelephoneNumber.ReadOnly = false;
            this.txtEmail.ReadOnly = false;
            this.btnEditPersonalInfo.Enabled = false;

            this.cmbGender.Visible = true;
            this.cmbAge.Visible = true;
            this.dateBirthday.Visible = true;
            this.btnSavePersonalInfo.Enabled = true;

            this.txtFirstName.TabStop = true;
            this.txtMiddleName.TabStop = true;
            this.txtLastName.TabStop = true;
            this.cmbGender.TabStop = true;
            this.cmbAge.TabStop = true;
            this.txtAddress.TabStop = true;
            this.dateBirthday.TabStop = true;
            this.txtCellphoneNumber.TabStop = true;
            this.txtTelephoneNumber.TabStop = true;
            this.txtEmail.TabStop = true;

            this.txtFirstName.Focus();
        }

        private void btnEditVitalSigns_Click(object sender, EventArgs e)
        {
            this.btnAddVitalSigns.Visible = false;
            this.btnCancelVitalSigns.Visible = false;

            this.txtHeight.ReadOnly = false;
            this.txtWeight.ReadOnly = false;
            this.txtTemperature.ReadOnly = false;
            this.txtPulseRate.ReadOnly = false;
            this.txtBloodPressure.ReadOnly = false;
            this.dateVitalSigns.Enabled = true;

            this.txtHeight.TabStop = true;
            this.txtWeight.TabStop = true;
            this.txtTemperature.TabStop = true;
            this.txtPulseRate.TabStop = true;
            this.txtBloodPressure.TabStop = true;
            this.dateVitalSigns.TabStop = true;

            this.btnSaveVitalSigns.Visible = true;
            this.btnRemoveVitalSigns.Visible = true;

            this.btnNewVitalSigns.Enabled = true;
            this.btnEditVitalSigns.Enabled = false;

            this.txtHeight.Focus();
        }

        private void btnEditDiagnosis_Click(object sender, EventArgs e)
        {
            this.btnAddDiagnosis.Visible = false;
            this.btnCancelDiagnosis.Visible = false;

            this.txtDiagnosis.ReadOnly = false;
            this.dateDiagnosis.Enabled = true;

            this.txtDiagnosis.TabStop = true;
            this.dateDiagnosis.TabStop = true;

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

            this.txtSymptoms.ReadOnly = false;
            this.dateSymptoms.Enabled = true;

            this.txtSymptoms.TabStop = true;
            this.dateSymptoms.TabStop = true;

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

            this.txtPrescriptions.ReadOnly = false;
            this.datePrescriptions.Enabled = true;

            this.txtPrescriptions.TabStop = true;
            this.datePrescriptions.TabStop = true;

            this.btnSavePrescriptions.Visible = true;
            this.btnRemovePrescriptions.Visible = true;

            this.btnNewPrescriptions.Enabled = true;
            this.btnEditPrescriptions.Enabled = false;
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            this.txtReceiptNo.ReadOnly = false;
            this.txtTotalMedicalFee.ReadOnly = false;
            this.cmbDiscount.Enabled = true;
            this.txtAmount.ReadOnly = false;
            this.btnTransact.Visible = true;

            this.btnEditPayment.Enabled = false;

            this.txtReceiptNo.TabStop = true;
            this.txtTotalMedicalFee.TabStop = true;
            this.cmbDiscount.TabStop = true;
            this.txtAmount.TabStop = true;

            this.txtReceiptNo.Focus();
        }

        // New

        private void btnNewVitalSigns_Click(object sender, EventArgs e)
        {
            this.txtHeight.ResetText();
            this.txtWeight.ResetText();
            this.txtTemperature.ResetText();
            this.txtPulseRate.ResetText();
            this.txtBloodPressure.ResetText();
            this.dateVitalSigns.Value = DateTime.Now;

            vital_signs.LoadVitalSigns(val.PatientPrimaryID, this.gridVitalSigns);

            this.btnAddVitalSigns.Visible = true;
            this.btnCancelVitalSigns.Visible = true;

            this.btnNewVitalSigns.Enabled = false;
            this.btnEditVitalSigns.Enabled = false;
            this.btnAddVitalSigns.Enabled = false;
            this.btnSaveVitalSigns.Visible = false;
            this.btnRemoveVitalSigns.Visible = false;

            this.txtHeight.ReadOnly = false;
            this.txtWeight.ReadOnly = false;
            this.txtTemperature.ReadOnly = false;
            this.txtPulseRate.ReadOnly = false;
            this.txtBloodPressure.ReadOnly = false;
            this.dateVitalSigns.Enabled = true;

            this.txtHeight.TabStop = true;
            this.txtWeight.TabStop = true;
            this.txtTemperature.TabStop = true;
            this.txtPulseRate.TabStop = true;
            this.txtBloodPressure.TabStop = true;
            this.dateVitalSigns.TabStop = true;

            this.txtHeight.Focus();
        }

        private void btnNewDiagnosis_Click(object sender, EventArgs e)
        {
            this.txtDiagnosis.ResetText();
            this.dateDiagnosis.Value = DateTime.Now;

            diagnosis.LoadDiagnosis(val.PatientPrimaryID, this.gridDiagnosis);

            this.btnAddDiagnosis.Visible = true;
            this.btnCancelDiagnosis.Visible = true;

            this.btnNewDiagnosis.Enabled = false;
            this.btnEditDiagnosis.Enabled = false;
            this.btnSaveDiagnosis.Visible = false;
            this.btnRemoveDiagnosis.Visible = false;

            this.txtDiagnosis.ReadOnly = false;
            this.dateDiagnosis.Enabled = true;

            this.txtDiagnosis.TabStop = true;
            this.dateDiagnosis.TabStop = true;

            this.txtDiagnosis.Focus();
        }

        private void btnNewSymptoms_Click(object sender, EventArgs e)
        {
            this.txtSymptoms.ResetText();
            this.dateSymptoms.Value = DateTime.Now;

            symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptoms);

            this.btnAddSymptoms.Visible = true;
            this.btnCancelSymptoms.Visible = true;

            this.btnNewSymptoms.Enabled = false;
            this.btnEditSymptoms.Enabled = false;
            this.btnSaveSymptoms.Visible = false;
            this.btnRemoveSymptoms.Visible = false;

            this.txtSymptoms.ReadOnly = false;
            this.dateSymptoms.Enabled = true;

            this.txtSymptoms.TabStop = true;
            this.dateSymptoms.TabStop = true;

            this.txtSymptoms.Focus();
        }

        private void btnNewPrescriptions_Click(object sender, EventArgs e)
        {
            this.txtPrescriptions.ResetText();
            prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptions);

            this.btnAddPrescriptions.Visible = true;
            this.btnCancelPrescriptions.Visible = true;

            this.btnNewPrescriptions.Enabled = false;
            this.btnEditPrescriptions.Enabled = false;
            this.btnSavePrescriptions.Visible = false;
            this.btnRemovePrescriptions.Visible = false;

            this.txtPrescriptions.ReadOnly = false;
            this.datePrescriptions.Enabled = true;

            this.txtPrescriptions.TabStop = true;
            this.datePrescriptions.TabStop = true;

            this.txtPrescriptions.Focus();
        }

        // Add

        private void btnAddVitalSigns_Click(object sender, EventArgs e)
        {
            if (vital_signs.AddVitalSigns(val.PatientPrimaryID, this.txtHeight.Text, this.txtWeight.Text, this.txtTemperature.Text,
                this.txtPulseRate.Text, this.txtBloodPressure.Text, this.dateVitalSigns.Value, val.UserFullName, val.PatientFullName,
                string.Format("Added Vital Signs!\r\n" +
                "Height: {0}\r\n" +
                "Weight: {1}\r\n" +
                "Temperature: {2}\r\n" +
                "Pulse Rate: {3}\r\n" +
                "Blood Pressure: {4}\r\n" +
                "Date: {5}",
                this.txtHeight.Text,
                this.txtWeight.Text,
                this.txtTemperature.Text,
                this.txtPulseRate.Text,
                this.txtBloodPressure.Text,
                this.dateVitalSigns.Value.ToString("D"))))
            {
                MessageBox.Show("Vital signs successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                vital_signs.LoadVitalSigns(val.PatientPrimaryID, this.gridVitalSigns);

                this.txtHeight.ResetText();
                this.txtWeight.ResetText();
                this.txtTemperature.ResetText();
                this.txtPulseRate.ResetText();
                this.txtBloodPressure.ResetText();
                this.dateVitalSigns.Value = DateTime.Now;

                this.txtHeight.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add vital signs!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            if (diagnosis.AddDiagnosis(val.PatientPrimaryID, this.txtDiagnosis.Text, this.dateDiagnosis.Value, val.UserFullName, val.PatientFullName,
                string.Format("Added Diagnosis!\r\n" +
                "Diagnosis: {0}\r\n" +
                "Date: {1}",
                this.txtDiagnosis.Text,
                this.dateDiagnosis.Value.ToString("D"))))
            {
                MessageBox.Show("Diagnosis successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                diagnosis.LoadDiagnosis(val.PatientPrimaryID, this.gridDiagnosis);

                this.txtDiagnosis.ResetText();
                this.dateDiagnosis.Value = DateTime.Now;

                this.txtDiagnosis.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add diagnosis!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSymptoms_Click(object sender, EventArgs e)
        {
            if (symptoms.AddSymptom(val.PatientPrimaryID, this.txtSymptoms.Text, this.dateSymptoms.Value, val.UserFullName, val.PatientFullName,
                string.Format("Added Symptom!\r\n" +
                "Symptom: {0}\r\n" +
                "Date: {1}",
                this.txtSymptoms.Text,
                this.dateSymptoms.Value.ToString("D"))))
            {
                MessageBox.Show("Symptom successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptoms);

                this.txtSymptoms.ResetText();
                this.dateSymptoms.Value = DateTime.Now;

                this.txtSymptoms.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPrescriptions_Click(object sender, EventArgs e)
        {
            if (prescriptions.AddPrescription(val.PatientPrimaryID, this.txtPrescriptions.Text, this.datePrescriptions.Value, val.UserFullName, val.PatientFullName,
                string.Format("Added Prescription!\r\n" +
                "Prescription:\r\n\r\n" +
                "{0}\r\n\r\n" +
                "Date: {1}",
                this.txtPrescriptions.Text,
                this.datePrescriptions.Value.ToString("D"))))
            {
                MessageBox.Show("Prescription successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptions);

                this.txtPrescriptions.ResetText();
                this.datePrescriptions.Value = DateTime.Now;

                this.txtPrescriptions.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add prescription!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel

        private void btnCancelVitalSigns_Click(object sender, EventArgs e)
        {
            vital_signs.LoadVitalSigns(val.PatientPrimaryID, this.gridVitalSigns);

            this.txtHeight.ResetText();
            this.txtWeight.ResetText();
            this.txtTemperature.ResetText();
            this.txtPulseRate.ResetText();
            this.txtBloodPressure.ResetText();
            this.dateVitalSigns.Value = DateTime.Now;

            this.txtHeight.ReadOnly = true;
            this.txtWeight.ReadOnly = true;
            this.txtTemperature.ReadOnly = true;
            this.txtPulseRate.ReadOnly = true;
            this.txtBloodPressure.ReadOnly = true;
            this.dateVitalSigns.Enabled = false;

            this.txtHeight.TabStop = false;
            this.txtWeight.TabStop = false;
            this.txtTemperature.TabStop = false;
            this.txtPulseRate.TabStop = false;
            this.txtBloodPressure.TabStop = false;
            this.dateVitalSigns.TabStop = false;

            this.btnAddVitalSigns.Visible = false;
            this.btnCancelVitalSigns.Visible = false;
            this.btnNewVitalSigns.Enabled = true;
        }

        private void btnCancelDiagnosis_Click(object sender, EventArgs e)
        {
            diagnosis.LoadDiagnosis(val.PatientPrimaryID, this.gridDiagnosis);

            this.txtDiagnosis.ResetText();
            this.dateDiagnosis.Value = DateTime.Now;

            this.txtDiagnosis.ReadOnly = true;
            this.dateDiagnosis.Enabled = false;

            this.txtDiagnosis.TabStop = false;
            this.dateDiagnosis.TabStop = false;

            this.btnAddDiagnosis.Visible = false;
            this.btnCancelDiagnosis.Visible = false;
            this.btnNewDiagnosis.Enabled = true;
        }

        private void btnCancelSymptoms_Click(object sender, EventArgs e)
        {
            symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptoms);

            this.txtSymptoms.ResetText();
            this.dateSymptoms.Value = DateTime.Now;

            this.txtSymptoms.ReadOnly = true;
            this.dateSymptoms.Enabled = false;

            this.txtSymptoms.TabStop = false;
            this.dateSymptoms.TabStop = false;

            this.btnAddSymptoms.Visible = false;
            this.btnCancelSymptoms.Visible = false;
            this.btnNewSymptoms.Enabled = true;
        }

        private void btnCancelPrescriptions_Click(object sender, EventArgs e)
        {
            prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptions);

            this.txtPrescriptions.ResetText();
            this.datePrescriptions.Value = DateTime.Now;

            this.txtPrescriptions.ReadOnly = true;
            this.datePrescriptions.Enabled = false;

            this.txtPrescriptions.TabStop = false;
            this.datePrescriptions.TabStop = false;

            this.btnAddPrescriptions.Visible = false;
            this.btnCancelPrescriptions.Visible = false;
            this.btnPrintPrescriptions.Enabled = false;
            this.btnNewPrescriptions.Enabled = true;
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
            else if (patient.UpdatePatient(val.PatientPrimaryID, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text,
                this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text,
                this.txtTelephoneNumber.Text, this.txtEmail.Text, val.UserFullName, val.PatientFullName,
                string.Format("Updated Patient Personal Info!\r\n" +
                "First Name: from ({0}) to ({1})\r\n" +
                "Middle Name: from ({2}) to ({3})\r\n" +
                "Last Name: from ({4}) to ({5})\r\n" +
                "Gender: from ({6}) to ({7})\r\n" +
                "Age: from ({8}) to ({9})\r\n" +
                "Address: from ({10}) to ({11})\r\n" +
                "Birthday: from ({12}) to ({13})\r\n" +
                "Cellphone Number: from ({14}) to ({15})\r\n" +
                "Telephone Number: from ({16}) to ({17})\r\n" +
                "Email: from ({18}) to ({19})",
                val.PatientFirstName, this.txtFirstName.Text,
                val.PatientMiddleName, this.txtMiddleName.Text,
                val.PatientLastName, this.txtLastName.Text,
                val.PatientGender, this.cmbGender.Text,
                val.PatientAge, this.cmbAge.Text,
                val.PatientAddress, this.txtAddress.Text,
                val.PatientBirthday.ToString("D"), this.dateBirthday.Value.Date.ToString("D"),
                val.PatientCellphoneNumer, this.txtCellphoneNumber.Text,
                val.PatientTelephoneNumber, this.txtTelephoneNumber.Text,
                val.PatientEmail, this.txtEmail.Text)))
            {
                MessageBox.Show("Patient successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (patient.GetPatient(val.PatientPrimaryID))
                {
                    LoadPatientDetails();
                    LoadFromVitalSignsToPaymentHistory();
                }

                this.txtFirstName.ReadOnly = true;
                this.txtMiddleName.ReadOnly = true;
                this.txtLastName.ReadOnly = true;
                this.txtGender.Visible = true;
                this.txtAge.Visible = true;
                this.txtAddress.ReadOnly = true;
                this.txtBirthday.Visible = true;
                this.txtCellphoneNumber.ReadOnly = true;
                this.txtTelephoneNumber.ReadOnly = true;
                this.txtEmail.ReadOnly = true;
                this.btnEditPersonalInfo.Enabled = true;

                this.cmbGender.Visible = false;
                this.cmbAge.Visible = false;
                this.dateBirthday.Visible = false;
                this.btnSavePersonalInfo.Enabled = false;

                this.txtFirstName.TabStop = false;
                this.txtMiddleName.TabStop = false;
                this.txtLastName.TabStop = false;
                this.cmbGender.TabStop = false;
                this.cmbAge.TabStop = false;
                this.txtAddress.TabStop = false;
                this.dateBirthday.TabStop = false;
                this.txtCellphoneNumber.TabStop = false;
                this.txtTelephoneNumber.TabStop = false;
                this.txtEmail.TabStop = false;

                this.btnEditPersonalInfo.Focus();
            }
            else
            {
                MessageBox.Show("Failed to update patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveVitalSigns_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(this.gridVitalSigns.SelectedCells[6].Value.ToString());

            if (vital_signs.UpdateVitalSigns(int.Parse(this.gridVitalSigns.SelectedCells[0].Value.ToString()), this.txtHeight.Text,
                this.txtWeight.Text, this.txtTemperature.Text, this.txtPulseRate.Text, this.txtBloodPressure.Text, this.dateVitalSigns.Value,
                val.UserFullName, val.PatientFullName,
                string.Format("Updated Vital Signs!\r\n" +
                "Height: from ({0}) to ({1})\r\n" +
                "Weight: from ({2}) to ({3})\r\n" +
                "Temperature: from ({4}) to ({5})\r\n" +
                "Pulse Rate: from ({6}) to ({7})\r\n" +
                "Blood Pressure: from ({8}) to ({9})\r\n" +
                "Date: from ({10}) to ({11})",
                this.gridVitalSigns.SelectedCells[1].Value.ToString(), this.txtHeight.Text,
                this.gridVitalSigns.SelectedCells[2].Value.ToString(), this.txtWeight.Text,
                this.gridVitalSigns.SelectedCells[3].Value.ToString(), this.txtTemperature.Text,
                this.gridVitalSigns.SelectedCells[4].Value.ToString(), this.txtPulseRate.Text,
                this.gridVitalSigns.SelectedCells[5].Value.ToString(), this.txtBloodPressure.Text,
                date.ToString("D"), this.dateVitalSigns.Value.ToString("D"))))
            {
                MessageBox.Show("Vital signs successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                vital_signs.LoadVitalSigns(val.PatientPrimaryID, this.gridVitalSigns);

                this.txtHeight.ResetText();
                this.txtWeight.ResetText();
                this.txtTemperature.ResetText();
                this.txtPulseRate.ResetText();
                this.txtBloodPressure.ResetText();
                this.dateVitalSigns.Value = DateTime.Now;

                this.txtHeight.ReadOnly = true;
                this.txtWeight.ReadOnly = true;
                this.txtTemperature.ReadOnly = true;
                this.txtPulseRate.ReadOnly = true;
                this.txtBloodPressure.ReadOnly = true;
                this.dateVitalSigns.Enabled = false;

                this.txtHeight.TabStop = false;
                this.txtWeight.TabStop = false;
                this.txtTemperature.TabStop = false;
                this.txtPulseRate.TabStop = false;
                this.txtBloodPressure.TabStop = false;
                this.dateVitalSigns.TabStop = false;

                this.btnSaveVitalSigns.Visible = false;
                this.btnRemoveVitalSigns.Visible = false;

                this.btnEditVitalSigns.Focus();
            }
            else
            {
                MessageBox.Show("Failed to update vital signs!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveDiagnosis_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(this.gridDiagnosis.SelectedCells[2].Value.ToString());

            if (diagnosis.UpdateDiagnosis(int.Parse(this.gridDiagnosis.SelectedCells[0].Value.ToString()), this.txtDiagnosis.Text,
                this.dateDiagnosis.Value, val.UserFullName, val.PatientFullName,
                string.Format("Updated Diagnosis!\r\n" +
                "Diagnosis: from ({0}) to ({1})\r\n" +
                "Date: from ({2}) to ({3})",
                this.gridDiagnosis.SelectedCells[1].Value.ToString(), this.txtDiagnosis.Text,
                date.ToString("D"), this.dateDiagnosis.Value.ToString("D"))))
            {
                MessageBox.Show("Diagnosis successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                diagnosis.LoadDiagnosis(val.PatientPrimaryID, this.gridDiagnosis);

                this.txtDiagnosis.ResetText();
                this.dateDiagnosis.Value = DateTime.Now;

                this.txtDiagnosis.ReadOnly = true;
                this.dateDiagnosis.Enabled = false;

                this.txtDiagnosis.TabStop = false;
                this.dateDiagnosis.TabStop = false;

                this.btnSaveDiagnosis.Visible = false;
                this.btnRemoveDiagnosis.Visible = false;

                this.btnEditDiagnosis.Focus();
            }
            else
            {
                MessageBox.Show("Failed to update diagnosis!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSymptoms_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(this.gridSymptoms.SelectedCells[2].Value.ToString());

            if (symptoms.UpdateSymptom(int.Parse(this.gridSymptoms.SelectedCells[0].Value.ToString()), this.txtSymptoms.Text, this.dateSymptoms.Value,
                val.UserFullName, val.PatientFullName,
                string.Format("Updated Patient Symptom!\r\n" +
                "Symptom: from ({0}) to ({1})\r\n" +
                "Date: from ({2}) to ({3})",
                this.gridSymptoms.SelectedCells[1].Value.ToString(), this.txtSymptoms.Text,
                date.ToString("D"), this.dateSymptoms.Value.ToString("D"))))
            {
                MessageBox.Show("Symptom successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptoms);

                this.txtSymptoms.ResetText();
                this.dateSymptoms.Value = DateTime.Now;

                this.txtSymptoms.ReadOnly = true;
                this.dateSymptoms.Enabled = false;

                this.txtSymptoms.TabStop = false;
                this.dateSymptoms.TabStop = false;

                this.btnSaveSymptoms.Visible = false;
                this.btnRemoveSymptoms.Visible = false;

                this.btnEditSymptoms.Focus();
            }
            else
            {
                MessageBox.Show("Error updating symptom!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePrescriptions_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(this.gridPrescriptions.SelectedCells[2].Value.ToString());

            if (prescriptions.UpdatePrescriptions(int.Parse(this.gridPrescriptions.SelectedCells[0].Value.ToString()),
                this.txtPrescriptions.Text, this.datePrescriptions.Value, val.UserFullName, val.PatientFullName,
                string.Format("Updated Prescription!\r\n" +
                "Prescription:\r\n\r\n" +
                "from\r\n\r\n" +
                "{0}\r\n\r\n" +
                "to\r\n\r\n" +
                "{1}\r\n" +
                "Date: from ({2}) to ({3})",
                this.gridPrescriptions.SelectedCells[1].Value.ToString(), this.txtPrescriptions.Text,
                date.ToString("D"), this.datePrescriptions.Value.ToString("D"))))
            {
                MessageBox.Show("Prescription successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptions);

                this.txtPrescriptions.ResetText();
                this.datePrescriptions.Value = DateTime.Now;

                this.txtPrescriptions.ReadOnly = true;
                this.datePrescriptions.Enabled = false;

                this.txtPrescriptions.TabStop = false;
                this.datePrescriptions.TabStop = false;

                this.btnSavePrescriptions.Visible = false;
                this.btnRemovePrescriptions.Visible = false;
                this.btnPrintPrescriptions.Enabled = false;

                this.btnEditPrescriptions.Focus();
            }
            else
            {
                MessageBox.Show("Failed to update prescription!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtTotalMedicalFee.Text))
            {
                MessageBox.Show("Please input total medical fee first!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTotalMedicalFee.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                MessageBox.Show("Please input amount first!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTotalMedicalFee.Focus();
            }
            else if (MessageBox.Show("Save update payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (payment.UpdatePaymentTransaction(int.Parse(this.gridPaymentHistory.SelectedCells[0].Value.ToString()), this.txtReceiptNo.Text,
                this.txtTotalMedicalFee.Text, this.cmbDiscount.Text, this.txtAmount.Text, this.txtTotalAmountPaid.Text, this.txtChange.Text,
                val.UserFullName, val.PatientFullName, string.Format("Updated Payment Transaction!\r\n" +
                "Receipt No: from ({0}) to ({1})\r\n" +
                "Total Medical Fee: from ({2}) to ({3})\r\n" +
                "Discount: from ({4}) to ({5})\r\n" +
                "Amount: from ({6}) to ({7})\r\n" +
                "Total Amount Paid: from ({8}) to ({9})\r\n" +
                "Change from ({10}) to ({11})",
                this.gridPaymentHistory.SelectedCells[1].Value.ToString(), this.txtReceiptNo.Text,
                this.gridPaymentHistory.SelectedCells[2].Value.ToString(), this.txtTotalMedicalFee.Text,
                this.gridPaymentHistory.SelectedCells[3].Value.ToString(), this.cmbDiscount.Text,
                this.gridPaymentHistory.SelectedCells[4].Value.ToString(), this.txtAmount.Text,
                this.gridPaymentHistory.SelectedCells[5].Value.ToString(), this.txtTotalAmountPaid.Text,
                this.gridPaymentHistory.SelectedCells[6].Value.ToString(), this.txtChange.Text)))
                {
                    MessageBox.Show("Payment successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    payment.LoadPaymentHistory(val.PatientPrimaryID, this.gridPaymentHistory);

                    this.txtReceiptNo.ReadOnly = true;
                    this.txtTotalMedicalFee.ReadOnly = true;
                    this.cmbDiscount.Enabled = false;
                    this.txtAmount.ReadOnly = true;
                    this.btnTransact.Visible = false;
                    this.btnSavePayment.Enabled = false;

                    this.txtReceiptNo.TabStop = false;
                    this.txtTotalMedicalFee.TabStop = false;
                    this.cmbDiscount.TabStop = false;
                    this.txtAmount.TabStop = false;

                    this.btnBackInPaymentHistory.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to update payment!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Remove

        private void btnRemoveVitalSigns_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(this.gridVitalSigns.SelectedCells[6].Value.ToString());

            if (vital_signs.RemoveVitalSigns(int.Parse(this.gridVitalSigns.SelectedCells[0].Value.ToString()), val.UserFullName, val.PatientFullName,
                string.Format("Vital Signs Removed!\r\n" +
                "Height: {0}\r\n" +
                "Weight: {1}\r\n" +
                "Temperature: {2}\r\n" +
                "Pulse Rate: {3}\r\n" +
                "Blood Pressure: {4}\r\n" +
                "Date: {5}",
                this.gridVitalSigns.SelectedCells[1].Value.ToString(),
                this.gridVitalSigns.SelectedCells[2].Value.ToString(),
                this.gridVitalSigns.SelectedCells[3].Value.ToString(),
                this.gridVitalSigns.SelectedCells[4].Value.ToString(),
                this.gridVitalSigns.SelectedCells[5].Value.ToString(),
                date.ToString("D"))))
            {
                MessageBox.Show("Vital signs successfully removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                vital_signs.LoadVitalSigns(val.PatientPrimaryID, this.gridVitalSigns);

                this.txtHeight.ResetText();
                this.txtWeight.ResetText();
                this.txtTemperature.ResetText();
                this.txtPulseRate.ResetText();
                this.txtBloodPressure.ResetText();
                this.dateVitalSigns.Value = DateTime.Now;

                this.txtHeight.ReadOnly = true;
                this.txtWeight.ReadOnly = true;
                this.txtTemperature.ReadOnly = true;
                this.txtPulseRate.ReadOnly = true;
                this.txtBloodPressure.ReadOnly = true;
                this.dateVitalSigns.Enabled = false;

                this.txtHeight.TabStop = false;
                this.txtWeight.TabStop = false;
                this.txtTemperature.TabStop = false;
                this.txtPulseRate.TabStop = false;
                this.txtBloodPressure.TabStop = false;
                this.dateVitalSigns.TabStop = false;

                this.btnSaveVitalSigns.Visible = false;
                this.btnRemoveVitalSigns.Visible = false;
                this.btnEditVitalSigns.Enabled = false;

                this.btnNewVitalSigns.Focus();
            }
            else
            {
                MessageBox.Show("Failed to remove vital signs!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveDiagnosis_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(this.gridDiagnosis.SelectedCells[2].Value.ToString());

            if (diagnosis.RemoveDiagnosis(int.Parse(this.gridDiagnosis.SelectedCells[0].Value.ToString()), val.UserFullName, val.PatientFullName,
                string.Format("Diagnosis Removed!\r\n" +
                "Diagnosis: {0}\r\n" +
                "Date: {1}",
                this.gridDiagnosis.SelectedCells[1].Value.ToString(),
                date.ToString("D"))))
            {
                MessageBox.Show("Diagnosis successfully removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                diagnosis.LoadDiagnosis(val.PatientPrimaryID, this.gridDiagnosis);

                this.txtDiagnosis.ResetText();
                this.dateDiagnosis.Value = DateTime.Now;

                this.txtDiagnosis.ReadOnly = true;
                this.dateDiagnosis.Enabled = false;

                this.txtDiagnosis.TabStop = false;
                this.dateDiagnosis.TabStop = false;

                this.btnSaveDiagnosis.Visible = false;
                this.btnRemoveDiagnosis.Visible = false;
                this.btnEditDiagnosis.Enabled = false;

                this.btnNewDiagnosis.Focus();
            }
            else
            {
                MessageBox.Show("Failed to remove diagnosis!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSymptoms_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(this.gridSymptoms.SelectedCells[2].Value.ToString());

            if (symptoms.RemoveSymptom(int.Parse(this.gridSymptoms.SelectedCells[0].Value.ToString()), val.UserFullName, val.PatientFullName,
                string.Format("Symptom Removed!\r\n" +
                "Symptom: {0}\r\n" +
                "Date: {1}",
                this.gridSymptoms.SelectedCells[1].Value.ToString(),
                date.ToString("D"))))
            {
                MessageBox.Show("Symptom successfully removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                symptoms.LoadSymptoms(val.PatientPrimaryID, this.gridSymptoms);

                this.txtSymptoms.ResetText();
                this.dateSymptoms.Value = DateTime.Now;

                this.txtSymptoms.ReadOnly = true;
                this.dateSymptoms.Enabled = false;

                this.txtSymptoms.TabStop = false;
                this.dateSymptoms.TabStop = false;

                this.btnSaveSymptoms.Visible = false;
                this.btnRemoveSymptoms.Visible = false;
                this.btnEditSymptoms.Enabled = false;

                this.btnNewSymptoms.Focus();
            }
            else
            {
                MessageBox.Show("Failed to remove symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemovePrescriptions_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(this.gridPrescriptions.SelectedCells[2].Value.ToString());

            if (prescriptions.RemovePrescriptions(int.Parse(this.gridPrescriptions.SelectedCells[0].Value.ToString()), val.UserFullName, val.PatientFullName,
                string.Format("Prescription Removed!\r\n" +
                "Prescription:\r\n\r\n" +
                "{0}\r\n\r\n" +
                "Date: {1}",
                this.gridPrescriptions.SelectedCells[1].Value.ToString(),
                date.ToString("D"))))
            {
                MessageBox.Show("Prescription successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                prescriptions.LoadPrescriptions(val.PatientPrimaryID, this.gridPrescriptions);

                this.txtPrescriptions.ResetText();
                this.datePrescriptions.Value = DateTime.Now;

                this.txtPrescriptions.ReadOnly = true;
                this.datePrescriptions.Enabled = false;

                this.txtPrescriptions.TabStop = false;
                this.datePrescriptions.TabStop = false;

                this.btnSavePrescriptions.Visible = false;
                this.btnRemovePrescriptions.Visible = false;
                this.btnEditPrescriptions.Enabled = false;

                this.btnNewPrescriptions.Focus();
            }
            else
            {
                MessageBox.Show("Failed to remove prescription!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    this.txtTotalAmountPaid.Text = double.Parse(this.txtTotalMedicalFee.Text).ToString("0.00");
                    this.txtChange.Text = total.ToString("0.00");
                }
                else if (this.cmbDiscount.Text == "PWD")
                {
                    discount = (double.Parse(this.txtTotalMedicalFee.Text) * pwd);
                    discounted = (double.Parse(this.txtTotalMedicalFee.Text) - discount);
                    total = (double.Parse(this.txtAmount.Text) - discounted);

                    this.txtTotalAmountPaid.Text = discounted.ToString("0.00");
                    this.txtChange.Text = total.ToString("0.00");
                }
                else if (this.cmbDiscount.Text == "Senior Citizen")
                {
                    discount = (double.Parse(this.txtTotalMedicalFee.Text) * senior_citizen);
                    discounted = (double.Parse(this.txtTotalMedicalFee.Text) - discount);
                    total = (double.Parse(this.txtAmount.Text) - discounted);

                    this.txtTotalAmountPaid.Text = discounted.ToString("0.00");
                    this.txtChange.Text = total.ToString("0.00");
                }
                else if (this.cmbDiscount.Text == "VIP")
                {
                    discount = (double.Parse(this.txtTotalMedicalFee.Text) * vip);
                    discounted = (double.Parse(this.txtTotalMedicalFee.Text) - discount);
                    total = (double.Parse(this.txtAmount.Text) - discounted);

                    this.txtTotalAmountPaid.Text = discounted.ToString("0.00");
                    this.txtChange.Text = total.ToString("0.00");
                }
            }
            this.btnSavePayment.Enabled = true;
        }

        // Print

        private void btnPrintPrescriptions_Click(object sender, EventArgs e)
        {
            doctor.GetDoctorID(val.PatientDoctorPrimaryID);

            this.rprtPrescription.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pFullName", val.PatientFullName));
            parameters.Add(new ReportParameter("pAge", this.txtAge.Text));
            parameters.Add(new ReportParameter("pSex", this.txtGender.Text.Substring(0, 1)));
            parameters.Add(new ReportParameter("pAddress", this.txtAddress.Text));
            parameters.Add(new ReportParameter("pDate", this.datePrescriptions.Value.ToString("MM/dd/yyyy")));
            parameters.Add(new ReportParameter("pPrescription", this.txtPrescriptions.Text));
            parameters.Add(new ReportParameter("pMedicalPersonnelID", val.DoctorID));
            this.rprtPrescription.LocalReport.SetParameters(parameters);
            this.rprtPrescription.SetDisplayMode(DisplayMode.PrintLayout);
            this.rprtPrescription.RefreshReport();
        }

        private void btnPrintPaymentHistory_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt no is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtReceiptNo.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtTotalMedicalFee.Text))
            {
                MessageBox.Show("Total medical fee is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTotalMedicalFee.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                MessageBox.Show("Amount is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAmount.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtTotalAmountPaid.Text) || String.IsNullOrWhiteSpace(this.txtChange.Text))
            {
                MessageBox.Show("Please transact first before printing!", "Transact First", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime date = DateTime.Parse(this.gridPaymentHistory.SelectedCells[8].Value.ToString());

                this.rprtReceipt.Clear();
                ReportParameterCollection parameters = new ReportParameterCollection();
                parameters.Add(new ReportParameter("pReceiptNo", this.txtReceiptNo.Text));
                parameters.Add(new ReportParameter("pDate", date.ToString("MM/dd/yyyy")));
                parameters.Add(new ReportParameter("pName", this.txtFullName.Text));
                parameters.Add(new ReportParameter("pTotalMedicalFee", this.txtTotalMedicalFee.Text));
                parameters.Add(new ReportParameter("pDiscount", this.cmbDiscount.Text));
                parameters.Add(new ReportParameter("pAmount", this.txtAmount.Text));
                parameters.Add(new ReportParameter("pTotalAmountPaid", this.txtTotalAmountPaid.Text));
                parameters.Add(new ReportParameter("pChange", this.txtChange.Text));
                parameters.Add(new ReportParameter("pCashier", this.gridPaymentHistory.SelectedCells[7].Value.ToString()));
                this.rprtReceipt.LocalReport.SetParameters(parameters);
                rprtReceipt.SetDisplayMode(DisplayMode.PrintLayout);
                this.rprtReceipt.RefreshReport();
            }
        }

        // Back

        private void btnBackInPeronalInfo_Click(object sender, EventArgs e)
        {
            BackToPatients();
        }

        private void btnBackVitalSigns_Click(object sender, EventArgs e)
        {
            BackToPatients();
        }

        private void btnBackInDiagnosis_Click_1(object sender, EventArgs e)
        {
            BackToPatients();
        }

        private void btnBackInSymptoms_Click(object sender, EventArgs e)
        {
            BackToPatients();
        }

        private void btnBackInPrintPrescription_Click(object sender, EventArgs e)
        {
            BackToPatients();
        }

        private void btnBackInPrescriptions_Click(object sender, EventArgs e)
        {
            BackToPatients();
        }

        private void btnBackInPaymentHistory_Click(object sender, EventArgs e)
        {
            BackToPatients();
        }
    }
}