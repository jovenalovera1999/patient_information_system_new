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

        public void LoadVitalSigns(int patient_fid, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    id,
                                    CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    DATE_FORMAT(date, '%a, %d %b %Y')
                                    FROM pis_db.vital_signs
                                    WHERE patient_fid = @patient_fid AND
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

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Height";
                        grid.Columns["CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Weight";
                        grid.Columns["CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Temperature";
                        grid.Columns["CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Pulse Rate";
                        grid.Columns["CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Blood Pressure";
                        grid.Columns["DATE_FORMAT(date, '%a, %d %b %Y')"].HeaderText = "Date";
                    }
                } 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading vital signs: " + ex.ToString());
            }
        }

        public bool AddVitalSigns(int patient_fid, string height, string weight, string temperature, 
            string pulse_rate, string blood_pressure)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.vital_signs(patient_fid, height, weight, temperature, pulse_rate, blood_pressure)
                                    VALUES(
                                    @patient_fid,
                                    AES_ENCRYPT(@height, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@weight, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@temperature, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@pulse_rate", pulse_rate);
                        cmd.Parameters.AddWithValue("@blood_pressure", blood_pressure);

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

        public bool UpdateVitalSigns(int id, string height, string weight, string temperature, string pulse_rate, string blood_pressure,
            DateTime date)
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
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
                Console.WriteLine("Error updating vital signs: " + ex.ToString());
                return false;
            }
        }

        public bool RemoveVitalSigns(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE pis_db.vital_signs
                                    SET
                                    status = 'Removed'
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

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
                Console.WriteLine("Error removing vital signs: " + ex.ToString());
                return false;
            }
        }
    }
}
