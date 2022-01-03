
namespace PatientInformationSystemNew.forms
{
    partial class frmInventory
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
            this.tabControlInventory = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabSupplies = new System.Windows.Forms.TabPage();
            this.gridSupplies = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabIncomingSupplies = new System.Windows.Forms.TabPage();
            this.btnSupplyArrived = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateArrive = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAddIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.switchExpirationDate = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label21 = new System.Windows.Forms.Label();
            this.dateExpiration = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSupplyQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridIncomingSupplies = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSupplyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabManageSupplies = new System.Windows.Forms.TabPage();
            this.txtItemUsed = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeductItem = new Guna.UI2.WinForms.Guna2Button();
            this.switchExpirationDateManageSupplies = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnAddManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateExpirationManageSupplies = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSupplyQuantityManageSupplies = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplyNameManageSupplies = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplyIDManageSupplies = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridManageSupplies = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabControlInventory.SuspendLayout();
            this.tabSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplies)).BeginInit();
            this.tabIncomingSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIncomingSupplies)).BeginInit();
            this.tabManageSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridManageSupplies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlInventory
            // 
            this.tabControlInventory.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlInventory.Controls.Add(this.tabSupplies);
            this.tabControlInventory.Controls.Add(this.tabIncomingSupplies);
            this.tabControlInventory.Controls.Add(this.tabManageSupplies);
            this.tabControlInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlInventory.ItemSize = new System.Drawing.Size(140, 50);
            this.tabControlInventory.Location = new System.Drawing.Point(0, 0);
            this.tabControlInventory.Name = "tabControlInventory";
            this.tabControlInventory.SelectedIndex = 0;
            this.tabControlInventory.Size = new System.Drawing.Size(1830, 958);
            this.tabControlInventory.TabButtonHoverState.BorderColor = System.Drawing.Color.White;
            this.tabControlInventory.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlInventory.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlInventory.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControlInventory.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlInventory.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlInventory.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlInventory.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlInventory.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControlInventory.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlInventory.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlInventory.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControlInventory.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlInventory.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControlInventory.TabButtonSelectedState.InnerColor = System.Drawing.Color.Blue;
            this.tabControlInventory.TabButtonSize = new System.Drawing.Size(140, 50);
            this.tabControlInventory.TabIndex = 3;
            this.tabControlInventory.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlInventory.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            this.tabControlInventory.SelectedIndexChanged += new System.EventHandler(this.tabControlInventory_SelectedIndexChanged);
            // 
            // tabSupplies
            // 
            this.tabSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabSupplies.Controls.Add(this.gridSupplies);
            this.tabSupplies.Location = new System.Drawing.Point(4, 4);
            this.tabSupplies.Name = "tabSupplies";
            this.tabSupplies.Size = new System.Drawing.Size(1682, 950);
            this.tabSupplies.TabIndex = 1;
            this.tabSupplies.Text = "Supplies";
            // 
            // gridSupplies
            // 
            this.gridSupplies.AllowUserToAddRows = false;
            this.gridSupplies.AllowUserToDeleteRows = false;
            this.gridSupplies.AllowUserToResizeColumns = false;
            this.gridSupplies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridSupplies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSupplies.BackgroundColor = System.Drawing.Color.White;
            this.gridSupplies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSupplies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSupplies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSupplies.ColumnHeadersHeight = 40;
            this.gridSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupplies.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridSupplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSupplies.EnableHeadersVisualStyles = false;
            this.gridSupplies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSupplies.Location = new System.Drawing.Point(0, 0);
            this.gridSupplies.Name = "gridSupplies";
            this.gridSupplies.ReadOnly = true;
            this.gridSupplies.RowHeadersVisible = false;
            this.gridSupplies.RowHeadersWidth = 51;
            this.gridSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSupplies.RowTemplate.Height = 35;
            this.gridSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSupplies.Size = new System.Drawing.Size(1682, 950);
            this.gridSupplies.TabIndex = 32;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridSupplies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridSupplies.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridSupplies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridSupplies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSupplies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridSupplies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSupplies.ThemeStyle.HeaderStyle.Height = 40;
            this.gridSupplies.ThemeStyle.ReadOnly = true;
            this.gridSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridSupplies.ThemeStyle.RowsStyle.Height = 35;
            this.gridSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // tabIncomingSupplies
            // 
            this.tabIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabIncomingSupplies.Controls.Add(this.btnSupplyArrived);
            this.tabIncomingSupplies.Controls.Add(this.btnDeleteIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.label7);
            this.tabIncomingSupplies.Controls.Add(this.dateArrive);
            this.tabIncomingSupplies.Controls.Add(this.btnAddIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.btnSaveIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.btnEditIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.switchExpirationDate);
            this.tabIncomingSupplies.Controls.Add(this.label21);
            this.tabIncomingSupplies.Controls.Add(this.dateExpiration);
            this.tabIncomingSupplies.Controls.Add(this.txtSupplyQuantity);
            this.tabIncomingSupplies.Controls.Add(this.label2);
            this.tabIncomingSupplies.Controls.Add(this.txtSupplyName);
            this.tabIncomingSupplies.Controls.Add(this.label1);
            this.tabIncomingSupplies.Controls.Add(this.gridIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.txtSupplyID);
            this.tabIncomingSupplies.Controls.Add(this.label8);
            this.tabIncomingSupplies.Location = new System.Drawing.Point(4, 4);
            this.tabIncomingSupplies.Name = "tabIncomingSupplies";
            this.tabIncomingSupplies.Size = new System.Drawing.Size(1682, 950);
            this.tabIncomingSupplies.TabIndex = 2;
            this.tabIncomingSupplies.Text = "Incoming Supplies";
            // 
            // btnSupplyArrived
            // 
            this.btnSupplyArrived.Animated = true;
            this.btnSupplyArrived.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSupplyArrived.BorderColor = System.Drawing.Color.Transparent;
            this.btnSupplyArrived.BorderRadius = 5;
            this.btnSupplyArrived.BorderThickness = 1;
            this.btnSupplyArrived.CheckedState.Parent = this.btnSupplyArrived;
            this.btnSupplyArrived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplyArrived.CustomImages.Parent = this.btnSupplyArrived;
            this.btnSupplyArrived.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplyArrived.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplyArrived.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplyArrived.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupplyArrived.DisabledState.Parent = this.btnSupplyArrived;
            this.btnSupplyArrived.Enabled = false;
            this.btnSupplyArrived.FillColor = System.Drawing.Color.Lime;
            this.btnSupplyArrived.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSupplyArrived.ForeColor = System.Drawing.Color.White;
            this.btnSupplyArrived.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSupplyArrived.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSupplyArrived.HoverState.Parent = this.btnSupplyArrived;
            this.btnSupplyArrived.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnSupplyArrived.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSupplyArrived.Location = new System.Drawing.Point(1417, 241);
            this.btnSupplyArrived.Name = "btnSupplyArrived";
            this.btnSupplyArrived.ShadowDecoration.Parent = this.btnSupplyArrived;
            this.btnSupplyArrived.Size = new System.Drawing.Size(192, 58);
            this.btnSupplyArrived.TabIndex = 166;
            this.btnSupplyArrived.Text = "Supply Arrived";
            this.btnSupplyArrived.Click += new System.EventHandler(this.btnSupplyArrived_Click);
            // 
            // btnDeleteIncomingSupplies
            // 
            this.btnDeleteIncomingSupplies.Animated = true;
            this.btnDeleteIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteIncomingSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteIncomingSupplies.BorderRadius = 5;
            this.btnDeleteIncomingSupplies.BorderThickness = 1;
            this.btnDeleteIncomingSupplies.CheckedState.Parent = this.btnDeleteIncomingSupplies;
            this.btnDeleteIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteIncomingSupplies.CustomImages.Parent = this.btnDeleteIncomingSupplies;
            this.btnDeleteIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteIncomingSupplies.DisabledState.Parent = this.btnDeleteIncomingSupplies;
            this.btnDeleteIncomingSupplies.Enabled = false;
            this.btnDeleteIncomingSupplies.FillColor = System.Drawing.Color.Red;
            this.btnDeleteIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDeleteIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnDeleteIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDeleteIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnDeleteIncomingSupplies.HoverState.Parent = this.btnDeleteIncomingSupplies;
            this.btnDeleteIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.delete_icon;
            this.btnDeleteIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteIncomingSupplies.Location = new System.Drawing.Point(780, 213);
            this.btnDeleteIncomingSupplies.Name = "btnDeleteIncomingSupplies";
            this.btnDeleteIncomingSupplies.ShadowDecoration.Parent = this.btnDeleteIncomingSupplies;
            this.btnDeleteIncomingSupplies.Size = new System.Drawing.Size(130, 58);
            this.btnDeleteIncomingSupplies.TabIndex = 165;
            this.btnDeleteIncomingSupplies.Text = "Delete";
            this.btnDeleteIncomingSupplies.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(484, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 164;
            this.label7.Text = "Arrive Date:";
            // 
            // dateArrive
            // 
            this.dateArrive.Animated = true;
            this.dateArrive.BorderColor = System.Drawing.Color.Transparent;
            this.dateArrive.BorderRadius = 5;
            this.dateArrive.BorderThickness = 1;
            this.dateArrive.CheckedState.Parent = this.dateArrive;
            this.dateArrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateArrive.FillColor = System.Drawing.Color.Blue;
            this.dateArrive.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateArrive.ForeColor = System.Drawing.Color.White;
            this.dateArrive.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateArrive.HoverState.BorderColor = System.Drawing.Color.White;
            this.dateArrive.HoverState.FillColor = System.Drawing.Color.Blue;
            this.dateArrive.HoverState.Parent = this.dateArrive;
            this.dateArrive.Location = new System.Drawing.Point(489, 155);
            this.dateArrive.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateArrive.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateArrive.Name = "dateArrive";
            this.dateArrive.ShadowDecoration.Parent = this.dateArrive;
            this.dateArrive.Size = new System.Drawing.Size(446, 45);
            this.dateArrive.TabIndex = 163;
            this.dateArrive.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            // 
            // btnAddIncomingSupplies
            // 
            this.btnAddIncomingSupplies.Animated = true;
            this.btnAddIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddIncomingSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddIncomingSupplies.BorderRadius = 5;
            this.btnAddIncomingSupplies.BorderThickness = 1;
            this.btnAddIncomingSupplies.CheckedState.Parent = this.btnAddIncomingSupplies;
            this.btnAddIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIncomingSupplies.CustomImages.Parent = this.btnAddIncomingSupplies;
            this.btnAddIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddIncomingSupplies.DisabledState.Parent = this.btnAddIncomingSupplies;
            this.btnAddIncomingSupplies.FillColor = System.Drawing.Color.Lime;
            this.btnAddIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnAddIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnAddIncomingSupplies.HoverState.Parent = this.btnAddIncomingSupplies;
            this.btnAddIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnAddIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddIncomingSupplies.Location = new System.Drawing.Point(489, 213);
            this.btnAddIncomingSupplies.Name = "btnAddIncomingSupplies";
            this.btnAddIncomingSupplies.ShadowDecoration.Parent = this.btnAddIncomingSupplies;
            this.btnAddIncomingSupplies.Size = new System.Drawing.Size(130, 58);
            this.btnAddIncomingSupplies.TabIndex = 162;
            this.btnAddIncomingSupplies.Text = "Add";
            this.btnAddIncomingSupplies.Click += new System.EventHandler(this.btnAddIncomingSupplies_Click);
            // 
            // btnSaveIncomingSupplies
            // 
            this.btnSaveIncomingSupplies.Animated = true;
            this.btnSaveIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveIncomingSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveIncomingSupplies.BorderRadius = 5;
            this.btnSaveIncomingSupplies.BorderThickness = 1;
            this.btnSaveIncomingSupplies.CheckedState.Parent = this.btnSaveIncomingSupplies;
            this.btnSaveIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveIncomingSupplies.CustomImages.Parent = this.btnSaveIncomingSupplies;
            this.btnSaveIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveIncomingSupplies.DisabledState.Parent = this.btnSaveIncomingSupplies;
            this.btnSaveIncomingSupplies.Enabled = false;
            this.btnSaveIncomingSupplies.FillColor = System.Drawing.Color.Lime;
            this.btnSaveIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSaveIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnSaveIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSaveIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSaveIncomingSupplies.HoverState.Parent = this.btnSaveIncomingSupplies;
            this.btnSaveIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnSaveIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveIncomingSupplies.Location = new System.Drawing.Point(489, 213);
            this.btnSaveIncomingSupplies.Name = "btnSaveIncomingSupplies";
            this.btnSaveIncomingSupplies.ShadowDecoration.Parent = this.btnSaveIncomingSupplies;
            this.btnSaveIncomingSupplies.Size = new System.Drawing.Size(130, 58);
            this.btnSaveIncomingSupplies.TabIndex = 160;
            this.btnSaveIncomingSupplies.Text = "Save";
            this.btnSaveIncomingSupplies.Visible = false;
            this.btnSaveIncomingSupplies.Click += new System.EventHandler(this.btnSaveIncomingSupplies_Click);
            // 
            // btnEditIncomingSupplies
            // 
            this.btnEditIncomingSupplies.Animated = true;
            this.btnEditIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditIncomingSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditIncomingSupplies.BorderRadius = 5;
            this.btnEditIncomingSupplies.BorderThickness = 1;
            this.btnEditIncomingSupplies.CheckedState.Parent = this.btnEditIncomingSupplies;
            this.btnEditIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditIncomingSupplies.CustomImages.Parent = this.btnEditIncomingSupplies;
            this.btnEditIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditIncomingSupplies.DisabledState.Parent = this.btnEditIncomingSupplies;
            this.btnEditIncomingSupplies.Enabled = false;
            this.btnEditIncomingSupplies.FillColor = System.Drawing.Color.Blue;
            this.btnEditIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEditIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnEditIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnEditIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnEditIncomingSupplies.HoverState.Parent = this.btnEditIncomingSupplies;
            this.btnEditIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.edit_icon;
            this.btnEditIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditIncomingSupplies.Location = new System.Drawing.Point(634, 213);
            this.btnEditIncomingSupplies.Name = "btnEditIncomingSupplies";
            this.btnEditIncomingSupplies.ShadowDecoration.Parent = this.btnEditIncomingSupplies;
            this.btnEditIncomingSupplies.Size = new System.Drawing.Size(130, 58);
            this.btnEditIncomingSupplies.TabIndex = 159;
            this.btnEditIncomingSupplies.Text = "Edit";
            this.btnEditIncomingSupplies.Click += new System.EventHandler(this.btnEditIncomingSupplies_Click);
            // 
            // switchExpirationDate
            // 
            this.switchExpirationDate.Animated = true;
            this.switchExpirationDate.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchExpirationDate.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.switchExpirationDate.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchExpirationDate.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchExpirationDate.CheckedState.Parent = this.switchExpirationDate;
            this.switchExpirationDate.Location = new System.Drawing.Point(649, 15);
            this.switchExpirationDate.Name = "switchExpirationDate";
            this.switchExpirationDate.ShadowDecoration.Parent = this.switchExpirationDate;
            this.switchExpirationDate.Size = new System.Drawing.Size(51, 28);
            this.switchExpirationDate.TabIndex = 117;
            this.switchExpirationDate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchExpirationDate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchExpirationDate.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchExpirationDate.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchExpirationDate.UncheckedState.Parent = this.switchExpirationDate;
            this.switchExpirationDate.CheckedChanged += new System.EventHandler(this.switchExpirationDate_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(484, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(150, 28);
            this.label21.TabIndex = 116;
            this.label21.Text = "Expiration Date:";
            // 
            // dateExpiration
            // 
            this.dateExpiration.Animated = true;
            this.dateExpiration.BorderColor = System.Drawing.Color.Transparent;
            this.dateExpiration.BorderRadius = 5;
            this.dateExpiration.BorderThickness = 1;
            this.dateExpiration.CheckedState.Parent = this.dateExpiration;
            this.dateExpiration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateExpiration.Enabled = false;
            this.dateExpiration.FillColor = System.Drawing.Color.Blue;
            this.dateExpiration.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateExpiration.ForeColor = System.Drawing.Color.White;
            this.dateExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateExpiration.HoverState.BorderColor = System.Drawing.Color.White;
            this.dateExpiration.HoverState.FillColor = System.Drawing.Color.Blue;
            this.dateExpiration.HoverState.Parent = this.dateExpiration;
            this.dateExpiration.Location = new System.Drawing.Point(489, 56);
            this.dateExpiration.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateExpiration.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.ShadowDecoration.Parent = this.dateExpiration;
            this.dateExpiration.Size = new System.Drawing.Size(446, 45);
            this.dateExpiration.TabIndex = 115;
            this.dateExpiration.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            // 
            // txtSupplyQuantity
            // 
            this.txtSupplyQuantity.Animated = true;
            this.txtSupplyQuantity.BorderRadius = 5;
            this.txtSupplyQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyQuantity.DefaultText = "";
            this.txtSupplyQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyQuantity.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyQuantity.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyQuantity.DisabledState.Parent = this.txtSupplyQuantity;
            this.txtSupplyQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyQuantity.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyQuantity.FocusedState.Parent = this.txtSupplyQuantity;
            this.txtSupplyQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSupplyQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyQuantity.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyQuantity.HoverState.Parent = this.txtSupplyQuantity;
            this.txtSupplyQuantity.Location = new System.Drawing.Point(25, 254);
            this.txtSupplyQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplyQuantity.Name = "txtSupplyQuantity";
            this.txtSupplyQuantity.PasswordChar = '\0';
            this.txtSupplyQuantity.PlaceholderText = "";
            this.txtSupplyQuantity.SelectedText = "";
            this.txtSupplyQuantity.ShadowDecoration.Parent = this.txtSupplyQuantity;
            this.txtSupplyQuantity.Size = new System.Drawing.Size(446, 45);
            this.txtSupplyQuantity.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "Supply Quantity:";
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.Animated = true;
            this.txtSupplyName.BorderRadius = 5;
            this.txtSupplyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyName.DefaultText = "";
            this.txtSupplyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyName.DisabledState.Parent = this.txtSupplyName;
            this.txtSupplyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyName.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyName.FocusedState.Parent = this.txtSupplyName;
            this.txtSupplyName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSupplyName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyName.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyName.HoverState.Parent = this.txtSupplyName;
            this.txtSupplyName.Location = new System.Drawing.Point(25, 155);
            this.txtSupplyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.PasswordChar = '\0';
            this.txtSupplyName.PlaceholderText = "";
            this.txtSupplyName.SelectedText = "";
            this.txtSupplyName.ShadowDecoration.Parent = this.txtSupplyName;
            this.txtSupplyName.Size = new System.Drawing.Size(446, 45);
            this.txtSupplyName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "Supply Name:";
            // 
            // gridIncomingSupplies
            // 
            this.gridIncomingSupplies.AllowUserToAddRows = false;
            this.gridIncomingSupplies.AllowUserToDeleteRows = false;
            this.gridIncomingSupplies.AllowUserToResizeColumns = false;
            this.gridIncomingSupplies.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridIncomingSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIncomingSupplies.BackgroundColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridIncomingSupplies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridIncomingSupplies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIncomingSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridIncomingSupplies.ColumnHeadersHeight = 40;
            this.gridIncomingSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridIncomingSupplies.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridIncomingSupplies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridIncomingSupplies.EnableHeadersVisualStyles = false;
            this.gridIncomingSupplies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridIncomingSupplies.Location = new System.Drawing.Point(0, 340);
            this.gridIncomingSupplies.Name = "gridIncomingSupplies";
            this.gridIncomingSupplies.ReadOnly = true;
            this.gridIncomingSupplies.RowHeadersVisible = false;
            this.gridIncomingSupplies.RowHeadersWidth = 51;
            this.gridIncomingSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridIncomingSupplies.RowTemplate.Height = 35;
            this.gridIncomingSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIncomingSupplies.Size = new System.Drawing.Size(1682, 610);
            this.gridIncomingSupplies.TabIndex = 32;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridIncomingSupplies.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.Height = 40;
            this.gridIncomingSupplies.ThemeStyle.ReadOnly = true;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.Height = 35;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridIncomingSupplies.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridIncomingSupplies_CellMouseClick);
            // 
            // txtSupplyID
            // 
            this.txtSupplyID.Animated = true;
            this.txtSupplyID.BorderRadius = 5;
            this.txtSupplyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyID.DefaultText = "";
            this.txtSupplyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyID.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyID.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyID.DisabledState.Parent = this.txtSupplyID;
            this.txtSupplyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyID.Enabled = false;
            this.txtSupplyID.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyID.FocusedState.Parent = this.txtSupplyID;
            this.txtSupplyID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSupplyID.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyID.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyID.HoverState.Parent = this.txtSupplyID;
            this.txtSupplyID.Location = new System.Drawing.Point(25, 56);
            this.txtSupplyID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplyID.Name = "txtSupplyID";
            this.txtSupplyID.PasswordChar = '\0';
            this.txtSupplyID.PlaceholderText = "";
            this.txtSupplyID.SelectedText = "";
            this.txtSupplyID.ShadowDecoration.Parent = this.txtSupplyID;
            this.txtSupplyID.Size = new System.Drawing.Size(446, 45);
            this.txtSupplyID.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "Supply ID:";
            // 
            // tabManageSupplies
            // 
            this.tabManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabManageSupplies.Controls.Add(this.txtItemUsed);
            this.tabManageSupplies.Controls.Add(this.label9);
            this.tabManageSupplies.Controls.Add(this.btnDeductItem);
            this.tabManageSupplies.Controls.Add(this.switchExpirationDateManageSupplies);
            this.tabManageSupplies.Controls.Add(this.btnAddManageSupplies);
            this.tabManageSupplies.Controls.Add(this.btnDeleteManageSupplies);
            this.tabManageSupplies.Controls.Add(this.btnSaveManageSupplies);
            this.tabManageSupplies.Controls.Add(this.btnEditManageSupplies);
            this.tabManageSupplies.Controls.Add(this.label3);
            this.tabManageSupplies.Controls.Add(this.dateExpirationManageSupplies);
            this.tabManageSupplies.Controls.Add(this.txtSupplyQuantityManageSupplies);
            this.tabManageSupplies.Controls.Add(this.label4);
            this.tabManageSupplies.Controls.Add(this.txtSupplyNameManageSupplies);
            this.tabManageSupplies.Controls.Add(this.label5);
            this.tabManageSupplies.Controls.Add(this.txtSupplyIDManageSupplies);
            this.tabManageSupplies.Controls.Add(this.label6);
            this.tabManageSupplies.Controls.Add(this.gridManageSupplies);
            this.tabManageSupplies.Location = new System.Drawing.Point(4, 4);
            this.tabManageSupplies.Name = "tabManageSupplies";
            this.tabManageSupplies.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageSupplies.Size = new System.Drawing.Size(1682, 950);
            this.tabManageSupplies.TabIndex = 3;
            this.tabManageSupplies.Text = "Manage Supplies";
            // 
            // txtItemUsed
            // 
            this.txtItemUsed.Animated = true;
            this.txtItemUsed.BorderRadius = 5;
            this.txtItemUsed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemUsed.DefaultText = "";
            this.txtItemUsed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtItemUsed.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtItemUsed.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtItemUsed.DisabledState.Parent = this.txtItemUsed;
            this.txtItemUsed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemUsed.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtItemUsed.FocusedState.Parent = this.txtItemUsed;
            this.txtItemUsed.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtItemUsed.ForeColor = System.Drawing.Color.Black;
            this.txtItemUsed.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtItemUsed.HoverState.Parent = this.txtItemUsed;
            this.txtItemUsed.Location = new System.Drawing.Point(1163, 56);
            this.txtItemUsed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemUsed.Name = "txtItemUsed";
            this.txtItemUsed.PasswordChar = '\0';
            this.txtItemUsed.PlaceholderText = "";
            this.txtItemUsed.SelectedText = "";
            this.txtItemUsed.ShadowDecoration.Parent = this.txtItemUsed;
            this.txtItemUsed.Size = new System.Drawing.Size(446, 45);
            this.txtItemUsed.TabIndex = 179;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1158, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 28);
            this.label9.TabIndex = 178;
            this.label9.Text = "Item Used:";
            // 
            // btnDeductItem
            // 
            this.btnDeductItem.Animated = true;
            this.btnDeductItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeductItem.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeductItem.BorderRadius = 5;
            this.btnDeductItem.BorderThickness = 1;
            this.btnDeductItem.CheckedState.Parent = this.btnDeductItem;
            this.btnDeductItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeductItem.CustomImages.Parent = this.btnDeductItem;
            this.btnDeductItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeductItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeductItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeductItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeductItem.DisabledState.Parent = this.btnDeductItem;
            this.btnDeductItem.Enabled = false;
            this.btnDeductItem.FillColor = System.Drawing.Color.Lime;
            this.btnDeductItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDeductItem.ForeColor = System.Drawing.Color.White;
            this.btnDeductItem.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDeductItem.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnDeductItem.HoverState.Parent = this.btnDeductItem;
            this.btnDeductItem.Image = global::PatientInformationSystemNew.Properties.Resources.edit_icon;
            this.btnDeductItem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeductItem.Location = new System.Drawing.Point(1417, 114);
            this.btnDeductItem.Name = "btnDeductItem";
            this.btnDeductItem.ShadowDecoration.Parent = this.btnDeductItem;
            this.btnDeductItem.Size = new System.Drawing.Size(192, 58);
            this.btnDeductItem.TabIndex = 177;
            this.btnDeductItem.Text = "Deduct Item";
            this.btnDeductItem.Click += new System.EventHandler(this.btnDeductItem_Click);
            // 
            // switchExpirationDateManageSupplies
            // 
            this.switchExpirationDateManageSupplies.Animated = true;
            this.switchExpirationDateManageSupplies.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchExpirationDateManageSupplies.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.switchExpirationDateManageSupplies.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchExpirationDateManageSupplies.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchExpirationDateManageSupplies.CheckedState.Parent = this.switchExpirationDateManageSupplies;
            this.switchExpirationDateManageSupplies.Location = new System.Drawing.Point(649, 15);
            this.switchExpirationDateManageSupplies.Name = "switchExpirationDateManageSupplies";
            this.switchExpirationDateManageSupplies.ShadowDecoration.Parent = this.switchExpirationDateManageSupplies;
            this.switchExpirationDateManageSupplies.Size = new System.Drawing.Size(51, 28);
            this.switchExpirationDateManageSupplies.TabIndex = 176;
            this.switchExpirationDateManageSupplies.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchExpirationDateManageSupplies.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchExpirationDateManageSupplies.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchExpirationDateManageSupplies.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchExpirationDateManageSupplies.UncheckedState.Parent = this.switchExpirationDateManageSupplies;
            this.switchExpirationDateManageSupplies.CheckedChanged += new System.EventHandler(this.switchExpirationDateManageSupplies_CheckedChanged);
            // 
            // btnAddManageSupplies
            // 
            this.btnAddManageSupplies.Animated = true;
            this.btnAddManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddManageSupplies.BorderRadius = 5;
            this.btnAddManageSupplies.BorderThickness = 1;
            this.btnAddManageSupplies.CheckedState.Parent = this.btnAddManageSupplies;
            this.btnAddManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddManageSupplies.CustomImages.Parent = this.btnAddManageSupplies;
            this.btnAddManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddManageSupplies.DisabledState.Parent = this.btnAddManageSupplies;
            this.btnAddManageSupplies.FillColor = System.Drawing.Color.Lime;
            this.btnAddManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnAddManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddManageSupplies.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnAddManageSupplies.HoverState.Parent = this.btnAddManageSupplies;
            this.btnAddManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnAddManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddManageSupplies.Location = new System.Drawing.Point(489, 114);
            this.btnAddManageSupplies.Name = "btnAddManageSupplies";
            this.btnAddManageSupplies.ShadowDecoration.Parent = this.btnAddManageSupplies;
            this.btnAddManageSupplies.Size = new System.Drawing.Size(130, 58);
            this.btnAddManageSupplies.TabIndex = 175;
            this.btnAddManageSupplies.Text = "Add";
            this.btnAddManageSupplies.Click += new System.EventHandler(this.btnAddManageSupplies_Click);
            // 
            // btnDeleteManageSupplies
            // 
            this.btnDeleteManageSupplies.Animated = true;
            this.btnDeleteManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteManageSupplies.BorderRadius = 5;
            this.btnDeleteManageSupplies.BorderThickness = 1;
            this.btnDeleteManageSupplies.CheckedState.Parent = this.btnDeleteManageSupplies;
            this.btnDeleteManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteManageSupplies.CustomImages.Parent = this.btnDeleteManageSupplies;
            this.btnDeleteManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteManageSupplies.DisabledState.Parent = this.btnDeleteManageSupplies;
            this.btnDeleteManageSupplies.Enabled = false;
            this.btnDeleteManageSupplies.FillColor = System.Drawing.Color.Red;
            this.btnDeleteManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDeleteManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnDeleteManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDeleteManageSupplies.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnDeleteManageSupplies.HoverState.Parent = this.btnDeleteManageSupplies;
            this.btnDeleteManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.delete_icon;
            this.btnDeleteManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteManageSupplies.Location = new System.Drawing.Point(779, 114);
            this.btnDeleteManageSupplies.Name = "btnDeleteManageSupplies";
            this.btnDeleteManageSupplies.ShadowDecoration.Parent = this.btnDeleteManageSupplies;
            this.btnDeleteManageSupplies.Size = new System.Drawing.Size(130, 58);
            this.btnDeleteManageSupplies.TabIndex = 174;
            this.btnDeleteManageSupplies.Text = "Delete";
            this.btnDeleteManageSupplies.Click += new System.EventHandler(this.btnDeleteManageSupplies_Click);
            // 
            // btnSaveManageSupplies
            // 
            this.btnSaveManageSupplies.Animated = true;
            this.btnSaveManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveManageSupplies.BorderRadius = 5;
            this.btnSaveManageSupplies.BorderThickness = 1;
            this.btnSaveManageSupplies.CheckedState.Parent = this.btnSaveManageSupplies;
            this.btnSaveManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveManageSupplies.CustomImages.Parent = this.btnSaveManageSupplies;
            this.btnSaveManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveManageSupplies.DisabledState.Parent = this.btnSaveManageSupplies;
            this.btnSaveManageSupplies.FillColor = System.Drawing.Color.Lime;
            this.btnSaveManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSaveManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnSaveManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSaveManageSupplies.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSaveManageSupplies.HoverState.Parent = this.btnSaveManageSupplies;
            this.btnSaveManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnSaveManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveManageSupplies.Location = new System.Drawing.Point(489, 114);
            this.btnSaveManageSupplies.Name = "btnSaveManageSupplies";
            this.btnSaveManageSupplies.ShadowDecoration.Parent = this.btnSaveManageSupplies;
            this.btnSaveManageSupplies.Size = new System.Drawing.Size(130, 58);
            this.btnSaveManageSupplies.TabIndex = 173;
            this.btnSaveManageSupplies.Text = "Save";
            this.btnSaveManageSupplies.Visible = false;
            this.btnSaveManageSupplies.Click += new System.EventHandler(this.btnSaveManageSupplies_Click);
            // 
            // btnEditManageSupplies
            // 
            this.btnEditManageSupplies.Animated = true;
            this.btnEditManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditManageSupplies.BorderRadius = 5;
            this.btnEditManageSupplies.BorderThickness = 1;
            this.btnEditManageSupplies.CheckedState.Parent = this.btnEditManageSupplies;
            this.btnEditManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditManageSupplies.CustomImages.Parent = this.btnEditManageSupplies;
            this.btnEditManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditManageSupplies.DisabledState.Parent = this.btnEditManageSupplies;
            this.btnEditManageSupplies.Enabled = false;
            this.btnEditManageSupplies.FillColor = System.Drawing.Color.Blue;
            this.btnEditManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEditManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnEditManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnEditManageSupplies.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnEditManageSupplies.HoverState.Parent = this.btnEditManageSupplies;
            this.btnEditManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.edit_icon;
            this.btnEditManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditManageSupplies.Location = new System.Drawing.Point(634, 114);
            this.btnEditManageSupplies.Name = "btnEditManageSupplies";
            this.btnEditManageSupplies.ShadowDecoration.Parent = this.btnEditManageSupplies;
            this.btnEditManageSupplies.Size = new System.Drawing.Size(130, 58);
            this.btnEditManageSupplies.TabIndex = 172;
            this.btnEditManageSupplies.Text = "Edit";
            this.btnEditManageSupplies.Click += new System.EventHandler(this.btnEditManageSupplies_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(484, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 28);
            this.label3.TabIndex = 170;
            this.label3.Text = "Expiration Date:";
            // 
            // dateExpirationManageSupplies
            // 
            this.dateExpirationManageSupplies.Animated = true;
            this.dateExpirationManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.dateExpirationManageSupplies.BorderRadius = 5;
            this.dateExpirationManageSupplies.BorderThickness = 1;
            this.dateExpirationManageSupplies.CheckedState.Parent = this.dateExpirationManageSupplies;
            this.dateExpirationManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateExpirationManageSupplies.Enabled = false;
            this.dateExpirationManageSupplies.FillColor = System.Drawing.Color.Blue;
            this.dateExpirationManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateExpirationManageSupplies.ForeColor = System.Drawing.Color.White;
            this.dateExpirationManageSupplies.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateExpirationManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.dateExpirationManageSupplies.HoverState.FillColor = System.Drawing.Color.Blue;
            this.dateExpirationManageSupplies.HoverState.Parent = this.dateExpirationManageSupplies;
            this.dateExpirationManageSupplies.Location = new System.Drawing.Point(489, 56);
            this.dateExpirationManageSupplies.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateExpirationManageSupplies.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateExpirationManageSupplies.Name = "dateExpirationManageSupplies";
            this.dateExpirationManageSupplies.ShadowDecoration.Parent = this.dateExpirationManageSupplies;
            this.dateExpirationManageSupplies.Size = new System.Drawing.Size(446, 45);
            this.dateExpirationManageSupplies.TabIndex = 169;
            this.dateExpirationManageSupplies.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            // 
            // txtSupplyQuantityManageSupplies
            // 
            this.txtSupplyQuantityManageSupplies.Animated = true;
            this.txtSupplyQuantityManageSupplies.BorderRadius = 5;
            this.txtSupplyQuantityManageSupplies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyQuantityManageSupplies.DefaultText = "";
            this.txtSupplyQuantityManageSupplies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyQuantityManageSupplies.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyQuantityManageSupplies.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyQuantityManageSupplies.DisabledState.Parent = this.txtSupplyQuantityManageSupplies;
            this.txtSupplyQuantityManageSupplies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyQuantityManageSupplies.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyQuantityManageSupplies.FocusedState.Parent = this.txtSupplyQuantityManageSupplies;
            this.txtSupplyQuantityManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSupplyQuantityManageSupplies.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyQuantityManageSupplies.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyQuantityManageSupplies.HoverState.Parent = this.txtSupplyQuantityManageSupplies;
            this.txtSupplyQuantityManageSupplies.Location = new System.Drawing.Point(25, 254);
            this.txtSupplyQuantityManageSupplies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplyQuantityManageSupplies.Name = "txtSupplyQuantityManageSupplies";
            this.txtSupplyQuantityManageSupplies.PasswordChar = '\0';
            this.txtSupplyQuantityManageSupplies.PlaceholderText = "";
            this.txtSupplyQuantityManageSupplies.SelectedText = "";
            this.txtSupplyQuantityManageSupplies.ShadowDecoration.Parent = this.txtSupplyQuantityManageSupplies;
            this.txtSupplyQuantityManageSupplies.Size = new System.Drawing.Size(446, 45);
            this.txtSupplyQuantityManageSupplies.TabIndex = 168;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 28);
            this.label4.TabIndex = 167;
            this.label4.Text = "Supply Quantity:";
            // 
            // txtSupplyNameManageSupplies
            // 
            this.txtSupplyNameManageSupplies.Animated = true;
            this.txtSupplyNameManageSupplies.BorderRadius = 5;
            this.txtSupplyNameManageSupplies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyNameManageSupplies.DefaultText = "";
            this.txtSupplyNameManageSupplies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyNameManageSupplies.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyNameManageSupplies.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyNameManageSupplies.DisabledState.Parent = this.txtSupplyNameManageSupplies;
            this.txtSupplyNameManageSupplies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyNameManageSupplies.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyNameManageSupplies.FocusedState.Parent = this.txtSupplyNameManageSupplies;
            this.txtSupplyNameManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSupplyNameManageSupplies.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyNameManageSupplies.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyNameManageSupplies.HoverState.Parent = this.txtSupplyNameManageSupplies;
            this.txtSupplyNameManageSupplies.Location = new System.Drawing.Point(25, 155);
            this.txtSupplyNameManageSupplies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplyNameManageSupplies.Name = "txtSupplyNameManageSupplies";
            this.txtSupplyNameManageSupplies.PasswordChar = '\0';
            this.txtSupplyNameManageSupplies.PlaceholderText = "";
            this.txtSupplyNameManageSupplies.SelectedText = "";
            this.txtSupplyNameManageSupplies.ShadowDecoration.Parent = this.txtSupplyNameManageSupplies;
            this.txtSupplyNameManageSupplies.Size = new System.Drawing.Size(446, 45);
            this.txtSupplyNameManageSupplies.TabIndex = 166;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 165;
            this.label5.Text = "Supply Name:";
            // 
            // txtSupplyIDManageSupplies
            // 
            this.txtSupplyIDManageSupplies.Animated = true;
            this.txtSupplyIDManageSupplies.BorderRadius = 5;
            this.txtSupplyIDManageSupplies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyIDManageSupplies.DefaultText = "";
            this.txtSupplyIDManageSupplies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyIDManageSupplies.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyIDManageSupplies.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyIDManageSupplies.DisabledState.Parent = this.txtSupplyIDManageSupplies;
            this.txtSupplyIDManageSupplies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyIDManageSupplies.Enabled = false;
            this.txtSupplyIDManageSupplies.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyIDManageSupplies.FocusedState.Parent = this.txtSupplyIDManageSupplies;
            this.txtSupplyIDManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSupplyIDManageSupplies.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyIDManageSupplies.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyIDManageSupplies.HoverState.Parent = this.txtSupplyIDManageSupplies;
            this.txtSupplyIDManageSupplies.Location = new System.Drawing.Point(25, 56);
            this.txtSupplyIDManageSupplies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupplyIDManageSupplies.Name = "txtSupplyIDManageSupplies";
            this.txtSupplyIDManageSupplies.PasswordChar = '\0';
            this.txtSupplyIDManageSupplies.PlaceholderText = "";
            this.txtSupplyIDManageSupplies.SelectedText = "";
            this.txtSupplyIDManageSupplies.ShadowDecoration.Parent = this.txtSupplyIDManageSupplies;
            this.txtSupplyIDManageSupplies.Size = new System.Drawing.Size(446, 45);
            this.txtSupplyIDManageSupplies.TabIndex = 164;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 163;
            this.label6.Text = "Supply ID:";
            // 
            // gridManageSupplies
            // 
            this.gridManageSupplies.AllowUserToAddRows = false;
            this.gridManageSupplies.AllowUserToDeleteRows = false;
            this.gridManageSupplies.AllowUserToResizeColumns = false;
            this.gridManageSupplies.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gridManageSupplies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridManageSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridManageSupplies.BackgroundColor = System.Drawing.Color.White;
            this.gridManageSupplies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridManageSupplies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridManageSupplies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridManageSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridManageSupplies.ColumnHeadersHeight = 40;
            this.gridManageSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridManageSupplies.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridManageSupplies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridManageSupplies.EnableHeadersVisualStyles = false;
            this.gridManageSupplies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridManageSupplies.Location = new System.Drawing.Point(3, 337);
            this.gridManageSupplies.Name = "gridManageSupplies";
            this.gridManageSupplies.ReadOnly = true;
            this.gridManageSupplies.RowHeadersVisible = false;
            this.gridManageSupplies.RowHeadersWidth = 51;
            this.gridManageSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridManageSupplies.RowTemplate.Height = 35;
            this.gridManageSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridManageSupplies.Size = new System.Drawing.Size(1676, 610);
            this.gridManageSupplies.TabIndex = 33;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridManageSupplies.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridManageSupplies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridManageSupplies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridManageSupplies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridManageSupplies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridManageSupplies.ThemeStyle.HeaderStyle.Height = 40;
            this.gridManageSupplies.ThemeStyle.ReadOnly = true;
            this.gridManageSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridManageSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridManageSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridManageSupplies.ThemeStyle.RowsStyle.Height = 35;
            this.gridManageSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridManageSupplies.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridManageSupplies_CellMouseClick);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1830, 958);
            this.Controls.Add(this.tabControlInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.tabControlInventory.ResumeLayout(false);
            this.tabSupplies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplies)).EndInit();
            this.tabIncomingSupplies.ResumeLayout(false);
            this.tabIncomingSupplies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIncomingSupplies)).EndInit();
            this.tabManageSupplies.ResumeLayout(false);
            this.tabManageSupplies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridManageSupplies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControlInventory;
        private System.Windows.Forms.TabPage tabSupplies;
        private System.Windows.Forms.TabPage tabIncomingSupplies;
        private System.Windows.Forms.TabPage tabManageSupplies;
        private Guna.UI2.WinForms.Guna2DataGridView gridSupplies;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplyID;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView gridIncomingSupplies;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplyName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplyQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateExpiration;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchExpirationDate;
        private Guna.UI2.WinForms.Guna2Button btnSaveIncomingSupplies;
        private Guna.UI2.WinForms.Guna2Button btnEditIncomingSupplies;
        private Guna.UI2.WinForms.Guna2Button btnAddIncomingSupplies;
        private Guna.UI2.WinForms.Guna2DataGridView gridManageSupplies;
        private Guna.UI2.WinForms.Guna2Button btnAddManageSupplies;
        private Guna.UI2.WinForms.Guna2Button btnDeleteManageSupplies;
        private Guna.UI2.WinForms.Guna2Button btnSaveManageSupplies;
        private Guna.UI2.WinForms.Guna2Button btnEditManageSupplies;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateExpirationManageSupplies;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplyQuantityManageSupplies;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplyNameManageSupplies;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplyIDManageSupplies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateArrive;
        private Guna.UI2.WinForms.Guna2Button btnDeleteIncomingSupplies;
        private Guna.UI2.WinForms.Guna2Button btnSupplyArrived;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchExpirationDateManageSupplies;
        private Guna.UI2.WinForms.Guna2Button btnDeductItem;
        private Guna.UI2.WinForms.Guna2TextBox txtItemUsed;
        private System.Windows.Forms.Label label9;
    }
}