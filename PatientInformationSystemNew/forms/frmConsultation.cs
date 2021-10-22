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
    public partial class frmConsultation : Form
    {
        public frmConsultation()
        {
            InitializeComponent();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            forms.frmConsultationPrescription frmConsultationPrescription = new forms.frmConsultationPrescription();
            frmConsultationPrescription.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmConsultationPrescription);
            frmConsultationPrescription.Dock = DockStyle.Fill;
            frmConsultationPrescription.Show();
        }
    }
}