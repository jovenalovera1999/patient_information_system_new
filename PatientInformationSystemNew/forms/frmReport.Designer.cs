namespace PatientInformationSystemNew.forms
{
    partial class frmReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlReport = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPatientsAndSales = new System.Windows.Forms.TabPage();
            this.dateBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chartPatients = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.rprtPatientsSales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rprtInventory = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControlReport.SuspendLayout();
            this.tabPatientsAndSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPatients)).BeginInit();
            this.tabInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReport
            // 
            this.tabControlReport.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlReport.Controls.Add(this.tabPatientsAndSales);
            this.tabControlReport.Controls.Add(this.tabInventory);
            this.tabControlReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlReport.ItemSize = new System.Drawing.Size(140, 50);
            this.tabControlReport.Location = new System.Drawing.Point(0, 0);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(1830, 958);
            this.tabControlReport.TabButtonHoverState.BorderColor = System.Drawing.Color.White;
            this.tabControlReport.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlReport.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlReport.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControlReport.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControlReport.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlReport.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlReport.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlReport.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControlReport.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlReport.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlReport.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControlReport.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlReport.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControlReport.TabButtonSelectedState.InnerColor = System.Drawing.Color.Blue;
            this.tabControlReport.TabButtonSize = new System.Drawing.Size(140, 50);
            this.tabControlReport.TabIndex = 4;
            this.tabControlReport.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControlReport.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // tabPatientsAndSales
            // 
            this.tabPatientsAndSales.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPatientsAndSales.Controls.Add(this.rprtPatientsSales);
            this.tabPatientsAndSales.Controls.Add(this.dateBirthday);
            this.tabPatientsAndSales.Controls.Add(this.chartSales);
            this.tabPatientsAndSales.Controls.Add(this.label6);
            this.tabPatientsAndSales.Controls.Add(this.label7);
            this.tabPatientsAndSales.Controls.Add(this.label8);
            this.tabPatientsAndSales.Controls.Add(this.label9);
            this.tabPatientsAndSales.Controls.Add(this.label10);
            this.tabPatientsAndSales.Controls.Add(this.label11);
            this.tabPatientsAndSales.Controls.Add(this.chartPatients);
            this.tabPatientsAndSales.Controls.Add(this.label4);
            this.tabPatientsAndSales.Controls.Add(this.label5);
            this.tabPatientsAndSales.Controls.Add(this.label2);
            this.tabPatientsAndSales.Controls.Add(this.label3);
            this.tabPatientsAndSales.Controls.Add(this.label1);
            this.tabPatientsAndSales.Controls.Add(this.label20);
            this.tabPatientsAndSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPatientsAndSales.Location = new System.Drawing.Point(4, 4);
            this.tabPatientsAndSales.Name = "tabPatientsAndSales";
            this.tabPatientsAndSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientsAndSales.Size = new System.Drawing.Size(1682, 950);
            this.tabPatientsAndSales.TabIndex = 0;
            this.tabPatientsAndSales.Text = "Patients and Sales";
            // 
            // dateBirthday
            // 
            this.dateBirthday.Animated = true;
            this.dateBirthday.BorderColor = System.Drawing.Color.Transparent;
            this.dateBirthday.BorderRadius = 5;
            this.dateBirthday.BorderThickness = 1;
            this.dateBirthday.CheckedState.Parent = this.dateBirthday;
            this.dateBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateBirthday.FillColor = System.Drawing.Color.Blue;
            this.dateBirthday.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateBirthday.ForeColor = System.Drawing.Color.White;
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateBirthday.HoverState.BorderColor = System.Drawing.Color.White;
            this.dateBirthday.HoverState.FillColor = System.Drawing.Color.Blue;
            this.dateBirthday.HoverState.Parent = this.dateBirthday;
            this.dateBirthday.Location = new System.Drawing.Point(25, 17);
            this.dateBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.ShadowDecoration.Parent = this.dateBirthday;
            this.dateBirthday.Size = new System.Drawing.Size(314, 45);
            this.dateBirthday.TabIndex = 286;
            this.dateBirthday.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(341, 389);
            this.chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(371, 300);
            this.chartSales.TabIndex = 283;
            this.chartSales.Text = "chart6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 46);
            this.label6.TabIndex = 282;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 35);
            this.label7.TabIndex = 281;
            this.label7.Text = "Total Sales as of Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 46);
            this.label8.TabIndex = 280;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 35);
            this.label9.TabIndex = 279;
            this.label9.Text = "Total Sales as of Day:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 46);
            this.label10.TabIndex = 278;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 35);
            this.label11.TabIndex = 277;
            this.label11.Text = "Total Sales as of Month:";
            // 
            // chartPatients
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPatients.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPatients.Legends.Add(legend2);
            this.chartPatients.Location = new System.Drawing.Point(341, 74);
            this.chartPatients.Name = "chartPatients";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPatients.Series.Add(series2);
            this.chartPatients.Size = new System.Drawing.Size(371, 300);
            this.chartPatients.TabIndex = 274;
            this.chartPatients.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 46);
            this.label4.TabIndex = 273;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 35);
            this.label5.TabIndex = 272;
            this.label5.Text = "Total Patients as of Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 46);
            this.label2.TabIndex = 271;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 35);
            this.label3.TabIndex = 270;
            this.label3.Text = "Total Patients as of Day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 46);
            this.label1.TabIndex = 269;
            this.label1.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(19, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(307, 35);
            this.label20.TabIndex = 268;
            this.label20.Text = "Total Patients as of Month:";
            // 
            // tabInventory
            // 
            this.tabInventory.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabInventory.Controls.Add(this.rprtInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 4);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(1682, 950);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory";
            // 
            // rprtPatientsSales
            // 
            this.rprtPatientsSales.Location = new System.Drawing.Point(727, 74);
            this.rprtPatientsSales.Name = "rprtPatientsSales";
            this.rprtPatientsSales.Size = new System.Drawing.Size(683, 855);
            this.rprtPatientsSales.TabIndex = 287;
            // 
            // rprtInventory
            // 
            this.rprtInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rprtInventory.Location = new System.Drawing.Point(0, 0);
            this.rprtInventory.Name = "rprtInventory";
            this.rprtInventory.Size = new System.Drawing.Size(1682, 950);
            this.rprtInventory.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1830, 958);
            this.Controls.Add(this.tabControlReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.tabControlReport.ResumeLayout(false);
            this.tabPatientsAndSales.ResumeLayout(false);
            this.tabPatientsAndSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPatients)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControlReport;
        private System.Windows.Forms.TabPage tabPatientsAndSales;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPatients;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateBirthday;
        private Microsoft.Reporting.WinForms.ReportViewer rprtPatientsSales;
        private Microsoft.Reporting.WinForms.ReportViewer rprtInventory;
    }
}