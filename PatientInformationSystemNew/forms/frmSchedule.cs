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

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            if(val.UserRole == "Medical Staff")
            {
                this.btnSelect.Enabled = false;
            }
            else if(val.UserRole == "Doctor")
            {
                this.btnCancelPatient.Visible = false;
            }
            patient.loadPatientInSchedule(this.gridSchedule);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }

        private void gridSchedule_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridSchedule.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridSchedule.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.btnSelect.Enabled = true;
            this.btnCancelPatient.Enabled = true;

            string first_name = this.gridSchedule.SelectedCells[1].Value.ToString();
            string middle_name = this.gridSchedule.SelectedCells[2].Value.ToString();
            string last_name = this.gridSchedule.SelectedCells[3].Value.ToString();

            this.txtPatientID.Text = this.gridSchedule.SelectedCells[0].Value.ToString();
            if(String.IsNullOrWhiteSpace(this.gridSchedule.SelectedCells[2].Value.ToString()))
            {
                this.txtPatientName.Text = first_name + " " + last_name;
            }
            else
            {
                this.txtPatientName.Text = first_name + " " + middle_name[0] + ". " + last_name;
            }
        }

        private void gridSchedule_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
