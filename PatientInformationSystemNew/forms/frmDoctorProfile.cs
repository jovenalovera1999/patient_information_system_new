﻿using System;
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
    public partial class frmDoctorProfile : Form
    {
        public frmDoctorProfile()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.Doctor doctor = new functions.Doctor();
        functions.Patient patient = new functions.Patient();

        void LoadAge()
        {
            for (int i = 0; i < 100; i++)
            {
                this.cmbAge.Items.Add(i);
            }
        }

        void LoadProfilePicture()
        {
            if (val.DoctorProfilePicture != null)
            {
                MemoryStream ms = new MemoryStream(val.DoctorProfilePicture);
                this.picProfilePicture.Image = Image.FromStream(ms);
            }
        }

        void LoadDoctorDetails()
        {
            this.txtDoctorID.Text = val.DoctorID;
            this.txtFirstName.Text = val.DoctorFirstName;
            this.txtMiddleName.Text = val.DoctorMiddleName;
            this.txtLastName.Text = val.DoctorLastName;
            this.txtGender.Text = val.DoctorGender;
            this.cmbGender.Text = val.DoctorGender;
            this.txtAge.Text = val.DoctorAge;
            this.cmbAge.Text = val.DoctorAge;
            this.txtAddress.Text = val.DoctorAddress;
            this.dateBirthday.Value = val.DoctorBirthday;
            this.txtCellphoneNumber.Text = val.DoctorCellphoneNumber;
            this.txtTelephoneNumber.Text = val.DoctorTelephoneNumber;
            this.txtEmail.Text = val.DoctorEmail;
            this.txtSpecialization.Text = val.DoctorSpecialization;
        }

        void LoadForm()
        {
            LoadAge();
            LoadProfilePicture();
            LoadDoctorDetails();
            patient.LoadDoctorPatients(this.txtFirstName.Text, this.txtLastName.Text, this.txtSpecialization.Text, this.gridPatients);
        }

        void EditDoctor()
        {
            this.txtDoctorID.Enabled = true;
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
            this.txtSpecialization.Enabled = true;
            this.btnSave.Enabled = true;

            this.txtGender.Visible = false;
            this.txtAge.Visible = false;
            this.btnEdit.Enabled = false;

            this.txtDoctorID.Focus();
        }

        void GetDoctor()
        {
            if(doctor.GetDoctor(val.DoctorPrimaryID))
            {
                LoadProfilePicture();
                LoadDoctorDetails();
            }
        }

        void DoneSaving()
        {
            this.txtDoctorID.Enabled = false;
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
            this.txtSpecialization.Enabled = false;
            this.btnSave.Enabled = false;

            this.txtGender.Visible = true;
            this.txtAge.Visible = true;
            this.btnEdit.Enabled = true;
        }

        void SaveDoctor()
        {
            if (String.IsNullOrWhiteSpace(this.txtDoctorID.Text))
            {
                MessageBox.Show("Doctor ID is required!", "Requried", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDoctorID.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Requried", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Requried", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLastName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.cmbGender.Text))
            {
                MessageBox.Show("Gender is required!", "Requried", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbGender.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAddress.Text))
            {
                MessageBox.Show("Address is required!", "Requried", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddress.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(this.txtTelephoneNumber.Text) &&
                String.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                MessageBox.Show("Contact information is required! Please input at least one contact information", "Requried", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.txtCellphoneNumber.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSpecialization.Text))
            {
                MessageBox.Show("Specialization is required!", "Requried", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSpecialization.Focus();
            }
            else if (doctor.UpdateDoctorProfile(val.DoctorPrimaryID, this.txtDoctorID.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text,
                this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text,
                this.txtTelephoneNumber.Text, this.txtEmail.Text, this.txtSpecialization.Text))
            {
                MessageBox.Show("Doctor has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetDoctor();
                DoneSaving();
            }
            else
            {
                MessageBox.Show("Failed to update doctor!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void BackToListOfDoctors()
        {
            forms.frmListOfDoctors frmListOfDoctors = new forms.frmListOfDoctors();
            frmListOfDoctors.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmListOfDoctors);
            frmListOfDoctors.Dock = DockStyle.Fill;
            frmListOfDoctors.Show();
            this.Close();
        }

        void SelectPatient()
        {
            this.gridPatients.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPatients.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            string first_name = this.gridPatients.SelectedCells[1].Value.ToString();
            string middle_name = this.gridPatients.SelectedCells[2].Value.ToString();
            string last_name = this.gridPatients.SelectedCells[3].Value.ToString();

            this.txtPatientID.Text = this.gridPatients.SelectedCells[0].Value.ToString();
            if (String.IsNullOrWhiteSpace(middle_name))
            {
                this.txtPatientName.Text = string.Format("{0} {1}", first_name, last_name);
            }
            else
            {
                this.txtPatientName.Text = string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name);
            }

            this.btnSelect.Enabled = true;
        }

        void GetPatient()
        {
            
        }

        private void frmDoctorProfileNew_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDoctor();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDoctor();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToListOfDoctors();
        }

        private void gridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectPatient();
        }

        private void gridPatients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
