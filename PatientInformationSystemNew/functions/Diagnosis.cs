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
    class Diagnosis
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void loadDiagnosisRecordsOfPatient(string patient_id, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(diagnosis_id, 'jovencutegwapo123') AS CHAR) AS 'ID',
                                    CAST(AES_DECRYPT(diagnosis, 'jovencutegwapo123') AS CHAR) AS 'Diagnosis', 
                                    DATE_FORMAT(date, '%M %d, %Y') AS 'Date'
                                    FROM patient_information_db.diagnosis 
                                    WHERE CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id
                                    ORDER BY date ASC;";

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
                Console.WriteLine("Error loading diagnosis records of patient: " + ex.ToString());
            }
        }

        public bool addDiagnosis(string patient_id, string diagnosis_id, string diagnosis, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.diagnosis(patient_id, diagnosis_id, diagnosis, date)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@diagnosis_id, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@diagnosis, 'jovencutegwapo123'),
                                    @date
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@diagnosis_id", diagnosis_id);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding a diagnosis: " + ex.ToString());
                return false;
            }
        }

        public bool updateDiagnosis(string patient_id, string diagnosis_id, string diagnosis, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE patient_information_db.diagnosis 
                                    SET 
                                    diagnosis = AES_ENCRYPT(@diagnosis, 'jovencutegwapo123'),
                                    date = @date
                                    WHERE   
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND 
                                    CAST(AES_DECRYPT(diagnosis_id, 'jovencutegwapo123') AS CHAR) = @diagnosis_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@diagnosis_id", diagnosis_id);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating diagnosis: " + ex.ToString());
                return false;
            }
        }

        public bool removeDiagnosis(string patient_id, string diagnosis_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE FROM patient_information_db.diagnosis
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND 
                                    CAST(AES_DECRYPT(diagnosis_id, 'jovencutegwapo123') AS CHAR) = @diagnosis_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@diagnosis_id", diagnosis_id);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error deleting diagnosis: " + ex.ToString());
                return false;
            }
        }
    }
}
