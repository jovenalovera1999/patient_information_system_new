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

        // Username

        public bool usernameDuplicate(string username)
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

        public bool DoctorDuplicate(int patient_fid, string doctor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.patient_doctor
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @doctor;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
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
                Console.WriteLine("Error detecting duplicate doctor: " + ex.ToString());
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

        public bool DiagnosisNameDuplicate(int patient_fid, string diagnosis)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM pis_db.diagnosis
                                    WHERE 
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @diagnosis;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
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

        public bool SymptomNameDuplicate(int patient_fid, string symptoms)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM pis_db.symptoms
                                    WHERE 
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(symptoms, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @symptoms;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@symptoms", symptoms);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
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

        public bool PrescriptionNameDuplicate(int patient_fid, string prescriptions)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT * 
                                    FROM pis_db.prescriptions
                                    WHERE 
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(prescriptions, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @prescriptions;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@prescriptions", prescriptions);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
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
                                    FROM pis_db.inventory_incoming
                                    WHERE CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @supply_name;";

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
    }
}
