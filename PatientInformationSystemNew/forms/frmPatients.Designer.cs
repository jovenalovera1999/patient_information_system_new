
namespace PatientInformationSystemNew.forms
{
    partial class frmPatients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPatientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gridPatients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPaymentTransaction = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientID
            // 
            this.txtPatientID.Animated = true;
            this.txtPatientID.BorderRadius = 3;
            this.txtPatientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientID.DefaultText = "";
            this.txtPatientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtPatientID.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtPatientID.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtPatientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientID.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPatientID.ForeColor = System.Drawing.Color.Black;
            this.txtPatientID.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientID.Location = new System.Drawing.Point(15, 43);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PasswordChar = '\0';
            this.txtPatientID.PlaceholderText = "";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.Size = new System.Drawing.Size(392, 37);
            this.txtPatientID.TabIndex = 24;
            this.txtPatientID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Patient ID:";
            // 
            // gridPatients
            // 
            this.gridPatients.AllowUserToAddRows = false;
            this.gridPatients.AllowUserToDeleteRows = false;
            this.gridPatients.AllowUserToResizeColumns = false;
            this.gridPatients.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPatients.BackgroundColor = System.Drawing.Color.White;
            this.gridPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridPatients.ColumnHeadersHeight = 36;
            this.gridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPatients.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridPatients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPatients.EnableHeadersVisualStyles = false;
            this.gridPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPatients.Location = new System.Drawing.Point(0, 218);
            this.gridPatients.Margin = new System.Windows.Forms.Padding(2);
            this.gridPatients.Name = "gridPatients";
            this.gridPatients.ReadOnly = true;
            this.gridPatients.RowHeadersVisible = false;
            this.gridPatients.RowHeadersWidth = 51;
            this.gridPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPatients.RowTemplate.Height = 36;
            this.gridPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPatients.Size = new System.Drawing.Size(1754, 763);
            this.gridPatients.TabIndex = 31;
            this.gridPatients.TabStop = false;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridPatients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridPatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPatients.ThemeStyle.HeaderStyle.Height = 36;
            this.gridPatients.ThemeStyle.ReadOnly = true;
            this.gridPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridPatients.ThemeStyle.RowsStyle.Height = 36;
            this.gridPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.gridPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridPatients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPatients_CellMouseClick);
            this.gridPatients.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPatients_CellMouseDoubleClick);
            // 
            // btnPaymentTransaction
            // 
            this.btnPaymentTransaction.Animated = true;
            this.btnPaymentTransaction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPaymentTransaction.BorderColor = System.Drawing.Color.Transparent;
            this.btnPaymentTransaction.BorderThickness = 1;
            this.btnPaymentTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaymentTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaymentTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaymentTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaymentTransaction.FillColor = System.Drawing.Color.Blue;
            this.btnPaymentTransaction.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPaymentTransaction.ForeColor = System.Drawing.Color.White;
            this.btnPaymentTransaction.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnPaymentTransaction.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnPaymentTransaction.Image = global::PatientInformationSystemNew.Properties.Resources.payment_icon;
            this.btnPaymentTransaction.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPaymentTransaction.Location = new System.Drawing.Point(225, 170);
            this.btnPaymentTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaymentTransaction.Name = "btnPaymentTransaction";
            this.btnPaymentTransaction.Size = new System.Drawing.Size(206, 44);
            this.btnPaymentTransaction.TabIndex = 30;
            this.btnPaymentTransaction.TabStop = false;
            this.btnPaymentTransaction.Text = "Payment Transaction";
            this.btnPaymentTransaction.Click += new System.EventHandler(this.btnPaymentTransaction_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Animated = true;
            this.btnAddPatient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPatient.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddPatient.BorderThickness = 1;
            this.btnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPatient.FillColor = System.Drawing.Color.Lime;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddPatient.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnAddPatient.Image = global::PatientInformationSystemNew.Properties.Resources.patient_icon;
            this.btnAddPatient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddPatient.Location = new System.Drawing.Point(435, 170);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(206, 44);
            this.btnAddPatient.TabIndex = 29;
            this.btnAddPatient.TabStop = false;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Animated = true;
            this.btnSelect.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelect.BorderColor = System.Drawing.Color.Transparent;
            this.btnSelect.BorderThickness = 1;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelect.Enabled = false;
            this.btnSelect.FillColor = System.Drawing.Color.Lime;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSelect.Image = global::PatientInformationSystemNew.Properties.Resources.select_icon;
            this.btnSelect.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSelect.Location = new System.Drawing.Point(15, 170);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(206, 44);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderRadius = 3;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSearch.Location = new System.Drawing.Point(1350, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(392, 37);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1674, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Search:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Animated = true;
            this.txtPatientName.BorderRadius = 3;
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.DefaultText = "";
            this.txtPatientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtPatientName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtPatientName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtPatientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientName.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPatientName.ForeColor = System.Drawing.Color.Black;
            this.txtPatientName.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientName.Location = new System.Drawing.Point(15, 127);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.PlaceholderText = "";
            this.txtPatientName.ReadOnly = true;
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.Size = new System.Drawing.Size(392, 37);
            this.txtPatientName.TabIndex = 35;
            this.txtPatientName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Patient Name:";
            // 
            // dateTo
            // 
            this.dateTo.BackColor = System.Drawing.Color.Blue;
            this.dateTo.BorderRadius = 3;
            this.dateTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.ForeColor = System.Drawing.Color.White;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTo.FormatCustom = null;
            this.dateTo.Location = new System.Drawing.Point(1350, 177);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(392, 37);
            this.dateTo.TabIndex = 36;
            this.dateTo.Value = new System.DateTime(2022, 5, 20, 10, 16, 17, 647);
            this.dateTo.onValueChanged += new System.EventHandler(this.dateTo_onValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.BackColor = System.Drawing.Color.Blue;
            this.dateFrom.BorderRadius = 3;
            this.dateFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.ForeColor = System.Drawing.Color.White;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFrom.FormatCustom = null;
            this.dateFrom.Location = new System.Drawing.Point(950, 177);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(392, 37);
            this.dateFrom.TabIndex = 37;
            this.dateFrom.Value = new System.DateTime(2022, 5, 20, 10, 16, 17, 647);
            this.dateFrom.onValueChanged += new System.EventHandler(this.dateFrom_onValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(945, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1345, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "To:";
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1754, 981);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPatients);
            this.Controls.Add(this.btnPaymentTransaction);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtPatientID;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private Guna.UI2.WinForms.Guna2Button btnPaymentTransaction;
        private Guna.UI2.WinForms.Guna2DataGridView gridPatients;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientName;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dateTo;
        private Bunifu.Framework.UI.BunifuDatepicker dateFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}