
namespace PatientInformationSystemNew.forms
{
    partial class frmPatient
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
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPaymentTransaction = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.Animated = true;
            this.guna2TextBox4.BorderRadius = 5;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.Enabled = false;
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2TextBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Location = new System.Drawing.Point(26, 60);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(446, 45);
            this.guna2TextBox4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "Patient ID:";
            // 
            // btnPaymentTransaction
            // 
            this.btnPaymentTransaction.Animated = true;
            this.btnPaymentTransaction.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPaymentTransaction.BorderColor = System.Drawing.Color.Transparent;
            this.btnPaymentTransaction.BorderRadius = 5;
            this.btnPaymentTransaction.BorderThickness = 1;
            this.btnPaymentTransaction.CheckedState.Parent = this.btnPaymentTransaction;
            this.btnPaymentTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentTransaction.CustomImages.Parent = this.btnPaymentTransaction;
            this.btnPaymentTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaymentTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaymentTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaymentTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaymentTransaction.DisabledState.Parent = this.btnPaymentTransaction;
            this.btnPaymentTransaction.FillColor = System.Drawing.Color.Blue;
            this.btnPaymentTransaction.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPaymentTransaction.ForeColor = System.Drawing.Color.White;
            this.btnPaymentTransaction.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnPaymentTransaction.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnPaymentTransaction.HoverState.Parent = this.btnPaymentTransaction;
            this.btnPaymentTransaction.Image = global::PatientInformationSystemNew.Properties.Resources.payment_icon;
            this.btnPaymentTransaction.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPaymentTransaction.Location = new System.Drawing.Point(169, 121);
            this.btnPaymentTransaction.Name = "btnPaymentTransaction";
            this.btnPaymentTransaction.ShadowDecoration.Parent = this.btnPaymentTransaction;
            this.btnPaymentTransaction.Size = new System.Drawing.Size(246, 54);
            this.btnPaymentTransaction.TabIndex = 30;
            this.btnPaymentTransaction.Text = "Payment Transaction";
            this.btnPaymentTransaction.Click += new System.EventHandler(this.btnPaymentTransaction_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Animated = true;
            this.btnAddPatient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPatient.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddPatient.BorderRadius = 5;
            this.btnAddPatient.BorderThickness = 1;
            this.btnAddPatient.CheckedState.Parent = this.btnAddPatient;
            this.btnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPatient.CustomImages.Parent = this.btnAddPatient;
            this.btnAddPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPatient.DisabledState.Parent = this.btnAddPatient;
            this.btnAddPatient.FillColor = System.Drawing.Color.Lime;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddPatient.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnAddPatient.HoverState.Parent = this.btnAddPatient;
            this.btnAddPatient.Image = global::PatientInformationSystemNew.Properties.Resources.patient_icon;
            this.btnAddPatient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddPatient.Location = new System.Drawing.Point(431, 121);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.ShadowDecoration.Parent = this.btnAddPatient;
            this.btnAddPatient.Size = new System.Drawing.Size(182, 54);
            this.btnAddPatient.TabIndex = 29;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
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
            this.btnSelect.FillColor = System.Drawing.Color.Lime;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSelect.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSelect.HoverState.Parent = this.btnSelect;
            this.btnSelect.Image = global::PatientInformationSystemNew.Properties.Resources.select_icon;
            this.btnSelect.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSelect.Location = new System.Drawing.Point(26, 121);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShadowDecoration.Parent = this.btnSelect;
            this.btnSelect.Size = new System.Drawing.Size(128, 54);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 65;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 207);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.guna2DataGridView1.RowTemplate.Height = 55;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1830, 751);
            this.guna2DataGridView1.TabIndex = 31;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 65;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 55;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1830, 958);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnPaymentTransaction);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private Guna.UI2.WinForms.Guna2Button btnPaymentTransaction;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}