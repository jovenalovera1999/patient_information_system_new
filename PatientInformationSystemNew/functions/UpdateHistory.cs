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
                                    id,
                                    CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    DATE_FORMAT(date, '%a, %d %b %Y %r')
                                    FROM pis_db.update_history;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].HeaderText = "#";
                        grid.Columns["CAST(AES_DECRYPT(user, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Edited By";
                        grid.Columns["CAST(AES_DECRYPT(description, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Description";
                        grid.Columns["DATE_FORMAT(date, '%a, %d %b %Y %r')"].HeaderText = "Date";
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
