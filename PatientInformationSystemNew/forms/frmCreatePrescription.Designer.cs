
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridDiagnosisRecord = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridPrescriptionRecord = new Guna.UI2.WinForms.Guna2DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnosisRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrescriptionRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDiagnosisRecord
            // 
            this.gridDiagnosisRecord.AllowUserToAddRows = false;
            this.gridDiagnosisRecord.AllowUserToDeleteRows = false;
            this.gridDiagnosisRecord.AllowUserToResizeColumns = false;
            this.gridDiagnosisRecord.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gridDiagnosisRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridDiagnosisRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDiagnosisRecord.BackgroundColor = System.Drawing.Color.White;
            this.gridDiagnosisRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDiagnosisRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDiagnosisRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDiagnosisRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridDiagnosisRecord.ColumnHeadersHeight = 55;
            this.gridDiagnosisRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDiagnosisRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDiagnosisRecord.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridDiagnosisRecord.EnableHeadersVisualStyles = false;
            this.gridDiagnosisRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDiagnosisRecord.Location = new System.Drawing.Point(29, 114);
            this.gridDiagnosisRecord.Name = "gridDiagnosisRecord";
            this.gridDiagnosisRecord.ReadOnly = true;
            this.gridDiagnosisRecord.RowHeadersVisible = false;
            this.gridDiagnosisRecord.RowHeadersWidth = 51;
            this.gridDiagnosisRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDiagnosisRecord.RowTemplate.Height = 50;
            this.gridDiagnosisRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiagnosisRecord.Size = new System.Drawing.Size(773, 414);
            this.gridDiagnosisRecord.TabIndex = 147;
            this.gridDiagnosisRecord.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDiagnosisRecord.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridDiagnosisRecord.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridDiagnosisRecord.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridDiagnosisRecord.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridDiagnosisRecord.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridDiagnosisRecord.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDiagnosisRecord.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridDiagnosisRecord.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridDiagnosisRecord.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridDiagnosisRecord.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridDiagnosisRecord.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDiagnosisRecord.ThemeStyle.HeaderStyle.Height = 55;
            this.gridDiagnosisRecord.ThemeStyle.ReadOnly = true;
            this.gridDiagnosisRecord.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDiagnosisRecord.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDiagnosisRecord.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridDiagnosisRecord.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridDiagnosisRecord.ThemeStyle.RowsStyle.Height = 50;
            this.gridDiagnosisRecord.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridDiagnosisRecord.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.label1.Size = new System.Drawing.Size(186, 28);
            this.label1.TabIndex = 152;
            this.label1.Text = "Prescription Record:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 46);
            this.label2.TabIndex = 151;
            this.label2.Text = "Prescription";
            // 
            // gridPrescriptionRecord
            // 
            this.gridPrescriptionRecord.AllowUserToAddRows = false;
            this.gridPrescriptionRecord.AllowUserToDeleteRows = false;
            this.gridPrescriptionRecord.AllowUserToResizeColumns = false;
            this.gridPrescriptionRecord.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gridPrescriptionRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridPrescriptionRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPrescriptionRecord.BackgroundColor = System.Drawing.Color.White;
            this.gridPrescriptionRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPrescriptionRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPrescriptionRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPrescriptionRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridPrescriptionRecord.ColumnHeadersHeight = 55;
            this.gridPrescriptionRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPrescriptionRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPrescriptionRecord.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridPrescriptionRecord.EnableHeadersVisualStyles = false;
            this.gridPrescriptionRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPrescriptionRecord.Location = new System.Drawing.Point(29, 635);
            this.gridPrescriptionRecord.Name = "gridPrescriptionRecord";
            this.gridPrescriptionRecord.ReadOnly = true;
            this.gridPrescriptionRecord.RowHeadersVisible = false;
            this.gridPrescriptionRecord.RowHeadersWidth = 51;
            this.gridPrescriptionRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPrescriptionRecord.RowTemplate.Height = 50;
            this.gridPrescriptionRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPrescriptionRecord.Size = new System.Drawing.Size(773, 424);
            this.gridPrescriptionRecord.TabIndex = 150;
            this.gridPrescriptionRecord.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPrescriptionRecord.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridPrescriptionRecord.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridPrescriptionRecord.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridPrescriptionRecord.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridPrescriptionRecord.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridPrescriptionRecord.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPrescriptionRecord.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridPrescriptionRecord.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPrescriptionRecord.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridPrescriptionRecord.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridPrescriptionRecord.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPrescriptionRecord.ThemeStyle.HeaderStyle.Height = 55;
            this.gridPrescriptionRecord.ThemeStyle.ReadOnly = true;
            this.gridPrescriptionRecord.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPrescriptionRecord.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPrescriptionRecord.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridPrescriptionRecord.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridPrescriptionRecord.ThemeStyle.RowsStyle.Height = 50;
            this.gridPrescriptionRecord.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridPrescriptionRecord.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.txtPrescriptionReview.Location = new System.Drawing.Point(818, 114);
            this.txtPrescriptionReview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrescriptionReview.Name = "txtPrescriptionReview";
            this.txtPrescriptionReview.PasswordChar = '\0';
            this.txtPrescriptionReview.PlaceholderText = "";
            this.txtPrescriptionReview.SelectedText = "";
            this.txtPrescriptionReview.ShadowDecoration.Parent = this.txtPrescriptionReview;
            this.txtPrescriptionReview.Size = new System.Drawing.Size(538, 414);
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
            this.txtCreateNewPrescription.Location = new System.Drawing.Point(818, 635);
            this.txtCreateNewPrescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateNewPrescription.Name = "txtCreateNewPrescription";
            this.txtCreateNewPrescription.PasswordChar = '\0';
            this.txtCreateNewPrescription.PlaceholderText = "";
            this.txtCreateNewPrescription.SelectedText = "";
            this.txtCreateNewPrescription.ShadowDecoration.Parent = this.txtCreateNewPrescription;
            this.txtCreateNewPrescription.Size = new System.Drawing.Size(538, 424);
            this.txtCreateNewPrescription.TabIndex = 154;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(810, 19);
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
            this.label4.Location = new System.Drawing.Point(813, 74);
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
            this.label5.Location = new System.Drawing.Point(810, 540);
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
            this.label6.Location = new System.Drawing.Point(813, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 28);
            this.label6.TabIndex = 158;
            this.label6.Text = "Create New Prescription:";
            // 
            // rprtPrescription
            // 
            this.rprtPrescription.Location = new System.Drawing.Point(1374, 114);
            this.rprtPrescription.Name = "rprtPrescription";
            this.rprtPrescription.Size = new System.Drawing.Size(658, 865);
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
            this.btnPrescription.TabIndex = 160;
            this.btnPrescription.Text = "Save";
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
            this.btnBack.TabIndex = 161;
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
            this.dateRecords.Location = new System.Drawing.Point(206, 57);
            this.dateRecords.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateRecords.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateRecords.Name = "dateRecords";
            this.dateRecords.ShadowDecoration.Parent = this.dateRecords;
            this.dateRecords.Size = new System.Drawing.Size(596, 45);
            this.dateRecords.TabIndex = 162;
            this.dateRecords.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            // 
            // frmCreatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1942, 1080);
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
            this.Controls.Add(this.gridPrescriptionRecord);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.gridDiagnosisRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreatePrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCreatePrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnosisRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrescriptionRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gridDiagnosisRecord;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gridPrescriptionRecord;
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
    }
}