
namespace PatientInformationSystemNew.forms
{
    partial class frmSchedule
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
            this.txtPatientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridSchedule = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnCancelPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientID
            // 
            this.txtPatientID.Animated = true;
            this.txtPatientID.BorderRadius = 5;
            this.txtPatientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientID.DefaultText = "";
            this.txtPatientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtPatientID.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtPatientID.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtPatientID.DisabledState.Parent = this.txtPatientID;
            this.txtPatientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientID.Enabled = false;
            this.txtPatientID.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientID.FocusedState.Parent = this.txtPatientID;
            this.txtPatientID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPatientID.ForeColor = System.Drawing.Color.Black;
            this.txtPatientID.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientID.HoverState.Parent = this.txtPatientID;
            this.txtPatientID.Location = new System.Drawing.Point(26, 59);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PasswordChar = '\0';
            this.txtPatientID.PlaceholderText = "";
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.ShadowDecoration.Parent = this.txtPatientID;
            this.txtPatientID.Size = new System.Drawing.Size(446, 45);
            this.txtPatientID.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "Patient ID:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Animated = true;
            this.txtPatientName.BorderRadius = 5;
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.DefaultText = "";
            this.txtPatientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtPatientName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtPatientName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtPatientName.DisabledState.Parent = this.txtPatientName;
            this.txtPatientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientName.Enabled = false;
            this.txtPatientName.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientName.FocusedState.Parent = this.txtPatientName;
            this.txtPatientName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPatientName.ForeColor = System.Drawing.Color.Black;
            this.txtPatientName.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtPatientName.HoverState.Parent = this.txtPatientName;
            this.txtPatientName.Location = new System.Drawing.Point(26, 158);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.PlaceholderText = "";
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.ShadowDecoration.Parent = this.txtPatientName;
            this.txtPatientName.Size = new System.Drawing.Size(446, 45);
            this.txtPatientName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Patient Name:";
            // 
            // gridSchedule
            // 
            this.gridSchedule.AllowUserToAddRows = false;
            this.gridSchedule.AllowUserToDeleteRows = false;
            this.gridSchedule.AllowUserToResizeColumns = false;
            this.gridSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSchedule.BackgroundColor = System.Drawing.Color.White;
            this.gridSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSchedule.ColumnHeadersHeight = 55;
            this.gridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSchedule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridSchedule.EnableHeadersVisualStyles = false;
            this.gridSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSchedule.Location = new System.Drawing.Point(0, 303);
            this.gridSchedule.Name = "gridSchedule";
            this.gridSchedule.ReadOnly = true;
            this.gridSchedule.RowHeadersVisible = false;
            this.gridSchedule.RowHeadersWidth = 51;
            this.gridSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSchedule.RowTemplate.Height = 50;
            this.gridSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSchedule.Size = new System.Drawing.Size(1830, 655);
            this.gridSchedule.TabIndex = 25;
            this.gridSchedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSchedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridSchedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridSchedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridSchedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridSchedule.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridSchedule.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSchedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridSchedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSchedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridSchedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridSchedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSchedule.ThemeStyle.HeaderStyle.Height = 55;
            this.gridSchedule.ThemeStyle.ReadOnly = true;
            this.gridSchedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSchedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSchedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridSchedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridSchedule.ThemeStyle.RowsStyle.Height = 50;
            this.gridSchedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridSchedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridSchedule.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSchedule_CellMouseClick);
            this.gridSchedule.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridSchedule_CellMouseDoubleClick);
            // 
            // btnCancelPatient
            // 
            this.btnCancelPatient.Animated = true;
            this.btnCancelPatient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelPatient.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelPatient.BorderRadius = 5;
            this.btnCancelPatient.BorderThickness = 1;
            this.btnCancelPatient.CheckedState.Parent = this.btnCancelPatient;
            this.btnCancelPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelPatient.CustomImages.Parent = this.btnCancelPatient;
            this.btnCancelPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelPatient.DisabledState.Parent = this.btnCancelPatient;
            this.btnCancelPatient.Enabled = false;
            this.btnCancelPatient.FillColor = System.Drawing.Color.Red;
            this.btnCancelPatient.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelPatient.ForeColor = System.Drawing.Color.White;
            this.btnCancelPatient.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCancelPatient.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancelPatient.HoverState.Parent = this.btnCancelPatient;
            this.btnCancelPatient.Image = global::PatientInformationSystemNew.Properties.Resources.cancel_icon;
            this.btnCancelPatient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelPatient.Location = new System.Drawing.Point(169, 219);
            this.btnCancelPatient.Name = "btnCancelPatient";
            this.btnCancelPatient.ShadowDecoration.Parent = this.btnCancelPatient;
            this.btnCancelPatient.Size = new System.Drawing.Size(196, 54);
            this.btnCancelPatient.TabIndex = 27;
            this.btnCancelPatient.Text = "Cancel Patient";
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
            this.btnSelect.Location = new System.Drawing.Point(26, 219);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShadowDecoration.Parent = this.btnSelect;
            this.btnSelect.Size = new System.Drawing.Size(128, 54);
            this.btnSelect.TabIndex = 26;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1830, 958);
            this.Controls.Add(this.btnCancelPatient);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.gridSchedule);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtPatientID;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView gridSchedule;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private Guna.UI2.WinForms.Guna2Button btnCancelPatient;
    }
}