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

        private void frmMyProfile_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }

            if(val.UserRole != "Doctor")
            {
                this.btnViewMyPatient.Visible = false;
            }

            if(val.UserProfilePicture != null)
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
            this.cmbAge.Text = val.UserAge.ToString();
            this.txtAddress.Text = val.UserAddress;
            this.dateBirthday.Value = val.UserBirthday;
            this.txtCellphoneNumber.Text = val.UserCellphoneNumber;
            this.txtTelephoneNumber.Text = val.UserTelephoneNumber;
            this.txtEmail.Text = val.UserEmail;
            this.txtRole.Text = val.UserRole;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtUsername.Enabled = true;
            this.txtPassword.Enabled = true;
            this.txtFirstName.Enabled = true;
            this.txtMiddleName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.cmbGender.Enabled = true;
            this.cmbAge.Enabled = true;
            this.txtAddress.Enabled = true;
            this.dateBirthday.Enabled = true;
            this.txtCellphoneNumber.Enabled = true;
            this.txtTelephoneNumber.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtRole.Enabled = true;
            this.btnUploadPhoto.Visible = true;
            this.btnRemovePhoto.Visible = true;
            this.btnEdit.Enabled = false;
            this.btnSave.Enabled = true;
        }
    }
}
