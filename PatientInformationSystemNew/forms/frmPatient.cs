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
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnPaymentTransaction_Click(object sender, EventArgs e)
        {

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
    }
}
