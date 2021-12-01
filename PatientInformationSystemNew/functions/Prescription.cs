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
    class Prescription
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void LoadPrescriptionRecordsOfPatient(string full_name, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(prescription_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(prescriptions, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Prescriptions',
                                    DATE_FORMAT(date, '%M %d, %Y') AS 'Date' 
                                    FROM pis_db.prescriptions
                                    WHERE CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name
                                    ORDER BY date ASC;";

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
                Console.WriteLine("Error loading prescription records of patient: " + ex.ToString());
            }
        }

        public void LoadPrescriptionRecordsOfEachPatient(int patient_fid, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(prescription_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(prescriptions, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Prescriptions',
                                    DATE_FORMAT(date, '%M %d, %Y') AS 'Date' 
                                    FROM pis_db.prescriptions
                                    WHERE patient_fid = @patient_fid ORDER BY date ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading prescription records of each patient: " + ex.ToString());
            }
        }

        public void loadPrintPrescriptionRecordsOfPatient(string patient_id, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(prescription_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(prescriptions, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Prescriptions',
                                    DATE_FORMAT(date, '%M %d, %Y') AS 'Date' 
                                    FROM pis_db.prescriptions
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading print prescription records of patient: " + ex.ToString());
            }
        }

        public bool getPrescription(string patient_id, string prescription_id, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    DATE_FORMAT(date, '%m/%d/%y')
                                    FROM pis_db.prescriptions
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(prescription_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @prescription_id AND
                                    date = @date;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@prescription_id", prescription_id);
                        cmd.Parameters.AddWithValue("@date", date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PrescriptionDate = dt.Rows[0].Field<DateTime>("date");
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
                Console.WriteLine("Error getting prescription: " + ex.ToString());
                return false;
            }
        }

        public bool addPrescriptionFromConsultaion(string patient_id, string prescription_id, string prescriptions, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.prescriptions(patient_id, prescription_id, prescriptions, date)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@prescription_id, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@prescriptions, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @date
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@prescription_id", prescription_id);
                        cmd.Parameters.AddWithValue("@prescriptions", prescriptions);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding a new prescription from consultation: " + ex.ToString());
                return false;
            }
        }

        public bool AddPrescription(int patient_fid, string full_name, string prescription_id, string prescriptions, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.prescriptions(patient_fid, full_name, prescription_id, prescriptions, date)
                                    VALUES(
                                    @patient_fid,
                                    AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@prescription_id, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@prescriptions, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @date
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@prescription_id", prescription_id);
                        cmd.Parameters.AddWithValue("@prescriptions", prescriptions);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding prescription: " + ex.ToString());
                return false;
            }
        }

        public bool updatePrescriptions(string patient_id, string prescription_id, string prescriptions, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE pis_db.prescriptions
                                    SET prescriptions = AES_ENCRYPT(@prescriptions, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    date = @date
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(prescription_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @prescription_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@prescription_id", prescription_id);
                        cmd.Parameters.AddWithValue("@prescriptions", prescriptions);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating patient prescription: " + ex.ToString());
                return false;
            }
        }

        public bool removePrescriptions(string patient_id, string prescription_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE FROM pis_db.prescriptions
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(prescription_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @prescription_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@prescription_id", prescription_id);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error deleting patient prescription: " + ex.ToString());
                return false;
            }
        }
    }
}
