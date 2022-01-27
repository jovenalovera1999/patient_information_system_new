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
    class Diagnosis
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        public void LoadDiagnosis(int patient_fid, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    id,
                                    CAST(AES_DECRYPT(diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
                                    DATE_FORMAT(date, '%Y/%m/%d')
                                    FROM pis_db.diagnosis 
                                    WHERE 
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Visible';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("patient_fid", patient_fid);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Diagnosis";
                        grid.Columns["DATE_FORMAT(date, '%Y/%m/%d')"].HeaderText = "Date";
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading diagnosis: " + ex.ToString());
            }
        }

        public bool AddDiagnosis(int patient_fid, string diagnosis, DateTime date, string user, string patient, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_diagnosis(user, patient, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@patient, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    INSERT INTO pis_db.diagnosis(patient_fid, diagnosis, date)
                                    VALUES(
                                    @patient_fid,
                                    AES_ENCRYPT(@diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @date
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@patient", patient);
                        cmd.Parameters.AddWithValue("@description", description);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding a diagnosis: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateDiagnosis(int id, string diagnosis, DateTime date, string user, string patient, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_diagnosis(user, patient, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@patient, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.diagnosis 
                                    SET 
                                    diagnosis = AES_ENCRYPT(@diagnosis, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    date = @date
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@patient", patient);
                        cmd.Parameters.AddWithValue("@description", description);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating diagnosis: " + ex.ToString());
                return false;
            }
        }

        public bool RemoveDiagnosis(int id, string user, string patient, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_diagnosis(user, patient, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@patient, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    DELETE FROM pis_db.diagnosis
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@patient", patient);
                        cmd.Parameters.AddWithValue("@description", description);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating diagnosis to removed: " + ex.ToString());
                return false;
            }
        }
    }
}
