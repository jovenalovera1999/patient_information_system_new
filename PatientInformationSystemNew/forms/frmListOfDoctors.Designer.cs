
namespace PatientInformationSystemNew.forms
{
    partial class frmListOfDoctors
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
            this.txtDoctorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctorID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gridDoctors = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnMedicalStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Animated = true;
            this.txtDoctorName.BorderRadius = 5;
            this.txtDoctorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorName.DefaultText = "";
            this.txtDoctorName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtDoctorName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtDoctorName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtDoctorName.DisabledState.Parent = this.txtDoctorName;
            this.txtDoctorName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoctorName.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtDoctorName.FocusedState.Parent = this.txtDoctorName;
            this.txtDoctorName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDoctorName.ForeColor = System.Drawing.Color.Black;
            this.txtDoctorName.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtDoctorName.HoverState.Parent = this.txtDoctorName;
            this.txtDoctorName.Location = new System.Drawing.Point(20, 128);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.PasswordChar = '\0';
            this.txtDoctorName.PlaceholderText = "";
            this.txtDoctorName.ReadOnly = true;
            this.txtDoctorName.SelectedText = "";
            this.txtDoctorName.ShadowDecoration.Parent = this.txtDoctorName;
            this.txtDoctorName.Size = new System.Drawing.Size(392, 37);
            this.txtDoctorName.TabIndex = 31;
            this.txtDoctorName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Doctor Name:";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Animated = true;
            this.txtDoctorID.BorderRadius = 5;
            this.txtDoctorID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoctorID.DefaultText = "";
            this.txtDoctorID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtDoctorID.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtDoctorID.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtDoctorID.DisabledState.Parent = this.txtDoctorID;
            this.txtDoctorID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoctorID.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtDoctorID.FocusedState.Parent = this.txtDoctorID;
            this.txtDoctorID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDoctorID.ForeColor = System.Drawing.Color.Black;
            this.txtDoctorID.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtDoctorID.HoverState.Parent = this.txtDoctorID;
            this.txtDoctorID.Location = new System.Drawing.Point(20, 48);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.PasswordChar = '\0';
            this.txtDoctorID.PlaceholderText = "";
            this.txtDoctorID.ReadOnly = true;
            this.txtDoctorID.SelectedText = "";
            this.txtDoctorID.ShadowDecoration.Parent = this.txtDoctorID;
            this.txtDoctorID.Size = new System.Drawing.Size(392, 37);
            this.txtDoctorID.TabIndex = 29;
            this.txtDoctorID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Doctor ID:";
            // 
            // gridDoctors
            // 
            this.gridDoctors.AllowUserToAddRows = false;
            this.gridDoctors.AllowUserToDeleteRows = false;
            this.gridDoctors.AllowUserToResizeColumns = false;
            this.gridDoctors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDoctors.BackgroundColor = System.Drawing.Color.White;
            this.gridDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDoctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDoctors.ColumnHeadersHeight = 40;
            this.gridDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDoctors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridDoctors.EnableHeadersVisualStyles = false;
            this.gridDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDoctors.Location = new System.Drawing.Point(0, 232);
            this.gridDoctors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridDoctors.Name = "gridDoctors";
            this.gridDoctors.ReadOnly = true;
            this.gridDoctors.RowHeadersVisible = false;
            this.gridDoctors.RowHeadersWidth = 51;
            this.gridDoctors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDoctors.RowTemplate.Height = 35;
            this.gridDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDoctors.Size = new System.Drawing.Size(1754, 749);
            this.gridDoctors.TabIndex = 34;
            this.gridDoctors.TabStop = false;
            this.gridDoctors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDoctors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridDoctors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridDoctors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridDoctors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridDoctors.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridDoctors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDoctors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridDoctors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridDoctors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridDoctors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridDoctors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDoctors.ThemeStyle.HeaderStyle.Height = 40;
            this.gridDoctors.ThemeStyle.ReadOnly = true;
            this.gridDoctors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDoctors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDoctors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridDoctors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridDoctors.ThemeStyle.RowsStyle.Height = 35;
            this.gridDoctors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridDoctors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridDoctors.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDoctors_CellMouseClick);
            this.gridDoctors.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDoctors_CellMouseDoubleClick);
            // 
            // btnMedicalStaff
            // 
            this.btnMedicalStaff.Animated = true;
            this.btnMedicalStaff.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMedicalStaff.BorderColor = System.Drawing.Color.Transparent;
            this.btnMedicalStaff.BorderRadius = 5;
            this.btnMedicalStaff.BorderThickness = 1;
            this.btnMedicalStaff.CheckedState.Parent = this.btnMedicalStaff;
            this.btnMedicalStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicalStaff.CustomImages.Parent = this.btnMedicalStaff;
            this.btnMedicalStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicalStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicalStaff.DisabledState.Parent = this.btnMedicalStaff;
            this.btnMedicalStaff.FillColor = System.Drawing.Color.Blue;
            this.btnMedicalStaff.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMedicalStaff.ForeColor = System.Drawing.Color.White;
            this.btnMedicalStaff.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnMedicalStaff.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnMedicalStaff.HoverState.Parent = this.btnMedicalStaff;
            this.btnMedicalStaff.Image = global::PatientInformationSystemNew.Properties.Resources.medical_staff_icon;
            this.btnMedicalStaff.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMedicalStaff.Location = new System.Drawing.Point(159, 178);
            this.btnMedicalStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMedicalStaff.Name = "btnMedicalStaff";
            this.btnMedicalStaff.ShadowDecoration.Parent = this.btnMedicalStaff;
            this.btnMedicalStaff.Size = new System.Drawing.Size(135, 50);
            this.btnMedicalStaff.TabIndex = 33;
            this.btnMedicalStaff.TabStop = false;
            this.btnMedicalStaff.Text = "Medical Staff";
            this.btnMedicalStaff.Click += new System.EventHandler(this.btnMedicalStaff_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Animated = true;
            this.btnSelect.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSelect.BorderColor = System.Drawing.Color.Transparent;
            this.btnSelect.BorderRadius = 5;
            this.btnSelect.BorderThickness = 1;
            this.btnSelect.CheckedState.Parent = this.btnSelect;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.CustomImages.Parent = this.btnSelect;
            this.btnSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelect.DisabledState.Parent = this.btnSelect;
            this.btnSelect.Enabled = false;
            this.btnSelect.FillColor = System.Drawing.Color.Lime;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSelect.HoverState.Parent = this.btnSelect;
            this.btnSelect.Image = global::PatientInformationSystemNew.Properties.Resources.select_icon;
            this.btnSelect.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSelect.Location = new System.Drawing.Point(20, 178);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShadowDecoration.Parent = this.btnSelect;
            this.btnSelect.Size = new System.Drawing.Size(135, 50);
            this.btnSelect.TabIndex = 32;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmListOfDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1754, 981);
            this.Controls.Add(this.gridDoctors);
            this.Controls.Add(this.btnMedicalStaff);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListOfDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Doctors";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListOfDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMedicalStaff;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private Guna.UI2.WinForms.Guna2TextBox txtDoctorName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDoctorID;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView gridDoctors;
    }
}