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

        public void loadPatientUnpaid(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) AS 'Patient ID',
                                    CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR) AS 'First Name', 
                                    CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR) AS 'Middle Name',
                                    CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR) AS 'Last Name',
                                    payment_status AS 'Status' 
                                    FROM patient_information_db.patients 
                                    WHERE payment_status = 'Unpaid';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
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

        public void loadPatientPaymentHistory(string patient_id, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(receipt_no, 'jovencutegwapo123') AS CHAR) AS 'Receipt No.',
                                    total_medical_fee AS 'Total Medical Fee',
                                    CAST(AES_DECRYPT(discount, 'jovencutegwapo123') AS CHAR) AS 'Discount',
                                    amount AS 'Amount',
                                    total_amount_paid AS 'Total Amount Paid',
                                    `change` AS 'Change',
                                    DATE_FORMAT(date, '%M %d, %Y') AS 'Date'
                                    FROM patient_information_db.transactions
                                    WHERE CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
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

        public bool savePatientPayment(string patient_id, string receipt_no, double total_medical_fee, string discount, double amount, 
            double total_amount_paid, double change)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.transactions(patient_id, receipt_no, total_medical_fee, discount, amount, 
                                    total_amount_paid, `change`)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@receipt_no, 'jovencutegwapo123'), 
                                    @total_medical_fee,
                                    AES_ENCRYPT(@discount, 'jovencutegwapo123'),
                                    @amount,
                                    @total_amount_paid,
                                    @change
                                    );

                                    UPDATE patient_information_db.patients
                                    SET payment_status = 'Paid' 
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@receipt_no", receipt_no);
                        cmd.Parameters.AddWithValue("@total_medical_fee", total_medical_fee);
                        cmd.Parameters.AddWithValue("@discount", discount);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@total_amount_paid", total_amount_paid);
                        cmd.Parameters.AddWithValue("@change", change);

                        connection.Open();
                        cmd.ExecuteReader();

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

        public bool updatePaymentTransaction(string patient_id, string receipt_no, double total_medical_fee, string discount, double amount,
            double total_amount_paid, double change)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE patient_information_db.transactions
                                    SET
                                    receipt_no = AES_ENCRYPT(@receipt_no, 'jovencutegwapo123'),
                                    total_medical_fee = @total_medical_fee,
                                    discount = AES_ENCRYPT(@discount, 'jovencutegwapo123'),
                                    amount = @amount,
                                    total_amount_paid = @total_amount_paid,
                                    `change` = @change
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(receipt_no, 'jovencutegwapo123') AS CHAR) = @receipt_no OR
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@receipt_no", receipt_no);
                        cmd.Parameters.AddWithValue("@total_medical_fee", total_medical_fee);
                        cmd.Parameters.AddWithValue("@discount", discount);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@total_amount_paid", total_amount_paid);
                        cmd.Parameters.AddWithValue("@change", change);

                        connection.Open();
                        cmd.ExecuteReader();

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
    }
}
