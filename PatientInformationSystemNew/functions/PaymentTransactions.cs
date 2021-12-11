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
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Patient ID',
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'First Name', 
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Middle Name',
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Last Name',
                                    payment_status AS 'Status' 
                                    FROM pis_db.patients 
                                    WHERE
                                    status = 'Complete' AND
                                    payment_status = 'Unpaid';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading patients who are unpaid in payment transactions: " + ex.ToString());
            }
        }

        public void LoadPatientPaymentHistory(string full_name, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(transaction_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID',
                                    CAST(AES_DECRYPT(receipt_no, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Receipt No.',
                                    CAST(AES_DECRYPT(total_medical_fee, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Total Medical Fee',
                                    CAST(AES_DECRYPT(discount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Discount',
                                    CAST(AES_DECRYPT(amount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Amount',
                                    CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Total Amount Paid',
                                    CAST(AES_DECRYPT(`change`, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Change',
                                    CAST(AES_DECRYPT(cashier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Cashier',
                                    DATE_FORMAT(date, '%a, %d %b %Y') AS 'Date'
                                    FROM pis_db.transactions
                                    INNER JOIN pis_db.cashier ON pis_db.transactions.id = pis_db.cashier.id
                                    WHERE CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading patient payment history: " + ex.ToString());
            }
        }

        public bool SavePatientPayment(int id, int patient_fid, string transaction_id, string full_name, string receipt_no, string total_medical_fee, string discount, 
            string amount, string total_amount_paid, string change, string cashier)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.transactions(patient_fid, full_name, transaction_id, receipt_no, total_medical_fee, discount,
                                    amount, total_amount_paid, `change`)
                                    VALUES(
                                    @patient_fid,
                                    AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@transaction_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@receipt_no, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@total_medical_fee, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@discount, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@amount, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@change, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@transaction_id", transaction_id);
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

                    sql = @"SELECT *
                                FROM pis_db.transactions
                                ORDER BY id DESC LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.TransactionPrimaryID = dt.Rows[0].Field<int>("id");
                    }

                    sql = @"INSERT INTO pis_db.cashier(transaction_fid, cashier)
                            VALUES(
                            @transaction_fid,
                            AES_ENCRYPT(@cashier, 'j0v3ncut3gw4p0per0jok3l4ang')
                            );

                            UPDATE pis_db.patients
                            SET payment_status = 'Paid' 
                            WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@transaction_fid", val.TransactionPrimaryID);
                        cmd.Parameters.AddWithValue("@cashier", cashier);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

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

        public bool UpdatePaymentTransaction(string full_name, string transaction_id, string receipt_no, string total_medical_fee, 
            string discount, string amount, string total_amount_paid, string change, string update_id, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history(update_id, user, description)
                                    VALUES(
                                    AES_ENCRYPT(@update_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.transactions
                                    SET
                                    receipt_no = AES_ENCRYPT(@receipt_no, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    total_medical_fee = AES_ENCRYPT(@total_medical_fee, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    discount = AES_ENCRYPT(@discount, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    amount = AES_ENCRYPT(@amount, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    total_amount_paid = AES_ENCRYPT(@total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    `change` = AES_ENCRYPT(@change, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    CAST(AES_DECRYPT(transaction_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @transaction_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@transaction_id", transaction_id);
                        cmd.Parameters.AddWithValue("@receipt_no", receipt_no);
                        cmd.Parameters.AddWithValue("@total_medical_fee", total_medical_fee);
                        cmd.Parameters.AddWithValue("@discount", discount);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@total_amount_paid", total_amount_paid);
                        cmd.Parameters.AddWithValue("@change", change);
                        cmd.Parameters.AddWithValue("@update_id", update_id);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@description", description);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating patient payment: " + ex.ToString());
                return false;
            }
        }

        public bool GetPatientIDForPaymentTransaction(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.patients
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientPrimaryIDForPaymentTransaction = dt.Rows[0].Field<int>("id");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error getting id of patient for payment transaction: " + ex.ToString());
                return false;
            }
        }
    }
}
