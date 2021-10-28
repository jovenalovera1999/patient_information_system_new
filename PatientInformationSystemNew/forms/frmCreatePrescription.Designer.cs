
namespace PatientInformationSystemNew.forms
{
    partial class frmCreatePrescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridDiagnosis = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridSymptoms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtPrescriptionReview = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreateNewPrescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rprtPrescription = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrescription = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.dateRecords = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gridPrescriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnGeneratePrintNewPrescription = new Guna.UI2.WinForms.Guna2Button();
            this.btnGeneratePrintPrescriptionPreview = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSymptoms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDiagnosis
            // 
            this.gridDiagnosis.AllowUserToAddRows = false;
            this.gridDiagnosis.AllowUserToDeleteRows = false;
            this.gridDiagnosis.AllowUserToResizeColumns = false;
            this.gridDiagnosis.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridDiagnosis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDiagnosis.BackgroundColor = System.Drawing.Color.White;
            this.gridDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDiagnosis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDiagnosis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDiagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDiagnosis.ColumnHeadersHeight = 55;
            this.gridDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDiagnosis.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDiagnosis.EnableHeadersVisualStyles = false;
            this.gridDiagnosis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDiagnosis.Location = new System.Drawing.Point(29, 114);
            this.gridDiagnosis.Name = "gridDiagnosis";
            this.gridDiagnosis.ReadOnly = true;
            this.gridDiagnosis.RowHeadersVisible = false;
            this.gridDiagnosis.RowHeadersWidth = 51;
            this.gridDiagnosis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDiagnosis.RowTemplate.Height = 50;
            this.gridDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiagnosis.Size = new System.Drawing.Size(479, 414);
            this.gridDiagnosis.TabIndex = 147;
            this.gridDiagnosis.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDiagnosis.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridDiagnosis.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridDiagnosis.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridDiagnosis.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridDiagnosis.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridDiagnosis.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDiagnosis.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridDiagnosis.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridDiagnosis.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridDiagnosis.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridDiagnosis.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDiagnosis.ThemeStyle.HeaderStyle.Height = 55;
            this.gridDiagnosis.ThemeStyle.ReadOnly = true;
            this.gridDiagnosis.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDiagnosis.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDiagnosis.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridDiagnosis.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridDiagnosis.ThemeStyle.RowsStyle.Height = 50;
            this.gridDiagnosis.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridDiagnosis.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(21, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 46);
            this.label19.TabIndex = 148;
            this.label19.Text = "Diagnosis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(24, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 28);
            this.label13.TabIndex = 149;
            this.label13.Text = "Diagnosis Record:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 152;
            this.label1.Text = "Symptoms Record:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 46);
            this.label2.TabIndex = 151;
            this.label2.Text = "Symptoms";
            // 
            // gridSymptoms
            // 
            this.gridSymptoms.AllowUserToAddRows = false;
            this.gridSymptoms.AllowUserToDeleteRows = false;
            this.gridSymptoms.AllowUserToResizeColumns = false;
            this.gridSymptoms.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridSymptoms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridSymptoms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSymptoms.BackgroundColor = System.Drawing.Color.White;
            this.gridSymptoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSymptoms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSymptoms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSymptoms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridSymptoms.ColumnHeadersHeight = 55;
            this.gridSymptoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSymptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSymptoms.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridSymptoms.EnableHeadersVisualStyles = false;
            this.gridSymptoms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSymptoms.Location = new System.Drawing.Point(29, 635);
            this.gridSymptoms.Name = "gridSymptoms";
            this.gridSymptoms.ReadOnly = true;
            this.gridSymptoms.RowHeadersVisible = false;
            this.gridSymptoms.RowHeadersWidth = 51;
            this.gridSymptoms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSymptoms.RowTemplate.Height = 50;
            this.gridSymptoms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSymptoms.Size = new System.Drawing.Size(479, 424);
            this.gridSymptoms.TabIndex = 150;
            this.gridSymptoms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSymptoms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridSymptoms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridSymptoms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridSymptoms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridSymptoms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridSymptoms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSymptoms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridSymptoms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSymptoms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridSymptoms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridSymptoms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSymptoms.ThemeStyle.HeaderStyle.Height = 55;
            this.gridSymptoms.ThemeStyle.ReadOnly = true;
            this.gridSymptoms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSymptoms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSymptoms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridSymptoms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridSymptoms.ThemeStyle.RowsStyle.Height = 50;
            this.gridSymptoms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridSymptoms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txtPrescriptionReview
            // 
            this.txtPrescriptionReview.Animated = true;
            this.txtPrescriptionReview.BorderRadius = 5;
            this.txtPrescriptionReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrescriptionReview.DefaultText = "";
            this.txtPrescriptionReview.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtPrescriptionReview.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtPrescriptionReview.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtPrescriptionReview.DisabledState.Parent = this.txtPrescriptionReview;
            this.txtPrescriptionReview.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrescriptionReview.Enabled = false;
            this.txtPrescriptionReview.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtPrescriptionReview.FocusedState.Parent = this.txtPrescriptionReview;
            this.txtPrescriptionReview.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPrescriptionReview.ForeColor = System.Drawing.Color.Black;
            this.txtPrescriptionReview.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtPrescriptionReview.HoverState.Parent = this.txtPrescriptionReview;
            this.txtPrescriptionReview.Location = new System.Drawing.Point(1060, 635);
            this.txtPrescriptionReview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrescriptionReview.Name = "txtPrescriptionReview";
            this.txtPrescriptionReview.PasswordChar = '\0';
            this.txtPrescriptionReview.PlaceholderText = "";
            this.txtPrescriptionReview.SelectedText = "";
            this.txtPrescriptionReview.ShadowDecoration.Parent = this.txtPrescriptionReview;
            this.txtPrescriptionReview.Size = new System.Drawing.Size(538, 424);
            this.txtPrescriptionReview.TabIndex = 153;
            // 
            // txtCreateNewPrescription
            // 
            this.txtCreateNewPrescription.Animated = true;
            this.txtCreateNewPrescription.BorderRadius = 5;
            this.txtCreateNewPrescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreateNewPrescription.DefaultText = "";
            this.txtCreateNewPrescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtCreateNewPrescription.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtCreateNewPrescription.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtCreateNewPrescription.DisabledState.Parent = this.txtCreateNewPrescription;
            this.txtCreateNewPrescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreateNewPrescription.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtCreateNewPrescription.FocusedState.Parent = this.txtCreateNewPrescription;
            this.txtCreateNewPrescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCreateNewPrescription.ForeColor = System.Drawing.Color.Black;
            this.txtCreateNewPrescription.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtCreateNewPrescription.HoverState.Parent = this.txtCreateNewPrescription;
            this.txtCreateNewPrescription.Location = new System.Drawing.Point(1060, 114);
            this.txtCreateNewPrescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateNewPrescription.Name = "txtCreateNewPrescription";
            this.txtCreateNewPrescription.PasswordChar = '\0';
            this.txtCreateNewPrescription.PlaceholderText = "";
            this.txtCreateNewPrescription.SelectedText = "";
            this.txtCreateNewPrescription.ShadowDecoration.Parent = this.txtCreateNewPrescription;
            this.txtCreateNewPrescription.Size = new System.Drawing.Size(538, 414);
            this.txtCreateNewPrescription.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1052, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 46);
            this.label3.TabIndex = 155;
            this.label3.Text = "Prescription Preview";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1055, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 28);
            this.label4.TabIndex = 156;
            this.label4.Text = "Select from Prescription Record:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1052, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 46);
            this.label5.TabIndex = 157;
            this.label5.Text = "Create Prescription";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1055, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 28);
            this.label6.TabIndex = 158;
            this.label6.Text = "Create New Prescription:";
            // 
            // rprtPrescription
            // 
            this.rprtPrescription.Location = new System.Drawing.Point(1617, 114);
            this.rprtPrescription.Name = "rprtPrescription";
            this.rprtPrescription.Size = new System.Drawing.Size(415, 865);
            this.rprtPrescription.TabIndex = 159;
            this.rprtPrescription.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // btnPrescription
            // 
            this.btnPrescription.Animated = true;
            this.btnPrescription.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrescription.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrescription.BorderRadius = 5;
            this.btnPrescription.BorderThickness = 1;
            this.btnPrescription.CheckedState.Parent = this.btnPrescription;
            this.btnPrescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrescription.CustomImages.Parent = this.btnPrescription;
            this.btnPrescription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrescription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrescription.DisabledState.Parent = this.btnPrescription;
            this.btnPrescription.FillColor = System.Drawing.Color.Lime;
            this.btnPrescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPrescription.ForeColor = System.Drawing.Color.White;
            this.btnPrescription.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnPrescription.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnPrescription.HoverState.Parent = this.btnPrescription;
            this.btnPrescription.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnPrescription.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrescription.Location = new System.Drawing.Point(1905, 997);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.ShadowDecoration.Parent = this.btnPrescription;
            this.btnPrescription.Size = new System.Drawing.Size(131, 62);
            this.btnPrescription.TabIndex = 2;
            this.btnPrescription.Text = "Save";
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 5;
            this.btnBack.BorderThickness = 1;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.DisabledState.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::PatientInformationSystemNew.Properties.Resources.back_icon;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(1759, 997);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(131, 62);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            // 
            // dateRecords
            // 
            this.dateRecords.Animated = true;
            this.dateRecords.BorderColor = System.Drawing.Color.Transparent;
            this.dateRecords.BorderRadius = 5;
            this.dateRecords.BorderThickness = 1;
            this.dateRecords.CheckedState.Parent = this.dateRecords;
            this.dateRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateRecords.FillColor = System.Drawing.Color.Blue;
            this.dateRecords.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateRecords.ForeColor = System.Drawing.Color.White;
            this.dateRecords.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateRecords.HoverState.BorderColor = System.Drawing.Color.White;
            this.dateRecords.HoverState.FillColor = System.Drawing.Color.Blue;
            this.dateRecords.HoverState.Parent = this.dateRecords;
            this.dateRecords.Location = new System.Drawing.Point(207, 57);
            this.dateRecords.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateRecords.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateRecords.Name = "dateRecords";
            this.dateRecords.ShadowDecoration.Parent = this.dateRecords;
            this.dateRecords.Size = new System.Drawing.Size(301, 45);
            this.dateRecords.TabIndex = 162;
            this.dateRecords.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            this.dateRecords.ValueChanged += new System.EventHandler(this.dateRecords_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(518, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 28);
            this.label7.TabIndex = 165;
            this.label7.Text = "Prescription Record:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(515, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 46);
            this.label8.TabIndex = 164;
            this.label8.Text = "Prescription";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1609, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 46);
            this.label9.TabIndex = 166;
            this.label9.Text = "Print Prescription:";
            // 
            // gridPrescriptions
            // 
            this.gridPrescriptions.AllowUserToAddRows = false;
            this.gridPrescriptions.AllowUserToDeleteRows = false;
            this.gridPrescriptions.AllowUserToResizeColumns = false;
            this.gridPrescriptions.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gridPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPrescriptions.BackgroundColor = System.Drawing.Color.White;
            this.gridPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPrescriptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPrescriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridPrescriptions.ColumnHeadersHeight = 55;
            this.gridPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPrescriptions.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPrescriptions.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridPrescriptions.EnableHeadersVisualStyles = false;
            this.gridPrescriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPrescriptions.Location = new System.Drawing.Point(523, 114);
            this.gridPrescriptions.Name = "gridPrescriptions";
            this.gridPrescriptions.ReadOnly = true;
            this.gridPrescriptions.RowHeadersVisible = false;
            this.gridPrescriptions.RowHeadersWidth = 51;
            this.gridPrescriptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPrescriptions.RowTemplate.Height = 50;
            this.gridPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrescriptions.Size = new System.Drawing.Size(521, 945);
            this.gridPrescriptions.TabIndex = 163;
            this.gridPrescriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPrescriptions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridPrescriptions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridPrescriptions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridPrescriptions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPrescriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridPrescriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPrescriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridPrescriptions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridPrescriptions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPrescriptions.ThemeStyle.HeaderStyle.Height = 55;
            this.gridPrescriptions.ThemeStyle.ReadOnly = true;
            this.gridPrescriptions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPrescriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPrescriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridPrescriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridPrescriptions.ThemeStyle.RowsStyle.Height = 50;
            this.gridPrescriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridPrescriptions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridPrescriptions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPrescriptions_CellMouseClick);
            // 
            // btnGeneratePrintNewPrescription
            // 
            this.btnGeneratePrintNewPrescription.Animated = true;
            this.btnGeneratePrintNewPrescription.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGeneratePrintNewPrescription.BorderColor = System.Drawing.Color.Transparent;
            this.btnGeneratePrintNewPrescription.BorderRadius = 5;
            this.btnGeneratePrintNewPrescription.BorderThickness = 1;
            this.btnGeneratePrintNewPrescription.CheckedState.Parent = this.btnGeneratePrintNewPrescription;
            this.btnGeneratePrintNewPrescription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePrintNewPrescription.CustomImages.Parent = this.btnGeneratePrintNewPrescription;
            this.btnGeneratePrintNewPrescription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePrintNewPrescription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePrintNewPrescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratePrintNewPrescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneratePrintNewPrescription.DisabledState.Parent = this.btnGeneratePrintNewPrescription;
            this.btnGeneratePrintNewPrescription.FillColor = System.Drawing.Color.Blue;
            this.btnGeneratePrintNewPrescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnGeneratePrintNewPrescription.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePrintNewPrescription.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnGeneratePrintNewPrescription.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnGeneratePrintNewPrescription.HoverState.Parent = this.btnGeneratePrintNewPrescription;
            this.btnGeneratePrintNewPrescription.Image = global::PatientInformationSystemNew.Properties.Resources.generate_icon;
            this.btnGeneratePrintNewPrescription.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGeneratePrintNewPrescription.Location = new System.Drawing.Point(1477, 19);
            this.btnGeneratePrintNewPrescription.Name = "btnGeneratePrintNewPrescription";
            this.btnGeneratePrintNewPrescription.ShadowDecoration.Parent = this.btnGeneratePrintNewPrescription;
            this.btnGeneratePrintNewPrescription.Size = new System.Drawing.Size(121, 83);
            this.btnGeneratePrintNewPrescription.TabIndex = 1;
            this.btnGeneratePrintNewPrescription.Text = "Generate Print";
            // 
            // btnGeneratePrintPrescriptionPreview
            // 
            this.btnGeneratePrintPrescriptionPreview.Animated = true;
            this.btnGeneratePrintPrescriptionPreview.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGeneratePrintPrescriptionPreview.BorderColor = System.Drawing.Color.Transparent;
            this.btnGeneratePrintPrescriptionPreview.BorderRadius = 5;
            this.btnGeneratePrintPrescriptionPreview.BorderThickness = 1;
            this.btnGeneratePrintPrescriptionPreview.CheckedState.Parent = this.btnGeneratePrintPrescriptionPreview;
            this.btnGeneratePrintPrescriptionPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePrintPrescriptionPreview.CustomImages.Parent = this.btnGeneratePrintPrescriptionPreview;
            this.btnGeneratePrintPrescriptionPreview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePrintPrescriptionPreview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeneratePrintPrescriptionPreview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeneratePrintPrescriptionPreview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeneratePrintPrescriptionPreview.DisabledState.Parent = this.btnGeneratePrintPrescriptionPreview;
            this.btnGeneratePrintPrescriptionPreview.FillColor = System.Drawing.Color.Blue;
            this.btnGeneratePrintPrescriptionPreview.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnGeneratePrintPrescriptionPreview.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePrintPrescriptionPreview.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnGeneratePrintPrescriptionPreview.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnGeneratePrintPrescriptionPreview.HoverState.Parent = this.btnGeneratePrintPrescriptionPreview;
            this.btnGeneratePrintPrescriptionPreview.Image = global::PatientInformationSystemNew.Properties.Resources.generate_icon;
            this.btnGeneratePrintPrescriptionPreview.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGeneratePrintPrescriptionPreview.Location = new System.Drawing.Point(1477, 540);
            this.btnGeneratePrintPrescriptionPreview.Name = "btnGeneratePrintPrescriptionPreview";
            this.btnGeneratePrintPrescriptionPreview.ShadowDecoration.Parent = this.btnGeneratePrintPrescriptionPreview;
            this.btnGeneratePrintPrescriptionPreview.Size = new System.Drawing.Size(121, 83);
            this.btnGeneratePrintPrescriptionPreview.TabIndex = 167;
            this.btnGeneratePrintPrescriptionPreview.Text = "Generate Print";
            // 
            // frmCreatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1942, 1080);
            this.Controls.Add(this.btnGeneratePrintPrescriptionPreview);
            this.Controls.Add(this.btnGeneratePrintNewPrescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridPrescriptions);
            this.Controls.Add(this.dateRecords);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.rprtPrescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCreateNewPrescription);
            this.Controls.Add(this.txtPrescriptionReview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridSymptoms);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.gridDiagnosis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreatePrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCreatePrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSymptoms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridDiagnosis;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gridSymptoms;
        private Guna.UI2.WinForms.Guna2TextBox txtPrescriptionReview;
        private Guna.UI2.WinForms.Guna2TextBox txtCreateNewPrescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer rprtPrescription;
        private Guna.UI2.WinForms.Guna2Button btnPrescription;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateRecords;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView gridPrescriptions;
        private Guna.UI2.WinForms.Guna2Button btnGeneratePrintNewPrescription;
        private Guna.UI2.WinForms.Guna2Button btnGeneratePrintPrescriptionPreview;
    }
}