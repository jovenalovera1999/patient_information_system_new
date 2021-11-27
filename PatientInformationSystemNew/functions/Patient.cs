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
        public void LoadPatientInSchedule(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Patient ID',
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'First Name', 
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Middle Name',
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Last Name',
                                    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Gender',
                                    DATE_FORMAT(birthday, '%M %d, %Y') AS 'Birthday',
                                    status AS 'Status'
                                    FROM pis_db.patients
                                    WHERE status = 'Waiting' OR status = 'Consulting'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
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
                Console.WriteLine("Error loading patient in schedule: " + ex.ToString());
            }
        }

        public void LoadPatientsInPatients(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Patient ID', 
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'First Name',
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Middle Name',
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Last Name',
                                    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Gender', 
                                    DATE_FORMAT(date, '%M %d, %Y') AS 'Date Created'
                                    FROM pis_db.patients
                                    ORDER BY first_name DESC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
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
                Console.WriteLine("Error loading patients in patients: " + ex.ToString());
            }
        }

        public void loadDoctorPatients(string doctor_first_name, string doctor_last_name, string specialization, DataGridView grid)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Patient ID',
                                    CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'First Name',
                                    CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Middle Name',
                                    CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) AS 'Last Name',
                                    DATE_FORMAT(birthday, '%M %d, %Y') AS 'Birthday',
                                    DATE_FORMAT(date, '%M %d, %Y') AS 'Date Created'
                                    FROM
                                    pis_db.patients
                                    WHERE 
                                    CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    LIKE CONCAT('Dr.', ' ', @doctor_first_name, ' ', @doctor_last_name, ' ', '(',@specialization,')');";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_first_name", doctor_first_name);
                        cmd.Parameters.AddWithValue("@doctor_last_name", doctor_last_name);
                        cmd.Parameters.AddWithValue("@specialization", specialization);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        grid.DataSource = dt;
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
            string pulse_rate, string blood_pressure, string doctor, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.patients(patient_id, first_name, middle_name, last_name, gender, age, address, birthday, cellphone_number, telephone_number, 
                                    email, date)
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
                                    AES_ENCRYPT(@email, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @date
                                    );

                                    INSERT INTO pis_db.vital_signs(patient_id, height, weight, temperature, pulse_rate, 
                                    blood_pressure, date)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@height, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@weight, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@temperature, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @date
                                    );

                                    INSERT INTO pis_db.patient_doctor(patient_id, doctor, date)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@doctor, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @date
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
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
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@pulse_rate", pulse_rate);
                        cmd.Parameters.AddWithValue("@blood_pressure", blood_pressure);
                        cmd.Parameters.AddWithValue("@doctor", doctor);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        cmd.ExecuteReader();

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

        // Save patient

        public bool SavePatientCompleteConsultation(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE pis_db.patients
                                    SET status = 'Complete'
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error saving prescription and transferring patient to patient: " + ex.ToString());
                return false;
            }
        }

        // Update patient

        public bool UpdatePatient(string patient_id, string first_name, string middle_name, string last_name, string gender, string age,
            string address, DateTime birthday, string cellphone_number, string telephone_number, string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE pis_db.patients
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
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
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
                        cmd.ExecuteReader();

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

        public bool BackPatientToScheduleFromConsultation(string patient_id, DateTime date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE pis_db.patients 
                                    SET status = 'Waiting'
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;

                                    DELETE FROM pis_db.diagnosis
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    date = @date";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@date", date);

                        connection.Open();
                        cmd.ExecuteReader();

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

        public bool CancelPatientInSchedule(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE 
                                    FROM pis_db.patients
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting patient in schedule: " + ex.ToString());
                return false;
            }
        }

        // Get patient

        public bool GetPatientFromSchedule(string patient_id)
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
                                    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    birthday,
                                    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.patients 
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;

                                    UPDATE pis_db.patients SET status = 'Consulting' 
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
                            CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.vital_signs
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

                    sql = @"SELECT
                            CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.patient_doctor
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
                Console.WriteLine("Error getting a patient from schedule: " + ex.ToString());
                return false;
            }
        }

        public bool GetPatient(string patient_id)
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
                                    CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    birthday,
                                    CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.patients 
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
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
                            CAST(AES_DECRYPT(height, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(weight, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(temperature, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.vital_signs
                            WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
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

                    sql = @"SELECT
                            CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.patient_doctor
                            WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
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
            catch (Exception ex)
            {
                Console.WriteLine("Error getting a patient from schedule: " + ex.ToString());
                return false;
            }
        }
    }
}
