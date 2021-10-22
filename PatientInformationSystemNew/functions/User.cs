using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PatientInformationSystemNew.functions
{
    class User
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        // User Authentication
        public bool userAuthentication(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM patient_information_db.users
                                    WHERE username = @username AND password = @password;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {

                        }
                    }
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
