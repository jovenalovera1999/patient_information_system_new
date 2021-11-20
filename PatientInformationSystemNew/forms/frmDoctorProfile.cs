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

        private void frmDoctorProfileNew_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                this.cmbAge.Items.Add(i);
            }

            if (val.DoctorProfilePicture != null)
            {
                MemoryStream ms = new MemoryStream(val.DoctorProfilePicture);
                this.picProfilePicture.Image = Image.FromStream(ms);
            }

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

            patient.loadDoctorPatients(this.txtFirstName.Text, this.txtLastName.Text, this.txtSpecialization.Text, this.gridPatients);
        }

        private void btnEdit_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
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
            else if (doctor.updateDoctor(this.txtDoctorID.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text,
                this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text,
                this.txtTelephoneNumber.Text, this.txtEmail.Text, this.txtSpecialization.Text))
            {
                if (String.IsNullOrWhiteSpace(this.txtMiddleName.Text))
                {
                    MessageBox.Show(string.Format("Dr. {0} {1} successfully updated!", this.txtFirstName.Text, this.txtLastName.Text), "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Format("Dr. {0} {1}. {2} successfully updated!", this.txtFirstName.Text, this.txtMiddleName.Text[0],
                        this.txtLastName.Text), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (doctor.getDoctor(this.txtDoctorID.Text))
                {
                    if (val.DoctorProfilePicture != null)
                    {
                        MemoryStream ms = new MemoryStream(val.DoctorProfilePicture);
                        this.picProfilePicture.Image = Image.FromStream(ms);
                    }
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
            else
            {
                if (String.IsNullOrWhiteSpace(this.txtMiddleName.Text))
                {
                    MessageBox.Show(string.Format("Failed to update Dr. {0} {2} account!", this.txtFirstName.Text, this.txtLastName.Text), "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(string.Format("Failed to update Dr. {0} {1}. {2} account!", this.txtFirstName.Text, this.txtMiddleName.Text[0],
                        this.txtLastName.Text), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void gridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
        }

        private void gridPatients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(patient.getPatient(this.gridPatients.SelectedCells[0].Value.ToString()))
            {
                forms.frmDoctorsPatientProfile frmDoctorsPatientProfileNew = new forms.frmDoctorsPatientProfile();
                frmDoctorsPatientProfileNew.TopLevel = false;
                forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
                Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
                pnlDashboardBody.Controls.Add(frmDoctorsPatientProfileNew);
                frmDoctorsPatientProfileNew.Dock = DockStyle.Fill;
                frmDoctorsPatientProfileNew.Show();
                this.Close();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (patient.getPatient(this.txtPatientID.Text))
            {
                forms.frmDoctorsPatientProfile frmDoctorsPatientProfileNew = new forms.frmDoctorsPatientProfile();
                frmDoctorsPatientProfileNew.TopLevel = false;
                forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
                Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
                pnlDashboardBody.Controls.Add(frmDoctorsPatientProfileNew);
                frmDoctorsPatientProfileNew.Dock = DockStyle.Fill;
                frmDoctorsPatientProfileNew.Show();
                this.Close();
            }
        }
    }
}
