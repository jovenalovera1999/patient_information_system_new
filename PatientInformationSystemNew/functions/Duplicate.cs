using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PatientInformationSystemNew.functions
{
    class Duplicate
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        // User

        public bool UserIDDuplicate(string user_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.users
                                    WHERE CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @user_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
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
                Console.WriteLine("Error detecting duplicate user id: " + ex.ToString());
                return false;
            }
        }

        public bool UsernameDuplicate(string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM pis_db.users 
                                    WHERE CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @username;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
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
                Console.WriteLine("Error detecting duplicate username: " + ex.ToString());
                return false;
            }
        }

        // Patient

        public bool PatientIDDuplicate(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.patients
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
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
                Console.WriteLine("Error detecting duplicate patient id: " + ex.ToString());
                return false;
            }
        }

        public bool DuplicatePatientAndPatientDoctor(string first_name, string middle_name, string last_name, string doctor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.patients
                                    INNER JOIN pis_db.patient_doctor ON pis_db.patients.id = pis_db.patient_doctor.id
                                    WHERE
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @first_name AND
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @middle_name AND
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @last_name AND
                                    CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @doctor AND
                                    pis_db.patients.status = 'Complete'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@doctor", doctor);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientDoctor = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");

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
                Console.WriteLine("Error detecting patient full name and doctor: " + ex.ToString());
                return false;
            }
        }

        public bool DuplicatePatientInGeneral(string patient_id, string doctor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.patients
                                    INNER JOIN pis_db.patient_doctor ON pis_db.patients.id = pis_db.patient_doctor.id
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @doctor AND
                                    pis_db.patients.status = 'Complete';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@doctor", doctor);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
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
                Console.WriteLine("Error detecting duplicate patient: " + ex.ToString());
                return false;
            }
        }

        // Inventory

        public bool DuplicateSupplyNameWithoutExpirationDate(string supply_name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.inventory
                                    WHERE 
                                    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @supply_name AND
                                    status = 'Show';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.SupplyQuantity = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error detecting same name of supply to add or update from incoming supply: " + ex.ToString());
                return false;
            }
        }

        // Update history

        public bool UpdateHistoryIDDuplicate(string update_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.update_history
                                    WHERE CAST(AES_DECRYPT(update_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @update_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@update_id", update_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
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
                Console.WriteLine("Error detecting update history id duplicate: " + ex.ToString());
                return false;
            }
        }
    }
}
