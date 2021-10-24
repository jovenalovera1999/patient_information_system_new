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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.User login = new functions.User();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtUsername.Text) && String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Username and Password are required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                MessageBox.Show("Username is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Password is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
            }
            else if(login.userAuthentication(this.txtUsername.Text, this.txtPassword.Text))
            {
                forms.frmDashboard frmDashboard = new forms.frmDashboard();
                frmDashboard.Show();
                this.Hide();
            }
            else if(login.userAuthenticationForAdministratorOnly(this.txtUsername.Text, this.txtPassword.Text))
            {
                forms.frmDashboard frmDashboard = new forms.frmDashboard();
                frmDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password! Please try again!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.ResetText();
                this.txtPassword.ResetText();
                this.txtUsername.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.OpenForms["frmLogin"].Close();
            this.Close();
        }
    }
}
