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
        functions.Doctor doctor = new functions.Doctor();

        void LoadDoctors()
        {
            string sql = @"CALL load_select_doctors();";

            MySqlConnection connection = new MySqlConnection(con.conString());
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader myReader;

            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string doctors_name = myReader.GetString("CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ')')");
                    this.cmbDoctorName.Items.Add(doctors_name);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error filling doctors name: " + ex.ToString());
            }
        }

        void LoadInventoryReport()
        {
            using (MySqlConnection connection = new MySqlConnection(con.conString()))
            {
                string sql = @"CALL load_inventory_report();";

                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);

                    this.rprtInventory.LocalReport.DataSources.Clear();
                    ReportDataSource source = new ReportDataSource("DataSet1", dt);
                    this.rprtInventory.LocalReport.DataSources.Add(source);
                    this.rprtInventory.RefreshReport();
                    connection.Close();
                }
            }
        }

        void CountPatients()
        {
            doctor.GetDoctorPrimaryID(this.cmbDoctorName.Text);

            report.countTotalPatientsInMonth(val.DoctorPrimaryID, this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("yyyy"));
            report.countTotalPatientsInDay(val.DoctorPrimaryID, this.dateReport.Value.ToString("MMMM"), this.dateReport.Value.ToString("dd"),
                this.dateReport.Value.ToString("yyyy"));
            report.countTotalPatientsInYear(val.DoctorPrimaryID, this.dateReport.Value.ToString("yyyy"));
            report.countOverallTotalPatients(val.DoctorPrimaryID);

            this.lblTotalPatientsInMonth.Text = val.CountTotalPatientsInMonth;
            this.lblTotalPatientsInDay.Text = val.CountTotalPatientsInDay;
            this.lblTotalPatientsInYear.Text = val.CountTotalPatientsInYear;
            this.lblOverallTotalPatients.Text = val.CountOverallTotalPatients;

        }

        void CountSales()
        {
            doctor.GetDoctorPrimaryID(this.cmbDoctorName.Text);

            report.countTotalSalesInMonth(val.DoctorPrimaryID, this.dateReport.Value.ToString("MM"), this.dateReport.Value.ToString("yy"));
            report.countTotalSalesInDay(val.DoctorPrimaryID, this.dateReport.Value.ToString("MM"), this.dateReport.Value.ToString("dd"),
                this.dateReport.Value.ToString("yy"));
            report.countTotalSalesInYear(val.DoctorPrimaryID, this.dateReport.Value.ToString("yy"));
            report.countOverallTotalSales(val.DoctorPrimaryID);

            this.lblTotalSalesInMonth.Text = val.CountTotalSalesInMonth;
            this.lblTotalSalesInDay.Text = val.CountTotalSalesInDay;
            this.lblTotalSalesInYear.Text = val.CountTotalSalesInYear;
            this.lblOverallTotalSales.Text = val.CountOverallTotalSales;

            if (String.IsNullOrWhiteSpace(this.lblTotalSalesInMonth.Text))
            {
                this.lblTotalSalesInMonth.Text = "0.00";
            }
            if (String.IsNullOrWhiteSpace(this.lblTotalSalesInDay.Text))
            {
                this.lblTotalSalesInDay.Text = "0.00";
            }
            if (String.IsNullOrWhiteSpace(this.lblTotalSalesInYear.Text))
            {
                this.lblTotalSalesInYear.Text = "0.00";
            }
            if (String.IsNullOrWhiteSpace(this.lblOverallTotalSales.Text))
            {
                this.lblOverallTotalSales.Text = "0.00";
            }
        }

        void LoadCharts()
        {
            foreach (var series in this.chartPatients.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in this.chartSales.Series)
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

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.dateReport.Value = DateTime.Now.Date;
            LoadDoctors();
            LoadInventoryReport();
        }

        private void cmbDoctorName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountPatients();
            CountSales();
            LoadCharts();
        }

        private void dateReport_ValueChanged(object sender, EventArgs e)
        {
            CountPatients();
            CountSales();
            LoadCharts();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("pDateReviewed", DateTime.Now.ToString("D")));
            parameters.Add(new ReportParameter("pTotalPatientsInMonth", this.lblTotalPatientsInMonth.Text.ToString()));
            parameters.Add(new ReportParameter("pTotalPatientsInDay", this.lblTotalPatientsInDay.Text.ToString()));
            parameters.Add(new ReportParameter("pTotalPatientsInYear", this.lblTotalPatientsInYear.Text.ToString()));
            parameters.Add(new ReportParameter("pOverallTotalPatients", this.lblOverallTotalPatients.Text.ToString()));
            parameters.Add(new ReportParameter("pTotalSalesInMonth", this.lblTotalSalesInMonth.Text.ToString()));
            parameters.Add(new ReportParameter("pTotalSalesInDay", this.lblTotalSalesInMonth.Text.ToString()));
            parameters.Add(new ReportParameter("pTotalSalesInYear", this.lblTotalSalesInMonth.Text.ToString()));
            parameters.Add(new ReportParameter("pOverallTotalSales", this.lblOverallTotalSales.Text.ToString()));
            this.rprtPatientsSales.LocalReport.SetParameters(parameters);
            this.rprtPatientsSales.RefreshReport();
        }
    }
}
