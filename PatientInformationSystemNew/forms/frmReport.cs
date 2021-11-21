using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
