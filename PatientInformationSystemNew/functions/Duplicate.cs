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

        // Vital Signs

        public bool VitalSignsIDDuplicate(string full_name, string vital_signs_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.vital_signs
                                    WHERE
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    CAST(AES_DECRYPT(vital_signs_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @vital_signs_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@vital_signs_id", vital_signs_id);

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
                Console.WriteLine("Error detecting vital signs id: " + ex.ToString());
                return false;
            }
        }

        // Doctor

        public bool DoctorDuplicateID(string full_name, string doctor_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.patient_doctor
                                    WHERE 
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    CAST(AES_DECRYPT(doctor_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @doctor_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@doctor_id", doctor_id);

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
                Console.WriteLine("Error detecting duplicate doctor id: " + ex.ToString());
                return false;
            }
        }

        // Diagnosis

        public bool DiagnosisIDDuplicate(string full_name, string diagnosis_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM pis_db.diagnosis
                                    WHERE
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    CAST(AES_DECRYPT(diagnosis_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @diagnosis_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@diagnosis_id", diagnosis_id);

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
                Console.WriteLine("Error detecting diagonsis id duplicate: " + ex.ToString());
                return false;
            }
        }

        // Symptoms

        public bool SymptomsIDDuplicate(string full_name, string symptoms_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM pis_db.symptoms 
                                    WHERE 
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    CAST(AES_DECRYPT(symptoms_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @symptoms_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);

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
                Console.WriteLine("Error detecting duplicate symptoms id: " + ex.ToString());
                return false;
            }
        }

        // Prescription

        public bool PrescriptionIDDuplicate(string full_name, string prescription_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.prescriptions
                                    WHERE
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    CAST(AES_DECRYPT(prescription_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @prescription_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@prescription_id", prescription_id);

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
                Console.WriteLine("Error detecting duplicate prescriptions ID: " + ex.ToString());
                return false;
            }
        }

        // Transactions

        public bool TransactionIDDuplicate(string full_name, string transaction_id)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.transactions
                                    WHERE
                                    CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name AND
                                    CAST(AES_DECRYPT(transaction_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @transaction_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@transaction_id", transaction_id);

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
                Console.WriteLine("Error detecting duplicate receipt no: " + ex.ToString());
                return false;
            }
        }

        // Inventory

        public bool inventorySupplyDuplicate(string supply_name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM pis_db.inventory_incoming
                                    WHERE CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @supply_name;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);

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
                Console.WriteLine("Error detecting duplicate name of supply without expiration date: " + ex.ToString());
                return false;
            }
        }

        public bool duplicateSupplyNameWithoutExpirationDate(string supply_name)
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
                                    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @supply_name;";

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
