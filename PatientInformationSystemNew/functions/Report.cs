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

        public void countTotalPatientsInMonth(string month, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM pis_db.number_of_patients
                                    WHERE
                                    DATE_FORMAT(date, '%M') = @month AND
                                    DATE_FORMAT(date, '%Y') = @year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        connection.Open();
                        val.CountTotalPatientsInMonth = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error counting total patients in month: " + ex.ToString());
            }
        }

        public void countTotalPatientsInDay(string month, string day, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM pis_db.number_of_patients
                                    WHERE
                                    DATE_FORMAT(date, '%M') = @month AND
                                    DATE_FORMAT(date, '%d') = @day AND
                                    DATE_FORMAT(date, '%Y') = @year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@year", year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        connection.Open();
                        val.CountTotalPatientsInDay = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error counting total patients in day: " + ex.ToString());
            }
        }

        public void countTotalPatientsInYear(string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM pis_db.number_of_patients
                                    WHERE
                                    DATE_FORMAT(date, '%Y') = @year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {;
                        cmd.Parameters.AddWithValue("@year", year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        connection.Open();
                        val.CountTotalPatientsInYear = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting total patients in year: " + ex.ToString());
            }
        }

        public void countOverallTotalPatients()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT COUNT(*)
                                    FROM pis_db.number_of_patients;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        connection.Open();
                        val.CountOverallTotalPatients = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting overall total patients: " + ex.ToString());
            }
        }

        public void countTotalSalesInMonth(string month, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT SUM(CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR))
                                    FROM pis_db.payment_transactions
                                    WHERE
                                    DATE_FORMAT(date, '%M') = @month AND
                                    DATE_FORMAT(date, '%Y') = @year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        connection.Open();
                        val.CountTotalSalesInMonth = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error counting total sales in month: " + ex.ToString());
            }
        }

        public void countTotalSalesInDay(string month, string day, string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT SUM(CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR))
                                    FROM pis_db.payment_transactions
                                    WHERE
                                    DATE_FORMAT(date, '%M') = @month AND
                                    DATE_FORMAT(date, '%d') = @day AND
                                    DATE_FORMAT(date, '%Y') = @year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@year", year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        connection.Open();
                        val.CountTotalSalesInDay = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting total sales in day: " + ex.ToString());
            }
        }
        public void countTotalSalesInYear(string year)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT SUM(CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR))
                                    FROM pis_db.payment_transactions
                                    WHERE
                                    DATE_FORMAT(date, '%Y') = @year;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@year", year);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        connection.Open();
                        val.CountTotalSalesInYear = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error counting total sales in year: " + ex.ToString());
            }
        }

        public void countOverallTotalSales()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT SUM(CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR))
                                    FROM pis_db.payment_transactions;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        connection.Open();
                        val.CountOverallTotalSales = cmd.ExecuteScalar().ToString();
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
