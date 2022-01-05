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
        functions.Duplicate duplicate = new functions.Duplicate();

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

        void LoadFormByRole()
        {
            if (val.UserRole == "Doctor")
            {
                this.btnCancelPatient.Visible = false;
                patient.LoadDoctorPatientsInSchedule(val.UserPrimaryID, this.gridSchedule);
            }
            else if (val.UserRole == "Medical Staff")
            {
                this.btnSelect.Visible = false;
                patient.LoadPatientsInSchedule(this.gridSchedule);
            }
            else
            {
                patient.LoadPatientsInSchedule(this.gridSchedule);
            }
        }

        void LoadForm()
        {
            LoadFormByRole();
        }

        void ResetGridColor()
        {
            this.gridSchedule.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridSchedule.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        void ResetTextbox()
        {
            this.txtPatientID.ResetText();
            this.txtPatientName.ResetText();
        }

        void DisabledButtons()
        {
            this.btnSelect.Enabled = false;
            this.btnCancelPatient.Enabled = false;
        }

        void ReloadForm()
        {
            ResetGridColor();
            ResetTextbox();
            DisabledButtons();
            LoadFormByRole();
        }

        void SelectPatient()
        {
            this.gridSchedule.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridSchedule.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.btnSelect.Enabled = true;
            this.btnCancelPatient.Enabled = true;

            string first_name = this.gridSchedule.SelectedCells[3].Value.ToString();
            string middle_name = this.gridSchedule.SelectedCells[4].Value.ToString();
            string last_name = this.gridSchedule.SelectedCells[5].Value.ToString();

            this.txtPatientID.Text = this.gridSchedule.SelectedCells[2].Value.ToString();
            if (String.IsNullOrWhiteSpace(middle_name))
            {
                this.txtPatientName.Text = string.Format("{0} {1}", first_name, last_name);
            }
            else
            {
                this.txtPatientName.Text = string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name);
            }
        }

        void GetPatientByButton()
        {
            if (duplicate.DuplicatePatientInGeneral(this.txtPatientID.Text))
            {
                if (patient.GetPatientFromScheduleWithFirstAccountExisting(int.Parse(this.gridSchedule.SelectedCells[0].Value.ToString())))
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
            else if (patient.GetPatientFromSchedule(int.Parse(this.gridSchedule.SelectedCells[0].Value.ToString())))
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
            if (val.UserRole == "Doctor" || val.UserRole == "Administrator")
            {
                if (duplicate.DuplicatePatientInGeneral(this.gridSchedule.SelectedCells[2].Value.ToString()))
                {
                    if (patient.GetPatientFromScheduleWithFirstAccountExisting(int.Parse(this.gridSchedule.SelectedCells[0].Value.ToString())))
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
                else if (patient.GetPatientFromSchedule(int.Parse(this.gridSchedule.SelectedCells[0].Value.ToString())))
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
        }

        void CancelPatientSuccess()
        {
            MessageBox.Show("Patient appointment with the doctor successfully cancelled!", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            ReloadForm();
        }

        void CancelPatient()
        {
            if (MessageBox.Show("Are you sure you want cancel this patient appointment with the doctor?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (duplicate.DuplicatePatientAndPatientDoctor(int.Parse(this.gridSchedule.SelectedCells[1].Value.ToString()),
                    this.gridSchedule.SelectedCells[3].Value.ToString(), this.gridSchedule.SelectedCells[4].Value.ToString(),
                    this.gridSchedule.SelectedCells[5].Value.ToString()))
                {
                    if (patient.CancelPatientInScheduleWithFirstAccountExisting(this.gridSchedule.SelectedCells[2].Value.ToString()))
                    {
                        CancelPatientSuccess();
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (patient.CancelPatientInSchedule(this.gridSchedule.SelectedCells[2].Value.ToString()))
                {
                    CancelPatientSuccess();
                }
                else
                {
                    MessageBox.Show("Failed to cancel patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
