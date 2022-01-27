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

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;

                if (s == 60)
                {
                    s = 00;
                }
                this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

                if (this.lblTime.Text == "12:00:00 am")
                {
                    this.lblDate.Text = DateTime.Now.ToString("D");
                }
            }));
        }

        void LoadForm()
        {
            t = new System.Timers.Timer();
            t.Interval = 1000; // Seconds
            t.Elapsed += OnTimeEvent;

            this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            this.lblDate.Text = DateTime.Now.Date.ToString("D");

            t.Start();

            if (val.UserRole == "Doctor")
            {
                this.btnDoctors.Visible = false;
                this.btnSignUp.Visible = false;
                this.btnReport.Visible = false;
                this.btnUpdateHistory.Visible = false;
            }
            else if (val.UserRole == "Medical Staff")
            {
                this.btnDoctors.Visible = false;
                this.btnSignUp.Visible = false;
                this.btnReport.Visible = false;
                this.btnUpdateHistory.Visible = false;
            }
        }

        void GoToSchedule()
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmSchedule frmSchedule = new forms.frmSchedule();
            frmSchedule.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmSchedule);
            frmSchedule.Dock = DockStyle.Fill;
            frmSchedule.Show();
        }

        void GoToPatient()
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmPatients frmPatient = new forms.frmPatients();
            frmPatient.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmPatient);
            frmPatient.Dock = DockStyle.Fill;
            frmPatient.Show();
        }

        void GoToDoctors()
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmListOfDoctors frmListOfDoctors = new forms.frmListOfDoctors();
            frmListOfDoctors.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmListOfDoctors);
            frmListOfDoctors.Dock = DockStyle.Fill;
            frmListOfDoctors.Show();
        }

        void GoToInventory()
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmInventory frmInventory = new forms.frmInventory();
            frmInventory.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmInventory);
            frmInventory.Dock = DockStyle.Fill;
            frmInventory.Show();
        }

        void GoToSignUp()
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmSignUp frmSignUp = new forms.frmSignUp();
            frmSignUp.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmSignUp);
            frmSignUp.Dock = DockStyle.Fill;
            frmSignUp.Show();
        }

        void GoToReport()
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmReport frmReport = new forms.frmReport();
            frmReport.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmReport);
            frmReport.Dock = DockStyle.Fill;
            frmReport.Show();
        }

        void GoToUpdateHistory()
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmUpdateHistory frmUpdateHistory = new forms.frmUpdateHistory();
            frmUpdateHistory.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmUpdateHistory);
            frmUpdateHistory.Dock = DockStyle.Fill;
            frmUpdateHistory.Show();
        }

        void GoToProfile()
        {
            this.pnlDashboardBody.Controls.Clear();
            forms.frmMyProfile frmMyProfile = new forms.frmMyProfile();
            frmMyProfile.TopLevel = false;
            this.pnlDashboardBody.Controls.Add(frmMyProfile);
            frmMyProfile.Dock = DockStyle.Fill;
            frmMyProfile.Show();
        }

        void Logout()
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                forms.frmLogin login = new forms.frmLogin();
                login.Show();
                this.pnlDashboardBody.Controls.Clear();
                this.Close();
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            GoToSchedule();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            GoToPatient();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            GoToDoctors();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            GoToInventory();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            GoToSignUp();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            GoToReport();
        }

        private void btnUpdateHistory_Click(object sender, EventArgs e)
        {
            GoToUpdateHistory();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            GoToProfile();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Dispose();
            t.Stop();
        }
    }
}
