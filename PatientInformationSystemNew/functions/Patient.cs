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
    class Patient
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        // Load patient in schedule
        public void LoadPatientsInSchedule(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    id,
                                    doctor_fid,
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    DATE_FORMAT(birthday, '%d %b %Y'),
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.schedule
                                    WHERE
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Waiting' OR
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["doctor_fid"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(birthday, '%d %b %Y')"].HeaderText = "Birthday";
                        grid.Columns["CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Status";
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading patient in schedule: " + ex.ToString());
            }
        }

        public void LoadPatients(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    pis_db.patients.id,
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
                                    CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(pis_db.patients.middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(pis_db.patients.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(pis_db.patients.gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(pis_db.users.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(pis_db.users.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(', CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') AS 'Doctor',
                                    DATE_FORMAT(pis_db.patients.date, '%Y/%m/%d')
                                    FROM pis_db.patients
                                    INNER JOIN pis_db.users ON pis_db.patients.doctor_fid = pis_db.users.id
                                    WHERE CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete'
                                    ORDER BY pis_db.users.first_name ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(pis_db.patients.date, '%Y/%m/%d')"].HeaderText = "Date Created";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading patients in patients: " + ex.ToString());
            }
        }

        public void LoadDoctorPatientsInSchedule(int doctor_fid, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    id,
                                    doctor_fid,
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    DATE_FORMAT(birthday, '%d %b %Y'),
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.schedule
                                    WHERE 
                                    doctor_fid = @doctor_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Waiting' OR
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["doctor_fid"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(birthday, '%d %b %Y')"].HeaderText = "Birthday";
                        grid.Columns["CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Status";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading doctor's patients in schedule: " + ex.ToString());
            }
        }

        public void LoadDoctorPatients(int doctor_fid, DataGridView grid)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    id,
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), 
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    DATE_FORMAT(date, '%Y/%m/%d')
                                    FROM pis_db.patients
                                    WHERE
                                    doctor_fid = @doctor_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete'
                                    ORDER BY first_name ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(date, '%Y/%m/%d')"].HeaderText = "Date Created";
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading doctor's patients: " + ex.ToString());
            }
        }

        // Add patient

        public bool AddPatient(string patient_id, string first_name, string middle_name, string last_name, string gender, string age, string address, 
            DateTime birthday, string cellphone_number, string telephone_number, string email, string height, string weight, string temperature,
            string pulse_rate, string blood_pressure, string doctor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT id
                                    FROM pis_db.users
                                    WHERE
                                    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', 
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',
                                    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') = @doctor;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor", doctor);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientDoctorPrimaryID = dt.Rows[0].Field<int>("id");
                        }
                        else
                        {
                            return false;
                        }
                    }
                    
                    sql = @"INSERT INTO pis_db.patients(doctor_fid, patient_id, first_name, middle_name, last_name, gender, age, address, birthday,
                            cellphone_number, telephone_number, email)
                            VALUES(
                            @doctor_fid,
                            AES_ENCRYPT(@patient_id, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@first_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@middle_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@last_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@gender, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@age, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@address, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            @birthday, 
                            AES_ENCRYPT(@cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@email, 'j0v3ncut3gw4p0per0jok3l4ang')
                            );

                            INSERT INTO pis_db.schedule(doctor_fid, patient_id, first_name, middle_name, last_name, gender, birthday)
                            VALUES(
                            @doctor_fid,
                            AES_ENCRYPT(@patient_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@first_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@middle_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@last_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@gender, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            @birthday
                            );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", val.PatientDoctorPrimaryID);
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@cellphone_number", cellphone_number);
                        cmd.Parameters.AddWithValue("@telephone_number", telephone_number);
                        cmd.Parameters.AddWithValue("@email", email);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"SELECT id
                            FROM pis_db.patients ORDER BY id DESC LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                    }

                    sql = @"INSERT INTO pis_db.vital_signs(patient_fid, height, weight, temperature, pulse_rate, blood_pressure, status)
                            VALUES(
                            @patient_fid,
                            AES_ENCRYPT(@height, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@weight, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@temperature, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang')
                            );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@pulse_rate", pulse_rate);
                        cmd.Parameters.AddWithValue("@blood_pressure", blood_pressure);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding patient to schedule: " + ex.ToString());
                return false;
            }
        }

        public bool AddPatientWithFirstAccountExisting(string patient_id, string first_name, string middle_name, string last_name, string gender,
            string age, string address, DateTime birthday, string cellphone_number, string telephone_number, string email, string height,
            string weight, string temperature, string pulse_rate, string blood_pressure, string doctor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT id
                                    FROM pis_db.users
                                    WHERE
                                    CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', 
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',
                                    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),')') = @doctor;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor", doctor);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientDoctorPrimaryID = dt.Rows[0].Field<int>("id");
                        }
                        else
                        {
                            return false;
                        }
                    }
                    
                    sql = @"INSERT INTO pis_db.duplicate_patients(patient_id, first_name, middle_name, last_name, gender, age, address,
                            birthday, cellphone_number, telephone_number, email)
                            VALUES(
                            AES_ENCRYPT(@patient_id, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@first_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@middle_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@last_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@gender, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@age, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@address, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            @birthday, 
                            AES_ENCRYPT(@cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@email, 'j0v3ncut3gw4p0per0jok3l4ang')
                            );

                            INSERT INTO pis_db.schedule(doctor_fid, patient_id, first_name, middle_name, last_name, gender, birthday)
                            VALUES(
                            @doctor_fid,
                            AES_ENCRYPT(@patient_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@first_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@middle_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@last_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@gender, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            @birthday
                            );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", val.PatientDoctorPrimaryID);
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@cellphone_number", cellphone_number);
                        cmd.Parameters.AddWithValue("@telephone_number", telephone_number);
                        cmd.Parameters.AddWithValue("@email", email);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"SELECT
                            id
                            FROM pis_db.patients
                            WHERE
                            doctor_fid = @doctor_fid AND
                            CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", val.PatientDoctorPrimaryID);
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"INSERT INTO pis_db.vital_signs(patient_fid, height, weight, temperature, pulse_rate, blood_pressure, status)
                            VALUES(
                            @patient_fid,
                            AES_ENCRYPT(@height, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@weight, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@temperature, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang')
                            );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@pulse_rate", pulse_rate);
                        cmd.Parameters.AddWithValue("@blood_pressure", blood_pressure);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding patient to schedule with first account existing: " + ex.ToString());
                return false;
            }
        }

        // Save patient

        public bool SavePrescription(int patient_fid, string prescriptions)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.prescriptions(patient_fid, prescriptions, status)
                                    VALUES(
                                    @patient_fid,
                                    AES_ENCRYPT(@prescriptions, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT('In Consultation', 'j0v3ncut3gw4p0per0jok3l4ang'));";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@prescriptions", prescriptions);

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
                Console.WriteLine("Error saving prescription: " + ex.ToString());
                return false;
            }
        }

        public bool DoneConsulting(string patient_id, int patient_fid, string full_name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.number_of_patients(full_name)
                                    VALUES(
                                    AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.vital_signs
                                    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                    UPDATE pis_db.symptoms
                                    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                    UPDATE pis_db.prescriptions
                                    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                    UPDATE pis_db.patients
                                    SET status = AES_ENCRYPT('Complete', 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND 
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                    DELETE FROM pis_db.schedule
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND 
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);

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
                Console.WriteLine("Error updating patient to done consulting or complete: " + ex.ToString());
                return false;
            }
        }

        public bool DoneConsultingWithFirstAccountExisting(string patient_id, int patient_fid, string full_name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.number_of_patients(full_name)
                                    VALUES(
                                    AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.vital_signs
                                    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                    UPDATE pis_db.symptoms
                                    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                    UPDATE pis_db.prescriptions
                                    SET status = AES_ENCRYPT('Visible', 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                    DELETE FROM pis_db.schedule
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND 
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"UPDATE pis_db.patients
                            SET
                            first_name = AES_ENCRYPT(@first_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            middle_name = AES_ENCRYPT(@middle_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            last_name = AES_ENCRYPT(@last_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            gender = AES_ENCRYPT(@gender, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            age = AES_ENCRYPT(@age, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            address = AES_ENCRYPT(@address, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            birthday = @birthday, 
                            cellphone_number = AES_ENCRYPT(@cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            telephone_number = AES_ENCRYPT(@telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            email = AES_ENCRYPT(@email, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            payment_status = AES_ENCRYPT('Unpaid', 'j0v3ncut3gw4p0per0jok3l4ang')
                            WHERE
                            CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete';

                            DELETE FROM pis_db.duplicate_patients
                            WHERE
                            CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@first_name", val.PatientFirstName);
                        cmd.Parameters.AddWithValue("@middle_name", val.PatientMiddleName);
                        cmd.Parameters.AddWithValue("@last_name", val.PatientLastName);
                        cmd.Parameters.AddWithValue("@gender", val.PatientGender);
                        cmd.Parameters.AddWithValue("@age", val.PatientAge);
                        cmd.Parameters.AddWithValue("@address", val.PatientAddress);
                        cmd.Parameters.AddWithValue("@birthday", val.PatientBirthday.Date);
                        cmd.Parameters.AddWithValue("@cellphone_number", val.PatientCellphoneNumer);
                        cmd.Parameters.AddWithValue("@telephone_number", val.PatientTelephoneNumber);
                        cmd.Parameters.AddWithValue("@email", val.PatientEmail);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating patient to done consulting or complete with first account existing: " + ex.ToString());
                return false;
            }
        }

        // Update patient

        public bool UpdatePatient(int id, string first_name, string middle_name, string last_name, 
            string gender, string age, string address, DateTime birthday, string cellphone_number, string telephone_number, 
            string email, string user, string patient, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_patient(user, patient, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@patient, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.patients
                                    SET
                                    first_name = AES_ENCRYPT(@first_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    middle_name = AES_ENCRYPT(@middle_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    last_name = AES_ENCRYPT(@last_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    gender = AES_ENCRYPT(@gender, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    age = AES_ENCRYPT(@age, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    address = AES_ENCRYPT(@address, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    birthday = @birthday,
                                    cellphone_number = AES_ENCRYPT(@cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    telephone_number = AES_ENCRYPT(@telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    email = AES_ENCRYPT(@email, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@birthday", birthday);
                        cmd.Parameters.AddWithValue("@cellphone_number", cellphone_number);
                        cmd.Parameters.AddWithValue("@telephone_number", telephone_number);
                        cmd.Parameters.AddWithValue("@email", email);
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
                Console.WriteLine("Error updating patient: " + ex.ToString());
                return false;
            }
        }

        // Cancel, remove or delete patient

        public bool CancelPatientInSchedule(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.patients
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                    DELETE FROM pis_db.schedule
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Waiting';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"DELETE FROM pis_db.vital_signs
                            WHERE patient_fid = @patient_fid AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                            DELETE FROM pis_db.symptoms
                            WHERE patient_fid = @patient_fid AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                            DELETE FROM pis_db.patients
                            WHERE
                            CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);

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
                Console.WriteLine("Error updating patient in schedule to cancelled: " + ex.ToString());
                return false;
            }
        }

        public bool CancelPatientInScheduleWithFirstAccountExisting(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.patients
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Complete';

                                    DELETE FROM pis_db.schedule
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Waiting';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"DELETE FROM pis_db.vital_signs
                            WHERE patient_fid = @patient_fid AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                            DELETE FROM pis_db.symptoms
                            WHERE patient_fid = @patient_fid AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                            DELETE FROM pis_db.duplicate_patients
                            WHERE
                            CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating patient in schedule to cancelled: " + ex.ToString());
                return false;
            }
        }

        public bool BackPatientToScheduleFromConsultation(string patient_id, int patient_fid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE FROM pis_db.prescriptions
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';

                                    UPDATE pis_db.schedule 
                                    SET status = AES_ENCRYPT('Waiting', 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Consulting';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating patient status in schedule going back: " + ex.ToString());
                return false;
            }
        }

        // Get patient

        public bool GetPatientFromSchedule(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.schedule
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"SELECT
                            pis_db.patients.id,
                            doctor_fid,
                            CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            birthday,
                            CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.patients
                            INNER JOIN pis_db.vital_signs ON pis_db.patients.id = pis_db.vital_signs.id
                            WHERE
                            CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                            CAST(AES_DECRYPT(pis_db.patients.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation' AND
                            CAST(AES_DECRYPT(pis_db.vital_signs.status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", val.PatientID);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                            val.PatientDoctorPrimaryID = dt.Rows[0].Field<int>("doctor_fid");
                            val.PatientID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientAge = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.PatientCellphoneNumer = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientHeight = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientWeight = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientTemperature = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientPulseRate = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientBloodPressure = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"UPDATE pis_db.schedule
                            SET status = AES_ENCRYPT('Consulting', 'j0v3ncut3gw4p0per0jok3l4ang')
                            WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

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
                Console.WriteLine("Error getting a patient from schedule: " + ex.ToString());
                return false;
            }
        }

        public bool GetPatientFromScheduleWithFirstAccountExisting(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.schedule
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.PatientID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"SELECT id
                            FROM pis_db.patients
                            WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", val.PatientID);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"SELECT
                            CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            birthday,
                            CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.duplicate_patients
                            WHERE
                            CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", val.PatientID);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientAge = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.PatientCellphoneNumer = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"SELECT
                            CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.vital_signs
                            WHERE
                            patient_fid = @patient_fid AND
                            CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'In Consultation';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientHeight = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientWeight = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientTemperature = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientPulseRate = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientBloodPressure = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"UPDATE pis_db.schedule
                            SET status = AES_ENCRYPT('Consulting', 'j0v3ncut3gw4p0per0jok3l4ang')
                            WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting a patient from schedule: " + ex.ToString());
                return false;
            }
        }

        public bool GetPatient(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    id,
                                    doctor_fid,
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    birthday,
                                    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.patients
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                            val.PatientDoctorPrimaryID = dt.Rows[0].Field<int>("doctor_fid");
                            val.PatientID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientAge = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.PatientCellphoneNumer = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"SELECT
                            CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.users
                            WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", val.PatientDoctorPrimaryID);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.DoctorFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.DoctorLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.DoctorSpecialization = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientDoctor = string.Format("Dr. {0} {1} ({2})", val.DoctorFirstName, val.DoctorLastName, val.DoctorSpecialization);

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
                Console.WriteLine("Error getting a patient from schedule: " + ex.ToString());
                return false;
            }
        }
    }
}
