
namespace PatientInformationSystemNew.forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlDashboardHeader = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlDashboardLeftSide = new System.Windows.Forms.Panel();
            this.btnUpdateHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatient = new Guna.UI2.WinForms.Guna2Button();
            this.btnSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDashboardBody = new System.Windows.Forms.Panel();
            this.pnlDashboardHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnlDashboardLeftSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashboardHeader
            // 
            this.pnlDashboardHeader.Controls.Add(this.lblTime);
            this.pnlDashboardHeader.Controls.Add(this.lblDate);
            this.pnlDashboardHeader.Controls.Add(this.label3);
            this.pnlDashboardHeader.Controls.Add(this.label2);
            this.pnlDashboardHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlDashboardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboardHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboardHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDashboardHeader.Name = "pnlDashboardHeader";
            this.pnlDashboardHeader.Size = new System.Drawing.Size(1920, 99);
            this.pnlDashboardHeader.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1719, 9);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(174, 37);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "12:00:00 am";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(1722, 46);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(187, 19);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Monday, 11 November 2021";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "St. Louise de Marillac";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(98, 99);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pnlDashboardLeftSide
            // 
            this.pnlDashboardLeftSide.Controls.Add(this.btnUpdateHistory);
            this.pnlDashboardLeftSide.Controls.Add(this.btnReport);
            this.pnlDashboardLeftSide.Controls.Add(this.btnProfile);
            this.pnlDashboardLeftSide.Controls.Add(this.btnLogout);
            this.pnlDashboardLeftSide.Controls.Add(this.btnSignUp);
            this.pnlDashboardLeftSide.Controls.Add(this.btnInventory);
            this.pnlDashboardLeftSide.Controls.Add(this.btnDoctors);
            this.pnlDashboardLeftSide.Controls.Add(this.btnPatient);
            this.pnlDashboardLeftSide.Controls.Add(this.btnSchedule);
            this.pnlDashboardLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashboardLeftSide.Location = new System.Drawing.Point(0, 99);
            this.pnlDashboardLeftSide.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDashboardLeftSide.Name = "pnlDashboardLeftSide";
            this.pnlDashboardLeftSide.Size = new System.Drawing.Size(166, 981);
            this.pnlDashboardLeftSide.TabIndex = 1;
            // 
            // btnUpdateHistory
            // 
            this.btnUpdateHistory.Animated = true;
            this.btnUpdateHistory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateHistory.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateHistory.BorderThickness = 1;
            this.btnUpdateHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateHistory.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateHistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateHistory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateHistory.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUpdateHistory.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateHistory.Image = global::PatientInformationSystemNew.Properties.Resources.update_history_icon;
            this.btnUpdateHistory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateHistory.Location = new System.Drawing.Point(0, 264);
            this.btnUpdateHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateHistory.Name = "btnUpdateHistory";
            this.btnUpdateHistory.Size = new System.Drawing.Size(166, 44);
            this.btnUpdateHistory.TabIndex = 18;
            this.btnUpdateHistory.Text = "Update History";
            this.btnUpdateHistory.Click += new System.EventHandler(this.btnUpdateHistory_Click);
            // 
            // btnReport
            // 
            this.btnReport.Animated = true;
            this.btnReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.BorderColor = System.Drawing.Color.Transparent;
            this.btnReport.BorderThickness = 1;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnReport.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.Image = global::PatientInformationSystemNew.Properties.Resources.report_icon;
            this.btnReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReport.Location = new System.Drawing.Point(0, 220);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(166, 44);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Animated = true;
            this.btnProfile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProfile.BorderColor = System.Drawing.Color.Transparent;
            this.btnProfile.BorderThickness = 1;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProfile.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnProfile.Image = global::PatientInformationSystemNew.Properties.Resources.profile_icon;
            this.btnProfile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProfile.Location = new System.Drawing.Point(0, 893);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(166, 44);
            this.btnProfile.TabIndex = 16;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.Image = global::PatientInformationSystemNew.Properties.Resources.logout_icon;
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(0, 937);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 44);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Animated = true;
            this.btnSignUp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignUp.BorderColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderThickness = 1;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignUp.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSignUp.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSignUp.Image = global::PatientInformationSystemNew.Properties.Resources.sign_up_icon;
            this.btnSignUp.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSignUp.Location = new System.Drawing.Point(0, 176);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(166, 44);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Animated = true;
            this.btnInventory.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInventory.BorderColor = System.Drawing.Color.Transparent;
            this.btnInventory.BorderThickness = 1;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnInventory.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnInventory.Image = global::PatientInformationSystemNew.Properties.Resources.inventory_icon;
            this.btnInventory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInventory.Location = new System.Drawing.Point(0, 132);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(166, 44);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.Animated = true;
            this.btnDoctors.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDoctors.BorderColor = System.Drawing.Color.Transparent;
            this.btnDoctors.BorderThickness = 1;
            this.btnDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoctors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctors.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDoctors.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDoctors.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnDoctors.Image = global::PatientInformationSystemNew.Properties.Resources.doctor_icon;
            this.btnDoctors.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDoctors.Location = new System.Drawing.Point(0, 88);
            this.btnDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(166, 44);
            this.btnDoctors.TabIndex = 12;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Animated = true;
            this.btnPatient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPatient.BorderColor = System.Drawing.Color.Transparent;
            this.btnPatient.BorderThickness = 1;
            this.btnPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatient.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnPatient.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPatient.Image = global::PatientInformationSystemNew.Properties.Resources.patient_icon;
            this.btnPatient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPatient.Location = new System.Drawing.Point(0, 44);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(166, 44);
            this.btnPatient.TabIndex = 11;
            this.btnPatient.Text = "Patient";
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Animated = true;
            this.btnSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSchedule.BorderColor = System.Drawing.Color.Transparent;
            this.btnSchedule.BorderThickness = 1;
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSchedule.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSchedule.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnSchedule.Image = global::PatientInformationSystemNew.Properties.Resources.schedule_icon;
            this.btnSchedule.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSchedule.Location = new System.Drawing.Point(0, 0);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(166, 44);
            this.btnSchedule.TabIndex = 10;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // pnlDashboardBody
            // 
            this.pnlDashboardBody.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlDashboardBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardBody.Location = new System.Drawing.Point(166, 99);
            this.pnlDashboardBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDashboardBody.Name = "pnlDashboardBody";
            this.pnlDashboardBody.Size = new System.Drawing.Size(1754, 981);
            this.pnlDashboardBody.TabIndex = 2;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlDashboardBody);
            this.Controls.Add(this.pnlDashboardLeftSide);
            this.Controls.Add(this.pnlDashboardHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlDashboardHeader.ResumeLayout(false);
            this.pnlDashboardHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnlDashboardLeftSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboardHeader;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDashboardLeftSide;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Button btnDoctors;
        private Guna.UI2.WinForms.Guna2Button btnPatient;
        private Guna.UI2.WinForms.Guna2Button btnSchedule;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Panel pnlDashboardBody;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private Guna.UI2.WinForms.Guna2Button btnUpdateHistory;
    }
}