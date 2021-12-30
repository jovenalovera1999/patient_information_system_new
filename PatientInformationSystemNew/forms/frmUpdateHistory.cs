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

        private void frmUpdateHistory_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        void LoadForm()
        {
            update_history.LoadPatientsUpdates(this.gridPatients);
            update_history.LoadVitalSignsUpdates(this.gridVitalSigns);
            update_history.LoadDiagnosisUpdates(this.gridDiagnosis);
            update_history.LoadSymptomsUpdates(this.gridSymptoms);
            update_history.LoadPrescriptionsUpdates(this.gridPrescriptions);
            update_history.LoadPaymentTransactionsUpdates(this.gridPaymentTransactions);
        }

        void SelectPatient()
        {
            DateTime date = DateTime.Parse(this.gridPatients.SelectedCells[4].Value.ToString());

            this.txtEditedByPatients.Text = this.gridPatients.SelectedCells[1].Value.ToString();
            this.txtPatientNamePatients.Text = this.gridPatients.SelectedCells[2].Value.ToString();
            this.txtDatePatients.Text = date.ToString("D hh:mm tt");
            this.txtDescriptionPatients.Text = this.gridPatients.SelectedCells[3].Value.ToString();
        }

        void SelectVitalSigns()
        {
            DateTime date = DateTime.Parse(this.gridPatients.SelectedCells[4].Value.ToString());

            this.txtEditedByPatients.Text = this.gridPatients.SelectedCells[1].Value.ToString();
            this.txtPatientNamePatients.Text = this.gridPatients.SelectedCells[2].Value.ToString();
            this.txtDatePatients.Text = date.ToString("D hh:mm tt");
            this.txtDescriptionPatients.Text = this.gridPatients.SelectedCells[3].Value.ToString();
        }

        void SelectDiagnosis()
        {
            DateTime date = DateTime.Parse(this.gridPatients.SelectedCells[4].Value.ToString());

            this.txtEditedByPatients.Text = this.gridPatients.SelectedCells[1].Value.ToString();
            this.txtPatientNamePatients.Text = this.gridPatients.SelectedCells[2].Value.ToString();
            this.txtDatePatients.Text = date.ToString("D hh:mm tt");
            this.txtDescriptionPatients.Text = this.gridPatients.SelectedCells[3].Value.ToString();
        }

        void SelectSymptom()
        {
            DateTime date = DateTime.Parse(this.gridPatients.SelectedCells[4].Value.ToString());

            this.txtEditedByPatients.Text = this.gridPatients.SelectedCells[1].Value.ToString();
            this.txtPatientNamePatients.Text = this.gridPatients.SelectedCells[2].Value.ToString();
            this.txtDatePatients.Text = date.ToString("D hh:mm tt");
            this.txtDescriptionPatients.Text = this.gridPatients.SelectedCells[3].Value.ToString();
        }

        void SelectPrescription()
        {
            DateTime date = DateTime.Parse(this.gridPatients.SelectedCells[4].Value.ToString());

            this.txtEditedByPatients.Text = this.gridPatients.SelectedCells[1].Value.ToString();
            this.txtPatientNamePatients.Text = this.gridPatients.SelectedCells[2].Value.ToString();
            this.txtDatePatients.Text = date.ToString("D hh:mm tt");
            this.txtDescriptionPatients.Text = this.gridPatients.SelectedCells[3].Value.ToString();
        }

        void SelectPaymentTransaction()
        {
            DateTime date = DateTime.Parse(this.gridPatients.SelectedCells[4].Value.ToString());

            this.txtEditedByPatients.Text = this.gridPatients.SelectedCells[1].Value.ToString();
            this.txtPatientNamePatients.Text = this.gridPatients.SelectedCells[2].Value.ToString();
            this.txtDatePatients.Text = date.ToString("D hh:mm tt");
            this.txtDescriptionPatients.Text = this.gridPatients.SelectedCells[3].Value.ToString();
        }

        void SelectSupply()
        {
            DateTime date = DateTime.Parse(this.gridPatients.SelectedCells[4].Value.ToString());

            this.txtEditedByPatients.Text = this.gridPatients.SelectedCells[1].Value.ToString();
            this.txtPatientNamePatients.Text = this.gridPatients.SelectedCells[2].Value.ToString();
            this.txtDatePatients.Text = date.ToString("D hh:mm tt");
            this.txtDescriptionPatients.Text = this.gridPatients.SelectedCells[3].Value.ToString();
        }
    }
}
