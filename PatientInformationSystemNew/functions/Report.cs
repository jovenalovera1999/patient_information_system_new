using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PatientInformationSystemNew.functions
{
    class Report
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void countTotalPatientsInMonth(int doctor_fid, string month, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL count_total_patients_in_month(@doctor_fid, @month, @year);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.CountTotalPatientsInMonth = cmd.ExecuteScalar().ToString();
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error counting total patients in month: " + ex.ToString());
            }
        }

        public void countTotalPatientsInDay(int doctor_fid, string month, string day, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL count_total_patients_in_day(@doctor_fid, @month, @day, @year);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@year", year);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.CountTotalPatientsInDay = cmd.ExecuteScalar().ToString();
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error counting total patients in day: " + ex.ToString());
            }
        }

        public void countTotalPatientsInYear(int doctor_fid, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL count_total_patients_in_year(@doctor_fid, @year);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);
                        cmd.Parameters.AddWithValue("@year", year);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.CountTotalPatientsInYear = cmd.ExecuteScalar().ToString();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting total patients in year: " + ex.ToString());
            }
        }

        public void countOverallTotalPatients(int doctor_fid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL count_overall_total_patients(@doctor_fid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.CountOverallTotalPatients = cmd.ExecuteScalar().ToString();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting overall total patients: " + ex.ToString());
            }
        }

        public void countTotalSalesInMonth(int doctor_fid, string month, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL count_total_sales_in_month(@doctor_fid, @month, @year);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.CountTotalSalesInMonth = cmd.ExecuteScalar().ToString();
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error counting total sales in month: " + ex.ToString());
            }
        }

        public void countTotalSalesInDay(int doctor_fid, string month, string day, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL count_total_sales_in_day(@doctor_fid, @month, @day, @year);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@year", year);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.CountTotalSalesInDay = cmd.ExecuteScalar().ToString();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting total sales in day: " + ex.ToString());
            }
        }
        public void countTotalSalesInYear(int doctor_fid, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL count_total_sales_in_year(@doctor_fid, @year);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);
                        cmd.Parameters.AddWithValue("@year", year);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.CountTotalSalesInYear = cmd.ExecuteScalar().ToString();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting total sales in year: " + ex.ToString());
            }
        }

        public void countOverallTotalSales(int doctor_fid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL count_overall_total_sales(@doctor_fid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.CountOverallTotalSales = cmd.ExecuteScalar().ToString();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting overall total sales: " + ex.ToString());
            }
        }
    }
}
