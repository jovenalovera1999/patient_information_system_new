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
    public partial class frmUpdateHistory : Form
    {
        public frmUpdateHistory()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.UpdateHistory update_history = new functions.UpdateHistory();

        void LoadForm()
        {
            update_history.LoadPatientsUpdates(this.gridPatients);
            update_history.LoadVitalSignsUpdates(this.gridVitalSigns);
            update_history.LoadDiagnosisUpdates(this.gridDiagnosis);
            update_history.LoadSymptomsUpdates(this.gridSymptoms);
            update_history.LoadPrescriptionsUpdates(this.gridPrescriptions);
            update_history.LoadPaymentTransactionsUpdates(this.gridPaymentTransactions);
            update_history.LoadInventoryUpdates(this.gridInventory);
        }

        void SelectPatient()
        {
            this.gridPatients.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridPatients.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            DateTime date = DateTime.Parse(this.gridPatients.SelectedCells[4].Value.ToString());

            this.txtEditedByPatients.Text = this.gridPatients.SelectedCells[1].Value.ToString();
            this.txtPatientNamePatients.Text = this.gridPatients.SelectedCells[2].Value.ToString();
            this.txtDatePatients.Text = string.Format("{0} {1}", date.ToString("D"), date.ToString("hh:mm tt"));
            this.txtDescriptionPatients.Text = this.gridPatients.SelectedCells[3].Value.ToString();
        }

        void SelectVitalSigns()
        {
            this.gridVitalSigns.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridVitalSigns.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            DateTime date = DateTime.Parse(this.gridVitalSigns.SelectedCells[4].Value.ToString());

            this.txtEditedByVitalSigns.Text = this.gridVitalSigns.SelectedCells[1].Value.ToString();
            this.txtPatientNameVitalSigns.Text = this.gridVitalSigns.SelectedCells[2].Value.ToString();
            this.txtDateVitalSigns.Text = date.ToString("D") + " " + date.ToString("hh:mm tt");
            this.txtDescriptionVitalSigns.Text = this.gridVitalSigns.SelectedCells[3].Value.ToString();
        }

        void SelectDiagnosis()
        {
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            DateTime date = DateTime.Parse(this.gridDiagnosis.SelectedCells[4].Value.ToString());

            this.txtEditedByDiagnosis.Text = this.gridDiagnosis.SelectedCells[1].Value.ToString();
            this.txtPatientNameDiagnosis.Text = this.gridDiagnosis.SelectedCells[2].Value.ToString();
            this.txtDateDiagnosis.Text = string.Format("{0} {1}", date.ToString("D"), date.ToString("hh:mm tt"));
            this.txtDescriptionDiagnosis.Text = this.gridDiagnosis.SelectedCells[3].Value.ToString();
        }

        void SelectSymptom()
        {
            this.gridSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            DateTime date = DateTime.Parse(this.gridSymptoms.SelectedCells[4].Value.ToString());

            this.txtEditedBySymptoms.Text = this.gridSymptoms.SelectedCells[1].Value.ToString();
            this.txtPatientNameSymptoms.Text = this.gridSymptoms.SelectedCells[2].Value.ToString();
            this.txtDateSymptoms.Text = string.Format("{0} {1}", date.ToString("D"), date.ToString("hh:mm tt"));
            this.txtDescriptionSymptoms.Text = this.gridSymptoms.SelectedCells[3].Value.ToString();
        }

        void SelectPrescription()
        {
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridPrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            DateTime date = DateTime.Parse(this.gridPrescriptions.SelectedCells[4].Value.ToString());

            this.txtEditedByPrescriptions.Text = this.gridPrescriptions.SelectedCells[1].Value.ToString();
            this.txtPatientNamePrescriptions.Text = this.gridPrescriptions.SelectedCells[2].Value.ToString();
            this.txtDatePrescriptions.Text = string.Format("{0} {1}", date.ToString("D"), date.ToString("hh:mm tt"));
            this.txtDescriptionPrescriptions.Text = this.gridPrescriptions.SelectedCells[3].Value.ToString();
        }

        void SelectPaymentTransaction()
        {
            this.gridPaymentTransactions.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridPaymentTransactions.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            DateTime date = DateTime.Parse(this.gridPaymentTransactions.SelectedCells[4].Value.ToString());

            this.txtEditedByPaymentTransactions.Text = this.gridPaymentTransactions.SelectedCells[1].Value.ToString();
            this.txtPatientNamePaymentTransactions.Text = this.gridPaymentTransactions.SelectedCells[2].Value.ToString();
            this.txtDatePaymentTransactions.Text = string.Format("{0} {1}", date.ToString("D"), date.ToString("hh:mm tt"));
            this.txtDescriptionPaymentTransactions.Text = this.gridPaymentTransactions.SelectedCells[3].Value.ToString();
        }

        void SelectSupply()
        {
            this.gridInventory.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridInventory.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            DateTime date = DateTime.Parse(this.gridInventory.SelectedCells[3].Value.ToString());

            this.txtEditedByInventory.Text = this.gridInventory.SelectedCells[1].Value.ToString();
            this.txtDateInventory.Text = string.Format("{0} {1}", date.ToString("D"), date.ToString("hh:mm tt"));
            this.txtDescriptionInventory.Text = this.gridInventory.SelectedCells[2].Value.ToString();
        }

        private void frmUpdateHistory_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void gridPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectPatient();
        }

        private void gridVitalSigns_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectVitalSigns();
        }

        private void gridDiagnosis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectDiagnosis();
        }

        private void gridSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectSymptom();
        }

        private void gridPrescriptions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectPrescription();
        }

        private void gridPaymentTransactions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectPaymentTransaction();
        }

        private void gridInventory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectSupply();
        }
    }
}
