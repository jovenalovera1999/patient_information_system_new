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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.User user = new functions.User();
        functions.Duplicate duplicate = new functions.Duplicate();

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }
            this.dateBirthday.Value = DateTime.Now;
        }

        string imgLocation = "";
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                this.picProfilePicture.ImageLocation = imgLocation;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(duplicate.usernameDuplicate(this.txtUsername.Text))
            {
                MessageBox.Show("Username is already taken! Please choose different username!", "Already Taken", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                this.txtUsername.ResetText();
                this.txtUsername.Focus();
            }
            else
            {
                if(String.IsNullOrWhiteSpace(this.txtUserID.Text))
                {
                    MessageBox.Show("User ID is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUserID.Focus();
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
                else if(String.IsNullOrWhiteSpace(this.txtFirstname.Text))
                {
                    MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtFirstname.Focus();
                }
                else if(String.IsNullOrWhiteSpace(this.txtLastname.Text))
                {
                    MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtLastname.Focus();
                }
                else if()
                {

                }
            }
        }
    }
}
