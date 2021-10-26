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
    public partial class frmConsultation : Form
    {
        public frmConsultation()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Symptoms symptom = new functions.Symptoms();

        private void frmConsultation_Load(object sender, EventArgs e)
        {
            this.txtPatientID.Text = val.PatientID;
            this.txtFirstName.Text = val.PatientFirstName;
            this.txtMiddleName.Text = val.PatientMiddleName;
            this.txtLastName.Text = val.PatientLastName;
            this.txtGender.Text = val.PatientGender;
            this.txtAge.Text = val.PatientAge.ToString();
            this.txtAddress.Text = val.PatientAddress;
            this.dateBirthday.Value = val.PatientBirthday;
            this.txtCellphoneNumber.Text = val.PatientCellphoneNumer;
            this.txtTelephoneNumber.Text = val.PatientTelephoneNumber;
            this.txtEmail.Text = val.PatientEmail;
            this.txtHeight.Text = val.PatientHeight.ToString();
            this.txtWeight.Text = val.PatientWeight.ToString();
            this.txtTemperature.Text = val.PatientTemperature.ToString();
            this.txtPulseRate.Text = val.PatientPulseRate.ToString();
            this.txtBloodPressure.Text = val.PatientBloodPressure.ToString();
            symptom.loadSymptomsInConsultation(this.txtPatientID.Text, this.gridSymptoms);
            this.txtDiagnosis.Focus();
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            int n = this.gridDiagnosis.Rows.Add();
            this.txtDiagnosis.Text = this.gridDiagnosis.Rows[n].Cells[0].Value.ToString();

            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtDiagnosis.ResetText();
            this.txtDiagnosis.Focus();
        }

        private void btnRemoveDiagnosis_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.gridDiagnosis.SelectedRows)
            {
                this.gridDiagnosis.Rows.Remove(row);
            }
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtDiagnosis.ResetText();
            this.txtDiagnosis.Focus();
        }

        private void btnAddSymptoms_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdateSymptoms_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemoveSymptoms_Click(object sender, EventArgs e)
        {

        }

        private void btnInputSymptoms_Click(object sender, EventArgs e)
        {
            this.txtSymptoms.Visible = true;
            this.btnUpdateSymptoms.Visible = true;
            this.btnRemoveSymptoms.Visible = true;
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            
        }
    }
}