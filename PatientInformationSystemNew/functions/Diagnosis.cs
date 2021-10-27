﻿using System;
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

        public void loadDiagnosisRecordsOfPatient(string patient_id, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(diagnosis_id, 'jovencutegwapo123') AS CHAR) AS 'ID',
                                    CAST(AES_DECRYPT(diagnosis, 'jovencutegwapo123') AS CHAR) AS 'Diagnosis', 
                                    date AS 'Date'
                                    FROM patient_information_db.diagnosis 
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
                Console.WriteLine("Error loading diagnosis records of patient: " + ex.ToString());
            }
        }

        public void loadDiagnosisRecordsOfPatientByDate(string patient_id, DateTime date, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(diagnosis_id, 'jovencutegwapo123') AS CHAR) AS 'ID', 
                                    CAST(AES_DECRYPT(diagnosis, 'jovencutegwapo123') AS CHAR) AS 'Diagnosis', 
                                    date AS 'Date'
                                    FROM patient_information_db.diagnosis
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id AND 
                                    date = @date;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@date", date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading diagnosis records of patient by date: " + ex.ToString());
            }
        }
    }
}
