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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmSchedule frmSchedule = new forms.frmSchedule();
            frmSchedule.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmSchedule);
            frmSchedule.Dock = DockStyle.Fill;
            frmSchedule.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmPatient frmPatient = new forms.frmPatient();
            frmPatient.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmPatient);
            frmPatient.Dock = DockStyle.Fill;
            frmPatient.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmSignUp frmSignUp = new forms.frmSignUp();
            frmSignUp.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmSignUp);
            frmSignUp.Dock = DockStyle.Fill;
            frmSignUp.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            forms.frmMyProfile frmMyProfile = new forms.frmMyProfile();
            frmMyProfile.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmMyProfile);
            frmMyProfile.Dock = DockStyle.Fill;
            frmMyProfile.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                forms.frmLogin login = new forms.frmLogin();
                login.Show();
                this.pnlDashboardBody.Controls.Clear();
                this.Close();
            }
        }
    }
}
