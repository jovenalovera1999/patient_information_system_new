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
    class UpdateHistory
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void LoadUpdateHistory(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(update_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID',
                                    CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Edited By',
                                    CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Description',
                                    DATE_FORMAT(date, '%a, %d %b %Y %r') AS 'Date'
                                    FROM pis_db.update_history ORDER BY date DESC;";

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
                Console.WriteLine("Error loading update history: " + ex.ToString());
            }
        }
    }
}
