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
    class Doctor
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();


        // Load Doctor
        
        public void loadDoctors(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR) AS 'Doctor ID',
                                    CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR) AS 'First Name',
                                    CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR) AS 'Middle Name',
                                    CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR) AS 'Last Name',
                                    CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR) AS 'Specialization'
                                    FROM patient_information_db.users
                                    WHERE
                                    CAST(AES_DECRYPT(role, 'jovencutegwapo123') AS CHAR) = 'Doctor'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading doctors: " + ex.ToString());
            }
        }

        // Get Doctor

        public bool getDoctor(string user_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR),
                                    profile_picture,
                                    CAST(AES_DECRYPT(username, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(password, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(gender, 'jovencutegwapo123') AS CHAR),
                                    age,
                                    CAST(AES_DECRYPT(address, 'jovencutegwapo123') AS CHAR),
                                    birthday,
                                    CAST(AES_DECRYPT(cellphone_number, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(telephone_number, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(email, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(role, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR)
                                    FROM patient_information_db.users
                                    WHERE CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR) = @user_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
