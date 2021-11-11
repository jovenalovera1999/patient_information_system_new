using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PatientInformationSystemNew.forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        System.Timers.Timer t;
        int s;

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000; // Seconds
            t.Elapsed += OnTimeEvent;

            this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            this.lblDate.Text = DateTime.Now.Date.ToString("D");

            t.Start();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;

                if(s == 60)
                {
                    s = 00;
                }
                this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            }));
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
            forms.frmPatients frmPatient = new forms.frmPatients();
            frmPatient.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmPatient);
            frmPatient.Dock = DockStyle.Fill;
            frmPatient.Show();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmListOfDoctors frmListOfDoctors = new forms.frmListOfDoctors();
            frmListOfDoctors.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmListOfDoctors);
            frmListOfDoctors.Dock = DockStyle.Fill;
            frmListOfDoctors.Show();
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
            this.pnlDashboardBody.Controls.Clear();
            forms.frmMyProfileNew frmMyProfileNew = new forms.frmMyProfileNew();
            frmMyProfileNew.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmMyProfileNew);
            frmMyProfileNew.Dock = DockStyle.Fill;
            frmMyProfileNew.Show();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                forms.frmLogin login = new forms.frmLogin();
                login.Show();
                this.pnlDashboardBody.Controls.Clear();
                t.Stop();
                this.Close();
            }
        }
    }
}
