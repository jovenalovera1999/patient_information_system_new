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

        void autoGenNum()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while(generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
        }

        private void frmPatientProfileNew_Load(object sender, EventArgs e)
        {
            autoGenNum();

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

        }

        private void gridDiagnosis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gridManageSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void gridPrescriptions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

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

        }

        private void btnEditDoctors_Click(object sender, EventArgs e)
        {

        }

        private void btnEditDiagnosis_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSymptoms_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPrescriptions_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPayment_Click(object sender, EventArgs e)
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
