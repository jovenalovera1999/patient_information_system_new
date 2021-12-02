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
    class VitalSigns
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void LoadVitalSigns(string full_name, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(vital_signs_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID',
                                    CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Height',
                                    CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Weight',
                                    CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Temperature',
                                    CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Pulse Rate',
                                    CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Blood Pressure',
                                    DATE_FORMAT(date, '%M %d, %Y') AS 'Date'
                                    FROM pis_db.vital_signs
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
                Console.WriteLine("Error loading vital signs: " + ex.ToString());
            }
        }

        public void LoadEachPatientVitalSigns(int patient_fid, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(vital_signs_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID',
                                    CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Height',
                                    CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Weight',
                                    CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Temperature',
                                    CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Pulse Rate',
                                    CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Blood Pressure',
                                    DATE_FORMAT(date, '%M %d, %Y') AS 'Date'
                                    FROM pis_db.vital_signs
                                    WHERE patient_fid = @patient_fid ORDER BY date ASC;";

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
                Console.WriteLine("Error loading each patient vital signs: " + ex.ToString());
            }
        }

        public bool AddPatientVitalSigns(int patient_fid, string full_name, string vital_signs_id, string height, string weight, string temperature, 
            string pulse_rate, string blood_pressure, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.vital_signs(patient_fid, full_name, vital_signs_id, height, weight, temperature, pulse_rate, 
                                    blood_pressure, date)
                                    VALUES(
                                    @patient_fid,
                                    AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@vital_signs_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@height, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@weight, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@temperature, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @date
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@vital_signs_id", vital_signs_id);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@pulse_rate", pulse_rate);
                        cmd.Parameters.AddWithValue("@blood_pressure", blood_pressure);
                        cmd.Parameters.AddWithValue("@date", date);

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
                Console.WriteLine("Error adding each patient vital signs: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateVitalSigns(string full_name, string vital_signs_id, string height, string weight, string temperature, string pulse_rate,
            string blood_pressure, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE pis_db.vital_signs
                                    SET
                                    height = AES_ENCRYPT(@height, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    weight = AES_ENCRYPT(@weight, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    temperature = AES_ENCRYPT(@temperature, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    pulse_rate = AES_ENCRYPT(@pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    blood_pressure = AES_ENCRYPT(@blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    date = @date
                                    WHERE
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    CAST(AES_DECRYPT(vital_signs_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @vital_signs_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@vital_signs_id", vital_signs_id);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@pulse_rate", pulse_rate);
                        cmd.Parameters.AddWithValue("@blood_pressure", blood_pressure);
                        cmd.Parameters.AddWithValue("@date", date);

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
                Console.WriteLine("Error updating each patient vital signs: " + ex.ToString());
                return false;
            }
        }
    }
}
