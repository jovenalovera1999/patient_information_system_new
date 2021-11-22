using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            for(int i = 1; i < 80; i++)
            {
                this.cmbAge.Items.Add(i);
            }
            this.dateBirthday.Value = DateTime.Now;
        }

        private void txtCellphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, plus sign, open and close parenthesis, and space
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 43 && e.KeyChar != 40 && e.KeyChar != 41 && e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 plus sign is allowed
            if (e.KeyChar == 43)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 open parenthesis is allowed
            if (e.KeyChar == 40)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 close parenthesis is allowed
            if (e.KeyChar == 41)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9, backspace, plus sign, open and close parenthesis, and space
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 43 && e.KeyChar != 40 && e.KeyChar != 41 && e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
            // Checks to make sure only 1 plus sign is allowed
            if (e.KeyChar == 43)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 open parenthesis is allowed
            if (e.KeyChar == 40)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
            // Checks to make sure only 1 close parenthesis is allowed
            if (e.KeyChar == 41)
            {
                if ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }

        string imgLocation = "";
        private void btnUploadPhoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                this.picProfilePicture.ImageLocation = imgLocation;
            }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            imgLocation = null;
            this.picProfilePicture.ImageLocation = null;
            this.picProfilePicture.Image = null;
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
            else if (String.IsNullOrWhiteSpace(this.txtUserID.Text))
            {
                MessageBox.Show("User ID is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUserID.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                MessageBox.Show("Username is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                MessageBox.Show("Password is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtFirstname.Text))
            {
                MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstname.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtLastname.Text))
            {
                MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLastname.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.cmbGender.Text))
            {
                MessageBox.Show("Gender is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbGender.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.cmbAge.Text))
            {
                MessageBox.Show("Age is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbAge.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAddress.Text))
            {
                MessageBox.Show("Address is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddress.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(this.txtTelephoneNumber.Text) &&
                String.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                MessageBox.Show("Contact Information are required! Please input atleast one contact information!", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCellphoneNumber.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.cmbRole.Text))
            {
                MessageBox.Show("Role is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbRole.Focus();
            }
            else if (this.cmbRole.Text == "Doctor" && String.IsNullOrWhiteSpace(this.txtSpecialization.Text))
            {
                MessageBox.Show("Specialization is required for doctor!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSpecialization.Focus();
            }
            else if (this.cmbRole.Text == "Medical Staff" && !String.IsNullOrWhiteSpace(this.txtSpecialization.Text))
            {
                MessageBox.Show("Only doctor can have a specialization", "Doctor Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUserID.Focus();
            }
            else if(String.IsNullOrWhiteSpace(imgLocation)) 
            {
                if(user.signUp(this.txtUserID.Text, null, this.txtUsername.Text, this.txtPassword.Text, this.txtFirstname.Text, this.txtMiddlename.Text,
                    this.txtLastname.Text, this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date, 
                    this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text, this.cmbRole.Text, this.txtSpecialization.Text))
                {
                    MessageBox.Show("User account has been successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.txtUserID.ResetText();
                    this.txtUsername.ResetText();
                    this.txtPassword.ResetText();
                    this.txtFirstname.ResetText();
                    this.txtMiddlename.ResetText();
                    this.txtLastname.ResetText();
                    this.txtAddress.ResetText();
                    this.txtCellphoneNumber.ResetText();
                    this.txtTelephoneNumber.ResetText();
                    this.txtEmail.ResetText();
                    this.txtSpecialization.ResetText();

                    this.cmbGender.Text = null;
                    this.cmbAge.Text = null;
                    this.cmbRole.Text = null;

                    this.dateBirthday.Value = DateTime.Now.Date;

                    this.txtUserID.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to create user account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(!String.IsNullOrWhiteSpace(imgLocation))
            {
                byte[] profilePicture = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                profilePicture = br.ReadBytes((int)fs.Length);

                if(user.signUp(this.txtUserID.Text, profilePicture, this.txtUsername.Text, this.txtPassword.Text, this.txtFirstname.Text,
                    this.txtMiddlename.Text, this.txtLastname.Text, this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text,
                    this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text,
                    this.cmbRole.Text, this.txtSpecialization.Text))
                {
                    MessageBox.Show("User account has been successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.txtUserID.ResetText();
                    this.txtUsername.ResetText();
                    this.txtPassword.ResetText();
                    this.txtFirstname.ResetText();
                    this.txtMiddlename.ResetText();
                    this.txtLastname.ResetText();
                    this.txtAddress.ResetText();
                    this.txtCellphoneNumber.ResetText();
                    this.txtTelephoneNumber.ResetText();
                    this.txtEmail.ResetText();
                    this.txtSpecialization.ResetText();

                    imgLocation = null;
                    this.picProfilePicture.ImageLocation = null;
                    this.picProfilePicture.Image = null;
                    this.cmbGender.Text = null;
                    this.cmbAge.Text = null;
                    this.cmbRole.Text = null;

                    this.dateBirthday.Value = DateTime.Now.Date;

                    this.txtUserID.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to create user account!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
