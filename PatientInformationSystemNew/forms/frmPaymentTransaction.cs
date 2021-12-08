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
    public partial class frmPaymentTransaction : Form
    {
        public frmPaymentTransaction()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.PaymentTransactions payment = new functions.PaymentTransactions();
        functions.Duplicate duplicate = new functions.Duplicate();

        private void frmPaymentTransaction_Load(object sender, EventArgs e)
        {
            payment.LoadPatientUnpaid(this.gridPaymentTransaction);
            this.cmbDiscount.Text = "None";
            this.btnSaveTransaction.Enabled = false;
            this.txtReceiptNo.Focus();
        }

        private void gridPaymentTransaction_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPaymentTransaction.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPaymentTransaction.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            payment.GetPatientIDForPaymentTransaction(this.gridPaymentTransaction.SelectedCells[0].Value.ToString());

            string first_name = this.gridPaymentTransaction.SelectedCells[1].Value.ToString();
            string middle_name = this.gridPaymentTransaction.SelectedCells[2].Value.ToString();
            string last_name = this.gridPaymentTransaction.SelectedCells[3].Value.ToString();

            if(String.IsNullOrWhiteSpace(middle_name))
            {
                this.txtFullName.Text = string.Format("{0} {1}", first_name, last_name);
            }
            else
            {
                this.txtFullName.Text = string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name);
            }
            this.txtReceiptNo.Focus();
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            double pwd = .20;
            double senior_citizen = .20;
            double vip = .15;
            double discount;
            double discounted;
            double total;

            if(String.IsNullOrWhiteSpace(this.txtFullName.Text))
            {
                MessageBox.Show("Choose patient first before transact!", "Choose First", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(String.IsNullOrWhiteSpace(this.txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt number is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(String.IsNullOrWhiteSpace(this.txtTotalMedicalFee.Text))
            {
                MessageBox.Show("Input total medical fee first before transact!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(String.IsNullOrWhiteSpace(this.txtAmount.Text))
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
                this.rprtReceipt.Clear();
                ReportParameterCollection parameters = new ReportParameterCollection();
                parameters.Add(new ReportParameter("pName", this.txtFullName.Text));
                parameters.Add(new ReportParameter("pReceiptNo", this.txtReceiptNo.Text));
                parameters.Add(new ReportParameter("pDate", DateTime.Now.ToString("MM/dd/yy")));
                parameters.Add(new ReportParameter("pTotalMedicalFee", this.txtTotalMedicalFee.Text));
                parameters.Add(new ReportParameter("pDiscount", this.cmbDiscount.Text));
                parameters.Add(new ReportParameter("pAmount", this.txtAmount.Text));
                parameters.Add(new ReportParameter("pTotalAmountPaid", this.txtTotalAmountPaid.Text));
                parameters.Add(new ReportParameter("pChange", this.txtChange.Text));
                parameters.Add(new ReportParameter("pCashier", val.UserFullName));
                this.rprtReceipt.LocalReport.SetParameters(parameters);
                this.rprtReceipt.RefreshReport();
            }
            this.btnSaveTransaction.Enabled = true;
        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }

            if (MessageBox.Show("Save payment transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (duplicate.TransactionIDDuplicate(val.PatientFullName, generateID.ToString()))
                {
                    MessageBox.Show("Transaction ID is already taken! Please click again!", "Already Taken", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (payment.SavePatientPayment(val.PatientPrimaryIDForPaymentTransaction, val.PatientPrimaryIDForPaymentTransaction,
                    generateID.ToString(), this.txtFullName.Text, this.txtReceiptNo.Text, this.txtTotalMedicalFee.Text, this.cmbDiscount.Text, this.txtAmount.Text, 
                    this.txtTotalAmountPaid.Text, this.txtChange.Text, val.UserFullName))
                {
                    MessageBox.Show("Payment transaction successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.gridPaymentTransaction.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                    this.gridPaymentTransaction.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                    payment.LoadPatientUnpaid(this.gridPaymentTransaction);

                    this.rprtReceipt.Clear();

                    this.txtFullName.ResetText();
                    this.txtReceiptNo.ResetText();
                    this.txtTotalMedicalFee.ResetText();
                    this.txtAmount.ResetText();
                    this.txtTotalAmountPaid.ResetText();
                    this.txtChange.ResetText();

                    this.cmbDiscount.Text = "None";
                    this.btnSaveTransaction.Enabled = false;

                    this.txtReceiptNo.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to save payment transaction!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            forms.frmPatients frmPatient = new forms.frmPatients();
            frmPatient.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPatient);
            frmPatient.Dock = DockStyle.Fill;
            frmPatient.Show();
            this.Close();
        }
    }
}
