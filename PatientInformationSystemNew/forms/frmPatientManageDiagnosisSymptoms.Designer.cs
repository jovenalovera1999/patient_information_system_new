
namespace PatientInformationSystemNew.forms
{
    partial class frmPatientManageDiagnosisSymptoms
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
            this.label16 = new System.Windows.Forms.Label();
            this.gridDiagnosis = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiagnosisID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnNewDiagnosis = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridSymptoms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewSymptoms = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddSymptoms = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveSymptoms = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateSymptoms = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSymptoms = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSymptomsID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.dateDiagnosis = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateSymptoms = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAddDiagnosis = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveDiagnosis = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDiagnosis = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSymptoms)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(35, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(167, 28);
            this.label16.TabIndex = 274;
            this.label16.Text = "Diagnosis Record:";
            // 
            // gridDiagnosis
            // 
            this.gridDiagnosis.AllowUserToAddRows = false;
            this.gridDiagnosis.AllowUserToDeleteRows = false;
            this.gridDiagnosis.AllowUserToResizeColumns = false;
            this.gridDiagnosis.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gridDiagnosis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDiagnosis.BackgroundColor = System.Drawing.Color.White;
            this.gridDiagnosis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDiagnosis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDiagnosis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDiagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridDiagnosis.ColumnHeadersHeight = 55;
            this.gridDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDiagnosis.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridDiagnosis.EnableHeadersVisualStyles = false;
            this.gridDiagnosis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDiagnosis.Location = new System.Drawing.Point(40, 116);
            this.gridDiagnosis.Name = "gridDiagnosis";
            this.gridDiagnosis.ReadOnly = true;
            this.gridDiagnosis.RowHeadersVisible = false;
            this.gridDiagnosis.RowHeadersWidth = 51;
            this.gridDiagnosis.RowTemplate.Height = 50;
            this.gridDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDiagnosis.Size = new System.Drawing.Size(514, 940);
            this.gridDiagnosis.TabIndex = 273;
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
            this.gridDiagnosis.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDiagnosis_CellMouseClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(32, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 46);
            this.label19.TabIndex = 272;
            this.label19.Text = "Diagnosis";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Animated = true;
            this.txtDiagnosis.BorderRadius = 5;
            this.txtDiagnosis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosis.DefaultText = "";
            this.txtDiagnosis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtDiagnosis.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtDiagnosis.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtDiagnosis.DisabledState.Parent = this.txtDiagnosis;
            this.txtDiagnosis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiagnosis.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtDiagnosis.FocusedState.Parent = this.txtDiagnosis;
            this.txtDiagnosis.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiagnosis.ForeColor = System.Drawing.Color.Black;
            this.txtDiagnosis.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtDiagnosis.HoverState.Parent = this.txtDiagnosis;
            this.txtDiagnosis.Location = new System.Drawing.Point(574, 257);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.PasswordChar = '\0';
            this.txtDiagnosis.PlaceholderText = "";
            this.txtDiagnosis.SelectedText = "";
            this.txtDiagnosis.ShadowDecoration.Parent = this.txtDiagnosis;
            this.txtDiagnosis.Size = new System.Drawing.Size(446, 45);
            this.txtDiagnosis.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(569, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 28);
            this.label12.TabIndex = 279;
            this.label12.Text = "Diagnosis:";
            // 
            // txtDiagnosisID
            // 
            this.txtDiagnosisID.Animated = true;
            this.txtDiagnosisID.BorderRadius = 5;
            this.txtDiagnosisID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiagnosisID.DefaultText = "";
            this.txtDiagnosisID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtDiagnosisID.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtDiagnosisID.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtDiagnosisID.DisabledState.Parent = this.txtDiagnosisID;
            this.txtDiagnosisID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiagnosisID.Enabled = false;
            this.txtDiagnosisID.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtDiagnosisID.FocusedState.Parent = this.txtDiagnosisID;
            this.txtDiagnosisID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDiagnosisID.ForeColor = System.Drawing.Color.Black;
            this.txtDiagnosisID.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtDiagnosisID.HoverState.Parent = this.txtDiagnosisID;
            this.txtDiagnosisID.Location = new System.Drawing.Point(574, 157);
            this.txtDiagnosisID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiagnosisID.Name = "txtDiagnosisID";
            this.txtDiagnosisID.PasswordChar = '\0';
            this.txtDiagnosisID.PlaceholderText = "";
            this.txtDiagnosisID.SelectedText = "";
            this.txtDiagnosisID.ShadowDecoration.Parent = this.txtDiagnosisID;
            this.txtDiagnosisID.Size = new System.Drawing.Size(446, 45);
            this.txtDiagnosisID.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(569, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 28);
            this.label13.TabIndex = 278;
            this.label13.Text = "Diagnosis ID:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(569, 315);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 28);
            this.label21.TabIndex = 281;
            this.label21.Text = "Set Date:";
            // 
            // btnNewDiagnosis
            // 
            this.btnNewDiagnosis.Animated = true;
            this.btnNewDiagnosis.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewDiagnosis.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewDiagnosis.BorderRadius = 5;
            this.btnNewDiagnosis.BorderThickness = 1;
            this.btnNewDiagnosis.CheckedState.Parent = this.btnNewDiagnosis;
            this.btnNewDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewDiagnosis.CustomImages.Parent = this.btnNewDiagnosis;
            this.btnNewDiagnosis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewDiagnosis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewDiagnosis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewDiagnosis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewDiagnosis.DisabledState.Parent = this.btnNewDiagnosis;
            this.btnNewDiagnosis.FillColor = System.Drawing.Color.Lime;
            this.btnNewDiagnosis.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNewDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnNewDiagnosis.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnNewDiagnosis.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnNewDiagnosis.HoverState.Parent = this.btnNewDiagnosis;
            this.btnNewDiagnosis.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNewDiagnosis.Location = new System.Drawing.Point(934, 101);
            this.btnNewDiagnosis.Name = "btnNewDiagnosis";
            this.btnNewDiagnosis.ShadowDecoration.Parent = this.btnNewDiagnosis;
            this.btnNewDiagnosis.Size = new System.Drawing.Size(86, 43);
            this.btnNewDiagnosis.TabIndex = 6;
            this.btnNewDiagnosis.Text = "New";
            this.btnNewDiagnosis.Click += new System.EventHandler(this.btnNewDiagnosis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1032, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 284;
            this.label1.Text = "Symptoms Record:";
            // 
            // gridSymptoms
            // 
            this.gridSymptoms.AllowUserToAddRows = false;
            this.gridSymptoms.AllowUserToDeleteRows = false;
            this.gridSymptoms.AllowUserToResizeColumns = false;
            this.gridSymptoms.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gridSymptoms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridSymptoms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSymptoms.BackgroundColor = System.Drawing.Color.White;
            this.gridSymptoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSymptoms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSymptoms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSymptoms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridSymptoms.ColumnHeadersHeight = 55;
            this.gridSymptoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSymptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSymptoms.DefaultCellStyle = dataGridViewCellStyle12;
            this.gridSymptoms.EnableHeadersVisualStyles = false;
            this.gridSymptoms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSymptoms.Location = new System.Drawing.Point(1037, 116);
            this.gridSymptoms.Name = "gridSymptoms";
            this.gridSymptoms.ReadOnly = true;
            this.gridSymptoms.RowHeadersVisible = false;
            this.gridSymptoms.RowHeadersWidth = 51;
            this.gridSymptoms.RowTemplate.Height = 50;
            this.gridSymptoms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSymptoms.Size = new System.Drawing.Size(514, 940);
            this.gridSymptoms.TabIndex = 283;
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
            this.gridSymptoms.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSymptoms_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1029, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 46);
            this.label2.TabIndex = 282;
            this.label2.Text = "Symptoms";
            // 
            // btnNewSymptoms
            // 
            this.btnNewSymptoms.Animated = true;
            this.btnNewSymptoms.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewSymptoms.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewSymptoms.BorderRadius = 5;
            this.btnNewSymptoms.BorderThickness = 1;
            this.btnNewSymptoms.CheckedState.Parent = this.btnNewSymptoms;
            this.btnNewSymptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSymptoms.CustomImages.Parent = this.btnNewSymptoms;
            this.btnNewSymptoms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewSymptoms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewSymptoms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewSymptoms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewSymptoms.DisabledState.Parent = this.btnNewSymptoms;
            this.btnNewSymptoms.FillColor = System.Drawing.Color.Lime;
            this.btnNewSymptoms.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNewSymptoms.ForeColor = System.Drawing.Color.White;
            this.btnNewSymptoms.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnNewSymptoms.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnNewSymptoms.HoverState.Parent = this.btnNewSymptoms;
            this.btnNewSymptoms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNewSymptoms.Location = new System.Drawing.Point(1931, 101);
            this.btnNewSymptoms.Name = "btnNewSymptoms";
            this.btnNewSymptoms.ShadowDecoration.Parent = this.btnNewSymptoms;
            this.btnNewSymptoms.Size = new System.Drawing.Size(86, 43);
            this.btnNewSymptoms.TabIndex = 13;
            this.btnNewSymptoms.Text = "New";
            this.btnNewSymptoms.Click += new System.EventHandler(this.btnNewSymptoms_Click);
            // 
            // btnAddSymptoms
            // 
            this.btnAddSymptoms.Animated = true;
            this.btnAddSymptoms.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSymptoms.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSymptoms.BorderRadius = 5;
            this.btnAddSymptoms.BorderThickness = 1;
            this.btnAddSymptoms.CheckedState.Parent = this.btnAddSymptoms;
            this.btnAddSymptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSymptoms.CustomImages.Parent = this.btnAddSymptoms;
            this.btnAddSymptoms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSymptoms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddSymptoms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddSymptoms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddSymptoms.DisabledState.Parent = this.btnAddSymptoms;
            this.btnAddSymptoms.Enabled = false;
            this.btnAddSymptoms.FillColor = System.Drawing.Color.Lime;
            this.btnAddSymptoms.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddSymptoms.ForeColor = System.Drawing.Color.White;
            this.btnAddSymptoms.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddSymptoms.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnAddSymptoms.HoverState.Parent = this.btnAddSymptoms;
            this.btnAddSymptoms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddSymptoms.Location = new System.Drawing.Point(1883, 416);
            this.btnAddSymptoms.Name = "btnAddSymptoms";
            this.btnAddSymptoms.ShadowDecoration.Parent = this.btnAddSymptoms;
            this.btnAddSymptoms.Size = new System.Drawing.Size(134, 54);
            this.btnAddSymptoms.TabIndex = 10;
            this.btnAddSymptoms.Text = "Add Symptoms";
            this.btnAddSymptoms.Click += new System.EventHandler(this.btnAddSymptoms_Click);
            // 
            // btnRemoveSymptoms
            // 
            this.btnRemoveSymptoms.Animated = true;
            this.btnRemoveSymptoms.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveSymptoms.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemoveSymptoms.BorderRadius = 5;
            this.btnRemoveSymptoms.BorderThickness = 1;
            this.btnRemoveSymptoms.CheckedState.Parent = this.btnRemoveSymptoms;
            this.btnRemoveSymptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSymptoms.CustomImages.Parent = this.btnRemoveSymptoms;
            this.btnRemoveSymptoms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveSymptoms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveSymptoms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveSymptoms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveSymptoms.DisabledState.Parent = this.btnRemoveSymptoms;
            this.btnRemoveSymptoms.Enabled = false;
            this.btnRemoveSymptoms.FillColor = System.Drawing.Color.Red;
            this.btnRemoveSymptoms.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRemoveSymptoms.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSymptoms.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnRemoveSymptoms.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnRemoveSymptoms.HoverState.Parent = this.btnRemoveSymptoms;
            this.btnRemoveSymptoms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRemoveSymptoms.Location = new System.Drawing.Point(1585, 416);
            this.btnRemoveSymptoms.Name = "btnRemoveSymptoms";
            this.btnRemoveSymptoms.ShadowDecoration.Parent = this.btnRemoveSymptoms;
            this.btnRemoveSymptoms.Size = new System.Drawing.Size(134, 54);
            this.btnRemoveSymptoms.TabIndex = 12;
            this.btnRemoveSymptoms.Text = "Remove Symptoms";
            this.btnRemoveSymptoms.Click += new System.EventHandler(this.btnRemoveSymptoms_Click);
            // 
            // btnUpdateSymptoms
            // 
            this.btnUpdateSymptoms.Animated = true;
            this.btnUpdateSymptoms.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateSymptoms.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateSymptoms.BorderRadius = 5;
            this.btnUpdateSymptoms.BorderThickness = 1;
            this.btnUpdateSymptoms.CheckedState.Parent = this.btnUpdateSymptoms;
            this.btnUpdateSymptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSymptoms.CustomImages.Parent = this.btnUpdateSymptoms;
            this.btnUpdateSymptoms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateSymptoms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateSymptoms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateSymptoms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateSymptoms.DisabledState.Parent = this.btnUpdateSymptoms;
            this.btnUpdateSymptoms.Enabled = false;
            this.btnUpdateSymptoms.FillColor = System.Drawing.Color.Blue;
            this.btnUpdateSymptoms.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdateSymptoms.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSymptoms.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUpdateSymptoms.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnUpdateSymptoms.HoverState.Parent = this.btnUpdateSymptoms;
            this.btnUpdateSymptoms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateSymptoms.Location = new System.Drawing.Point(1734, 416);
            this.btnUpdateSymptoms.Name = "btnUpdateSymptoms";
            this.btnUpdateSymptoms.ShadowDecoration.Parent = this.btnUpdateSymptoms;
            this.btnUpdateSymptoms.Size = new System.Drawing.Size(134, 54);
            this.btnUpdateSymptoms.TabIndex = 11;
            this.btnUpdateSymptoms.Text = "Update Symptoms";
            this.btnUpdateSymptoms.Click += new System.EventHandler(this.btnUpdateSymptoms_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1566, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 294;
            this.label3.Text = "Set Date:";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Animated = true;
            this.txtSymptoms.BorderRadius = 5;
            this.txtSymptoms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSymptoms.DefaultText = "";
            this.txtSymptoms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSymptoms.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSymptoms.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSymptoms.DisabledState.Parent = this.txtSymptoms;
            this.txtSymptoms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSymptoms.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSymptoms.FocusedState.Parent = this.txtSymptoms;
            this.txtSymptoms.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSymptoms.ForeColor = System.Drawing.Color.Black;
            this.txtSymptoms.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSymptoms.HoverState.Parent = this.txtSymptoms;
            this.txtSymptoms.Location = new System.Drawing.Point(1571, 257);
            this.txtSymptoms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.PasswordChar = '\0';
            this.txtSymptoms.PlaceholderText = "";
            this.txtSymptoms.SelectedText = "";
            this.txtSymptoms.ShadowDecoration.Parent = this.txtSymptoms;
            this.txtSymptoms.Size = new System.Drawing.Size(446, 45);
            this.txtSymptoms.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1566, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 293;
            this.label4.Text = "Symptoms:";
            // 
            // txtSymptomsID
            // 
            this.txtSymptomsID.Animated = true;
            this.txtSymptomsID.BorderRadius = 5;
            this.txtSymptomsID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSymptomsID.DefaultText = "";
            this.txtSymptomsID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSymptomsID.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSymptomsID.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSymptomsID.DisabledState.Parent = this.txtSymptomsID;
            this.txtSymptomsID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSymptomsID.Enabled = false;
            this.txtSymptomsID.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSymptomsID.FocusedState.Parent = this.txtSymptomsID;
            this.txtSymptomsID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSymptomsID.ForeColor = System.Drawing.Color.Black;
            this.txtSymptomsID.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSymptomsID.HoverState.Parent = this.txtSymptomsID;
            this.txtSymptomsID.Location = new System.Drawing.Point(1571, 157);
            this.txtSymptomsID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSymptomsID.Name = "txtSymptomsID";
            this.txtSymptomsID.PasswordChar = '\0';
            this.txtSymptomsID.PlaceholderText = "";
            this.txtSymptomsID.SelectedText = "";
            this.txtSymptomsID.ShadowDecoration.Parent = this.txtSymptomsID;
            this.txtSymptomsID.Size = new System.Drawing.Size(446, 45);
            this.txtSymptomsID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1566, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 292;
            this.label5.Text = "Symptoms ID:";
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
            this.btnBack.Location = new System.Drawing.Point(1901, 994);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(131, 62);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateDiagnosis
            // 
            this.dateDiagnosis.Animated = true;
            this.dateDiagnosis.BorderColor = System.Drawing.Color.Transparent;
            this.dateDiagnosis.BorderRadius = 5;
            this.dateDiagnosis.BorderThickness = 1;
            this.dateDiagnosis.CheckedState.Parent = this.dateDiagnosis;
            this.dateDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateDiagnosis.FillColor = System.Drawing.Color.Blue;
            this.dateDiagnosis.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateDiagnosis.ForeColor = System.Drawing.Color.White;
            this.dateDiagnosis.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateDiagnosis.HoverState.BorderColor = System.Drawing.Color.White;
            this.dateDiagnosis.HoverState.FillColor = System.Drawing.Color.Blue;
            this.dateDiagnosis.HoverState.Parent = this.dateDiagnosis;
            this.dateDiagnosis.Location = new System.Drawing.Point(574, 356);
            this.dateDiagnosis.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateDiagnosis.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDiagnosis.Name = "dateDiagnosis";
            this.dateDiagnosis.ShadowDecoration.Parent = this.dateDiagnosis;
            this.dateDiagnosis.Size = new System.Drawing.Size(446, 45);
            this.dateDiagnosis.TabIndex = 2;
            this.dateDiagnosis.Value = new System.DateTime(2021, 10, 30, 0, 0, 0, 0);
            // 
            // dateSymptoms
            // 
            this.dateSymptoms.Animated = true;
            this.dateSymptoms.BorderColor = System.Drawing.Color.Transparent;
            this.dateSymptoms.BorderRadius = 5;
            this.dateSymptoms.BorderThickness = 1;
            this.dateSymptoms.CheckedState.Parent = this.dateSymptoms;
            this.dateSymptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateSymptoms.FillColor = System.Drawing.Color.Blue;
            this.dateSymptoms.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateSymptoms.ForeColor = System.Drawing.Color.White;
            this.dateSymptoms.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateSymptoms.HoverState.BorderColor = System.Drawing.Color.White;
            this.dateSymptoms.HoverState.FillColor = System.Drawing.Color.Blue;
            this.dateSymptoms.HoverState.Parent = this.dateSymptoms;
            this.dateSymptoms.Location = new System.Drawing.Point(1571, 356);
            this.dateSymptoms.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateSymptoms.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateSymptoms.Name = "dateSymptoms";
            this.dateSymptoms.ShadowDecoration.Parent = this.dateSymptoms;
            this.dateSymptoms.Size = new System.Drawing.Size(446, 45);
            this.dateSymptoms.TabIndex = 9;
            this.dateSymptoms.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.Animated = true;
            this.btnAddDiagnosis.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddDiagnosis.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddDiagnosis.BorderRadius = 5;
            this.btnAddDiagnosis.BorderThickness = 1;
            this.btnAddDiagnosis.CheckedState.Parent = this.btnAddDiagnosis;
            this.btnAddDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDiagnosis.CustomImages.Parent = this.btnAddDiagnosis;
            this.btnAddDiagnosis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiagnosis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDiagnosis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDiagnosis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDiagnosis.DisabledState.Parent = this.btnAddDiagnosis;
            this.btnAddDiagnosis.Enabled = false;
            this.btnAddDiagnosis.FillColor = System.Drawing.Color.Lime;
            this.btnAddDiagnosis.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnAddDiagnosis.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddDiagnosis.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnAddDiagnosis.HoverState.Parent = this.btnAddDiagnosis;
            this.btnAddDiagnosis.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddDiagnosis.Location = new System.Drawing.Point(886, 416);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.ShadowDecoration.Parent = this.btnAddDiagnosis;
            this.btnAddDiagnosis.Size = new System.Drawing.Size(134, 54);
            this.btnAddDiagnosis.TabIndex = 295;
            this.btnAddDiagnosis.Text = "Add Diagnosis";
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click_1);
            // 
            // btnRemoveDiagnosis
            // 
            this.btnRemoveDiagnosis.Animated = true;
            this.btnRemoveDiagnosis.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveDiagnosis.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemoveDiagnosis.BorderRadius = 5;
            this.btnRemoveDiagnosis.BorderThickness = 1;
            this.btnRemoveDiagnosis.CheckedState.Parent = this.btnRemoveDiagnosis;
            this.btnRemoveDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDiagnosis.CustomImages.Parent = this.btnRemoveDiagnosis;
            this.btnRemoveDiagnosis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveDiagnosis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveDiagnosis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveDiagnosis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveDiagnosis.DisabledState.Parent = this.btnRemoveDiagnosis;
            this.btnRemoveDiagnosis.Enabled = false;
            this.btnRemoveDiagnosis.FillColor = System.Drawing.Color.Red;
            this.btnRemoveDiagnosis.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRemoveDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDiagnosis.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnRemoveDiagnosis.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnRemoveDiagnosis.HoverState.Parent = this.btnRemoveDiagnosis;
            this.btnRemoveDiagnosis.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRemoveDiagnosis.Location = new System.Drawing.Point(588, 416);
            this.btnRemoveDiagnosis.Name = "btnRemoveDiagnosis";
            this.btnRemoveDiagnosis.ShadowDecoration.Parent = this.btnRemoveDiagnosis;
            this.btnRemoveDiagnosis.Size = new System.Drawing.Size(134, 54);
            this.btnRemoveDiagnosis.TabIndex = 297;
            this.btnRemoveDiagnosis.Text = "Remove Diagnosis";
            this.btnRemoveDiagnosis.Click += new System.EventHandler(this.btnRemoveDiagnosis_Click_1);
            // 
            // btnUpdateDiagnosis
            // 
            this.btnUpdateDiagnosis.Animated = true;
            this.btnUpdateDiagnosis.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateDiagnosis.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateDiagnosis.BorderRadius = 5;
            this.btnUpdateDiagnosis.BorderThickness = 1;
            this.btnUpdateDiagnosis.CheckedState.Parent = this.btnUpdateDiagnosis;
            this.btnUpdateDiagnosis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDiagnosis.CustomImages.Parent = this.btnUpdateDiagnosis;
            this.btnUpdateDiagnosis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDiagnosis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDiagnosis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDiagnosis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDiagnosis.DisabledState.Parent = this.btnUpdateDiagnosis;
            this.btnUpdateDiagnosis.Enabled = false;
            this.btnUpdateDiagnosis.FillColor = System.Drawing.Color.Blue;
            this.btnUpdateDiagnosis.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdateDiagnosis.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDiagnosis.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUpdateDiagnosis.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnUpdateDiagnosis.HoverState.Parent = this.btnUpdateDiagnosis;
            this.btnUpdateDiagnosis.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateDiagnosis.Location = new System.Drawing.Point(737, 416);
            this.btnUpdateDiagnosis.Name = "btnUpdateDiagnosis";
            this.btnUpdateDiagnosis.ShadowDecoration.Parent = this.btnUpdateDiagnosis;
            this.btnUpdateDiagnosis.Size = new System.Drawing.Size(134, 54);
            this.btnUpdateDiagnosis.TabIndex = 296;
            this.btnUpdateDiagnosis.Text = "Update Diagnosis";
            this.btnUpdateDiagnosis.Click += new System.EventHandler(this.btnUpdateDiagnosis_Click_1);
            // 
            // frmManageDiagnosisSymptoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1942, 1080);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.btnRemoveDiagnosis);
            this.Controls.Add(this.btnUpdateDiagnosis);
            this.Controls.Add(this.dateSymptoms);
            this.Controls.Add(this.dateDiagnosis);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNewSymptoms);
            this.Controls.Add(this.btnAddSymptoms);
            this.Controls.Add(this.btnRemoveSymptoms);
            this.Controls.Add(this.btnUpdateSymptoms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSymptomsID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridSymptoms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewDiagnosis);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtDiagnosis);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDiagnosisID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gridDiagnosis);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageDiagnosisSymptoms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Diagnosis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageDiagnosisSymptoms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSymptoms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2DataGridView gridDiagnosis;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox txtDiagnosis;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtDiagnosisID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2Button btnNewDiagnosis;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView gridSymptoms;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnNewSymptoms;
        private Guna.UI2.WinForms.Guna2Button btnAddSymptoms;
        private Guna.UI2.WinForms.Guna2Button btnRemoveSymptoms;
        private Guna.UI2.WinForms.Guna2Button btnUpdateSymptoms;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSymptoms;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSymptomsID;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateDiagnosis;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateSymptoms;
        private Guna.UI2.WinForms.Guna2Button btnAddDiagnosis;
        private Guna.UI2.WinForms.Guna2Button btnRemoveDiagnosis;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDiagnosis;
    }
}