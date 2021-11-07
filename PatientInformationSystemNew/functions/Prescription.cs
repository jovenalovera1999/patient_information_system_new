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

        public void loadPrescriptionRecordsOfPatient(string patient_id, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(prescription_id, 'jovencutegwapo123') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(prescriptions, 'jovencutegwapo123') AS CHAR) AS 'Prescriptions',
                                    DATE_FORMAT(date, '%d %M %Y') AS 'Date' 
                                    FROM patient_information_db.prescriptions
                                    WHERE CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id;";

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
            catch(Exception ex)
            {
                Console.WriteLine("Error loading prescription records of patient: " + ex.ToString());
            }
        }

        public bool addPrescriptionFromConsultaion(string patient_id, string prescription_id, string prescriptions, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.prescriptions(patient_id, prescription_id, prescriptions, date)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@prescription_id, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@prescriptions, 'jovencutegwapo123'),
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

        public bool addPrescription(string patient_id, string prescription_id, string prescriptions, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.prescriptions(patient_id, prescription_id, prescriptions, date)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@prescription_id, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@prescriptions, 'jovencutegwapo123'),
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
            catch (Exception ex)
            {
                Console.WriteLine("Error adding a new prescription from consultation: " + ex.ToString());
                return false;
            }
        }
        public bool updatePrescriptions(string patient_id, string prescription_id, string prescriptions, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE patient_information_db.prescriptions
                                    SET prescriptions = AES_ENCRYPT(@prescriptions, 'jovencutegwapo123'),
                                    date = @date
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(prescription_id, 'jovencutegwapo123') AS CHAR) = @prescription_id;";

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
                    string sql = @"DELETE FROM patient_information_db.prescriptions
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(prescription_id, 'jovencutegwapo123') AS CHAR) = @prescription_id;";

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
