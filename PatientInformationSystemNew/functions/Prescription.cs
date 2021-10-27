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
    class Prescription
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void loadPrescriptionRecordsOfPatient(string patient_id, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(prescription_id, 'jovencutegwapo123') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(prescriptions, 'jovencutegwapo123') AS CHAR) AS 'Prescriptions',
                                    date AS 'Date' 
                                    FROM patient_information_db.prescriptions
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
                Console.WriteLine("Error loading prescription records of patient: " + ex.ToString());
            }
        }

        public void loadPrescriptionRecordsOfPatientByDate(string patient_id, DateTime date, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(prescription_id, 'jovencutegwapo123') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(prescriptions, 'jovencutegwapo123') AS CHAR) AS 'Prescription', 
                                    date AS 'Date' 
                                    FROM patient_information_db.prescriptions 
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND 
                                    date = @date;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@date", date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading prescription records of patient by date: " + ex.ToString());
            }
        }
    }
}
