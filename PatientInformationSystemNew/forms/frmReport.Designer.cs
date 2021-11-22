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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControlReport = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPatientsAndSales = new System.Windows.Forms.TabPage();
            this.lblOverallTotalSales = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOverallTotalPatients = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rprtPatientsSales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateReport = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalSalesInYear = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalSalesInDay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalSalesInMonth = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chartPatients = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalPatientsInYear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPatientsInDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPatientsInMonth = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabInventory = new System.Windows.Forms.TabPage();
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
            this.tabPatientsAndSales.Controls.Add(this.lblOverallTotalSales);
            this.tabPatientsAndSales.Controls.Add(this.label6);
            this.tabPatientsAndSales.Controls.Add(this.lblOverallTotalPatients);
            this.tabPatientsAndSales.Controls.Add(this.label2);
            this.tabPatientsAndSales.Controls.Add(this.rprtPatientsSales);
            this.tabPatientsAndSales.Controls.Add(this.dateReport);
            this.tabPatientsAndSales.Controls.Add(this.chartSales);
            this.tabPatientsAndSales.Controls.Add(this.lblTotalSalesInYear);
            this.tabPatientsAndSales.Controls.Add(this.label7);
            this.tabPatientsAndSales.Controls.Add(this.lblTotalSalesInDay);
            this.tabPatientsAndSales.Controls.Add(this.label9);
            this.tabPatientsAndSales.Controls.Add(this.lblTotalSalesInMonth);
            this.tabPatientsAndSales.Controls.Add(this.label11);
            this.tabPatientsAndSales.Controls.Add(this.chartPatients);
            this.tabPatientsAndSales.Controls.Add(this.lblTotalPatientsInYear);
            this.tabPatientsAndSales.Controls.Add(this.label5);
            this.tabPatientsAndSales.Controls.Add(this.lblTotalPatientsInDay);
            this.tabPatientsAndSales.Controls.Add(this.label3);
            this.tabPatientsAndSales.Controls.Add(this.lblTotalPatientsInMonth);
            this.tabPatientsAndSales.Controls.Add(this.label20);
            this.tabPatientsAndSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPatientsAndSales.Location = new System.Drawing.Point(4, 4);
            this.tabPatientsAndSales.Name = "tabPatientsAndSales";
            this.tabPatientsAndSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientsAndSales.Size = new System.Drawing.Size(1682, 950);
            this.tabPatientsAndSales.TabIndex = 0;
            this.tabPatientsAndSales.Text = "Patients and Sales";
            // 
            // lblOverallTotalSales
            // 
            this.lblOverallTotalSales.AutoSize = true;
            this.lblOverallTotalSales.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallTotalSales.ForeColor = System.Drawing.Color.White;
            this.lblOverallTotalSales.Location = new System.Drawing.Point(17, 883);
            this.lblOverallTotalSales.Name = "lblOverallTotalSales";
            this.lblOverallTotalSales.Size = new System.Drawing.Size(38, 46);
            this.lblOverallTotalSales.TabIndex = 291;
            this.lblOverallTotalSales.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 839);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 35);
            this.label6.TabIndex = 290;
            this.label6.Text = "Overall Total Sales:";
            // 
            // lblOverallTotalPatients
            // 
            this.lblOverallTotalPatients.AutoSize = true;
            this.lblOverallTotalPatients.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallTotalPatients.ForeColor = System.Drawing.Color.White;
            this.lblOverallTotalPatients.Location = new System.Drawing.Point(17, 415);
            this.lblOverallTotalPatients.Name = "lblOverallTotalPatients";
            this.lblOverallTotalPatients.Size = new System.Drawing.Size(38, 46);
            this.lblOverallTotalPatients.TabIndex = 289;
            this.lblOverallTotalPatients.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 35);
            this.label2.TabIndex = 288;
            this.label2.Text = "Overall Total Patients:";
            // 
            // rprtPatientsSales
            // 
            this.rprtPatientsSales.Location = new System.Drawing.Point(893, 74);
            this.rprtPatientsSales.Name = "rprtPatientsSales";
            this.rprtPatientsSales.Size = new System.Drawing.Size(683, 855);
            this.rprtPatientsSales.TabIndex = 287;
            // 
            // dateReport
            // 
            this.dateReport.Animated = true;
            this.dateReport.BorderColor = System.Drawing.Color.Transparent;
            this.dateReport.BorderRadius = 5;
            this.dateReport.BorderThickness = 1;
            this.dateReport.CheckedState.Parent = this.dateReport;
            this.dateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateReport.FillColor = System.Drawing.Color.Blue;
            this.dateReport.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateReport.ForeColor = System.Drawing.Color.White;
            this.dateReport.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateReport.HoverState.BorderColor = System.Drawing.Color.White;
            this.dateReport.HoverState.FillColor = System.Drawing.Color.Blue;
            this.dateReport.HoverState.Parent = this.dateReport;
            this.dateReport.Location = new System.Drawing.Point(25, 17);
            this.dateReport.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateReport.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateReport.Name = "dateReport";
            this.dateReport.ShadowDecoration.Parent = this.dateReport;
            this.dateReport.Size = new System.Drawing.Size(373, 45);
            this.dateReport.TabIndex = 286;
            this.dateReport.Value = new System.DateTime(2021, 10, 23, 0, 45, 31, 4);
            this.dateReport.ValueChanged += new System.EventHandler(this.dateReport_ValueChanged);
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            this.chartSales.Location = new System.Drawing.Point(390, 542);
            this.chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 11F);
            series1.Name = "Sales";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(488, 387);
            this.chartSales.TabIndex = 283;
            this.chartSales.Text = "chart6";
            title1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            title1.Name = "chartSales";
            title1.Text = "Sales Chart";
            this.chartSales.Titles.Add(title1);
            // 
            // lblTotalSalesInYear
            // 
            this.lblTotalSalesInYear.AutoSize = true;
            this.lblTotalSalesInYear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesInYear.ForeColor = System.Drawing.Color.White;
            this.lblTotalSalesInYear.Location = new System.Drawing.Point(17, 784);
            this.lblTotalSalesInYear.Name = "lblTotalSalesInYear";
            this.lblTotalSalesInYear.Size = new System.Drawing.Size(38, 46);
            this.lblTotalSalesInYear.TabIndex = 282;
            this.lblTotalSalesInYear.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 740);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 35);
            this.label7.TabIndex = 281;
            this.label7.Text = "Total Sales in Year:";
            // 
            // lblTotalSalesInDay
            // 
            this.lblTotalSalesInDay.AutoSize = true;
            this.lblTotalSalesInDay.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesInDay.ForeColor = System.Drawing.Color.White;
            this.lblTotalSalesInDay.Location = new System.Drawing.Point(17, 685);
            this.lblTotalSalesInDay.Name = "lblTotalSalesInDay";
            this.lblTotalSalesInDay.Size = new System.Drawing.Size(38, 46);
            this.lblTotalSalesInDay.TabIndex = 280;
            this.lblTotalSalesInDay.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 641);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 35);
            this.label9.TabIndex = 279;
            this.label9.Text = "Total Sales in Day:";
            // 
            // lblTotalSalesInMonth
            // 
            this.lblTotalSalesInMonth.AutoSize = true;
            this.lblTotalSalesInMonth.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesInMonth.ForeColor = System.Drawing.Color.White;
            this.lblTotalSalesInMonth.Location = new System.Drawing.Point(17, 586);
            this.lblTotalSalesInMonth.Name = "lblTotalSalesInMonth";
            this.lblTotalSalesInMonth.Size = new System.Drawing.Size(38, 46);
            this.lblTotalSalesInMonth.TabIndex = 278;
            this.lblTotalSalesInMonth.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 542);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 35);
            this.label11.TabIndex = 277;
            this.label11.Text = "Total Sales in Month:";
            // 
            // chartPatients
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPatients.ChartAreas.Add(chartArea2);
            this.chartPatients.Location = new System.Drawing.Point(390, 74);
            this.chartPatients.Name = "chartPatients";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Patients";
            this.chartPatients.Series.Add(series2);
            this.chartPatients.Size = new System.Drawing.Size(488, 387);
            this.chartPatients.TabIndex = 274;
            this.chartPatients.Text = "chart1";
            title2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            title2.Name = "chartPatients";
            title2.Text = "Patients Chart";
            this.chartPatients.Titles.Add(title2);
            // 
            // lblTotalPatientsInYear
            // 
            this.lblTotalPatientsInYear.AutoSize = true;
            this.lblTotalPatientsInYear.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatientsInYear.ForeColor = System.Drawing.Color.White;
            this.lblTotalPatientsInYear.Location = new System.Drawing.Point(17, 316);
            this.lblTotalPatientsInYear.Name = "lblTotalPatientsInYear";
            this.lblTotalPatientsInYear.Size = new System.Drawing.Size(38, 46);
            this.lblTotalPatientsInYear.TabIndex = 273;
            this.lblTotalPatientsInYear.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 35);
            this.label5.TabIndex = 272;
            this.label5.Text = "Total Patients in Year:";
            // 
            // lblTotalPatientsInDay
            // 
            this.lblTotalPatientsInDay.AutoSize = true;
            this.lblTotalPatientsInDay.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatientsInDay.ForeColor = System.Drawing.Color.White;
            this.lblTotalPatientsInDay.Location = new System.Drawing.Point(17, 217);
            this.lblTotalPatientsInDay.Name = "lblTotalPatientsInDay";
            this.lblTotalPatientsInDay.Size = new System.Drawing.Size(38, 46);
            this.lblTotalPatientsInDay.TabIndex = 271;
            this.lblTotalPatientsInDay.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 35);
            this.label3.TabIndex = 270;
            this.label3.Text = "Total Patients in Day:";
            // 
            // lblTotalPatientsInMonth
            // 
            this.lblTotalPatientsInMonth.AutoSize = true;
            this.lblTotalPatientsInMonth.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPatientsInMonth.ForeColor = System.Drawing.Color.White;
            this.lblTotalPatientsInMonth.Location = new System.Drawing.Point(17, 118);
            this.lblTotalPatientsInMonth.Name = "lblTotalPatientsInMonth";
            this.lblTotalPatientsInMonth.Size = new System.Drawing.Size(38, 46);
            this.lblTotalPatientsInMonth.TabIndex = 269;
            this.lblTotalPatientsInMonth.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(19, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(273, 35);
            this.label20.TabIndex = 268;
            this.label20.Text = "Total Patients in Month:";
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
        private System.Windows.Forms.Label lblTotalPatientsInMonth;
        private System.Windows.Forms.Label lblTotalPatientsInYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPatientsInDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPatients;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Label lblTotalSalesInYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalSalesInDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalSalesInMonth;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateReport;
        private Microsoft.Reporting.WinForms.ReportViewer rprtPatientsSales;
        private Microsoft.Reporting.WinForms.ReportViewer rprtInventory;
        private System.Windows.Forms.Label lblOverallTotalSales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOverallTotalPatients;
        private System.Windows.Forms.Label label2;
    }
}