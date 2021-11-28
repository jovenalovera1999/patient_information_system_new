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
    }
}
