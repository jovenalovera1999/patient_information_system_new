using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace PatientInformationSystemNew.forms
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.Report report = new functions.Report();

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.dateReport.Value = DateTime.Now.Date;

            report.countTotalPatientsInMonth(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("yyyy"));
            report.countTotalPatientsInDay(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("dd"), 
                this.dateReport.Value.ToString("yyyy"));
            report.countTotalPatientsInYear(this.dateReport.Value.ToString("yyyy"));
            report.countOverallTotalPatients();

            report.countTotalSalesInMonth(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("yyyy"));
            report.countTotalSalesInDay(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("dd"),
                this.dateReport.Value.ToString("yyyy"));
            report.countTotalSalesInYear(this.dateReport.Value.ToString("yyyy"));
            report.countOverallTotalSales();
            
            this.lblTotalPatientsInMonth.Text = val.CountTotalPatientsInMonth;
            this.lblTotalPatientsInDay.Text = val.CountTotalPatientsInDay;
            this.lblTotalPatientsInYear.Text = val.CountTotalPatientsInYear;
            this.lblOverallTotalPatients.Text = val.CountOverallTotalPatients;

            this.lblTotalSalesInMonth.Text = val.CountTotalSalesInMonth;
            this.lblTotalSalesInDay.Text = val.CountTotalSalesInDay;
            this.lblTotalSalesInYear.Text = val.CountTotalSalesInYear;
            this.lblOverallTotalSales.Text = val.CountOverallTotalSales;

            if(String.IsNullOrWhiteSpace(this.lblTotalSalesInMonth.Text))
            {
                this.lblTotalSalesInMonth.Text = "0";
            }
            if(String.IsNullOrWhiteSpace(this.lblTotalSalesInDay.Text))
            {
                this.lblTotalSalesInDay.Text = "0";
            }
            if(String.IsNullOrWhiteSpace(this.lblTotalSalesInYear.Text))
            {
                this.lblTotalSalesInYear.Text = "0";
            }
            if(String.IsNullOrWhiteSpace(this.lblOverallTotalSales.Text))
            {
                this.lblOverallTotalSales.Text = "0";
            }
        }

        private void dateReport_ValueChanged(object sender, EventArgs e)
        {
            report.countTotalPatientsInMonth(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("yyyy"));
            report.countTotalPatientsInDay(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("dd"), 
                this.dateReport.Value.ToString("yyyy"));
            report.countTotalPatientsInYear(this.dateReport.Value.ToString("yyyy"));
            report.countOverallTotalPatients();

            report.countTotalSalesInMonth(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("yyyy"));
            report.countTotalSalesInDay(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("dd"),
                this.dateReport.Value.ToString("yyyy"));
            report.countTotalSalesInYear(this.dateReport.Value.ToString("yyyy"));
            report.countOverallTotalSales();

            this.lblTotalPatientsInMonth.Text = val.CountTotalPatientsInMonth;
            this.lblTotalPatientsInDay.Text = val.CountTotalPatientsInDay;
            this.lblTotalPatientsInYear.Text = val.CountTotalPatientsInYear;
            this.lblOverallTotalPatients.Text = val.CountOverallTotalPatients;

            this.lblTotalSalesInMonth.Text = val.CountTotalSalesInMonth;
            this.lblTotalSalesInDay.Text = val.CountTotalSalesInDay;
            this.lblTotalSalesInYear.Text = val.CountTotalSalesInYear;
            this.lblOverallTotalSales.Text = val.CountOverallTotalSales;

            if (String.IsNullOrWhiteSpace(this.lblTotalSalesInMonth.Text))
            {
                this.lblTotalSalesInMonth.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.lblTotalSalesInDay.Text))
            {
                this.lblTotalSalesInDay.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(this.lblTotalSalesInYear.Text))
            {
                this.lblTotalSalesInYear.Text = "0";
            }
            if(String.IsNullOrWhiteSpace(this.lblOverallTotalSales.Text))
            {
                this.lblOverallTotalSales.Text = "0";
            }

            foreach(var series in this.chartPatients.Series)
            {
                series.Points.Clear();
            }
            foreach(var series in this.chartSales.Series)
            {
                series.Points.Clear();
            }

            this.chartPatients.Series[0].Points.AddXY("Month", this.lblTotalPatientsInMonth.Text);
            this.chartPatients.Series[0].Points.AddXY("Day", this.lblTotalPatientsInDay.Text);
            this.chartPatients.Series[0].Points.AddXY("Year", this.lblTotalPatientsInYear.Text);
            this.chartPatients.Series[0].Points.AddXY("Overall", this.lblOverallTotalPatients.Text);

            this.chartSales.Series[0].Points.AddXY("Month", this.lblTotalSalesInMonth.Text);
            this.chartSales.Series[0].Points.AddXY("Day", this.lblTotalSalesInDay.Text);
            this.chartSales.Series[0].Points.AddXY("Year", this.lblTotalSalesInYear.Text);
            this.chartSales.Series[0].Points.AddXY("Overall", this.lblOverallTotalSales.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.rprtPatientsSales.Clear();
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pDateReviewed", DateTime.Now.ToString("D")));
            parameters.Add(new ReportParameter("pReviewedBy", val.UserFullName));
            parameters.Add(new ReportParameter("pRole", val.UserRole));
            parameters.Add(new ReportParameter("pSelectedDate", this.dateReport.Value.ToString("D")));
            parameters.Add(new ReportParameter("pTotalPatientsInMonth", this.lblTotalPatientsInMonth.Text));
            parameters.Add(new ReportParameter("pTotalPatientsInDay", this.lblTotalPatientsInDay.Text));
            parameters.Add(new ReportParameter("pTotalPatientsInYear", this.lblTotalPatientsInYear.Text));
            parameters.Add(new ReportParameter("pOverallTotalPatients", this.lblOverallTotalPatients.Text));
            parameters.Add(new ReportParameter("pTotalSalesInMonth", this.lblTotalSalesInMonth.Text));
            parameters.Add(new ReportParameter("pTotalSalesInDay", this.lblTotalSalesInDay.Text));
            parameters.Add(new ReportParameter("pTotalSalesInYear", this.lblTotalSalesInYear.Text));
            parameters.Add(new ReportParameter("pOverallTotalSales", this.lblOverallTotalSales.Text));
            this.rprtPatientsSales.LocalReport.SetParameters(parameters);
            this.rprtPatientsSales.RefreshReport();
        }
    }
}
