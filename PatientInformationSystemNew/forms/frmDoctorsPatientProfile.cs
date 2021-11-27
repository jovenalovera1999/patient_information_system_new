﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PatientInformationSystemNew.forms
{
    public partial class frmDoctorsPatientProfile : Form
    {
        public frmDoctorsPatientProfile()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.Diagnosis diagnosis = new functions.Diagnosis();
        functions.Symptoms symptoms = new functions.Symptoms();
        functions.Prescription prescriptions = new functions.Prescription();
        functions.Patient patient = new functions.Patient();
        functions.PaymentTransactions payment = new functions.PaymentTransactions();
        functions.Duplicate duplicate = new functions.Duplicate();

        void autoGenNum()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 5)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtAddDiagnosisID.Text = generateID.ToString();
            this.txtAddSymptomID.Text = generateID.ToString();
            this.txtAddPrescriptionID.Text = generateID.ToString();
        }

        private void frmDoctorsPatientProfileNew_Load(object sender, EventArgs e)
        {
            autoGenNum();

            for (int i = 0; i < 120; i++)
            {
                this.cmbAge.Items.Add(i);
            }

            this.txtPatientID.Text = val.PatientID;
            this.txtFirstName.Text = val.PatientFirstName;
            this.txtMiddleName.Text = val.PatientMiddleName;
            this.txtLastName.Text = val.PatientLastName;
            this.cmbGender.Text = val.PatientGender;
            this.cmbAge.Text = val.PatientAge;
            this.txtAddress.Text = val.PatientAddress;
            this.dateBirthday.Value = val.PatientBirthday;
            this.txtCellphoneNumber.Text = val.PatientCellphoneNumer;
            this.txtTelephoneNumber.Text = val.PatientTelephoneNumber;
            this.txtEmail.Text = val.PatientEmail;
            this.txtHeight.Text = val.PatientHeight;
            this.txtWeight.Text = val.PatientWeight;
            this.txtTemperature.Text = val.PatientTemperature;
            this.txtPulseRate.Text = val.PatientPulseRate;
            this.txtBloodPressure.Text = val.PatientBloodPressure;
            this.txtFullName.Text = val.PatientFullName;
            this.cmbDiscount.Text = "None";

            diagnosis.LoadDiagnosisRecordsOfPatient(this.txtPatientID.Text, this.gridDiagnosisRecords);
            diagnosis.LoadDiagnosisRecordsOfPatient(this.txtPatientID.Text, this.gridManageDiagnosis);

            symptoms.LoadSymptomsRecordsOfPatient(this.txtPatientID.Text, this.gridSymptomsRecords);
            symptoms.LoadSymptomsRecordsOfPatient(this.txtPatientID.Text, this.gridManageSymptoms);

            prescriptions.loadPrescriptionRecordsOfPatient(this.txtPatientID.Text, this.gridPrescriptionsRecords);
            prescriptions.loadPrescriptionRecordsOfPatient(this.txtPatientID.Text, this.gridManagePrescriptions);
            prescriptions.loadPrintPrescriptionRecordsOfPatient(this.txtPatientID.Text, this.gridPrintPrescription);

            payment.loadPatientPaymentHistory(this.txtPatientID.Text, this.gridPaymentHistory);

            this.dateSelectedDiagnosis.Value = DateTime.Now.Date;
            this.dateSelectedSymptom.Value = DateTime.Now.Date;
            this.dateSelectedPrescription.Value = DateTime.Now.Date;

            this.dateAddDiagnosis.Value = DateTime.Now.Date;
            this.dateAddSymptom.Value = DateTime.Now.Date;
            this.dateAddPrescription.Value = DateTime.Now.Date;
        }

        // Edit

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtFirstName.Enabled = true;
            this.txtMiddleName.Enabled = true;
            this.txtLastName.Enabled = true;
            this.cmbGender.Enabled = true;
            this.cmbAge.Enabled = true;
            this.txtAddress.Enabled = true;
            this.dateBirthday.Enabled = true;
            this.txtCellphoneNumber.Enabled = true;
            this.txtTelephoneNumber.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtHeight.Enabled = true;
            this.txtWeight.Enabled = true;
            this.txtTemperature.Enabled = true;
            this.txtPulseRate.Enabled = true;
            this.txtBloodPressure.Enabled = true;
            this.btnSave.Enabled = true;

            this.btnEdit.Enabled = false;
            this.txtFirstName.Focus();
        }

        private void btnEditPayment_Click(object sender, EventArgs e)
        {
            this.txtTotalMedicalFee.Enabled = true;
            this.cmbDiscount.Enabled = true;
            this.txtAmount.Enabled = true;
            this.btnTransact.Visible = true;
            this.btnSavePayment.Enabled = true;

            this.btnEditPayment.Enabled = false;
        }

        // Cell Mouse Click

        private void gridManageDiagnosis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSelectedDiagnosis.Text = this.gridManageDiagnosis.SelectedCells[1].Value.ToString();
            this.dateSelectedDiagnosis.Value = DateTime.Parse(this.gridManageDiagnosis.SelectedCells[2].Value.ToString());

            this.txtAddDiagnosis.ResetText();

            this.txtAddDiagnosis.Enabled = false;
            this.dateAddDiagnosis.Enabled = false;
            this.btnAddDiagnosis.Enabled = false;

            this.btnNewDiagnosis.Enabled = true;
            this.txtSelectedDiagnosis.Enabled = true;
            this.dateSelectedDiagnosis.Enabled = true;
            this.btnUpdateDiagnosis.Enabled = true;
            this.btnRemoveDiagnosis.Enabled = true;

            this.txtSelectedDiagnosis.Focus();
        }

        private void gridManageSymptoms_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSelectedSymptom.Text = this.gridManageSymptoms.SelectedCells[1].Value.ToString();
            this.dateSelectedSymptom.Value = DateTime.Parse(this.gridManageSymptoms.SelectedCells[2].Value.ToString());

            this.txtAddSymptom.ResetText();

            this.txtAddSymptom.Enabled = false;
            this.dateAddSymptom.Enabled = false;
            this.btnAddSymptom.Enabled = false;

            this.btnNewSymptom.Enabled = true;
            this.txtSelectedSymptom.Enabled = true;
            this.dateSelectedSymptom.Enabled = true;
            this.btnUpdateSymptom.Enabled = true;
            this.btnRemoveSymptom.Enabled = true;

            this.txtSelectedSymptom.Focus();
        }

        private void gridManagePrescriptions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSelectedPrescription.Text = this.gridManagePrescriptions.SelectedCells[1].Value.ToString();
            this.dateSelectedPrescription.Value = DateTime.Parse(this.gridManagePrescriptions.SelectedCells[2].Value.ToString());

            this.txtAddPrescription.ResetText();

            this.txtAddPrescription.Enabled = false;
            this.dateAddPrescription.Enabled = false;
            this.btnAddPrescription.Enabled = false;

            this.btnNewPrescription.Enabled = true;
            this.txtSelectedPrescription.Enabled = true;
            this.dateSelectedPrescription.Enabled = true;
            this.btnUpdatePrescription.Enabled = true;
            this.btnRemovePrescription.Enabled = true;

            this.txtSelectedPrescription.Focus();
        }

        private void gridPrintPrescription_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPrintPrescription.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPrintPrescription.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            DateTime date = DateTime.Parse(this.gridPrintPrescription.SelectedCells[2].Value.ToString());

            this.rprtPrescription.Clear();

            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pFullName", val.PatientFullName));
            parameters.Add(new ReportParameter("pAge", this.cmbAge.Text));
            parameters.Add(new ReportParameter("pSex", this.cmbGender.Text.Substring(0, 1)));
            parameters.Add(new ReportParameter("pAddress", this.txtAddress.Text));
            parameters.Add(new ReportParameter("pDate", date.ToString("MM/dd/yy")));
            parameters.Add(new ReportParameter("pPrescription", this.gridPrintPrescription.SelectedCells[1].Value.ToString()));

            this.rprtPrescription.LocalReport.SetParameters(parameters);
            this.rprtPrescription.RefreshReport();
        }

        private void gridPaymentHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridPaymentHistory.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridPaymentHistory.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtReceiptNo.Text = this.gridPaymentHistory.SelectedCells[0].Value.ToString();
            this.txtTotalMedicalFee.Text = this.gridPaymentHistory.SelectedCells[1].Value.ToString();
            this.cmbDiscount.Text = this.gridPaymentHistory.SelectedCells[2].Value.ToString();
            this.txtAmount.Text = this.gridPaymentHistory.SelectedCells[3].Value.ToString();
            this.txtTotalAmountPaid.Text = this.gridPaymentHistory.SelectedCells[4].Value.ToString();
            this.txtChange.Text = this.gridPaymentHistory.SelectedCells[5].Value.ToString();

            this.btnEditPayment.Enabled = true;

            DateTime date = DateTime.Parse(this.gridPaymentHistory.SelectedCells[6].Value.ToString());

            this.rprtReceipt.Clear();

            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pName", this.txtFullName.Text));
            parameters.Add(new ReportParameter("pReceiptNo", this.txtReceiptNo.Text));
            parameters.Add(new ReportParameter("pDate", date.ToString("MM/dd/yy")));
            parameters.Add(new ReportParameter("pTotalMedicalFee", this.txtTotalMedicalFee.Text));
            parameters.Add(new ReportParameter("pDiscount", this.cmbDiscount.Text));
            parameters.Add(new ReportParameter("pAmount", this.txtAmount.Text));
            parameters.Add(new ReportParameter("pTotalAmountPaid", this.txtTotalAmountPaid.Text));
            parameters.Add(new ReportParameter("pChange", this.txtChange.Text));
            parameters.Add(new ReportParameter("pCashier", val.UserFullName));

            this.rprtReceipt.LocalReport.SetParameters(parameters);
            this.rprtReceipt.RefreshReport();
        }

        // New

        private void btnNewDiagnosis_Click(object sender, EventArgs e)
        {
            this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtSelectedDiagnosis.ResetText();

            this.dateSelectedDiagnosis.Value = DateTime.Now.Date;

            this.txtSelectedDiagnosis.Enabled = false;
            this.dateSelectedDiagnosis.Enabled = false;
            this.btnUpdateDiagnosis.Enabled = false;
            this.btnRemoveDiagnosis.Enabled = false;
            this.btnNewDiagnosis.Enabled = false;

            this.txtAddDiagnosis.Enabled = true;
            this.dateAddDiagnosis.Enabled = true;
            this.btnAddDiagnosis.Enabled = true;

            this.txtAddDiagnosis.Focus();
        }

        private void btnNewSymptom_Click(object sender, EventArgs e)
        {
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridManageSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtSelectedSymptom.ResetText();

            this.dateSelectedSymptom.Value = DateTime.Now.Date;

            this.txtSelectedSymptom.Enabled = false;
            this.dateSelectedSymptom.Enabled = false;
            this.btnUpdateSymptom.Enabled = false;
            this.btnRemoveSymptom.Enabled = false;
            this.btnNewSymptom.Enabled = false;

            this.txtAddSymptom.Enabled = true;
            this.dateAddSymptom.Enabled = true;
            this.btnAddSymptom.Enabled = true;

            this.txtAddSymptom.Focus();
        }

        private void btnNewPrescription_Click(object sender, EventArgs e)
        {
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            this.txtSelectedPrescription.ResetText();

            this.dateSelectedPrescription.Value = DateTime.Now.Date;

            this.txtSelectedPrescription.Enabled = false;
            this.dateSelectedPrescription.Enabled = false;
            this.btnUpdatePrescription.Enabled = false;
            this.btnRemovePrescription.Enabled = false;
            this.btnNewPrescription.Enabled = false;

            this.txtAddPrescription.Enabled = true;
            this.dateAddPrescription.Enabled = true;
            this.btnAddPrescription.Enabled = true;

            this.txtAddPrescription.Focus();
        }

        // Add

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            if (duplicate.diagnosisNameDuplicate(val.PatientID, this.txtAddDiagnosis.Text, this.dateAddDiagnosis.Value.Date))
            {
                MessageBox.Show(string.Format("{0} is already exist same as of date!", this.txtAddDiagnosis.Text), "Already Exist", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.txtAddDiagnosis.ResetText();
                this.txtAddDiagnosis.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAddDiagnosis.Text))
            {
                MessageBox.Show("Diagnosis is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddDiagnosis.Focus();
            }
            else if (diagnosis.addDiagnosis(val.PatientID, this.txtAddDiagnosisID.Text, this.txtAddDiagnosis.Text, this.dateAddDiagnosis.Value.Date))
            {
                diagnosis.LoadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosisRecords);
                diagnosis.LoadDiagnosisRecordsOfPatient(val.PatientID, this.gridManageDiagnosis);

                autoGenNum();

                this.txtAddDiagnosis.ResetText();
                this.dateAddDiagnosis.Value = DateTime.Now.Date;

                this.txtAddDiagnosis.Focus();
            }
            else
            {
                MessageBox.Show(string.Format("Failed to add {0}!", this.txtAddDiagnosis.Text), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSymptom_Click(object sender, EventArgs e)
        {
            if (duplicate.symptomNameDuplicate(val.PatientID, this.txtAddDiagnosis.Text, this.dateAddSymptom.Value.Date))
            {
                MessageBox.Show(string.Format("{0} is already exist same as of date!", this.txtAddSymptom.Text), "Already Exist", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.txtAddSymptom.ResetText();
                this.txtAddSymptom.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAddSymptom.Text))
            {
                MessageBox.Show("Symptom is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddSymptom.Focus();
            }
            else if (symptoms.addPatientSymptom(val.PatientID, this.txtAddSymptomID.Text, this.txtAddSymptom.Text, this.dateAddSymptom.Value.Date))
            {
                symptoms.LoadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptomsRecords);
                symptoms.LoadSymptomsRecordsOfPatient(val.PatientID, this.gridManageSymptoms);

                autoGenNum();

                this.txtAddSymptom.ResetText();
                this.dateAddSymptom.Value = DateTime.Now.Date;

                this.txtAddSymptom.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add symptom!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            if (duplicate.symptomNameDuplicate(val.PatientID, this.txtAddPrescription.Text, this.dateAddPrescription.Value.Date))
            {
                MessageBox.Show("Prescription is already exist same as of date!", "Already Exist", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.txtAddPrescription.ResetText();
                this.txtAddPrescription.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAddPrescription.Text))
            {
                MessageBox.Show("Prescription is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddPrescription.Focus();
            }
            else if (prescriptions.addPrescription(val.PatientID, this.txtAddPrescriptionID.Text, this.txtAddPrescription.Text,
                this.dateAddPrescription.Value.Date))
            {
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptionsRecords);
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridManagePrescriptions);

                autoGenNum();

                this.txtAddPrescription.ResetText();
                this.dateAddPrescription.Value = DateTime.Now.Date;

                this.txtAddPrescription.Focus();
            }
            else
            {
                MessageBox.Show("Failed to add prescription!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update

        private void btnUpdateDiagnosis_Click(object sender, EventArgs e)
        {
            if (duplicate.diagnosisNameDuplicate(val.PatientID, this.txtSelectedDiagnosis.Text, this.dateSelectedDiagnosis.Value.Date))
            {
                MessageBox.Show(string.Format("{0} is already exist same as of date!", this.txtSelectedDiagnosis.Text), "Already Exist", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.txtSelectedDiagnosis.Focus();
            }
            else if (diagnosis.updateDiagnosis(val.PatientID, this.gridManageDiagnosis.SelectedCells[0].Value.ToString(), this.txtSelectedDiagnosis.Text,
                this.dateSelectedDiagnosis.Value.Date))
            {
                MessageBox.Show("Diagnosis successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                diagnosis.LoadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosisRecords);
                diagnosis.LoadDiagnosisRecordsOfPatient(val.PatientID, this.gridManageDiagnosis);

                this.txtSelectedDiagnosis.ResetText();
                this.dateSelectedDiagnosis.Value = DateTime.Now.Date;

                this.txtSelectedDiagnosis.Enabled = false;
                this.dateSelectedDiagnosis.Enabled = false;
                this.btnUpdateDiagnosis.Enabled = false;
                this.btnRemoveDiagnosis.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to update {0}!", this.gridManageDiagnosis.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSymptom_Click(object sender, EventArgs e)
        {
            if (duplicate.symptomNameDuplicate(val.PatientID, this.txtSelectedSymptom.Text, this.dateSelectedSymptom.Value.Date))
            {
                MessageBox.Show(string.Format("{0} is already exist same as of date!", this.txtSelectedSymptom.Text), "Already Exist", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.txtSelectedSymptom.ResetText();
                this.txtSelectedSymptom.Focus();
            }
            else if (symptoms.updateSymptom(val.PatientID, this.gridManageSymptoms.SelectedCells[0].Value.ToString(), this.txtSelectedSymptom.Text,
                this.dateSelectedSymptom.Value.Date))
            {
                MessageBox.Show("Symptom successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridManageSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManageSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                symptoms.LoadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptomsRecords);
                symptoms.LoadSymptomsRecordsOfPatient(val.PatientID, this.gridManageSymptoms);

                this.txtSelectedSymptom.ResetText();
                this.dateSelectedSymptom.Value = DateTime.Now.Date;

                this.txtSelectedSymptom.Enabled = false;
                this.dateSelectedSymptom.Enabled = false;
                this.btnUpdateSymptom.Enabled = false;
                this.btnRemoveSymptom.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to update {0}!", this.gridManageSymptoms.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePrescription_Click(object sender, EventArgs e)
        {
            if (duplicate.prescriptionNameDuplicate(val.PatientID, this.txtSelectedPrescription.Text, this.dateSelectedPrescription.Value.Date))
            {
                MessageBox.Show("Prescription is already exist same as of date!", "Already Exist", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.txtSelectedPrescription.ResetText();
                this.txtSelectedPrescription.Focus();
            }
            else if (prescriptions.updatePrescriptions(val.PatientID, this.gridManagePrescriptions.SelectedCells[0].Value.ToString(),
                this.txtSelectedPrescription.Text, this.dateSelectedPrescription.Value.Date))
            {
                MessageBox.Show("Prescription successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptionsRecords);
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridManagePrescriptions);

                this.txtSelectedPrescription.ResetText();
                this.dateSelectedPrescription.Value = DateTime.Now.Date;

                this.txtSelectedPrescription.Enabled = false;
                this.dateSelectedPrescription.Enabled = false;
                this.btnUpdatePrescription.Enabled = false;
                this.btnRemovePrescription.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to update prescription!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Remove

        private void btnRemoveDiagnosis_Click(object sender, EventArgs e)
        {
            if (diagnosis.removeDiagnosis(val.PatientID, this.gridManageDiagnosis.SelectedCells[0].Value.ToString()))
            {
                MessageBox.Show(string.Format("{0} successfully removed!", this.gridManageDiagnosis.SelectedCells[1].Value.ToString()),
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManageDiagnosis.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                diagnosis.LoadDiagnosisRecordsOfPatient(val.PatientID, this.gridDiagnosisRecords);
                diagnosis.LoadDiagnosisRecordsOfPatient(val.PatientID, this.gridManageDiagnosis);

                this.txtSelectedDiagnosis.ResetText();
                this.dateSelectedDiagnosis.Value = DateTime.Now.Date;

                this.txtSelectedDiagnosis.Enabled = false;
                this.dateSelectedDiagnosis.Enabled = false;
                this.btnUpdateDiagnosis.Enabled = false;
                this.btnRemoveDiagnosis.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to remove {0}!", this.gridManageDiagnosis.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSymptom_Click(object sender, EventArgs e)
        {
            if (symptoms.deleteSymptom(val.PatientID, this.gridManageSymptoms.SelectedCells[0].Value.ToString()))
            {
                MessageBox.Show(string.Format("{0} successfully removed!", this.gridManageSymptoms.SelectedCells[1].Value.ToString()),
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridManageSymptoms.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManageSymptoms.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                symptoms.LoadSymptomsRecordsOfPatient(val.PatientID, this.gridSymptomsRecords);
                symptoms.LoadSymptomsRecordsOfPatient(val.PatientID, this.gridManageSymptoms);

                this.txtSelectedSymptom.ResetText();
                this.dateSelectedSymptom.Value = DateTime.Now.Date;

                this.txtSelectedSymptom.Enabled = false;
                this.dateSelectedSymptom.Enabled = false;
                this.btnUpdateSymptom.Enabled = false;
                this.btnRemoveSymptom.Enabled = false;
            }
            else
            {
                MessageBox.Show(string.Format("Failed to remove {0}!", this.gridManageSymptoms.SelectedCells[1].Value.ToString()), "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemovePrescription_Click(object sender, EventArgs e)
        {
            if (prescriptions.removePrescriptions(val.PatientID, this.gridManagePrescriptions.SelectedCells[0].Value.ToString()))
            {
                MessageBox.Show("Prescription successfully removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridManagePrescriptions.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridPrescriptionsRecords);
                prescriptions.loadPrescriptionRecordsOfPatient(val.PatientID, this.gridManagePrescriptions);

                this.txtSelectedPrescription.ResetText();
                this.dateSelectedPrescription.Value = DateTime.Now.Date;

                this.txtSelectedPrescription.Enabled = false;
                this.dateSelectedPrescription.Enabled = false;
                this.btnUpdatePrescription.Enabled = false;
                this.btnRemovePrescription.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed to remove prescription!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Transact

        private void btnTransact_Click(object sender, EventArgs e)
        {
            double pwd = .20;
            double senior_citizen = .20;
            double vip = .15;
            double discount;
            double discounted;
            double total;

            if (String.IsNullOrWhiteSpace(this.txtReceiptNo.Text))
            {
                MessageBox.Show("Receipt number is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtTotalMedicalFee.Text))
            {
                MessageBox.Show("Input total medical fee first before transact!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                MessageBox.Show("Input amount first!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.cmbDiscount.Text == "None")
                {
                    total = (double.Parse(this.txtAmount.Text) - double.Parse(this.txtTotalMedicalFee.Text));

                    this.txtTotalAmountPaid.Text = this.txtTotalMedicalFee.Text;
                    this.txtChange.Text = total.ToString();
                }
                else if (this.cmbDiscount.Text == "PWD")
                {
                    discount = (double.Parse(this.txtTotalMedicalFee.Text) * pwd);
                    discounted = (double.Parse(this.txtTotalMedicalFee.Text) - discount);
                    total = (double.Parse(this.txtAmount.Text) - discounted);

                    this.txtTotalAmountPaid.Text = discounted.ToString();
                    this.txtChange.Text = total.ToString();
                }
                else if (this.cmbDiscount.Text == "Senior Citizen")
                {
                    discount = (double.Parse(this.txtTotalMedicalFee.Text) * senior_citizen);
                    discounted = (double.Parse(this.txtTotalMedicalFee.Text) - discount);
                    total = (double.Parse(this.txtAmount.Text) - discounted);

                    this.txtTotalAmountPaid.Text = discounted.ToString();
                    this.txtChange.Text = total.ToString();
                }
                else if (this.cmbDiscount.Text == "VIP")
                {
                    discount = (double.Parse(this.txtTotalMedicalFee.Text) * vip);
                    discounted = (double.Parse(this.txtTotalMedicalFee.Text) - discount);
                    total = (double.Parse(this.txtAmount.Text) - discounted);

                    this.txtTotalAmountPaid.Text = discounted.ToString();
                    this.txtChange.Text = total.ToString();
                }
                DateTime date = DateTime.Parse(this.gridPaymentHistory.SelectedCells[6].Value.ToString());

                this.rprtReceipt.Clear();

                ReportParameterCollection parameters = new ReportParameterCollection();
                parameters.Add(new ReportParameter("pName", this.txtFullName.Text));
                parameters.Add(new ReportParameter("pReceiptNo", this.txtReceiptNo.Text));
                parameters.Add(new ReportParameter("pDate", date.ToString("MM/dd/yy")));
                parameters.Add(new ReportParameter("pTotalMedicalFee", this.txtTotalMedicalFee.Text));
                parameters.Add(new ReportParameter("pDiscount", this.cmbDiscount.Text));
                parameters.Add(new ReportParameter("pAmount", this.txtAmount.Text));
                parameters.Add(new ReportParameter("pTotalAmountPaid", this.txtTotalAmountPaid.Text));
                parameters.Add(new ReportParameter("pChange", this.txtChange.Text));
                parameters.Add(new ReportParameter("pCashier", val.UserFullName));

                this.rprtReceipt.LocalReport.SetParameters(parameters);
                this.rprtReceipt.RefreshReport();
            }
            this.btnSavePayment.Enabled = true;
        }

        // Save

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtFirstName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLastName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.cmbGender.Text))
            {
                MessageBox.Show("Gender is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbGender.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.cmbAge.Text))
            {
                MessageBox.Show("Age is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbAge.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAddress.Text))
            {
                MessageBox.Show("Address is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAddress.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtCellphoneNumber.Text) && String.IsNullOrWhiteSpace(this.txtTelephoneNumber.Text) &&
                String.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                MessageBox.Show("Contact information are required! Please input atleast one contact information", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCellphoneNumber.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtWeight.Text))
            {
                MessageBox.Show("Weight is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtWeight.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtTemperature.Text))
            {
                MessageBox.Show("Temperature is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTemperature.Focus();
            }
            else if (patient.UpdatePatient(this.txtPatientID.Text, this.txtFirstName.Text, this.txtMiddleName.Text, this.txtLastName.Text,
                this.cmbGender.Text, this.cmbAge.Text, this.txtAddress.Text, this.dateBirthday.Value.Date, this.txtCellphoneNumber.Text,
                this.txtTelephoneNumber.Text, this.txtEmail.Text))
            {
                MessageBox.Show("Patient successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (patient.GetPatient(this.txtPatientID.Text))
                {
                    this.txtPatientID.Text = val.PatientID;
                    this.txtFirstName.Text = val.PatientFirstName;
                    this.txtMiddleName.Text = val.PatientMiddleName;
                    this.txtLastName.Text = val.PatientLastName;
                    this.cmbGender.Text = val.PatientGender;
                    this.cmbAge.Text = val.PatientAge.ToString();
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
                }

                this.txtFirstName.Enabled = false;
                this.txtMiddleName.Enabled = false;
                this.txtLastName.Enabled = false;
                this.cmbGender.Enabled = false;
                this.cmbAge.Enabled = false;
                this.txtAddress.Enabled = false;
                this.dateBirthday.Enabled = false;
                this.txtCellphoneNumber.Enabled = false;
                this.txtTelephoneNumber.Enabled = false;
                this.txtEmail.Enabled = false;
                this.txtHeight.Enabled = false;
                this.txtWeight.Enabled = false;
                this.txtTemperature.Enabled = false;
                this.txtPulseRate.Enabled = false;
                this.txtBloodPressure.Enabled = false;
                this.btnSave.Enabled = false;

                this.btnEdit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to update patient!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtTotalMedicalFee.Text))
            {
                MessageBox.Show("Please input total medical fee first!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTotalMedicalFee.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtAmount.Text))
            {
                MessageBox.Show("Please input amount first!", "Input First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtTotalMedicalFee.Focus();
            }
            else if (payment.updatePaymentTransaction(val.PatientID, this.txtReceiptNo.Text, this.txtTotalMedicalFee.Text, this.cmbDiscount.Text,
                this.txtAmount.Text, this.txtTotalAmountPaid.Text, this.txtChange.Text))
            {
                MessageBox.Show("Payment successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.gridPaymentHistory.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridPaymentHistory.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                this.txtTotalMedicalFee.Enabled = false;
                this.cmbDiscount.Enabled = false;
                this.txtAmount.Enabled = false;
                this.btnTransact.Visible = false;
                this.btnSavePayment.Enabled = false;

                payment.loadPatientPaymentHistory(this.txtPatientID.Text, this.gridPaymentHistory);
            }
            else
            {
                MessageBox.Show("Failed to update payment!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Back

        private void btnBackToDoctorsPatientsInPeronalInfo_Click(object sender, EventArgs e)
        {
            forms.frmDoctorProfile frmDoctorProfile = new forms.frmDoctorProfile();
            frmDoctorProfile.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmDoctorProfile);
            frmDoctorProfile.Dock = DockStyle.Fill;
            frmDoctorProfile.Show();
            forms.frmDoctorProfile doctorProfile = (forms.frmDoctorProfile)Application.OpenForms["frmDoctorProfile"];
            TabControl tabControlDoctorProfile = (TabControl)doctorProfile.Controls["tabControlDoctor"];
            tabControlDoctorProfile.SelectedIndex = 1;
            this.Close();
        }

        private void btnBackToDoctorsPatientsInPrintPrescription_Click(object sender, EventArgs e)
        {
            forms.frmDoctorProfile frmDoctorProfile = new forms.frmDoctorProfile();
            frmDoctorProfile.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmDoctorProfile);
            frmDoctorProfile.Dock = DockStyle.Fill;
            frmDoctorProfile.Show();
            forms.frmDoctorProfile doctorProfile = (forms.frmDoctorProfile)Application.OpenForms["frmDoctorProfile"];
            TabControl tabControlDoctorProfile = (TabControl)doctorProfile.Controls["tabControlDoctor"];
            tabControlDoctorProfile.SelectedIndex = 1;
            this.Close();
        }

        private void btnBackToDoctorsPatientsInManageDiagnosis_Click(object sender, EventArgs e)
        {
            forms.frmDoctorProfile frmDoctorProfile = new forms.frmDoctorProfile();
            frmDoctorProfile.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmDoctorProfile);
            frmDoctorProfile.Dock = DockStyle.Fill;
            frmDoctorProfile.Show();
            forms.frmDoctorProfile doctorProfile = (forms.frmDoctorProfile)Application.OpenForms["frmDoctorProfile"];
            TabControl tabControlDoctorProfile = (TabControl)doctorProfile.Controls["tabControlDoctor"];
            tabControlDoctorProfile.SelectedIndex = 1;
            this.Close();
        }

        private void btnBackToDoctorsPatientsInManageSymptoms_Click(object sender, EventArgs e)
        {
            forms.frmDoctorProfile frmDoctorProfile = new forms.frmDoctorProfile();
            frmDoctorProfile.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmDoctorProfile);
            frmDoctorProfile.Dock = DockStyle.Fill;
            frmDoctorProfile.Show();
            forms.frmDoctorProfile doctorProfile = (forms.frmDoctorProfile)Application.OpenForms["frmDoctorProfile"];
            TabControl tabControlDoctorProfile = (TabControl)doctorProfile.Controls["tabControlDoctor"];
            tabControlDoctorProfile.SelectedIndex = 1;
            this.Close();
        }

        private void btnBackToDoctorsPatientsInManagePrescription_Click(object sender, EventArgs e)
        {
            forms.frmDoctorProfile frmDoctorProfile = new forms.frmDoctorProfile();
            frmDoctorProfile.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmDoctorProfile);
            frmDoctorProfile.Dock = DockStyle.Fill;
            frmDoctorProfile.Show();
            forms.frmDoctorProfile doctorProfile = (forms.frmDoctorProfile)Application.OpenForms["frmDoctorProfile"];
            TabControl tabControlDoctorProfile = (TabControl)doctorProfile.Controls["tabControlDoctor"];
            tabControlDoctorProfile.SelectedIndex = 1;
            this.Close();
        }

        private void btnBackToDoctorsPatientsInPaymentHistory_Click(object sender, EventArgs e)
        {
            forms.frmDoctorProfile frmDoctorProfile = new forms.frmDoctorProfile();
            frmDoctorProfile.TopLevel = false;
            forms.frmDashboard frmDashboard = (forms.frmDashboard)Application.OpenForms["frmDashboard"];
            Panel pnlDashboardBody = (Panel)frmDashboard.Controls["pnlDashboardBody"];
            pnlDashboardBody.Controls.Add(frmDoctorProfile);
            frmDoctorProfile.Dock = DockStyle.Fill;
            frmDoctorProfile.Show();
            forms.frmDoctorProfile doctorProfile = (forms.frmDoctorProfile)Application.OpenForms["frmDoctorProfile"];
            TabControl tabControlDoctorProfile = (TabControl)doctorProfile.Controls["tabControlDoctor"];
            tabControlDoctorProfile.SelectedIndex = 1;
            this.Close();
        }
    }
}
