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
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        void LoadForm()
        {
            if (val.UserRole == "Administrator" || val.UserRole == "Medical Staff")
            {
                this.btnSelect.Enabled = false;
                patient.LoadPatientInSchedule(this.gridSchedule);
            }
            else if (val.UserRole == "Doctor")
            {
                this.btnCancelPatient.Visible = false;
                patient.LoadDoctorPatientsInSchedule(val.UserFirstName, val.UserLastName, val.UserSpecialization, this.gridSchedule);
            }
        }

        void SelectPatient()
        {
            this.gridSchedule.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridSchedule.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.btnSelect.Enabled = true;
            this.btnCancelPatient.Enabled = true;

            string first_name = this.gridSchedule.SelectedCells[2].Value.ToString();
            string middle_name = this.gridSchedule.SelectedCells[3].Value.ToString();
            string last_name = this.gridSchedule.SelectedCells[4].Value.ToString();

            this.txtPatientID.Text = this.gridSchedule.SelectedCells[1].Value.ToString();
            if (String.IsNullOrWhiteSpace(middle_name))
            {
                this.txtPatientName.Text = string.Format("{0} {1}", first_name, last_name);
            }
            else
            {
                this.txtPatientName.Text = string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name);
            }

            patient.GetPatientIDAndDateCreated(this.gridSchedule.SelectedCells[1].Value.ToString());
        }

        void GetPatientByButton()
        {
            if (patient.GetPatientFromSchedule(this.txtPatientID.Text))
            {
                forms.frmConsultation frmConsultation = new forms.frmConsultation();
                frmConsultation.TopLevel = false;
                forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
                Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
                pnlDashboardBody.Controls.Add(frmConsultation);
                frmConsultation.Dock = DockStyle.Fill;
                frmConsultation.Show();
                this.Close();
            }
        }

        void GetPatientByGrid()
        {
            if (patient.GetPatientFromSchedule(this.gridSchedule.SelectedCells[1].Value.ToString()))
            {
                forms.frmConsultation frmConsultation = new forms.frmConsultation();
                frmConsultation.TopLevel = false;
                forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
                Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
                pnlDashboardBody.Controls.Add(frmConsultation);
                frmConsultation.Dock = DockStyle.Fill;
                frmConsultation.Show();
                this.Close();
            }
        }

        void CancelPatient()
        {
            if (MessageBox.Show("Are you sure you want to cancel patient appointment with the doctor?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (val.PatientInScheduleDateCreated > DateTime.Now)
                {
                    if (patient.CancelPatientInScheduleWithExistingFirstAccount(this.txtPatientID.Text))
                    {
                        MessageBox.Show("Patient successfully cancelled appointment with the doctor!", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.gridSchedule.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                        this.gridSchedule.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                        if (val.UserRole == "Administrator" || val.UserRole == "Medical Staff")
                        {
                            patient.LoadPatientInSchedule(this.gridSchedule);
                        }
                        else if (val.UserRole == "Doctor")
                        {
                            patient.LoadDoctorPatientsInSchedule(val.UserFirstName, val.UserLastName, val.UserSpecialization, this.gridSchedule);
                        }

                        this.txtPatientID.ResetText();
                        this.txtPatientName.ResetText();

                        this.btnSelect.Enabled = false;
                        this.btnCancelPatient.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel patient appointment with the doctor!", "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (patient.CancelPatientInScheduleWithoutExistingFirstAccount(this.txtPatientID.Text))
                    {
                        MessageBox.Show("Patient successfully cancelled appointment with the doctor!", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.gridSchedule.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                        this.gridSchedule.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                        if (val.UserRole == "Administrator" || val.UserRole == "Medical Staff")
                        {
                            patient.LoadPatientInSchedule(this.gridSchedule);
                        }
                        else if (val.UserRole == "Doctor")
                        {
                            patient.LoadDoctorPatientsInSchedule(val.UserFirstName, val.UserLastName, val.UserSpecialization, this.gridSchedule);
                        }

                        this.txtPatientID.ResetText();
                        this.txtPatientName.ResetText();

                        this.btnSelect.Enabled = false;
                        this.btnCancelPatient.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel patient appointment with the doctor!", "Failed", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void gridSchedule_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectPatient();
        }

        private void gridSchedule_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetPatientByGrid();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            GetPatientByButton();
        }

        private void btnCancelPatient_Click(object sender, EventArgs e)
        {
            CancelPatient();
        }
    }
}
