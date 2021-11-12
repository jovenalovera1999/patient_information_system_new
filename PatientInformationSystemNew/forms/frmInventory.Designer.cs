﻿
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
            this.btnDeleteIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateArrive = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAddIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelIncomingSupplies = new Guna.UI2.WinForms.Guna2Button();
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
            this.btnAddManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateManageSupplies = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.gridSupplies.ColumnHeadersHeight = 55;
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
            this.gridSupplies.RowTemplate.Height = 50;
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
            this.gridSupplies.ThemeStyle.HeaderStyle.Height = 55;
            this.gridSupplies.ThemeStyle.ReadOnly = true;
            this.gridSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridSupplies.ThemeStyle.RowsStyle.Height = 50;
            this.gridSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // tabIncomingSupplies
            // 
            this.tabIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabIncomingSupplies.Controls.Add(this.btnDeleteIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.label7);
            this.tabIncomingSupplies.Controls.Add(this.dateArrive);
            this.tabIncomingSupplies.Controls.Add(this.btnAddIncomingSupplies);
            this.tabIncomingSupplies.Controls.Add(this.btnCancelIncomingSupplies);
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
            this.btnDeleteIncomingSupplies.Location = new System.Drawing.Point(731, 213);
            this.btnDeleteIncomingSupplies.Name = "btnDeleteIncomingSupplies";
            this.btnDeleteIncomingSupplies.ShadowDecoration.Parent = this.btnDeleteIncomingSupplies;
            this.btnDeleteIncomingSupplies.Size = new System.Drawing.Size(106, 86);
            this.btnDeleteIncomingSupplies.TabIndex = 165;
            this.btnDeleteIncomingSupplies.Text = "Delete";
            this.btnDeleteIncomingSupplies.Visible = false;
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
            this.btnAddIncomingSupplies.Enabled = false;
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
            this.btnAddIncomingSupplies.Size = new System.Drawing.Size(106, 86);
            this.btnAddIncomingSupplies.TabIndex = 162;
            this.btnAddIncomingSupplies.Text = "Add";
            this.btnAddIncomingSupplies.Click += new System.EventHandler(this.btnAddIncomingSupplies_Click);
            // 
            // btnCancelIncomingSupplies
            // 
            this.btnCancelIncomingSupplies.Animated = true;
            this.btnCancelIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelIncomingSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelIncomingSupplies.BorderRadius = 5;
            this.btnCancelIncomingSupplies.BorderThickness = 1;
            this.btnCancelIncomingSupplies.CheckedState.Parent = this.btnCancelIncomingSupplies;
            this.btnCancelIncomingSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelIncomingSupplies.CustomImages.Parent = this.btnCancelIncomingSupplies;
            this.btnCancelIncomingSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelIncomingSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelIncomingSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelIncomingSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelIncomingSupplies.DisabledState.Parent = this.btnCancelIncomingSupplies;
            this.btnCancelIncomingSupplies.FillColor = System.Drawing.Color.Red;
            this.btnCancelIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnCancelIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCancelIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancelIncomingSupplies.HoverState.Parent = this.btnCancelIncomingSupplies;
            this.btnCancelIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.cancel_icon;
            this.btnCancelIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelIncomingSupplies.Location = new System.Drawing.Point(731, 213);
            this.btnCancelIncomingSupplies.Name = "btnCancelIncomingSupplies";
            this.btnCancelIncomingSupplies.ShadowDecoration.Parent = this.btnCancelIncomingSupplies;
            this.btnCancelIncomingSupplies.Size = new System.Drawing.Size(106, 86);
            this.btnCancelIncomingSupplies.TabIndex = 161;
            this.btnCancelIncomingSupplies.Text = "Cancel";
            this.btnCancelIncomingSupplies.Click += new System.EventHandler(this.btnCancelIncomingSupplies_Click);
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
            this.btnSaveIncomingSupplies.Size = new System.Drawing.Size(106, 86);
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
            this.btnEditIncomingSupplies.FillColor = System.Drawing.Color.Blue;
            this.btnEditIncomingSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnEditIncomingSupplies.ForeColor = System.Drawing.Color.White;
            this.btnEditIncomingSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnEditIncomingSupplies.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnEditIncomingSupplies.HoverState.Parent = this.btnEditIncomingSupplies;
            this.btnEditIncomingSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.edit_icon;
            this.btnEditIncomingSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEditIncomingSupplies.Location = new System.Drawing.Point(610, 213);
            this.btnEditIncomingSupplies.Name = "btnEditIncomingSupplies";
            this.btnEditIncomingSupplies.ShadowDecoration.Parent = this.btnEditIncomingSupplies;
            this.btnEditIncomingSupplies.Size = new System.Drawing.Size(106, 86);
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
            this.txtSupplyQuantity.TextChanged += new System.EventHandler(this.txtSupplyQuantity_TextChanged);
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
            this.txtSupplyName.TextChanged += new System.EventHandler(this.txtSupplyName_TextChanged);
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
            this.gridIncomingSupplies.ColumnHeadersHeight = 55;
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
            this.gridIncomingSupplies.RowTemplate.Height = 50;
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
            this.gridIncomingSupplies.ThemeStyle.HeaderStyle.Height = 55;
            this.gridIncomingSupplies.ThemeStyle.ReadOnly = true;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridIncomingSupplies.ThemeStyle.RowsStyle.Height = 50;
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
            this.tabManageSupplies.Controls.Add(this.btnAddManageSupplies);
            this.tabManageSupplies.Controls.Add(this.btnCancelManageSupplies);
            this.tabManageSupplies.Controls.Add(this.guna2Button3);
            this.tabManageSupplies.Controls.Add(this.btnUpdateManageSupplies);
            this.tabManageSupplies.Controls.Add(this.guna2ToggleSwitch1);
            this.tabManageSupplies.Controls.Add(this.label3);
            this.tabManageSupplies.Controls.Add(this.guna2DateTimePicker1);
            this.tabManageSupplies.Controls.Add(this.guna2TextBox3);
            this.tabManageSupplies.Controls.Add(this.label4);
            this.tabManageSupplies.Controls.Add(this.guna2TextBox4);
            this.tabManageSupplies.Controls.Add(this.label5);
            this.tabManageSupplies.Controls.Add(this.guna2TextBox5);
            this.tabManageSupplies.Controls.Add(this.label6);
            this.tabManageSupplies.Controls.Add(this.gridManageSupplies);
            this.tabManageSupplies.Location = new System.Drawing.Point(4, 4);
            this.tabManageSupplies.Name = "tabManageSupplies";
            this.tabManageSupplies.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageSupplies.Size = new System.Drawing.Size(1682, 950);
            this.tabManageSupplies.TabIndex = 3;
            this.tabManageSupplies.Text = "Manage Supplies";
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
            this.btnAddManageSupplies.Enabled = false;
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
            this.btnAddManageSupplies.Size = new System.Drawing.Size(130, 86);
            this.btnAddManageSupplies.TabIndex = 175;
            this.btnAddManageSupplies.Text = "Add";
            // 
            // btnCancelManageSupplies
            // 
            this.btnCancelManageSupplies.Animated = true;
            this.btnCancelManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancelManageSupplies.BorderRadius = 5;
            this.btnCancelManageSupplies.BorderThickness = 1;
            this.btnCancelManageSupplies.CheckedState.Parent = this.btnCancelManageSupplies;
            this.btnCancelManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelManageSupplies.CustomImages.Parent = this.btnCancelManageSupplies;
            this.btnCancelManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelManageSupplies.DisabledState.Parent = this.btnCancelManageSupplies;
            this.btnCancelManageSupplies.FillColor = System.Drawing.Color.Red;
            this.btnCancelManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancelManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnCancelManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCancelManageSupplies.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnCancelManageSupplies.HoverState.Parent = this.btnCancelManageSupplies;
            this.btnCancelManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.cancel_icon;
            this.btnCancelManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelManageSupplies.Location = new System.Drawing.Point(634, 213);
            this.btnCancelManageSupplies.Name = "btnCancelManageSupplies";
            this.btnCancelManageSupplies.ShadowDecoration.Parent = this.btnCancelManageSupplies;
            this.btnCancelManageSupplies.Size = new System.Drawing.Size(130, 86);
            this.btnCancelManageSupplies.TabIndex = 174;
            this.btnCancelManageSupplies.Text = "Cancel";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.DisabledState.Parent = this.guna2Button3;
            this.guna2Button3.Enabled = false;
            this.guna2Button3.FillColor = System.Drawing.Color.Lime;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Lime;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::PatientInformationSystemNew.Properties.Resources.save_icon;
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(489, 114);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(106, 86);
            this.guna2Button3.TabIndex = 173;
            this.guna2Button3.Text = "Save";
            // 
            // btnUpdateManageSupplies
            // 
            this.btnUpdateManageSupplies.Animated = true;
            this.btnUpdateManageSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateManageSupplies.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateManageSupplies.BorderRadius = 5;
            this.btnUpdateManageSupplies.BorderThickness = 1;
            this.btnUpdateManageSupplies.CheckedState.Parent = this.btnUpdateManageSupplies;
            this.btnUpdateManageSupplies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateManageSupplies.CustomImages.Parent = this.btnUpdateManageSupplies;
            this.btnUpdateManageSupplies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateManageSupplies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateManageSupplies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateManageSupplies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateManageSupplies.DisabledState.Parent = this.btnUpdateManageSupplies;
            this.btnUpdateManageSupplies.FillColor = System.Drawing.Color.Blue;
            this.btnUpdateManageSupplies.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdateManageSupplies.ForeColor = System.Drawing.Color.White;
            this.btnUpdateManageSupplies.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUpdateManageSupplies.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnUpdateManageSupplies.HoverState.Parent = this.btnUpdateManageSupplies;
            this.btnUpdateManageSupplies.Image = global::PatientInformationSystemNew.Properties.Resources.edit_icon;
            this.btnUpdateManageSupplies.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateManageSupplies.Location = new System.Drawing.Point(489, 213);
            this.btnUpdateManageSupplies.Name = "btnUpdateManageSupplies";
            this.btnUpdateManageSupplies.ShadowDecoration.Parent = this.btnUpdateManageSupplies;
            this.btnUpdateManageSupplies.Size = new System.Drawing.Size(130, 86);
            this.btnUpdateManageSupplies.TabIndex = 172;
            this.btnUpdateManageSupplies.Text = "Update";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.Animated = true;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(649, 23);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 171;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
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
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Animated = true;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderRadius = 5;
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Blue;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.HoverState.FillColor = System.Drawing.Color.Blue;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(489, 56);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(446, 45);
            this.guna2DateTimePicker1.TabIndex = 169;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Animated = true;
            this.guna2TextBox3.BorderRadius = 5;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.Enabled = false;
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2TextBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(25, 254);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(446, 45);
            this.guna2TextBox3.TabIndex = 168;
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
            this.guna2TextBox4.Location = new System.Drawing.Point(25, 155);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(446, 45);
            this.guna2TextBox4.TabIndex = 166;
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
            // guna2TextBox5
            // 
            this.guna2TextBox5.Animated = true;
            this.guna2TextBox5.BorderRadius = 5;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox5.DisabledState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.Enabled = false;
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.Blue;
            this.guna2TextBox5.FocusedState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2TextBox5.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.guna2TextBox5.HoverState.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Location = new System.Drawing.Point(25, 56);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.ShadowDecoration.Parent = this.guna2TextBox5;
            this.guna2TextBox5.Size = new System.Drawing.Size(446, 45);
            this.guna2TextBox5.TabIndex = 164;
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
            this.gridManageSupplies.ColumnHeadersHeight = 55;
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
            this.gridManageSupplies.Location = new System.Drawing.Point(3, 315);
            this.gridManageSupplies.Name = "gridManageSupplies";
            this.gridManageSupplies.ReadOnly = true;
            this.gridManageSupplies.RowHeadersVisible = false;
            this.gridManageSupplies.RowHeadersWidth = 51;
            this.gridManageSupplies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridManageSupplies.RowTemplate.Height = 50;
            this.gridManageSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridManageSupplies.Size = new System.Drawing.Size(1676, 632);
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
            this.gridManageSupplies.ThemeStyle.HeaderStyle.Height = 55;
            this.gridManageSupplies.ThemeStyle.ReadOnly = true;
            this.gridManageSupplies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridManageSupplies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gridManageSupplies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridManageSupplies.ThemeStyle.RowsStyle.Height = 50;
            this.gridManageSupplies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridManageSupplies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
        private Guna.UI2.WinForms.Guna2Button btnCancelIncomingSupplies;
        private Guna.UI2.WinForms.Guna2Button btnAddIncomingSupplies;
        private Guna.UI2.WinForms.Guna2DataGridView gridManageSupplies;
        private Guna.UI2.WinForms.Guna2Button btnAddManageSupplies;
        private Guna.UI2.WinForms.Guna2Button btnCancelManageSupplies;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnUpdateManageSupplies;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateArrive;
        private Guna.UI2.WinForms.Guna2Button btnDeleteIncomingSupplies;
    }
}