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

        // Patient

        // Username

        public bool usernameDuplicate(string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM patient_information_db.users 
                                    WHERE CAST(AES_DECRYPT(username, 'jovencutegwapo123') AS CHAR) = @username;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

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
                Console.WriteLine("Error detecting duplicate username: " + ex.ToString());
                return false;
            }
        }

        // Diagnosis

        public bool diagnosisIDDuplicate(string patient_id, string diagnosis_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM patient_information_db.diagnosis
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(diagnosis_id, 'jovencutegwapo123') AS CHAR) = @diagnosis_id;
                                    ";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@diagnosis_id", diagnosis_id);

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
                Console.WriteLine("Error detecting diagonsis id duplicate: " + ex.ToString());
                return false;
            }
        }

        public bool diagnosisNameDuplicate(string patient_id, string diagnosis, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM patient_information_db.diagnosis
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(diagnosis, 'jovencutegwapo123') AS CHAR) = @diagnosis AND
                                    date = @date;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@date", date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
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
            catch (Exception ex)
            {
                Console.WriteLine("Error detecting diagonsis name duplicate: " + ex.ToString());
                return false;
            }
        }

        // Symptoms

        public bool symptomsIDDuplicate(string patient_id, string symptoms_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM patient_information_db.symptoms 
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(symptoms_id, 'jovencutegwapo123') AS CHAR) = @symptoms_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@symptoms_id", symptoms_id);

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
                Console.WriteLine("Error detecting duplicate symptoms id: " + ex.ToString());
                return false;
            }
        }

        public bool symptomNameDuplicate(string patient_id, string symptoms, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM patient_information_db.symptoms
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(symptoms, 'jovencutegwapo123') AS CHAR) = @symptoms AND
                                    date = @date;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@date", date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
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
            catch (Exception ex)
            {
                Console.WriteLine("Error detecting symptom name duplicate: " + ex.ToString());
                return false;
            }
        }

        // Prescription

        public bool prescriptionIDDuplicate(string patient_id, string prescription_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM patient_information_db.prescriptions
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(prescription_id, 'jovencutegwapo123') AS CHAR) = @prescription_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patien_id", patient_id);
                        cmd.Parameters.AddWithValue("@prescription_id", prescription_id);

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
                Console.WriteLine("Error detecting duplicate prescriptions ID: " + ex.ToString());
                return false;
            }
        }

        public bool prescriptionNameDuplicate(string patient_id, string prescriptions, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM patient_information_db.prescriptions
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(prescriptions, 'jovencutegwapo123') AS CHAR) = @prescriptions AND
                                    date = @date;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@prescriptions", prescriptions);
                        cmd.Parameters.AddWithValue("@date", date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
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
            catch (Exception ex)
            {
                Console.WriteLine("Error detecting prescription duplicate: " + ex.ToString());
                return false;
            }
        }

        public bool inventorySupplyDuplicate(string supply_name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM patient_information_db.inventory_incoming
                                    WHERE CAST(AES_DECRYPT(supply_name, 'jovencutegwapo123') AS CHAR) = @supply_name;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);

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
                Console.WriteLine("Error detecting duplicate name of supply without expiration date: " + ex.ToString());
                return false;
            }
        }

        // Inventory

        public bool duplicateSupplyNameWithoutExpirationDate(string supply_name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(supply_name, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(quantity, 'jovencutegwapo123') AS CHAR)
                                    FROM patient_information_db.inventory
                                    WHERE 
                                    CAST(AES_DECRYPT(supply_name, 'jovencutegwapo123') AS CHAR) = @supply_name;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.SupplyQuantity = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(quantity, 'jovencutegwapo123') AS CHAR)");
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
    }
}
