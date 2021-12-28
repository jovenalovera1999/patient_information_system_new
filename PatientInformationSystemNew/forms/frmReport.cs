using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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

        void LoadInventoryReport()
        {
            using(MySqlConnection connection = new MySqlConnection(con.conString()))
            {
                string sql = @"SELECT
                               CAST(AES_DECRYPT(supply_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'supply_id',
                               CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'supply_name',
                               CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'quantity',
                               DATE_FORMAT(expiration_date, '%Y/%m/%d') AS 'expiration_date'
                               FROM pis_db.inventory
                               WHERE status = 'Show'
                               ORDER BY CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) ASC;";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);

                    this.rprtInventory.LocalReport.DataSources.Clear();
                    ReportDataSource source = new ReportDataSource("DataSet1", dt);
                    this.rprtInventory.LocalReport.DataSources.Add(source);
                    this.rprtInventory.RefreshReport();
                }
            }
        }

        void CountPatients()
        {
            report.countTotalPatientsInMonth(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("yyyy"));
            report.countTotalPatientsInDay(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("dd"),
                this.dateReport.Value.ToString("yyyy"));
            report.countTotalPatientsInYear(this.dateReport.Value.ToString("yyyy"));
            report.countOverallTotalPatients();

            this.lblTotalPatientsInMonth.Text = val.CountTotalPatientsInMonth;
            this.lblTotalPatientsInDay.Text = val.CountTotalPatientsInDay;
            this.lblTotalPatientsInYear.Text = val.CountTotalPatientsInYear;
            this.lblOverallTotalPatients.Text = val.CountOverallTotalPatients;

        }

        void CountSales()
        {
            report.countTotalSalesInMonth(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("yyyy"));
            report.countTotalSalesInDay(this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("dd"),
                this.dateReport.Value.ToString("yyyy"));
            report.countTotalSalesInYear(this.dateReport.Value.ToString("yyyy"));
            report.countOverallTotalSales();

            this.lblTotalSalesInMonth.Text = val.CountTotalSalesInMonth;
            this.lblTotalSalesInDay.Text = val.CountTotalSalesInDay;
            this.lblTotalSalesInYear.Text = val.CountTotalSalesInYear;
            this.lblOverallTotalSales.Text = val.CountOverallTotalSales;
        }

        void LoadNullSales()
        {
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
            if (String.IsNullOrWhiteSpace(this.lblOverallTotalSales.Text))
            {
                this.lblOverallTotalSales.Text = "0";
            }
        }

        void SeriesPointsClear()
        {
            foreach (var series in this.chartPatients.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in this.chartSales.Series)
            {
                series.Points.Clear();
            }
        }

        void FormLoad()
        {
            this.dateReport.Value = DateTime.Now.Date;
            CountPatients();
            CountSales();
            LoadNullSales();
            LoadInventoryReport();
        }

        void LoadSeriesPoints()
        {
            this.chartPatients.Series[0].Points.AddXY("Month", this.lblTotalPatientsInMonth.Text);
            this.chartPatients.Series[0].Points.AddXY("Day", this.lblTotalPatientsInDay.Text);
            this.chartPatients.Series[0].Points.AddXY("Year", this.lblTotalPatientsInYear.Text);
            this.chartPatients.Series[0].Points.AddXY("Overall", this.lblOverallTotalPatients.Text);

            this.chartSales.Series[0].Points.AddXY("Month", this.lblTotalSalesInMonth.Text);
            this.chartSales.Series[0].Points.AddXY("Day", this.lblTotalSalesInDay.Text);
            this.chartSales.Series[0].Points.AddXY("Year", this.lblTotalSalesInYear.Text);
            this.chartSales.Series[0].Points.AddXY("Overall", this.lblOverallTotalSales.Text);
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void dateReport_ValueChanged(object sender, EventArgs e)
        {
            CountPatients();
            CountSales();
            SeriesPointsClear();
            LoadSeriesPoints();
        }
    }
}
