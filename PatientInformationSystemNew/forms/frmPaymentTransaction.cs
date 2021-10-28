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

        private void frmPaymentTransaction_Load(object sender, EventArgs e)
        {
            payment.loadPatientUnpaid(this.gridPaymentTransaction);
            this.cmbDiscount.Text = "None";
            this.txtReceiptNo.Focus();
        }

        private void gridPaymentTransaction_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPaymentTransaction.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPaymentTransaction.RowsDefaultCellStyle.SelectionForeColor = Color.White;

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

                string first_name = this.gridPaymentTransaction.SelectedCells[1].Value.ToString();
                string middle_name = this.gridPaymentTransaction.SelectedCells[2].Value.ToString();
                string last_name = this.gridPaymentTransaction.SelectedCells[3].Value.ToString();

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
        }
    }
}
