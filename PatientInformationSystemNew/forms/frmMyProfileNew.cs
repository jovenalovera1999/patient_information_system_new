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
    public partial class frmMyProfileNew : Form
    {
        public frmMyProfileNew()
        {
            InitializeComponent();
        }

        components.Connections connection = new components.Connections();
        components.Values val = new components.Values();

        functions.User user = new functions.User();
        functions.Patient patient = new functions.Patient();

        private void frmMyProfileNew_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }

            if (val.UserProfilePicture != null)
            {
                MemoryStream ms = new MemoryStream(val.UserProfilePicture);
                this.picProfilePicture.Image = Image.FromStream(ms);
            }

            this.txtMyID.Text = val.UserID;
            this.txtUsername.Text = val.UserUsername;
            this.txtPassword.Text = val.UserPassword;
            this.txtFirstName.Text = val.UserFirstName;
            this.txtMiddleName.Text = val.UserMiddleName;
            this.txtLastName.Text = val.UserLastName;
            this.txtGender.Text = val.UserGender;
            this.cmbGender.Text = val.UserGender;
            this.txtAge.Text = val.UserAge;
            this.cmbAge.Text = val.UserAge;
            this.txtAddress.Text = val.UserAddress;
            this.dateBirthday.Value = val.UserBirthday;
            this.txtCellphoneNumber.Text = val.UserCellphoneNumber;
            this.txtTelephoneNumber.Text = val.UserTelephoneNumber;
            this.txtEmail.Text = val.UserEmail;
            this.txtRole.Text = val.UserRole;

            if (val.UserRole != "Doctor")
            {
                this.tabControlUser.TabPages.Remove(tabMyPatients);
            }
            else
            {
                patient.LoadDoctorPatients(this.txtFirstName.Text, this.txtLastName.Text, val.UserSpecialization, this.gridPatients);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtUsername.Enabled = true;
            this.txtPassword.Enabled = true;
            this.txtFirstName.Enabled = true;
            this.txtMiddleName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.cmbGender.Visible = true;
            this.cmbAge.Visible = true;
            this.txtAddress.Enabled = true;
            this.dateBirthday.Enabled = true;
            this.txtCellphoneNumber.Enabled = true;
            this.txtTelephoneNumber.Enabled = true;
            this.txtEmail.Enabled = true;
            this.btnUploadPhoto.Visible = true;
            this.btnRemovePhoto.Visible = true;
            this.btnSave.Enabled = true;

            this.txtGender.Visible = false;
            this.txtAge.Visible = false;
            this.btnEdit.Enabled = false;

            this.txtMyID.Focus();
        }

        string imgLocation = "";
        private void btnUploadPhoto_Click(object sender, EventArgs e)
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
            val.UserProfilePicture = null;
            imgLocation = null;
            this.picProfilePicture.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtMyID.Text))
            {
                MessageBox.Show("User ID is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMyID.Focus();
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
            else if (String.IsNullOrWhiteSpace(this.txtFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLastName.Focus();
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
            else if (String.IsNullOrWhiteSpace(imgLocation))
            {
                // User already with or without profile picture

                if (user.UpdateUser(val.UserPrimaryID, val.UserProfilePicture, this.txtUsername.Text, this.txtPassword.Text, this.txtFirstName.Text,
                    this.txtMiddleName.Text, this.txtLastName.Text, this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text,
                    this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text))
                {
                    MessageBox.Show("Your profile has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (user.GetUser(this.txtMyID.Text))
                    {
                        if (val.UserProfilePicture != null)
                        {
                            MemoryStream ms = new MemoryStream(val.UserProfilePicture);
                            this.picProfilePicture.Image = Image.FromStream(ms);
                        }

                        this.txtMyID.Text = val.UserID;
                        this.txtUsername.Text = val.UserUsername;
                        this.txtPassword.Text = val.UserPassword;
                        this.txtFirstName.Text = val.UserFirstName;
                        this.txtMiddleName.Text = val.UserMiddleName;
                        this.txtLastName.Text = val.UserLastName;
                        this.cmbGender.Text = val.UserGender;
                        this.txtGender.Text = val.UserGender;
                        this.cmbAge.Text = val.UserAge;
                        this.txtAge.Text = val.UserAge;
                        this.txtAddress.Text = val.UserAddress;
                        this.dateBirthday.Value = val.UserBirthday;
                        this.txtCellphoneNumber.Text = val.UserCellphoneNumber;
                        this.txtTelephoneNumber.Text = val.UserTelephoneNumber;
                        this.txtEmail.Text = val.UserEmail;
                        this.txtRole.Text = val.UserRole;
                    }

                    this.txtUsername.Enabled = false;
                    this.txtPassword.Enabled = false;
                    this.txtFirstName.Enabled = false;
                    this.txtMiddleName.Enabled = false;
                    this.txtLastName.Enabled = false;
                    this.cmbGender.Visible = false;
                    this.cmbAge.Visible = false;
                    this.txtAddress.Enabled = false;
                    this.dateBirthday.Enabled = false;
                    this.txtCellphoneNumber.Enabled = false;
                    this.txtTelephoneNumber.Enabled = false;
                    this.txtEmail.Enabled = false;
                    this.btnUploadPhoto.Visible = false;
                    this.btnRemovePhoto.Visible = false;
                    this.btnSave.Enabled = false;

                    this.txtGender.Visible = true;
                    this.txtAge.Visible = true;
                    this.btnEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Failed to update your profile!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!String.IsNullOrWhiteSpace(imgLocation))
            {
                // With new profile picture

                byte[] profilePicture = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                profilePicture = br.ReadBytes((int)fs.Length);

                if (user.UpdateUser(val.UserPrimaryID, profilePicture, this.txtUsername.Text, this.txtPassword.Text, this.txtFirstName.Text,
                    this.txtMiddleName.Text, this.txtLastName.Text, this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date,
                    this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text))
                {
                    MessageBox.Show("Your profile has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (user.GetUser(this.txtMyID.Text))
                    {
                        if (val.UserProfilePicture != null)
                        {
                            MemoryStream ms = new MemoryStream(val.UserProfilePicture);
                            this.picProfilePicture.Image = Image.FromStream(ms);
                        }

                        this.txtMyID.Text = val.UserID;
                        this.txtUsername.Text = val.UserUsername;
                        this.txtPassword.Text = val.UserPassword;
                        this.txtFirstName.Text = val.UserFirstName;
                        this.txtMiddleName.Text = val.UserMiddleName;
                        this.txtLastName.Text = val.UserLastName;
                        this.cmbGender.Text = val.UserGender;
                        this.txtGender.Text = val.UserGender;
                        this.cmbAge.Text = val.UserAge;
                        this.txtAge.Text = val.UserAge;
                        this.txtAddress.Text = val.UserAddress;
                        this.dateBirthday.Value = val.UserBirthday;
                        this.txtCellphoneNumber.Text = val.UserCellphoneNumber;
                        this.txtTelephoneNumber.Text = val.UserTelephoneNumber;
                        this.txtEmail.Text = val.UserEmail;
                        this.txtRole.Text = val.UserRole;
                    }

                    this.txtUsername.Enabled = false;
                    this.txtPassword.Enabled = false;
                    this.txtFirstName.Enabled = false;
                    this.txtMiddleName.Enabled = false;
                    this.txtLastName.Enabled = false;
                    this.cmbGender.Visible = false;
                    this.cmbAge.Visible = false;
                    this.txtAddress.Enabled = false;
                    this.dateBirthday.Enabled = false;
                    this.txtCellphoneNumber.Enabled = false;
                    this.txtTelephoneNumber.Enabled = false;
                    this.txtEmail.Enabled = false;
                    this.btnUploadPhoto.Visible = false;
                    this.btnRemovePhoto.Visible = false;
                    this.btnSave.Enabled = false;

                    this.txtGender.Visible = true;
                    this.txtAge.Visible = true;
                    this.btnEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Failed to update your profile!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmMyProfileNew_VisibleChanged(object sender, EventArgs e)
        {
            user.GetUser(this.txtMyID.Text);
        }
    }
}
