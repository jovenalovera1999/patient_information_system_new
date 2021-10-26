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
                    string sql = @"SELECT CAST(AES_DECRYPT(symptoms, 'jovencutegwapo123') AS CHAR) AS 'Symptoms'
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

        public bool symptomsAdded(string patient_id, string symptoms, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.symptoms_added(patient_id, symptoms, date)
                                    VALUES(@patient_id, @symptoms, @date);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding symptoms in symptoms added: " + ex.ToString());
                return false;
            }
        }

        public bool symptomsRemoved(string patient_id, string symptoms, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT patient_information_db(patient_id, symptoms, date)
                                    VALUES(@patient_id, @symptoms, @date);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }   
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding symptoms in symptoms removed: " + ex.ToString());
                return false;
            }
        }

        public bool symptomsSaved(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE * FROM patient_information_db.symptoms_added 
                                    WHERE patient_id = @patient_id;

                                    DELETE * FROM patient_information_db.symptoms_removed 
                                    WHERE patient_id = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error deleting symptoms in both added and removed symptoms: " + ex.ToString());
                return false;
            }
        }

        public bool symptomsCanceled(string patient_id, string symptoms, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.symptoms(patient_id, symptoms, date) 
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@symptoms, 'jovencutegwapo123'),
                                    date
                                    );";
                }
                    return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
