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
    class PaymentTransactions
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void LoadPatientUnpaid(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_patient_unpaid();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading patients who are unpaid in payment transactions: " + ex.ToString());
            }
        }

        public void LoadPaymentHistory(int patient_fid, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_payment_history(@patient_fid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(receipt_no, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Receipt No.";
                        grid.Columns["CAST(AES_DECRYPT(total_medical_fee, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Total Medical Fee";
                        grid.Columns["CAST(AES_DECRYPT(discount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Discount";
                        grid.Columns["CAST(AES_DECRYPT(amount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Amount";
                        grid.Columns["CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Total Amount Paid";
                        grid.Columns["CAST(AES_DECRYPT(`change`, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Change";
                        grid.Columns["CAST(AES_DECRYPT(cashier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Cashier";
                        grid.Columns["DATE_FORMAT(pis_db.payment_transactions.date, '%Y/%m/%d')"].HeaderText = "Date";

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading payment history: " + ex.ToString());
            }
        }

        public bool SavePatientPayment(int id, int patient_fid, string receipt_no, string total_medical_fee, string discount, string amount,
            string total_amount_paid, string change, string cashier)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL save_payment(@patient_fid, @receipt_no, @total_medical_fee, @discount, @amount, @total_amount_paid, @change);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@receipt_no", receipt_no);
                        cmd.Parameters.AddWithValue("@total_medical_fee", total_medical_fee);
                        cmd.Parameters.AddWithValue("@discount", discount);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@total_amount_paid", total_amount_paid);
                        cmd.Parameters.AddWithValue("@change", change);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"CALL get_payment_transaction_primary_id();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.TransactionPrimaryID = dt.Rows[0].Field<int>("id");
                    }

                    sql = @"CALL save_cashier_and_update_payment_status(@id, @transaction_fid, @cashier);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@transaction_fid", val.TransactionPrimaryID);
                        cmd.Parameters.AddWithValue("@cashier", cashier);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error saving payment transaction: " + ex.ToString());
                return false;
            }
        }

        public bool UpdatePaymentTransaction(int id, string receipt_no, string total_medical_fee, string discount, string amount,
            string total_amount_paid, string change, string user, string patient, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL update_payment_transaction(@id, @receipt_no, @total_medical_fee, @discount, @amount, @total_amount_paid, @change, @user, @patient, @description);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@receipt_no", receipt_no);
                        cmd.Parameters.AddWithValue("@total_medical_fee", total_medical_fee);
                        cmd.Parameters.AddWithValue("@discount", discount);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@total_amount_paid", total_amount_paid);
                        cmd.Parameters.AddWithValue("@change", change);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@patient", patient);
                        cmd.Parameters.AddWithValue("@description", description);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating payment transaction: " + ex.ToString());
                return false;
            }
        }
    }
}
