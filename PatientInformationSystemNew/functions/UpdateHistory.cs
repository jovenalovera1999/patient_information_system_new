using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PatientInformationSystemNew.functions
{
    class UpdateHistory
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void LoadPatientsUpdates(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_patient_updates();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Edited By";
                        grid.Columns["CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient";
                        grid.Columns["CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Description";
                        grid.Columns["CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))"].HeaderText = "Date and Time";

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading patients update history: " + ex.ToString());
            }
        }

        public void LoadVitalSignsUpdates(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_vital_signs_updates();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Edited By";
                        grid.Columns["CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient";
                        grid.Columns["CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Description";
                        grid.Columns["CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))"].HeaderText = "Date and Time";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading vital signs update history: " + ex.ToString());
            }
        }

        public void LoadDiagnosisUpdates(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_diagnosis_updates();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Edited By";
                        grid.Columns["CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient";
                        grid.Columns["CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Description";
                        grid.Columns["CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))"].HeaderText = "Date and Time";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading diagnosis update history: " + ex.ToString());
            }
        }

        public void LoadSymptomsUpdates(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_symptoms_update();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Edited By";
                        grid.Columns["CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient";
                        grid.Columns["CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Description";
                        grid.Columns["CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))"].HeaderText = "Date and Time";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading symptoms update history: " + ex.ToString());
            }
        }

        public void LoadPrescriptionsUpdates(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_prescriptions_updates();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Edited By";
                        grid.Columns["CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient";
                        grid.Columns["CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Description";
                        grid.Columns["CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))"].HeaderText = "Date and Time";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading prescriptions update history: " + ex.ToString());
            }
        }

        public void LoadPaymentTransactionsUpdates(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_payment_transaction_updates();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Edited By";
                        grid.Columns["CAST(AES_DECRYPT(patient, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient";
                        grid.Columns["CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Description";
                        grid.Columns["CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))"].HeaderText = "Date and Time";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading payment transactions update history: " + ex.ToString());
            }
        }

        public void LoadInventoryUpdates(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_inventory_updates();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Edited By";
                        grid.Columns["CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Description";
                        grid.Columns["CONCAT(DATE_FORMAT(date, '%Y/%m/%d'), ' ', TIME_FORMAT(date, '%h:%i %p'))"].HeaderText = "Date and Time";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading payment transactions update history: " + ex.ToString());
            }
        }
    }
}
