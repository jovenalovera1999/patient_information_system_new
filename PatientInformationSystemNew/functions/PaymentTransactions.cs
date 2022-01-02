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
                                    pis_db.patients.id,
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.patients
                                    INNER JOIN pis_db.patient_doctor ON pis_db.patients.id = pis_db.patient_doctor.id
                                    WHERE
                                    CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete' AND
                                    CAST(AES_DECRYPT(payment_status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Unpaid';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Doctor";
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
                    string sql = @"SELECT
                                    pis_db.payment_transactions.id,
                                    CAST(AES_DECRYPT(receipt_no, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(total_medical_fee, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(discount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(amount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(`change`, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(cashier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    DATE_FORMAT(pis_db.payment_transactions.date, '%Y/%m/%d')
                                    FROM pis_db.payment_transactions
                                    INNER JOIN pis_db.cashier ON pis_db.payment_transactions.id = pis_db.cashier.id
                                    WHERE patient_fid = @patient_fid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(receipt_no, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Receipt No.";
                        grid.Columns["CAST(AES_DECRYPT(total_medical_fee, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Total Medical Fee";
                        grid.Columns["CAST(AES_DECRYPT(discount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Discount";
                        grid.Columns["CAST(AES_DECRYPT(amount, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Amount";
                        grid.Columns["CAST(AES_DECRYPT(total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Total Amount Paid";
                        grid.Columns["CAST(AES_DECRYPT(`change`, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Change";
                        grid.Columns["CAST(AES_DECRYPT(cashier, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Cashier";
                        grid.Columns["DATE_FORMAT(pis_db.payment_transactions.date, '%Y/%m/%d')"].HeaderText = "Date";
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
                    string sql = @"INSERT INTO pis_db.payment_transactions(patient_fid, receipt_no, total_medical_fee, discount, amount,
                                    total_amount_paid, `change`)
                                    VALUES(
                                    @patient_fid,
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
                            FROM pis_db.payment_transactions
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

        public bool UpdatePaymentTransaction(int id, string receipt_no, string total_medical_fee, string discount, string amount,
            string total_amount_paid, string change, string user, string patient, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_payment_transactions(user, patient, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@patient, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.payment_transactions
                                    SET
                                    receipt_no = AES_ENCRYPT(@receipt_no, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    total_medical_fee = AES_ENCRYPT(@total_medical_fee, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    discount = AES_ENCRYPT(@discount, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    amount = AES_ENCRYPT(@amount, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    total_amount_paid = AES_ENCRYPT(@total_amount_paid, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    `change` = AES_ENCRYPT(@change, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE id = @id;";

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
