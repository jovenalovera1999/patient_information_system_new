
namespace PatientInformationSystemNew.forms
{
    partial class frmDoctorProfileNew
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
            this.tabControlDoctor = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.txtAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGender = new Guna.UI2.WinForms.Guna2TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dateBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSpecialization = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelephoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCellphoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAge = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picProfilePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtDoctorID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.gridPatients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.txtPatientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlDoctor.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).BeginInit();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDoctor
            // 
            this.tabControlDoctor.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlDoctor.Controls.Add(this.tabPersonalInfo);
            this.tabControlDoctor.Controls.Add(this.tabPatients);
            this.tabControlDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDoctor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDoctor.ItemSize = new System.Drawing.Size(140, 50);
            this.tabControlDoctor.Location = new System.Drawing.Point(0, 0);
            this.tabControlDoctor.Name = "tabControlDoctor";
            this.tabControlDoctor.SelectedIndex = 0;
            this.tabControlDoctor.Size = new System.Drawing.Size(1830, 958);
            this.tabControlDoctor.TabButtonHoverState.BorderColor = System.Drawing.Color.White;
            this.tabControlDoctor.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlDoctor.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlDoctor.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControlDoctor.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlDoctor.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlDoctor.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlDoctor.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlDoctor.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControlDoctor.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlDoctor.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlDoctor.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControlDoctor.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlDoctor.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControlDoctor.TabButtonSelectedState.InnerColor = System.Drawing.Color.Blue;
            this.tabControlDoctor.TabButtonSize = new System.Drawing.Size(140, 50);
            this.tabControlDoctor.TabIndex = 2;
            this.tabControlDoctor.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlDoctor.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPersonalInfo.Controls.Add(this.txtAge);
            this.tabPersonalInfo.Controls.Add(this.txtGender);
            this.tabPersonalInfo.Controls.Add(this.label21);
            this.tabPersonalInfo.Controls.Add(this.dateBirthday);
            this.tabPersonalInfo.Controls.Add(this.txtSpecialization);
            this.tabPersonalInfo.Controls.Add(this.label19);
            this.tabPersonalInfo.Controls.Add(this.label20);
            this.tabPersonalInfo.Controls.Add(this.txtLastName);
            this.tabPersonalInfo.Controls.Add(this.label18);
            this.tabPersonalInfo.Controls.Add(this.txtEmail);
            this.tabPersonalInfo.Controls.Add(this.label15);
            this.tabPersonalInfo.Controls.Add(this.txtTelephoneNumber);
            this.tabPersonalInfo.Controls.Add(this.label12);
            this.tabPersonalInfo.Controls.Add(this.txtCellphoneNumber);
            this.tabPersonalInfo.Controls.Add(this.label13);
            this.tabPersonalInfo.Controls.Add(this.label14);
            this.tabPersonalInfo.Controls.Add(this.txtAddress);
            this.tabPersonalInfo.Controls.Add(this.label11);
            this.tabPersonalInfo.Controls.Add(this.cmbAge);
            this.tabPersonalInfo.Controls.Add(this.cmbGender);
            this.tabPersonalInfo.Controls.Add(this.label9);
            this.tabPersonalInfo.Controls.Add(this.label10);
            this.tabPersonalInfo.Controls.Add(this.txtMiddleName);
            this.tabPersonalInfo.Controls.Add(this.label7);
            this.tabPersonalInfo.Controls.Add(this.txtFirstName);
            this.tabPersonalInfo.Controls.Add(this.label8);
            this.tabPersonalInfo.Controls.Add(this.label6);
            this.tabPersonalInfo.Controls.Add(this.label4);
            this.tabPersonalInfo.Controls.Add(this.picProfilePicture);
            this.tabPersonalInfo.Controls.Add(this.txtDoctorID);
            this.tabPersonalInfo.Controls.Add(this.label3);
            this.tabPersonalInfo.Controls.Add(this.btnBack);
            this.tabPersonalInfo.Controls.Add(this.btnSave);
            this.tabPersonalInfo.Controls.Add(this.btnEdit);
            this.tabPersonalInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 4);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(1682, 950);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Personal Info";
            // 
            // txtAge
            // 
            this.txtAge.Animated = true;
            this.txtAge.BorderRadius = 5;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.DefaultText = "";
            this.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtAge.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtAge.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtAge.DisabledState.Parent = this.txtAge;
            this.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAge.Enabled = false;
            this.txtAge.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtAge.FocusedState.Parent = this.txtAge;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtAge.HoverState.Parent = this.txtAge;
            this.txtAge.Location = new System.Drawing.Point(480, 510);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.PlaceholderText = "";
            this.txtAge.SelectedText = "";
            this.txtAge.ShadowDecoration.Parent = this.txtAge;
            this.txtAge.Size = new System.Drawing.Size(130, 45);
            this.txtAge.TabIndex = 271;
            // 
            // txtGender
            // 
            this.txtGender.Animated = true;
            this.txtGender.BorderRadius = 5;
            this.txtGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGender.DefaultText = "";
            this.txtGender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtGender.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtGender.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtGender.DisabledState.Parent = this.txtGender;
            this.txtGender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGender.Enabled = false;
            this.txtGender.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtGender.FocusedState.Parent = this.txtGender;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtGender.HoverState.Parent = this.txtGender;
            this.txtGender.Location = new System.Drawing.Point(480, 410);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.PasswordChar = '\0';
            this.txtGender.PlaceholderText = "";
            this.txtGender.SelectedText = "";
            this.txtGender.ShadowDecoration.Parent = this.txtGender;
            this.txtGender.Size = new System.Drawing.Size(130, 45);
            this.txtGender.TabIndex = 270;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(475, 668);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 28);
            this.label21.TabIndex = 269;
            this.label21.Text = "Birthday:";
            // 
            // dateBirthday
            // 
            this.dateBirthday.Animated = true;
            this.dateBirthday.BorderColor = System.Drawing.Color.Transparent;
            this.dateBirthday.BorderRadius = 5;
            this.dateBirthday.BorderThickness = 1;
            this.dateBirthday.CheckedState.Parent = this.dateBirthday;
            this.dateBirthday.Enabled = false;
            this.dateBirthday.FillColor = System.Drawing.Color.Blue;
            this.dateBirthday.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateBirthday.ForeColor = System.Drawing.Color.White;
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateBirthday.HoverState.BorderColor = System.Drawing.Color.White;
            this.dateBirthday.HoverState.FillColor = System.Drawing.Color.Blue;
            this.dateBirthday.HoverState.Parent = this.dateBirthday;
            this.dateBirthday.Location = new System.Drawing.Point(480, 708);
            this.dateBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.ShadowDecoration.Parent = this.dateBirthday;
            this.dateBirthday.Size = new System.Drawing.Size(446, 45);
            this.dateBirthday.TabIndex = 7;
            this.dateBirthday.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Animated = true;
            this.txtSpecialization.BorderRadius = 5;
            this.txtSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpecialization.DefaultText = "";
            this.txtSpecialization.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSpecialization.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSpecialization.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSpecialization.DisabledState.Parent = this.txtSpecialization;
            this.txtSpecialization.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSpecialization.Enabled = false;
            this.txtSpecialization.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSpecialization.FocusedState.Parent = this.txtSpecialization;
            this.txtSpecialization.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSpecialization.ForeColor = System.Drawing.Color.Black;
            this.txtSpecialization.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSpecialization.HoverState.Parent = this.txtSpecialization;
            this.txtSpecialization.Location = new System.Drawing.Point(943, 510);
            this.txtSpecialization.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.PasswordChar = '\0';
            this.txtSpecialization.PlaceholderText = "";
            this.txtSpecialization.SelectedText = "";
            this.txtSpecialization.ShadowDecoration.Parent = this.txtSpecialization;
            this.txtSpecialization.Size = new System.Drawing.Size(446, 45);
            this.txtSpecialization.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(938, 469);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 28);
            this.label19.TabIndex = 268;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(935, 453);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(224, 46);
            this.label20.TabIndex = 267;
            this.label20.Text = "Specialization";
            // 
            // txtLastName
            // 
            this.txtLastName.Animated = true;
            this.txtLastName.BorderRadius = 5;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.DisabledState.Parent = this.txtLastName;
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.Enabled = false;
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtLastName.FocusedState.Parent = this.txtLastName;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtLastName.HoverState.Parent = this.txtLastName;
            this.txtLastName.Location = new System.Drawing.Point(480, 313);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.SelectedText = "";
            this.txtLastName.ShadowDecoration.Parent = this.txtLastName;
            this.txtLastName.Size = new System.Drawing.Size(446, 45);
            this.txtLastName.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(475, 272);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 28);
            this.label18.TabIndex = 266;
            this.label18.Text = "Last Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.Enabled = false;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(943, 313);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(446, 45);
            this.txtEmail.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(938, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 28);
            this.label15.TabIndex = 265;
            this.label15.Text = "Email:";
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Animated = true;
            this.txtTelephoneNumber.BorderRadius = 5;
            this.txtTelephoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephoneNumber.DefaultText = "";
            this.txtTelephoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtTelephoneNumber.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtTelephoneNumber.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtTelephoneNumber.DisabledState.Parent = this.txtTelephoneNumber;
            this.txtTelephoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephoneNumber.Enabled = false;
            this.txtTelephoneNumber.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtTelephoneNumber.FocusedState.Parent = this.txtTelephoneNumber;
            this.txtTelephoneNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTelephoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtTelephoneNumber.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtTelephoneNumber.HoverState.Parent = this.txtTelephoneNumber;
            this.txtTelephoneNumber.Location = new System.Drawing.Point(943, 215);
            this.txtTelephoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.PasswordChar = '\0';
            this.txtTelephoneNumber.PlaceholderText = "";
            this.txtTelephoneNumber.SelectedText = "";
            this.txtTelephoneNumber.ShadowDecoration.Parent = this.txtTelephoneNumber;
            this.txtTelephoneNumber.Size = new System.Drawing.Size(446, 45);
            this.txtTelephoneNumber.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(938, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 28);
            this.label12.TabIndex = 264;
            this.label12.Text = "Telephone Number:";
            // 
            // txtCellphoneNumber
            // 
            this.txtCellphoneNumber.Animated = true;
            this.txtCellphoneNumber.BorderRadius = 5;
            this.txtCellphoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCellphoneNumber.DefaultText = "";
            this.txtCellphoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtCellphoneNumber.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtCellphoneNumber.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtCellphoneNumber.DisabledState.Parent = this.txtCellphoneNumber;
            this.txtCellphoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCellphoneNumber.Enabled = false;
            this.txtCellphoneNumber.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtCellphoneNumber.FocusedState.Parent = this.txtCellphoneNumber;
            this.txtCellphoneNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCellphoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtCellphoneNumber.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtCellphoneNumber.HoverState.Parent = this.txtCellphoneNumber;
            this.txtCellphoneNumber.Location = new System.Drawing.Point(943, 115);
            this.txtCellphoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCellphoneNumber.Name = "txtCellphoneNumber";
            this.txtCellphoneNumber.PasswordChar = '\0';
            this.txtCellphoneNumber.PlaceholderText = "";
            this.txtCellphoneNumber.SelectedText = "";
            this.txtCellphoneNumber.ShadowDecoration.Parent = this.txtCellphoneNumber;
            this.txtCellphoneNumber.Size = new System.Drawing.Size(446, 45);
            this.txtCellphoneNumber.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(938, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 28);
            this.label13.TabIndex = 263;
            this.label13.Text = "Cellphone Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(935, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(329, 46);
            this.label14.TabIndex = 262;
            this.label14.Text = "Contact Information:";
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.Enabled = false;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(480, 610);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(446, 45);
            this.txtAddress.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(475, 569);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 28);
            this.label11.TabIndex = 261;
            this.label11.Text = "Address:";
            // 
            // cmbAge
            // 
            this.cmbAge.BackColor = System.Drawing.Color.Transparent;
            this.cmbAge.BorderRadius = 5;
            this.cmbAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAge.FocusedColor = System.Drawing.Color.Blue;
            this.cmbAge.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.cmbAge.FocusedState.Parent = this.cmbAge;
            this.cmbAge.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbAge.ForeColor = System.Drawing.Color.Black;
            this.cmbAge.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.cmbAge.HoverState.Parent = this.cmbAge;
            this.cmbAge.ItemHeight = 30;
            this.cmbAge.ItemsAppearance.Parent = this.cmbAge;
            this.cmbAge.Location = new System.Drawing.Point(480, 510);
            this.cmbAge.Name = "cmbAge";
            this.cmbAge.ShadowDecoration.Parent = this.cmbAge;
            this.cmbAge.Size = new System.Drawing.Size(130, 36);
            this.cmbAge.TabIndex = 5;
            this.cmbAge.Visible = false;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.BorderRadius = 5;
            this.cmbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FocusedColor = System.Drawing.Color.Blue;
            this.cmbGender.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.cmbGender.FocusedState.Parent = this.cmbGender;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbGender.ForeColor = System.Drawing.Color.Black;
            this.cmbGender.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.cmbGender.HoverState.Parent = this.cmbGender;
            this.cmbGender.ItemHeight = 30;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.ItemsAppearance.Parent = this.cmbGender;
            this.cmbGender.Location = new System.Drawing.Point(480, 410);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.ShadowDecoration.Parent = this.cmbGender;
            this.cmbGender.Size = new System.Drawing.Size(130, 36);
            this.cmbGender.TabIndex = 4;
            this.cmbGender.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(475, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 28);
            this.label9.TabIndex = 260;
            this.label9.Text = "Age:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(475, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 28);
            this.label10.TabIndex = 259;
            this.label10.Text = "Gender:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Animated = true;
            this.txtMiddleName.BorderRadius = 5;
            this.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiddleName.DefaultText = "";
            this.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtMiddleName.DisabledState.Parent = this.txtMiddleName;
            this.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleName.Enabled = false;
            this.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtMiddleName.FocusedState.Parent = this.txtMiddleName;
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMiddleName.ForeColor = System.Drawing.Color.Black;
            this.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtMiddleName.HoverState.Parent = this.txtMiddleName;
            this.txtMiddleName.Location = new System.Drawing.Point(480, 215);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.PasswordChar = '\0';
            this.txtMiddleName.PlaceholderText = "";
            this.txtMiddleName.SelectedText = "";
            this.txtMiddleName.ShadowDecoration.Parent = this.txtMiddleName;
            this.txtMiddleName.Size = new System.Drawing.Size(446, 45);
            this.txtMiddleName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(475, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 28);
            this.label7.TabIndex = 258;
            this.label7.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Animated = true;
            this.txtFirstName.BorderRadius = 5;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.DisabledState.Parent = this.txtFirstName;
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.Enabled = false;
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtFirstName.FocusedState.Parent = this.txtFirstName;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtFirstName.HoverState.Parent = this.txtFirstName;
            this.txtFirstName.Location = new System.Drawing.Point(480, 115);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.ShadowDecoration.Parent = this.txtFirstName;
            this.txtFirstName.Size = new System.Drawing.Size(446, 45);
            this.txtFirstName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(475, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 28);
            this.label8.TabIndex = 257;
            this.label8.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(472, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 46);
            this.label6.TabIndex = 256;
            this.label6.Text = "Personal Information:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 46);
            this.label4.TabIndex = 255;
            this.label4.Text = "Medical Personnel ID:";
            // 
            // picProfilePicture
            // 
            this.picProfilePicture.BackgroundImage = global::PatientInformationSystemNew.Properties.Resources.no_profile_picture;
            this.picProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfilePicture.FillColor = System.Drawing.Color.Transparent;
            this.picProfilePicture.ImageRotate = 0F;
            this.picProfilePicture.Location = new System.Drawing.Point(114, 174);
            this.picProfilePicture.Name = "picProfilePicture";
            this.picProfilePicture.ShadowDecoration.Parent = this.picProfilePicture;
            this.picProfilePicture.Size = new System.Drawing.Size(237, 226);
            this.picProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfilePicture.TabIndex = 254;
            this.picProfilePicture.TabStop = false;
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
            this.txtDoctorID.Enabled = false;
            this.txtDoctorID.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtDoctorID.FocusedState.Parent = this.txtDoctorID;
            this.txtDoctorID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDoctorID.ForeColor = System.Drawing.Color.Black;
            this.txtDoctorID.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtDoctorID.HoverState.Parent = this.txtDoctorID;
            this.txtDoctorID.Location = new System.Drawing.Point(17, 115);
            this.txtDoctorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.PasswordChar = '\0';
            this.txtDoctorID.PlaceholderText = "";
            this.txtDoctorID.SelectedText = "";
            this.txtDoctorID.ShadowDecoration.Parent = this.txtDoctorID;
            this.txtDoctorID.Size = new System.Drawing.Size(446, 45);
            this.txtDoctorID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 253;
            this.label3.Text = "Doctor ID:";
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
            this.btnBack.Location = new System.Drawing.Point(1491, 866);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(131, 62);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderThickness = 1;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(1491, 710);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(131, 62);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.BorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.DisabledState.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.Blue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = global::PatientInformationSystemNew.Properties.Resources.edit_icon;
            this.btnEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(1491, 789);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(131, 62);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabPatients
            // 
            this.tabPatients.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPatients.Controls.Add(this.gridPatients);
            this.tabPatients.Controls.Add(this.btnSelect);
            this.tabPatients.Controls.Add(this.txtPatientName);
            this.tabPatients.Controls.Add(this.label1);
            this.tabPatients.Controls.Add(this.txtPatientID);
            this.tabPatients.Controls.Add(this.label2);
            this.tabPatients.Location = new System.Drawing.Point(4, 4);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Size = new System.Drawing.Size(1682, 950);
            this.tabPatients.TabIndex = 1;
            this.tabPatients.Text = "Patients";
            // 
            // gridPatients
            // 
            this.gridPatients.AllowUserToAddRows = false;
            this.gridPatients.AllowUserToDeleteRows = false;
            this.gridPatients.AllowUserToResizeColumns = false;
            this.gridPatients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPatients.BackgroundColor = System.Drawing.Color.White;
            this.gridPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPatients.ColumnHeadersHeight = 65;
            this.gridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPatients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPatients.EnableHeadersVisualStyles = false;
            this.gridPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPatients.Location = new System.Drawing.Point(0, 295);
            this.gridPatients.Name = "gridPatients";
            this.gridPatients.ReadOnly = true;
            this.gridPatients.RowHeadersVisible = false;
            this.gridPatients.RowHeadersWidth = 51;
            this.gridPatients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPatients.RowTemplate.Height = 55;
            this.gridPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPatients.Size = new System.Drawing.Size(1682, 655);
            this.gridPatients.TabIndex = 55;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridPatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridPatients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gridPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridPatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPatients.ThemeStyle.HeaderStyle.Height = 65;
            this.gridPatients.ThemeStyle.ReadOnly = true;
            this.gridPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridPatients.ThemeStyle.RowsStyle.Height = 55;
            this.gridPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridPatients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPatients_CellMouseClick);
            this.gridPatients.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPatients_CellMouseDoubleClick);
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
            this.btnSelect.Location = new System.Drawing.Point(23, 215);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.ShadowDecoration.Parent = this.btnSelect;
            this.btnSelect.Size = new System.Drawing.Size(128, 54);
            this.btnSelect.TabIndex = 53;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
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
            this.txtPatientName.Location = new System.Drawing.Point(23, 154);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.PlaceholderText = "";
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.ShadowDecoration.Parent = this.txtPatientName;
            this.txtPatientName.Size = new System.Drawing.Size(446, 45);
            this.txtPatientName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 51;
            this.label1.Text = "Patient Name:";
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
            this.txtPatientID.Location = new System.Drawing.Point(23, 55);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.PasswordChar = '\0';
            this.txtPatientID.PlaceholderText = "";
            this.txtPatientID.SelectedText = "";
            this.txtPatientID.ShadowDecoration.Parent = this.txtPatientID;
            this.txtPatientID.Size = new System.Drawing.Size(446, 45);
            this.txtPatientID.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 49;
            this.label2.Text = "Patient ID:";
            // 
            // frmDoctorProfileNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1830, 958);
            this.Controls.Add(this.tabControlDoctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctorProfileNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor\'s Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoctorProfileNew_Load);
            this.tabControlDoctor.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).EndInit();
            this.tabPatients.ResumeLayout(false);
            this.tabPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControlDoctor;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.TabPage tabPatients;
        private Guna.UI2.WinForms.Guna2DataGridView gridPatients;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateBirthday;
        private Guna.UI2.WinForms.Guna2TextBox txtSpecialization;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox txtTelephoneNumber;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtCellphoneNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAge;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtMiddleName;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox picProfilePicture;
        private Guna.UI2.WinForms.Guna2TextBox txtDoctorID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtAge;
        private Guna.UI2.WinForms.Guna2TextBox txtGender;
    }
}