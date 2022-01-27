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
    public partial class frmMyProfile : Form
    {
        public frmMyProfile()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.User user = new functions.User();

        void LoadAge()
        {
            for (int i = 1; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }
        }

        void LoadProfilePicture()
        {
            if (val.UserProfilePicture != null)
            {
                MemoryStream ms = new MemoryStream(val.UserProfilePicture);
                this.picProfilePicture.Image = Image.FromStream(ms);
            }
        }

        void LoadUserDetails()
        {
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
            this.txtBirthday.Text = val.UserBirthday.ToString("D");
            this.dateBirthday.Value = val.UserBirthday;
            this.txtCellphoneNumber.Text = val.UserCellphoneNumber;
            this.txtTelephoneNumber.Text = val.UserTelephoneNumber;
            this.txtEmail.Text = val.UserEmail;
            this.txtRole.Text = val.UserRole;
        }

        void LoadForm()
        {
            LoadAge();
            LoadProfilePicture();
            LoadUserDetails();
        }

        void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|PNG files(*.png)|*.png|JPG files(*.jpg)|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                this.picProfilePicture.ImageLocation = imgLocation;
            }
        }

        void RemovePhoto()
        {
            val.UserProfilePicture = null;
            imgLocation = null;
            this.picProfilePicture.Image = null;
        }

        void EditUser()
        {
            this.txtMyID.ReadOnly = false;
            this.txtUsername.ReadOnly = false;
            this.txtPassword.ReadOnly = false;
            this.txtFirstName.ReadOnly = false;
            this.txtMiddleName.ReadOnly = false;
            this.txtLastName.ReadOnly = false;
            this.txtGender.Visible = false;
            this.txtAge.Visible = false;
            this.txtAddress.ReadOnly = false;
            this.txtBirthday.Visible = false;
            this.txtCellphoneNumber.ReadOnly = false;
            this.txtTelephoneNumber.ReadOnly = false;
            this.txtEmail.ReadOnly = false;
            this.btnEdit.Enabled = false;

            this.cmbGender.Visible = true;
            this.cmbAge.Visible = true;
            this.dateBirthday.Visible = true;
            this.btnUploadPhoto.Visible = true;
            this.btnRemovePhoto.Visible = true;
            this.btnSave.Enabled = true;

            this.txtMyID.TabStop = true;
            this.txtUsername.TabStop = true;
            this.txtPassword.TabStop = true;
            this.txtFirstName.TabStop = true;
            this.txtMiddleName.TabStop = true;
            this.txtLastName.TabStop = true;
            this.cmbGender.TabStop = true;
            this.cmbAge.TabStop = true;
            this.txtAddress.TabStop = true;
            this.dateBirthday.TabStop = true;
            this.txtCellphoneNumber.TabStop = true;
            this.txtTelephoneNumber.TabStop = true;
            this.txtEmail.TabStop = true;

            this.txtMyID.Focus();
        }

        void DoneSaving()
        {
            this.txtMyID.ReadOnly = true;
            this.txtUsername.ReadOnly = true;
            this.txtPassword.ReadOnly = true;
            this.txtFirstName.ReadOnly = true;
            this.txtMiddleName.ReadOnly = true;
            this.txtLastName.ReadOnly = true;
            this.txtGender.Visible = true;
            this.txtAge.Visible = true;
            this.txtAddress.ReadOnly = true;
            this.txtBirthday.Visible = true;
            this.txtCellphoneNumber.ReadOnly = true;
            this.txtTelephoneNumber.ReadOnly = true;
            this.txtEmail.ReadOnly = true;
            this.btnEdit.Enabled = true;

            this.cmbGender.Visible = false;
            this.cmbAge.Visible = false;
            this.dateBirthday.Visible = false;
            this.btnUploadPhoto.Visible = false;
            this.btnRemovePhoto.Visible = false;
            this.btnSave.Enabled = false;

            this.txtMyID.TabStop = false;
            this.txtUsername.TabStop = false;
            this.txtPassword.TabStop = false;
            this.txtFirstName.TabStop = false;
            this.txtMiddleName.TabStop = false;
            this.txtLastName.TabStop = false;
            this.cmbGender.TabStop = false;
            this.cmbAge.TabStop = false;
            this.txtAddress.TabStop = false;
            this.dateBirthday.TabStop = false;
            this.txtCellphoneNumber.TabStop = false;
            this.txtTelephoneNumber.TabStop = false;
            this.txtEmail.TabStop = false;

            this.btnEdit.Focus();
        }

        void GetUser()
        {
            if (user.GetUser(val.UserPrimaryID))
            {
                LoadProfilePicture();
                LoadUserDetails();
            }
        }

        void UpdateUserAlreadyWithOrWithoutProfilePicture()
        {
            if (val.UserGender == "Male")
            {
                if (user.UpdateUser(val.UserPrimaryID, val.UserProfilePicture, this.txtUsername.Text, this.txtPassword.Text, this.txtFirstName.Text,
                    this.txtMiddleName.Text, this.txtLastName.Text, this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text,
                    this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text,
                    val.UserFullName, string.Format("Updated his profile!")))
                {
                    MessageBox.Show("Your profile has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUser();
                    DoneSaving();
                }
                else
                {
                    MessageBox.Show("Failed to update your profile!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (user.UpdateUser(val.UserPrimaryID, val.UserProfilePicture, this.txtUsername.Text, this.txtPassword.Text, this.txtFirstName.Text,
                    this.txtMiddleName.Text, this.txtLastName.Text, this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text,
                    this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text,
                    val.UserFullName, string.Format("Updated her profile!")))
                {
                    MessageBox.Show("Your profile has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUser();
                    DoneSaving();
                }
                else
                {
                    MessageBox.Show("Failed to update your profile!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void UpdateUserWithNewProfilePicture()
        {
            if (val.UserGender == "Male")
            {
                byte[] profilePicture = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                profilePicture = br.ReadBytes((int)fs.Length);

                if (user.UpdateUser(val.UserPrimaryID, profilePicture, this.txtUsername.Text, this.txtPassword.Text, this.txtFirstName.Text,
                    this.txtMiddleName.Text, this.txtLastName.Text, this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date,
                    this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text, val.UserFullName,
                    string.Format("Updated his profile!")))
                {
                    MessageBox.Show("Your profile has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUser();
                    DoneSaving();
                }
                else
                {
                    MessageBox.Show("Failed to update your profile!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                byte[] profilePicture = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                profilePicture = br.ReadBytes((int)fs.Length);

                if (user.UpdateUser(val.UserPrimaryID, profilePicture, this.txtUsername.Text, this.txtPassword.Text, this.txtFirstName.Text,
                    this.txtMiddleName.Text, this.txtLastName.Text, this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date,
                    this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text, val.UserFullName,
                    string.Format("Updated her profile!")))
                {
                    MessageBox.Show("Your profile has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetUser();
                    DoneSaving();
                }
                else
                {
                    MessageBox.Show("Failed to update your profile!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void SaveUser()
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
                UpdateUserAlreadyWithOrWithoutProfilePicture();
            }
            else if (!String.IsNullOrWhiteSpace(imgLocation))
            {
                // With new profile picture
                UpdateUserWithNewProfilePicture();
            }
        }

        private void frmMyProfile_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        string imgLocation = "";
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            UploadPhoto();
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            RemovePhoto();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
        }

        private void frmMyProfile_VisibleChanged(object sender, EventArgs e)
        {
            user.GetUser(val.UserPrimaryID);
        }
    }
}
