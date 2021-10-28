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
                                    WHERE payment_status = 'Unpaid' 
                                    ORDER BY first_name DESC;";

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
    }
}
