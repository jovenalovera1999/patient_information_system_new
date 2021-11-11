
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
            this.tabControlDoctor = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabSupplies = new System.Windows.Forms.TabPage();
            this.tabIncomingSupplies = new System.Windows.Forms.TabPage();
            this.tabManageSupplies = new System.Windows.Forms.TabPage();
            this.tabControlDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDoctor
            // 
            this.tabControlDoctor.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlDoctor.Controls.Add(this.tabSupplies);
            this.tabControlDoctor.Controls.Add(this.tabIncomingSupplies);
            this.tabControlDoctor.Controls.Add(this.tabManageSupplies);
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
            this.tabControlDoctor.TabIndex = 3;
            this.tabControlDoctor.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlDoctor.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // tabSupplies
            // 
            this.tabSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabSupplies.Location = new System.Drawing.Point(4, 4);
            this.tabSupplies.Name = "tabSupplies";
            this.tabSupplies.Size = new System.Drawing.Size(1682, 950);
            this.tabSupplies.TabIndex = 1;
            this.tabSupplies.Text = "Supplies";
            // 
            // tabIncomingSupplies
            // 
            this.tabIncomingSupplies.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabIncomingSupplies.Location = new System.Drawing.Point(4, 4);
            this.tabIncomingSupplies.Name = "tabIncomingSupplies";
            this.tabIncomingSupplies.Size = new System.Drawing.Size(1682, 950);
            this.tabIncomingSupplies.TabIndex = 2;
            this.tabIncomingSupplies.Text = "Incoming Supplies";
            // 
            // tabManageSupplies
            // 
            this.tabManageSupplies.Location = new System.Drawing.Point(4, 4);
            this.tabManageSupplies.Name = "tabManageSupplies";
            this.tabManageSupplies.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageSupplies.Size = new System.Drawing.Size(1682, 950);
            this.tabManageSupplies.TabIndex = 3;
            this.tabManageSupplies.Text = "Manage Supplies";
            this.tabManageSupplies.UseVisualStyleBackColor = true;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1830, 958);
            this.Controls.Add(this.tabControlDoctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlDoctor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControlDoctor;
        private System.Windows.Forms.TabPage tabSupplies;
        private System.Windows.Forms.TabPage tabIncomingSupplies;
        private System.Windows.Forms.TabPage tabManageSupplies;
    }
}