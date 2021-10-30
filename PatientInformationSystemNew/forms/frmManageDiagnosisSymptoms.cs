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
    public partial class frmManageDiagnosisSymptoms : Form
    {
        public frmManageDiagnosisSymptoms()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Diagnosis diagnosis = new functions.Diagnosis();
        functions.Symptoms symptoms = new functions.Symptoms();
        functions.Duplicate duplicate = new functions.Duplicate();

        void autoGenNumDiagnosis()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while(generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtDiagnosisID.Text = generateID.ToString();
        }

        void autoGenNumSymptoms()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtSymptomsID.Text = generateID.ToString();
        }

        private void frmManageDiagnosisSymptoms_Load(object sender, EventArgs e)
        {
            this.dateDiagnosis.Value = DateTime.Now.Date;
            this.dateSymptoms.Value = DateTime.Now.Date;
            diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosis);
            symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptoms);
            this.txtDiagnosis.Focus();
        }

        // Diagnosis

        private void gridDiagnosis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            this.txtDiagnosisID.Text = this.gridDiagnosis.SelectedCells[0].Value.ToString();
            this.txtDiagnosis.Text = this.gridDiagnosis.SelectedCells[1].Value.ToString();
            this.dateDiagnosis.Value = DateTime.Parse(this.gridDiagnosis.SelectedCells[2].Value.ToString());

            this.txtDiagnosis.Focus();

            this.btnAddDiagnosis.Enabled = false;
            this.btnUpdateDiagnosis.Enabled = true;
            this.btnRemoveDiagnosis.Enabled = true;
        }

        private void btnNewDiagnosis_Click(object sender, EventArgs e)
        {
            this.txtDiagnosisID.ResetText();
            this.txtDiagnosis.ResetText();
            this.btnAddDiagnosis.Enabled = true;

            this.dateDiagnosis.Value = DateTime.Now.Date;
            autoGenNumDiagnosis();


            this.txtDiagnosis.Focus();
        }

        private void btnAddDiagnosis_Click_1(object sender, EventArgs e)
        {
            if(duplicate.diagnosisIDDuplicate(val.PatientID, this.txtDiagnosisID.Text))
            {
                MessageBox.Show("Duplicate ID detected! Please try again!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                autoGenNumDiagnosis();
                this.txtDiagnosis.Focus();
            }
            else if (diagnosis.addDiagnosis(val.PatientID, this.txtDiagnosisID.Text, this.txtDiagnosis.Text, this.dateDiagnosis.Value.Date))
            {
                diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosis);
                this.txtDiagnosisID.ResetText();
                this.txtDiagnosis.ResetText();
                this.dateDiagnosis.Value = DateTime.Now.Date;
                this.txtDiagnosis.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add diagnosis!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateDiagnosis_Click_1(object sender, EventArgs e)
        {
            if (diagnosis.updateDiagnosis(val.PatientID, this.txtDiagnosisID.Text, this.txtDiagnosis.Text, this.dateDiagnosis.Value.Date))
            {
                MessageBox.Show("Diagnosis successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosis);
                this.txtDiagnosisID.ResetText();
                this.txtDiagnosis.ResetText();
                this.dateDiagnosis.Value = DateTime.Now.Date;
                this.txtDiagnosis.Focus();
            }
            else
            {
                MessageBox.Show("Failed to update diagnosis!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveDiagnosis_Click_1(object sender, EventArgs e)
        {
            if (diagnosis.removeDiagnosis(val.PatientID, this.txtDiagnosisID.Text))
            {
                MessageBox.Show("Diagnosis successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                diagnosis.loadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosis);
                this.txtDiagnosisID.ResetText();
                this.txtDiagnosis.ResetText();
                this.dateDiagnosis.Value = DateTime.Now.Date;
                this.txtDiagnosis.Focus();
            }
            else
            {
                MessageBox.Show("Failed to delete a diagnosis!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Symptoms

        private void gridSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtSymptomsID.Text = this.gridSymptoms.SelectedCells[0].Value.ToString();
            this.txtSymptoms.Text = this.gridSymptoms.SelectedCells[1].Value.ToString();
            this.dateSymptoms.Value = DateTime.Parse(this.gridSymptoms.SelectedCells[2].Value.ToString());

            this.txtSymptoms.Focus();

            this.btnAddSymptoms.Enabled = false;
            this.btnUpdateSymptoms.Enabled = true;
            this.btnRemoveSymptoms.Enabled = true;
        }

        private void btnNewSymptoms_Click(object sender, EventArgs e)
        {
            this.txtSymptomsID.ResetText();
            this.txtSymptoms.ResetText();
            this.dateSymptoms.Value = DateTime.Now;

            autoGenNumSymptoms();

            this.btnAddSymptoms.Enabled = true;
            this.btnUpdateSymptoms.Enabled = false;
            this.btnRemoveSymptoms.Enabled = false;

            this.txtSymptoms.Focus();
        }

        private void btnAddSymptoms_Click(object sender, EventArgs e)
        {
            if(duplicate.symptomsIDDuplicate(val.PatientID, this.txtSymptomsID.Text))
            {
                MessageBox.Show("Duplicate ID detected! Please try again!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                autoGenNumSymptoms();
                this.txtSymptoms.Focus();
            }
            else if(symptoms.addPatientSymptom(val.PatientID, this.txtSymptomsID.Text, this.txtSymptoms.Text, dateSymptoms.Value.Date))
            {
                symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptoms);
                this.txtSymptomsID.ResetText();
                this.txtSymptoms.ResetText();
                this.dateDiagnosis.Value = DateTime.Now;
                this.txtDiagnosis.Focus();
            }
            else
            {
                MessageBox.Show("Error adding symptoms!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSymptoms_Click(object sender, EventArgs e)
        {
            if(symptoms.updateSymptom(val.PatientID, this.txtSymptomsID.Text, this.txtSymptoms.Text))
            {
                MessageBox.Show("Symptoms successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptoms);
                this.txtSymptomsID.ResetText();
                this.txtSymptoms.ResetText();
                this.dateSymptoms.Value = DateTime.Now.Date;
                this.txtSymptoms.Focus();
            }
            else
            {
                MessageBox.Show("Failed to update symptoms!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSymptoms_Click(object sender, EventArgs e)
        {
            if(symptoms.deleteSymptom(val.PatientID, this.txtSymptomsID.Text))
            {
                MessageBox.Show("Symptom successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                symptoms.loadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptoms);
                this.txtSymptomsID.ResetText();
                this.txtSymptoms.ResetText();
                this.dateSymptoms.Value = DateTime.Now.Date;
            }
            else
            {
                MessageBox.Show("Failed to delete the symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}