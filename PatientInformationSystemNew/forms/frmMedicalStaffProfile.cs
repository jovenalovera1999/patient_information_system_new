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
    public partial class frmMedicalStaffProfile : Form
    {
        public frmMedicalStaffProfile()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.Duplicate duplicate = new functions.Duplicate();
        functions.MedicalStaff medical_staff = new functions.MedicalStaff();

        void LoadProfilePicture()
        {
            if(val.MedicalStaffProfilePicture != null)
            {
                MemoryStream ms = new MemoryStream(val.MedicalStaffProfilePicture);
                this.picMedicalStaff.Image = Image.FromStream(ms);
            }
        }

        void LoadMedicalStaffDetails()
        {
            this.txtMedicalStaffID.Text = val.MedicalStaffID;
            this.txtFirstName.Text = val.MedicalStaffFirstName;
            this.txtMiddleName.Text = val.MedicalStaffMiddleName;
            this.txtLastName.Text = val.MedicalStaffLastName;
            this.cmbGender.Text = val.MedicalStaffGender;
            this.txtGender.Text = val.MedicalStaffGender;
            this.cmbAge.Text = val.MedicalStaffAge;
            this.txtAge.Text = val.MedicalStaffAge;
            this.txtAddress.Text = val.MedicalStaffAddress;
            this.dateBirthday.Value = val.MedicalStaffBirthday;
            this.txtBirthday.Text = val.MedicalStaffBirthday.ToString("D");
            this.txtCellphoneNumber.Text = val.MedicalStaffCellphoneNumber;
            this.txtTelephoneNumber.Text = val.MedicalStaffTelephoneNumber;
            this.txtEmail.Text = val.MedicalStaffEmail;
        }

        void LoadAge()
        {
            for(int i = 0; i < 100; i++)
            {
                this.cmbAge.Items.Add(i);
            }
        }

        void LoadForm()
        {
            LoadAge();
            LoadProfilePicture();
            LoadMedicalStaffDetails();
        }

        void EditMedicalStaff()
        {
            this.txtMedicalStaffID.TabStop = true;
            this.txtFirstName.TabStop = true;
            this.txtMiddleName.TabStop = true;
            this.txtLastName.TabStop = true;
            this.txtAddress.TabStop = true;
            this.txtCellphoneNumber.TabStop = true;
            this.txtTelephoneNumber.TabStop = true;
            this.txtEmail.TabStop = true;

            this.txtMedicalStaffID.ReadOnly = false;
            this.txtFirstName.ReadOnly = false;
            this.txtMiddleName.ReadOnly = false;
            this.txtLastName.ReadOnly = false;
            this.txtAddress.ReadOnly = false;
            this.txtCellphoneNumber.ReadOnly = false;
            this.txtTelephoneNumber.ReadOnly = false;
            this.txtEmail.ReadOnly = false;

            this.cmbGender.Visible = true;
            this.cmbAge.Visible = true;
            this.dateBirthday.Visible = true;

            this.txtGender.Visible = false;
            this.txtAge.Visible = false;
            this.txtBirthday.Visible = false;

            this.btnSave.Enabled = true;
            this.btnEdit.Enabled = false;

            this.txtMedicalStaffID.Focus();
        }

        void ResetAfterSaved()
        {
            this.txtMedicalStaffID.TabStop = false;
            this.txtFirstName.TabStop = false;
            this.txtMiddleName.TabStop = false;
            this.txtLastName.TabStop = false;
            this.txtAddress.TabStop = false;
            this.txtCellphoneNumber.TabStop = false;
            this.txtTelephoneNumber.TabStop = false;
            this.txtEmail.TabStop = false;

            this.txtMedicalStaffID.ReadOnly = true;
            this.txtFirstName.ReadOnly = true;
            this.txtMiddleName.ReadOnly = true;
            this.txtLastName.ReadOnly = true;
            this.txtAddress.ReadOnly = true;
            this.txtCellphoneNumber.ReadOnly = true;
            this.txtTelephoneNumber.ReadOnly = true;
            this.txtEmail.ReadOnly = true;

            this.txtGender.Visible = true;
            this.txtAge.Visible = true;
            this.txtBirthday.Visible = true;

            this.cmbGender.Visible = false;
            this.cmbAge.Visible = false;
            this.dateBirthday.Visible = false;

            this.btnEdit.Enabled = true;
            this.btnSave.Enabled = false;
        }

        void SaveMedicalStaff()
        {
            if(String.IsNullOrWhiteSpace(this.txtMedicalStaffID.Text))
            {
                MessageBox.Show("Medical Staff ID is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtMedicalStaffID.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtFirstName.Text))
            {
                MessageBox.Show("First name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtLastName.Text))
            {
                MessageBox.Show("Last name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLastName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.cmbGender.Text))
            {
                MessageBox.Show("Gender is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbGender.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.cmbAge.Text))
            {
                MessageBox.Show("Age is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbAge.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtAddress.Text))
            {
                MessageBox.Show("Address is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddress.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(this.txtTelephoneNumber.Text) && String.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                MessageBox.Show("Input atleast one contact information!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCellphoneNumber.Focus();
            }
            else if(medical_staff.UpdateMedicalStaff(val.MedicalStaffPrimaryID, this.txtMedicalStaffID.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text, this.cmbGender.Text,
                this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text, this.txtTelephoneNumber.Text, this.txtEmail.Text))
            {
                MessageBox.Show("Medical staff successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if(medical_staff.GetMedicalStaff(val.MedicalStaffPrimaryID))
                {
                    LoadMedicalStaffDetails();
                }
                ResetAfterSaved();
            }
            else
            {
                MessageBox.Show("Failed to update medical staff!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GoToListOfMedicalStaff()
        {
            forms.frmListOfMedicalStaff frmListOfMedicalStaff = new forms.frmListOfMedicalStaff();
            frmListOfMedicalStaff.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmListOfMedicalStaff);
            frmListOfMedicalStaff.Dock = DockStyle.Fill;
            frmListOfMedicalStaff.Show();
            this.Close();
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

        private void frmMedicalStaffProfile_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveMedicalStaff();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMedicalStaff();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoToListOfMedicalStaff();
        }
    }
}
