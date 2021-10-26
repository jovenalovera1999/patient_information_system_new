using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace PatientInformationSystemNew.functions
{
    class Symptoms
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void loadSymptomsInConsultation(string patient_id, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(symptoms_id, 'jovencutegwapo123') AS CHAR) AS 'Symptoms ID', 
                                    CAST(AES_DECRYPT(symptoms, 'jovencutegwapo123') AS CHAR) AS 'Symptoms'
                                    FROM patient_information_db.symptoms
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
                Console.WriteLine("Error loading patient symptoms in consultation: " + ex.ToString());
            }
        }

        public bool addPatientSymptom(string patient_id, string symptoms_id, string symptoms)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.symptoms(patient_id, symptoms_id, symptoms)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@symptoms_id, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@symptoms, 'jovencutegwapo123')
                                    )";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding patient symptoms: " + ex.ToString());
                return false;
            }
        }

        public bool updateSymptom(string patient_id, string symptoms_id, string symptoms)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE patient_information_db.symptoms 
                                    SET 
                                    symptoms = AES_ENCRYPT(@symptoms, 'jovencutegwapo123') 
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND 
                                    CAST(AES_DECRYPT(symptoms_id, 'jovencutegwapo123') AS CHAR) = @symptoms_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating symptom: " + ex.ToString());
                return false;
            }
        }

        public bool deleteSymptom(string patient_id, string symptoms_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE FROM patient_information_db.symptoms
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND 
                                    CAST(AES_DECRYPT(symptoms_id, 'jovencutegwapo123') AS CHAR) = @symptoms_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error deleting patient symptom: " + ex.ToString());
                return false;
            }
        }
    }
}
