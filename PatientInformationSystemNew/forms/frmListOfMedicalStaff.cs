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
    public partial class frmListOfMedicalStaff : Form
    {
        public frmListOfMedicalStaff()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.MedicalStaff medical_staff = new functions.MedicalStaff();

        void LoadForm()
        {
            medical_staff.LoadMedicalStaff(this.gridMedicalStaff);
            this.btnSelect.Enabled = false;
        }

        void SelectMedicalStaff()
        {
            this.gridMedicalStaff.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridMedicalStaff.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtMedicalStaffID.Text = this.gridMedicalStaff.SelectedCells[1].Value.ToString();

            if (String.IsNullOrWhiteSpace(this.gridMedicalStaff.SelectedCells[3].Value.ToString()))
            {
                this.txtMedicalStaffName.Text = string.Format("{0} {1}", this.gridMedicalStaff.SelectedCells[2].Value.ToString(), this.gridMedicalStaff.SelectedCells[4].Value.ToString());
            }
            else
            {
                string middle_name = this.gridMedicalStaff.SelectedCells[3].Value.ToString();
                this.txtMedicalStaffName.Text = string.Format("{0} {1}. {2}", this.gridMedicalStaff.SelectedCells[2].Value.ToString(), middle_name[0], this.gridMedicalStaff.SelectedCells[4].Value.ToString());
            }
            this.btnSelect.Enabled = true;
        }

        void GetMedicalStaff()
        {
            if (medical_staff.GetMedicalStaff(int.Parse(this.gridMedicalStaff.SelectedCells[0].Value.ToString())))
            {
                forms.frmMedicalStaffProfile frmMedicalStaffProfile = new forms.frmMedicalStaffProfile();
                frmMedicalStaffProfile.TopLevel = false;
                forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
                Panel pnldashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
                pnldashboardBody.Controls.Add(frmMedicalStaffProfile);
                frmMedicalStaffProfile.Dock = DockStyle.Fill;
                frmMedicalStaffProfile.Show();
                this.Close();
            }
        }

        void BackToListOfDoctors()
        {
            forms.frmListOfDoctors frmListOfDoctors = new forms.frmListOfDoctors();
            frmListOfDoctors.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnldashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnldashboardBody.Controls.Add(frmListOfDoctors);
            frmListOfDoctors.Dock = DockStyle.Fill;
            frmListOfDoctors.Show();
            this.Close();
        }

        private void frmListOfMedicalStaff_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            GetMedicalStaff();
        }

        private void gridMedicalStaff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectMedicalStaff();
        }

        private void gridMedicalStaff_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GetMedicalStaff();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToListOfDoctors();
        }
    }
}
