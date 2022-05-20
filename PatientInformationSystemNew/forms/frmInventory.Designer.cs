
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
            this.label24 = new System.Windows.Forms.Label();
            this.txtSupplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSupplyArrived = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.switchExpirationDate = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSupplyQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridIncomingSupplies = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSupplyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabManageSupplies = new System.Windows.Forms.TabPage();
            this.txtIssuedTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSupplierManageSupplies = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtItemUsed = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeductItem = new Guna.UI2.WinForms.Guna2Button();
            this.switchExpirationDateManageSupplies = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnAddManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplyQuantityManageSupplies = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplyNameManageSupplies = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplyIDManageSupplies = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gridManageSupplies = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dateExpiration = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateArrive = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateExpirationManageSupplies = new Bunifu.Framework.UI.BunifuDatepicker();
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
            this.tabControlInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlInventory.ItemSize = new System.Drawing.Size(140, 50);
            this.tabControlInventory.Location = new System.Drawing.Point(0, 0);
            this.tabControlInventory.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlInventory.Name = "tabControlInventory";
            this.tabControlInventory.SelectedIndex = 0;
            this.tabControlInventory.Size = new System.Drawing.Size(1754, 981);
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
            this.tabSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.tabSupplies.Name = "tabSupplies";
            this.tabSupplies.Size = new System.Drawing.Size(1606, 973);
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
            this.gridSupplies.ColumnHeadersHeight = 36;
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
            this.gridSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.gridSupplies.Name = "gridSupplies";
            this.gridSupplies.ReadOnly = true;
            this.gridSupplies.RowHeadersVisible = false;
            this.gridSupplies.RowHeadersWidth = 51;
            this.gridSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSupplies.RowTemplate.Height = 36;
            this.gridSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSupplies.Size = new System.Drawing.Size(1606, 973);
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
            this.gridSupplies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridSupplies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSupplies.ThemeStyle.HeaderStyle.Height = 36;
            this.gridSupplies.ThemeStyle.ReadOnly = true;
            this.gridSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridSupplies.ThemeStyle.RowsStyle.Height = 36;
            this.gridSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // tabIncomingSupplies
            // 
            this.tabIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabIncomingSupplies.Controls.Add(this.dateArrive);
            this.tabIncomingSupplies.Controls.Add(this.dateExpiration);
            this.tabIncomingSupplies.Controls.Add(this.label24);
            this.tabIncomingSupplies.Controls.Add(this.txtSupplier);
            this.tabIncomingSupplies.Controls.Add(this.label10);
            this.tabIncomingSupplies.Controls.Add(this.btnSupplyArrived);
            this.tabIncomingSupplies.Controls.Add(this.btnDeleteIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.label7);
            this.tabIncomingSupplies.Controls.Add(this.btnAddIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.btnSaveIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.btnEditIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.switchExpirationDate);
            this.tabIncomingSupplies.Controls.Add(this.label21);
            this.tabIncomingSupplies.Controls.Add(this.txtSupplyQuantity);
            this.tabIncomingSupplies.Controls.Add(this.label2);
            this.tabIncomingSupplies.Controls.Add(this.txtSupplyName);
            this.tabIncomingSupplies.Controls.Add(this.label1);
            this.tabIncomingSupplies.Controls.Add(this.gridIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.txtSupplyID);
            this.tabIncomingSupplies.Controls.Add(this.label8);
            this.tabIncomingSupplies.Location = new System.Drawing.Point(4, 4);
            this.tabIncomingSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.tabIncomingSupplies.Name = "tabIncomingSupplies";
            this.tabIncomingSupplies.Size = new System.Drawing.Size(1606, 973);
            this.tabIncomingSupplies.TabIndex = 2;
            this.tabIncomingSupplies.Text = "Incoming Supplies";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(7, 5);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(427, 37);
            this.label24.TabIndex = 169;
            this.label24.Text = "Add or Manage Incoming Supplies";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Animated = true;
            this.txtSupplier.BorderRadius = 3;
            this.txtSupplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplier.DefaultText = "";
            this.txtSupplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplier.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplier.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplier.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplier.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplier.ForeColor = System.Drawing.Color.Black;
            this.txtSupplier.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplier.Location = new System.Drawing.Point(14, 169);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.PasswordChar = '\0';
            this.txtSupplier.PlaceholderText = "";
            this.txtSupplier.SelectedText = "";
            this.txtSupplier.Size = new System.Drawing.Size(392, 37);
            this.txtSupplier.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 51);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 167;
            this.label10.Text = "Supply ID:";
            // 
            // btnSupplyArrived
            // 
            this.btnSupplyArrived.Animated = true;
            this.btnSupplyArrived.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSupplyArrived.BorderColor = System.Drawing.Color.Transparent;
            this.btnSupplyArrived.BorderThickness = 1;
            this.btnSupplyArrived.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplyArrived.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplyArrived.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupplyArrived.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupplyArrived.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupplyArrived.Enabled = false;
            this.btnSupplyArrived.FillColor = System.Drawing.Color.Lime;
            this.btnSupplyArrived.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSupplyArrived.ForeColor = System.Drawing.Color.White;
            this.btnSupplyArrived.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSupplyArrived.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSupplyArrived.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnSupplyArrived.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSupplyArrived.Location = new System.Drawing.Point(1445, 316);
            this.btnSupplyArrived.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupplyArrived.Name = "btnSupplyArrived";
            this.btnSupplyArrived.Size = new System.Drawing.Size(159, 50);
            this.btnSupplyArrived.TabIndex = 166;
            this.btnSupplyArrived.TabStop = false;
            this.btnSupplyArrived.Text = "Supply Arrived";
            this.btnSupplyArrived.Click += new System.EventHandler(this.btnSupplyArrived_Click);
            // 
            // btnDeleteIncomingSupplies
            // 
            this.btnDeleteIncomingSupplies.Animated = true;
            this.btnDeleteIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteIncomingSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteIncomingSupplies.BorderThickness = 1;
            this.btnDeleteIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteIncomingSupplies.Enabled = false;
            this.btnDeleteIncomingSupplies.FillColor = System.Drawing.Color.Red;
            this.btnDeleteIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnDeleteIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDeleteIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnDeleteIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.delete_icon;
            this.btnDeleteIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteIncomingSupplies.Location = new System.Drawing.Point(1306, 316);
            this.btnDeleteIncomingSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteIncomingSupplies.Name = "btnDeleteIncomingSupplies";
            this.btnDeleteIncomingSupplies.Size = new System.Drawing.Size(135, 50);
            this.btnDeleteIncomingSupplies.TabIndex = 165;
            this.btnDeleteIncomingSupplies.TabStop = false;
            this.btnDeleteIncomingSupplies.Text = "Delete";
            this.btnDeleteIncomingSupplies.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(409, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 164;
            this.label7.Text = "Arrive Date:";
            // 
            // btnAddIncomingSupplies
            // 
            this.btnAddIncomingSupplies.Animated = true;
            this.btnAddIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddIncomingSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddIncomingSupplies.BorderThickness = 1;
            this.btnAddIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddIncomingSupplies.FillColor = System.Drawing.Color.Lime;
            this.btnAddIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnAddIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnAddIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnAddIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddIncomingSupplies.Location = new System.Drawing.Point(1028, 316);
            this.btnAddIncomingSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddIncomingSupplies.Name = "btnAddIncomingSupplies";
            this.btnAddIncomingSupplies.Size = new System.Drawing.Size(135, 50);
            this.btnAddIncomingSupplies.TabIndex = 162;
            this.btnAddIncomingSupplies.TabStop = false;
            this.btnAddIncomingSupplies.Text = "Add";
            this.btnAddIncomingSupplies.Click += new System.EventHandler(this.btnAddIncomingSupplies_Click);
            // 
            // btnSaveIncomingSupplies
            // 
            this.btnSaveIncomingSupplies.Animated = true;
            this.btnSaveIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveIncomingSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveIncomingSupplies.BorderThickness = 1;
            this.btnSaveIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveIncomingSupplies.Enabled = false;
            this.btnSaveIncomingSupplies.FillColor = System.Drawing.Color.Lime;
            this.btnSaveIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnSaveIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSaveIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSaveIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnSaveIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveIncomingSupplies.Location = new System.Drawing.Point(1028, 316);
            this.btnSaveIncomingSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveIncomingSupplies.Name = "btnSaveIncomingSupplies";
            this.btnSaveIncomingSupplies.Size = new System.Drawing.Size(135, 50);
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
            this.btnEditIncomingSupplies.BorderThickness = 1;
            this.btnEditIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditIncomingSupplies.Enabled = false;
            this.btnEditIncomingSupplies.FillColor = System.Drawing.Color.Blue;
            this.btnEditIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnEditIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnEditIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnEditIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.edit_icon;
            this.btnEditIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditIncomingSupplies.Location = new System.Drawing.Point(1167, 316);
            this.btnEditIncomingSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditIncomingSupplies.Name = "btnEditIncomingSupplies";
            this.btnEditIncomingSupplies.Size = new System.Drawing.Size(135, 50);
            this.btnEditIncomingSupplies.TabIndex = 159;
            this.btnEditIncomingSupplies.TabStop = false;
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
            this.switchExpirationDate.Location = new System.Drawing.Point(549, 53);
            this.switchExpirationDate.Margin = new System.Windows.Forms.Padding(2);
            this.switchExpirationDate.Name = "switchExpirationDate";
            this.switchExpirationDate.Size = new System.Drawing.Size(38, 23);
            this.switchExpirationDate.TabIndex = 4;
            this.switchExpirationDate.TabStop = false;
            this.switchExpirationDate.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchExpirationDate.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchExpirationDate.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchExpirationDate.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchExpirationDate.CheckedChanged += new System.EventHandler(this.switchExpirationDate_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(409, 51);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 25);
            this.label21.TabIndex = 116;
            this.label21.Text = "Expiration Date:";
            // 
            // txtSupplyQuantity
            // 
            this.txtSupplyQuantity.Animated = true;
            this.txtSupplyQuantity.BorderRadius = 3;
            this.txtSupplyQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyQuantity.DefaultText = "";
            this.txtSupplyQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyQuantity.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyQuantity.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyQuantity.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplyQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyQuantity.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyQuantity.Location = new System.Drawing.Point(14, 329);
            this.txtSupplyQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplyQuantity.Name = "txtSupplyQuantity";
            this.txtSupplyQuantity.PasswordChar = '\0';
            this.txtSupplyQuantity.PlaceholderText = "";
            this.txtSupplyQuantity.SelectedText = "";
            this.txtSupplyQuantity.Size = new System.Drawing.Size(392, 37);
            this.txtSupplyQuantity.TabIndex = 3;
            this.txtSupplyQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplyQuantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Supply Quantity (Pieces):";
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.Animated = true;
            this.txtSupplyName.BorderRadius = 3;
            this.txtSupplyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyName.DefaultText = "";
            this.txtSupplyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyName.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyName.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyName.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplyName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyName.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyName.Location = new System.Drawing.Point(14, 249);
            this.txtSupplyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.PasswordChar = '\0';
            this.txtSupplyName.PlaceholderText = "";
            this.txtSupplyName.SelectedText = "";
            this.txtSupplyName.Size = new System.Drawing.Size(392, 37);
            this.txtSupplyName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
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
            this.gridIncomingSupplies.ColumnHeadersHeight = 36;
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
            this.gridIncomingSupplies.Location = new System.Drawing.Point(0, 372);
            this.gridIncomingSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.gridIncomingSupplies.Name = "gridIncomingSupplies";
            this.gridIncomingSupplies.ReadOnly = true;
            this.gridIncomingSupplies.RowHeadersVisible = false;
            this.gridIncomingSupplies.RowHeadersWidth = 51;
            this.gridIncomingSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridIncomingSupplies.RowTemplate.Height = 36;
            this.gridIncomingSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIncomingSupplies.Size = new System.Drawing.Size(1606, 601);
            this.gridIncomingSupplies.TabIndex = 32;
            this.gridIncomingSupplies.TabStop = false;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridIncomingSupplies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridIncomingSupplies.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.Height = 36;
            this.gridIncomingSupplies.ThemeStyle.ReadOnly = true;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.Height = 36;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridIncomingSupplies.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridIncomingSupplies_CellMouseClick);
            // 
            // txtSupplyID
            // 
            this.txtSupplyID.Animated = true;
            this.txtSupplyID.BorderRadius = 3;
            this.txtSupplyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyID.DefaultText = "";
            this.txtSupplyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyID.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyID.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyID.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplyID.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyID.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyID.Location = new System.Drawing.Point(14, 85);
            this.txtSupplyID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplyID.Name = "txtSupplyID";
            this.txtSupplyID.PasswordChar = '\0';
            this.txtSupplyID.PlaceholderText = "";
            this.txtSupplyID.ReadOnly = true;
            this.txtSupplyID.SelectedText = "";
            this.txtSupplyID.Size = new System.Drawing.Size(392, 37);
            this.txtSupplyID.TabIndex = 0;
            this.txtSupplyID.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Supplier:";
            // 
            // tabManageSupplies
            // 
            this.tabManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabManageSupplies.Controls.Add(this.dateExpirationManageSupplies);
            this.tabManageSupplies.Controls.Add(this.txtIssuedTo);
            this.tabManageSupplies.Controls.Add(this.label13);
            this.tabManageSupplies.Controls.Add(this.txtSupplierManageSupplies);
            this.tabManageSupplies.Controls.Add(this.label12);
            this.tabManageSupplies.Controls.Add(this.label11);
            this.tabManageSupplies.Controls.Add(this.txtItemUsed);
            this.tabManageSupplies.Controls.Add(this.label9);
            this.tabManageSupplies.Controls.Add(this.btnDeductItem);
            this.tabManageSupplies.Controls.Add(this.switchExpirationDateManageSupplies);
            this.tabManageSupplies.Controls.Add(this.btnAddManageSupplies);
            this.tabManageSupplies.Controls.Add(this.btnDeleteManageSupplies);
            this.tabManageSupplies.Controls.Add(this.btnSaveManageSupplies);
            this.tabManageSupplies.Controls.Add(this.btnEditManageSupplies);
            this.tabManageSupplies.Controls.Add(this.label3);
            this.tabManageSupplies.Controls.Add(this.txtSupplyQuantityManageSupplies);
            this.tabManageSupplies.Controls.Add(this.label4);
            this.tabManageSupplies.Controls.Add(this.txtSupplyNameManageSupplies);
            this.tabManageSupplies.Controls.Add(this.label5);
            this.tabManageSupplies.Controls.Add(this.txtSupplyIDManageSupplies);
            this.tabManageSupplies.Controls.Add(this.label6);
            this.tabManageSupplies.Controls.Add(this.gridManageSupplies);
            this.tabManageSupplies.Location = new System.Drawing.Point(4, 4);
            this.tabManageSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.tabManageSupplies.Name = "tabManageSupplies";
            this.tabManageSupplies.Padding = new System.Windows.Forms.Padding(2);
            this.tabManageSupplies.Size = new System.Drawing.Size(1606, 973);
            this.tabManageSupplies.TabIndex = 3;
            this.tabManageSupplies.Text = "Manage Supplies";
            // 
            // txtIssuedTo
            // 
            this.txtIssuedTo.Animated = true;
            this.txtIssuedTo.BorderRadius = 3;
            this.txtIssuedTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIssuedTo.DefaultText = "";
            this.txtIssuedTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtIssuedTo.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtIssuedTo.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtIssuedTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIssuedTo.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtIssuedTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIssuedTo.ForeColor = System.Drawing.Color.Black;
            this.txtIssuedTo.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtIssuedTo.Location = new System.Drawing.Point(1209, 119);
            this.txtIssuedTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIssuedTo.Name = "txtIssuedTo";
            this.txtIssuedTo.PasswordChar = '\0';
            this.txtIssuedTo.PlaceholderText = "";
            this.txtIssuedTo.SelectedText = "";
            this.txtIssuedTo.Size = new System.Drawing.Size(392, 37);
            this.txtIssuedTo.TabIndex = 6;
            this.txtIssuedTo.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1504, 85);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 25);
            this.label13.TabIndex = 183;
            this.label13.Text = "Issued To:";
            // 
            // txtSupplierManageSupplies
            // 
            this.txtSupplierManageSupplies.Animated = true;
            this.txtSupplierManageSupplies.BorderRadius = 3;
            this.txtSupplierManageSupplies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierManageSupplies.DefaultText = "";
            this.txtSupplierManageSupplies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplierManageSupplies.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplierManageSupplies.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierManageSupplies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplierManageSupplies.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplierManageSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplierManageSupplies.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierManageSupplies.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplierManageSupplies.Location = new System.Drawing.Point(14, 169);
            this.txtSupplierManageSupplies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplierManageSupplies.Name = "txtSupplierManageSupplies";
            this.txtSupplierManageSupplies.PasswordChar = '\0';
            this.txtSupplierManageSupplies.PlaceholderText = "";
            this.txtSupplierManageSupplies.SelectedText = "";
            this.txtSupplierManageSupplies.Size = new System.Drawing.Size(392, 37);
            this.txtSupplierManageSupplies.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 25);
            this.label12.TabIndex = 181;
            this.label12.Text = "Supply ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(7, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(309, 37);
            this.label11.TabIndex = 180;
            this.label11.Text = "Add or Manage Supplies";
            // 
            // txtItemUsed
            // 
            this.txtItemUsed.Animated = true;
            this.txtItemUsed.BorderRadius = 3;
            this.txtItemUsed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemUsed.DefaultText = "";
            this.txtItemUsed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtItemUsed.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtItemUsed.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtItemUsed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemUsed.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtItemUsed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtItemUsed.ForeColor = System.Drawing.Color.Black;
            this.txtItemUsed.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtItemUsed.Location = new System.Drawing.Point(1209, 39);
            this.txtItemUsed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemUsed.Name = "txtItemUsed";
            this.txtItemUsed.PasswordChar = '\0';
            this.txtItemUsed.PlaceholderText = "";
            this.txtItemUsed.SelectedText = "";
            this.txtItemUsed.Size = new System.Drawing.Size(392, 37);
            this.txtItemUsed.TabIndex = 5;
            this.txtItemUsed.TabStop = false;
            this.txtItemUsed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemUsed_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1504, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 178;
            this.label9.Text = "Item Used:";
            // 
            // btnDeductItem
            // 
            this.btnDeductItem.Animated = true;
            this.btnDeductItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeductItem.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeductItem.BorderThickness = 1;
            this.btnDeductItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeductItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeductItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeductItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeductItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeductItem.Enabled = false;
            this.btnDeductItem.FillColor = System.Drawing.Color.Lime;
            this.btnDeductItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeductItem.ForeColor = System.Drawing.Color.White;
            this.btnDeductItem.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDeductItem.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnDeductItem.Image = global::PatientInformationSystemNew.Properties.Resources.edit_icon;
            this.btnDeductItem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeductItem.Location = new System.Drawing.Point(1466, 162);
            this.btnDeductItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeductItem.Name = "btnDeductItem";
            this.btnDeductItem.Size = new System.Drawing.Size(135, 50);
            this.btnDeductItem.TabIndex = 177;
            this.btnDeductItem.TabStop = false;
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
            this.switchExpirationDateManageSupplies.Location = new System.Drawing.Point(547, 53);
            this.switchExpirationDateManageSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.switchExpirationDateManageSupplies.Name = "switchExpirationDateManageSupplies";
            this.switchExpirationDateManageSupplies.Size = new System.Drawing.Size(38, 23);
            this.switchExpirationDateManageSupplies.TabIndex = 176;
            this.switchExpirationDateManageSupplies.TabStop = false;
            this.switchExpirationDateManageSupplies.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchExpirationDateManageSupplies.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchExpirationDateManageSupplies.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchExpirationDateManageSupplies.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchExpirationDateManageSupplies.CheckedChanged += new System.EventHandler(this.switchExpirationDateManageSupplies_CheckedChanged);
            // 
            // btnAddManageSupplies
            // 
            this.btnAddManageSupplies.Animated = true;
            this.btnAddManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddManageSupplies.BorderThickness = 1;
            this.btnAddManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddManageSupplies.FillColor = System.Drawing.Color.Lime;
            this.btnAddManageSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnAddManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAddManageSupplies.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnAddManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnAddManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddManageSupplies.Location = new System.Drawing.Point(1188, 316);
            this.btnAddManageSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddManageSupplies.Name = "btnAddManageSupplies";
            this.btnAddManageSupplies.Size = new System.Drawing.Size(135, 50);
            this.btnAddManageSupplies.TabIndex = 175;
            this.btnAddManageSupplies.TabStop = false;
            this.btnAddManageSupplies.Text = "Add";
            this.btnAddManageSupplies.Click += new System.EventHandler(this.btnAddManageSupplies_Click);
            // 
            // btnDeleteManageSupplies
            // 
            this.btnDeleteManageSupplies.Animated = true;
            this.btnDeleteManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteManageSupplies.BorderThickness = 1;
            this.btnDeleteManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteManageSupplies.Enabled = false;
            this.btnDeleteManageSupplies.FillColor = System.Drawing.Color.Red;
            this.btnDeleteManageSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeleteManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnDeleteManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDeleteManageSupplies.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnDeleteManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.delete_icon;
            this.btnDeleteManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteManageSupplies.Location = new System.Drawing.Point(1466, 316);
            this.btnDeleteManageSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteManageSupplies.Name = "btnDeleteManageSupplies";
            this.btnDeleteManageSupplies.Size = new System.Drawing.Size(135, 50);
            this.btnDeleteManageSupplies.TabIndex = 174;
            this.btnDeleteManageSupplies.TabStop = false;
            this.btnDeleteManageSupplies.Text = "Delete";
            this.btnDeleteManageSupplies.Click += new System.EventHandler(this.btnDeleteManageSupplies_Click);
            // 
            // btnSaveManageSupplies
            // 
            this.btnSaveManageSupplies.Animated = true;
            this.btnSaveManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveManageSupplies.BorderThickness = 1;
            this.btnSaveManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveManageSupplies.FillColor = System.Drawing.Color.Lime;
            this.btnSaveManageSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnSaveManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSaveManageSupplies.HoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSaveManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.btnSaveManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveManageSupplies.Location = new System.Drawing.Point(1188, 316);
            this.btnSaveManageSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveManageSupplies.Name = "btnSaveManageSupplies";
            this.btnSaveManageSupplies.Size = new System.Drawing.Size(135, 50);
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
            this.btnEditManageSupplies.BorderThickness = 1;
            this.btnEditManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditManageSupplies.Enabled = false;
            this.btnEditManageSupplies.FillColor = System.Drawing.Color.Blue;
            this.btnEditManageSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnEditManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnEditManageSupplies.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnEditManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.edit_icon;
            this.btnEditManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditManageSupplies.Location = new System.Drawing.Point(1327, 316);
            this.btnEditManageSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditManageSupplies.Name = "btnEditManageSupplies";
            this.btnEditManageSupplies.Size = new System.Drawing.Size(135, 50);
            this.btnEditManageSupplies.TabIndex = 172;
            this.btnEditManageSupplies.TabStop = false;
            this.btnEditManageSupplies.Text = "Edit";
            this.btnEditManageSupplies.Click += new System.EventHandler(this.btnEditManageSupplies_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(407, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 170;
            this.label3.Text = "Expiration Date:";
            // 
            // txtSupplyQuantityManageSupplies
            // 
            this.txtSupplyQuantityManageSupplies.Animated = true;
            this.txtSupplyQuantityManageSupplies.BorderRadius = 3;
            this.txtSupplyQuantityManageSupplies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyQuantityManageSupplies.DefaultText = "";
            this.txtSupplyQuantityManageSupplies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyQuantityManageSupplies.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyQuantityManageSupplies.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyQuantityManageSupplies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyQuantityManageSupplies.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyQuantityManageSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplyQuantityManageSupplies.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyQuantityManageSupplies.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyQuantityManageSupplies.Location = new System.Drawing.Point(14, 329);
            this.txtSupplyQuantityManageSupplies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplyQuantityManageSupplies.Name = "txtSupplyQuantityManageSupplies";
            this.txtSupplyQuantityManageSupplies.PasswordChar = '\0';
            this.txtSupplyQuantityManageSupplies.PlaceholderText = "";
            this.txtSupplyQuantityManageSupplies.SelectedText = "";
            this.txtSupplyQuantityManageSupplies.Size = new System.Drawing.Size(392, 37);
            this.txtSupplyQuantityManageSupplies.TabIndex = 3;
            this.txtSupplyQuantityManageSupplies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplyQuantityManageSupplies_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 167;
            this.label4.Text = "Supply Quantity (Pieces):";
            // 
            // txtSupplyNameManageSupplies
            // 
            this.txtSupplyNameManageSupplies.Animated = true;
            this.txtSupplyNameManageSupplies.BorderRadius = 3;
            this.txtSupplyNameManageSupplies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyNameManageSupplies.DefaultText = "";
            this.txtSupplyNameManageSupplies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyNameManageSupplies.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyNameManageSupplies.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyNameManageSupplies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyNameManageSupplies.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyNameManageSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplyNameManageSupplies.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyNameManageSupplies.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyNameManageSupplies.Location = new System.Drawing.Point(14, 249);
            this.txtSupplyNameManageSupplies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplyNameManageSupplies.Name = "txtSupplyNameManageSupplies";
            this.txtSupplyNameManageSupplies.PasswordChar = '\0';
            this.txtSupplyNameManageSupplies.PlaceholderText = "";
            this.txtSupplyNameManageSupplies.SelectedText = "";
            this.txtSupplyNameManageSupplies.Size = new System.Drawing.Size(392, 37);
            this.txtSupplyNameManageSupplies.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 165;
            this.label5.Text = "Supply Name:";
            // 
            // txtSupplyIDManageSupplies
            // 
            this.txtSupplyIDManageSupplies.Animated = true;
            this.txtSupplyIDManageSupplies.BorderRadius = 3;
            this.txtSupplyIDManageSupplies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyIDManageSupplies.DefaultText = "";
            this.txtSupplyIDManageSupplies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtSupplyIDManageSupplies.DisabledState.FillColor = System.Drawing.Color.White;
            this.txtSupplyIDManageSupplies.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyIDManageSupplies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupplyIDManageSupplies.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyIDManageSupplies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplyIDManageSupplies.ForeColor = System.Drawing.Color.Black;
            this.txtSupplyIDManageSupplies.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.txtSupplyIDManageSupplies.Location = new System.Drawing.Point(14, 85);
            this.txtSupplyIDManageSupplies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplyIDManageSupplies.Name = "txtSupplyIDManageSupplies";
            this.txtSupplyIDManageSupplies.PasswordChar = '\0';
            this.txtSupplyIDManageSupplies.PlaceholderText = "";
            this.txtSupplyIDManageSupplies.ReadOnly = true;
            this.txtSupplyIDManageSupplies.SelectedText = "";
            this.txtSupplyIDManageSupplies.Size = new System.Drawing.Size(392, 37);
            this.txtSupplyIDManageSupplies.TabIndex = 0;
            this.txtSupplyIDManageSupplies.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 163;
            this.label6.Text = "Supplier:";
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
            this.gridManageSupplies.ColumnHeadersHeight = 36;
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
            this.gridManageSupplies.Location = new System.Drawing.Point(2, 372);
            this.gridManageSupplies.Margin = new System.Windows.Forms.Padding(2);
            this.gridManageSupplies.Name = "gridManageSupplies";
            this.gridManageSupplies.ReadOnly = true;
            this.gridManageSupplies.RowHeadersVisible = false;
            this.gridManageSupplies.RowHeadersWidth = 51;
            this.gridManageSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridManageSupplies.RowTemplate.Height = 36;
            this.gridManageSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridManageSupplies.Size = new System.Drawing.Size(1602, 599);
            this.gridManageSupplies.TabIndex = 33;
            this.gridManageSupplies.TabStop = false;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridManageSupplies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridManageSupplies.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridManageSupplies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue;
            this.gridManageSupplies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridManageSupplies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridManageSupplies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridManageSupplies.ThemeStyle.HeaderStyle.Height = 36;
            this.gridManageSupplies.ThemeStyle.ReadOnly = true;
            this.gridManageSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridManageSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridManageSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridManageSupplies.ThemeStyle.RowsStyle.Height = 36;
            this.gridManageSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridManageSupplies.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridManageSupplies_CellMouseClick);
            // 
            // dateExpiration
            // 
            this.dateExpiration.BackColor = System.Drawing.Color.Blue;
            this.dateExpiration.BorderRadius = 3;
            this.dateExpiration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateExpiration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExpiration.ForeColor = System.Drawing.Color.White;
            this.dateExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateExpiration.FormatCustom = null;
            this.dateExpiration.Location = new System.Drawing.Point(413, 85);
            this.dateExpiration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(392, 37);
            this.dateExpiration.TabIndex = 5;
            this.dateExpiration.Value = new System.DateTime(2022, 5, 20, 10, 16, 17, 647);
            // 
            // dateArrive
            // 
            this.dateArrive.BackColor = System.Drawing.Color.Blue;
            this.dateArrive.BorderRadius = 3;
            this.dateArrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateArrive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateArrive.ForeColor = System.Drawing.Color.White;
            this.dateArrive.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateArrive.FormatCustom = null;
            this.dateArrive.Location = new System.Drawing.Point(413, 169);
            this.dateArrive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateArrive.Name = "dateArrive";
            this.dateArrive.Size = new System.Drawing.Size(392, 37);
            this.dateArrive.TabIndex = 6;
            this.dateArrive.Value = new System.DateTime(2022, 5, 20, 10, 16, 17, 647);
            // 
            // dateExpirationManageSupplies
            // 
            this.dateExpirationManageSupplies.BackColor = System.Drawing.Color.Blue;
            this.dateExpirationManageSupplies.BorderRadius = 3;
            this.dateExpirationManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateExpirationManageSupplies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExpirationManageSupplies.ForeColor = System.Drawing.Color.White;
            this.dateExpirationManageSupplies.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateExpirationManageSupplies.FormatCustom = null;
            this.dateExpirationManageSupplies.Location = new System.Drawing.Point(412, 85);
            this.dateExpirationManageSupplies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateExpirationManageSupplies.Name = "dateExpirationManageSupplies";
            this.dateExpirationManageSupplies.Size = new System.Drawing.Size(392, 37);
            this.dateExpirationManageSupplies.TabIndex = 4;
            this.dateExpirationManageSupplies.Value = new System.DateTime(2022, 5, 20, 10, 16, 17, 647);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1754, 981);
            this.Controls.Add(this.tabControlInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private Guna.UI2.WinForms.Guna2TextBox txtSupplyQuantityManageSupplies;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplyNameManageSupplies;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplyIDManageSupplies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnDeleteIncomingSupplies;
        private Guna.UI2.WinForms.Guna2Button btnSupplyArrived;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchExpirationDateManageSupplies;
        private Guna.UI2.WinForms.Guna2Button btnDeductItem;
        private Guna.UI2.WinForms.Guna2TextBox txtItemUsed;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtSupplierManageSupplies;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtIssuedTo;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuDatepicker dateExpiration;
        private Bunifu.Framework.UI.BunifuDatepicker dateArrive;
        private Bunifu.Framework.UI.BunifuDatepicker dateExpirationManageSupplies;
    }
}