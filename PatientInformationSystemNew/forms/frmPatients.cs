using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientInformationSystemNew.forms
{
    public partial class frmPatients : Form
    {
        public frmPatients()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();
        functions.Search search = new functions.Search();

        void GetPatient()
        {
            if (patient.GetPatient(int.Parse(this.gridPatients.SelectedCells[0].Value.ToString())))
            {
                forms.frmPatientProfile frmPatientProfile = new forms.frmPatientProfile();
                frmPatientProfile.TopLevel = false;
                forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
                Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
                pnlDashboardBody.Controls.Add(frmPatientProfile);
                frmPatientProfile.Dock = DockStyle.Fill;
                frmPatientProfile.Show();
                this.Close();
            }
        }

        void LoadPatientByDate()
        {
            if (val.UserRole == "Doctor")
            {
                patient.LoadDoctorPatientsByDate(val.UserPrimaryID, dateFrom.Value.Date, dateTo.Value.Date, gridPatients);
            }
            else
            {
                patient.LoadPatientsByDate(dateFrom.Value.Date, dateTo.Value.Date, gridPatients);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (val.UserRole == "Doctor")
            {
                if(String.IsNullOrWhiteSpace(this.txtSearch.Text))
                {
                    patient.LoadDoctorPatientsByDate(val.UserPrimaryID, dateFrom.Value.Date, dateTo.Value.Date, this.gridPatients);
                }
                else
                {
                    search.SearchPatientByDoctor(val.UserPrimaryID, this.txtSearch.Text, dateFrom.Value.Date, dateTo.Value, this.gridPatients);
                }
            }
            else
            {
                if(String.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    patient.LoadPatientsByDate(dateFrom.Value.Date, dateTo.Value.Date, gridPatients);
                }
                else
                {
                    search.SearchPatient(this.txtSearch.Text, dateFrom.Value.Date, dateTo.Value.Date, this.gridPatients);
                }
            }
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
            if (val.UserRole == "Doctor")
            {
                this.btnPaymentTransaction.Visible = false;
                this.btnAddPatient.Visible = false;
                patient.LoadDoctorPatients(val.UserPrimaryID, this.gridPatients);
            }
            else
            {
                patient.LoadPatients(this.gridPatients);
            }
            this.txtSearch.Focus();
        }

        private void dateFrom_onValueChanged(object sender, EventArgs e)
        {
            LoadPatientByDate();
        }

        private void dateTo_onValueChanged(object sender, EventArgs e)
        {
            LoadPatientByDate();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            GetPatient();
        }

        private void btnPaymentTransaction_Click(object sender, EventArgs e)
        {
            forms.frmPaymentTransaction frmPaymentTransaction = new forms.frmPaymentTransaction();
            frmPaymentTransaction.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmPaymentTransaction);
            frmPaymentTransaction.Dock = DockStyle.Fill;
            frmPaymentTransaction.Show();
            this.Close();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            forms.frmAddPatient frmAddPatient = new forms.frmAddPatient();
            frmAddPatient.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmAddPatient);
            frmAddPatient.Dock = DockStyle.Fill;
            frmAddPatient.Show();
            this.Close();
        }

        private void gridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPatients.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridPatients.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            string first_name = this.gridPatients.SelectedCells[2].Value.ToString();
            string middle_name = this.gridPatients.SelectedCells[3].Value.ToString();
            string last_name = this.gridPatients.SelectedCells[4].Value.ToString();

            this.txtPatientID.Text = this.gridPatients.SelectedCells[1].Value.ToString();

            if (String.IsNullOrWhiteSpace(middle_name))
            {
                this.txtPatientName.Text = string.Format("{0} {1}", first_name, last_name);
            }
            else
            {
                this.txtPatientName.Text = string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name);
            }

            this.btnSelect.Enabled = true;
        }

        private void gridPatients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetPatient();
        }
    }
}
