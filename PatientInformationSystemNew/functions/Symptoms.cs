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

        public void LoadSymptomsInConsultation(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(symptoms, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Symptoms'
                                    FROM pis_db.symptoms
                                    INNER JOIN pis_db.patients ON pis_db.symptoms.patient_fid = pis_db.patients.id
                                    WHERE pis_db.symptoms.status = 'In Consultation';";

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
            catch(Exception ex)
            {
                Console.WriteLine("Error loading patient symptoms in consultation: " + ex.ToString());
            }
        }

        public void LoadSymptomsRecordsOfPatient(string full_name, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(symptoms, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Symptoms', 
                                    DATE_FORMAT(date, '%a, %d %b %Y') AS 'Date' 
                                    FROM pis_db.symptoms 
                                    WHERE 
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    status = 'Show'
                                    ORDER BY date ASC;";

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
                Console.WriteLine("Error loading symptoms records of patient: " + ex.ToString());
            }
        }

        public void LoadSymptomsRecordsOfEachPatient(int patient_fid, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(symptoms, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Symptoms', 
                                    DATE_FORMAT(date, '%a, %d %b %Y') AS 'Date' 
                                    FROM pis_db.symptoms 
                                    WHERE 
                                    patient_fid = @patient_fid AND
                                    status = 'Show'
                                    ORDER BY date ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);

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
                Console.WriteLine("Error loading symptoms records of each patient: " + ex.ToString());
            }
        }

        public bool AddPatientSymptom(int patient_fid, string full_name, string symptoms_id, string symptoms, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.symptoms(patient_fid, full_name, symptoms_id, symptoms, date)
                                    VALUES(
                                    @patient_fid,
                                    AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@symptoms, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    @date
                                    )";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();

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

        public bool AddPatientSymptomInConsultation(int patient_fid, string full_name, string symptoms_id, string symptoms, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.symptoms(patient_fid, full_name, symptoms_id, symptoms, status, date)
                                    VALUES(
                                    @patient_fid,
                                    AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@symptoms, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    'In Consultation',
                                    @date
                                    )";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding patient symptoms: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateSymptom(string full_name, string symptoms_id, string symptoms, DateTime date, string update_id, string user,
            string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history(update_id, user, description)
                                    VALUES
                                    (
                                    AES_ENCRYPT(@update_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.symptoms 
                                    SET 
                                    symptoms = AES_ENCRYPT(@symptoms, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    date = @date
                                    WHERE 
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND 
                                    CAST(AES_DECRYPT(symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @symptoms_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@date", date);
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
                Console.WriteLine("Error updating symptom: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateSymptomInConsultation(int patient_fid, string full_name, string symptoms_id, string symptoms, string update_id,
            string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history(update_id, user, description)
                                    VALUES
                                    (
                                    AES_ENCRYPT(@update_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.symptoms 
                                    SET 
                                    symptoms = AES_ENCRYPT(@symptoms, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE 
                                    CONCAT(patient_fid, ' ', CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', status) 
                                    = CONCAT(@patient_fid, ' ', @full_name, ' ', @symptoms_id, ' ', 'In Consultation');";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error updating symptom: " + ex.ToString());
                return false;
            }
        }

        public bool RemoveSymptom(string full_name, string symptoms_id, string update_id, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history(update_id, user, description)
                                    VALUES
                                    (
                                    AES_ENCRYPT(@update_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.symptoms
                                    SET status = 'Removed'
                                    WHERE
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    CAST(AES_DECRYPT(symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @symptoms_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);
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
                Console.WriteLine("Error updating symptom to removed: " + ex.ToString());
                return false;
            }
        }

        public bool RemoveSymptomInConsultation(int patient_fid, string full_name, string symptoms_id, string update_id, string user,
            string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history(update_id, user, description)
                                    VALUES
                                    (
                                    AES_ENCRYPT(@update_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.symptoms
                                    SET status = 'Removed'
                                    WHERE
                                    CONCAT(patient_fid, ' ', CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', status) 
                                    = CONCAT(@patient_fid, ' ', @full_name, ' ', @symptoms_id, ' ', 'In Consultation');";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error updating symptom to removed: " + ex.ToString());
                return false;
            }
        }
    }
}
