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
                                    DATE_FORMAT(birthday, '%a, %d %b %Y ') AS 'Birthday',
                                    status AS 'Status'
                                    FROM pis_db.schedule
                                    WHERE status = 'Waiting' OR status = 'Consulting';";

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
                                    DATE_FORMAT(date, '%a, %d %b %Y') AS 'Date Created'
                                    FROM pis_db.patients
                                    WHERE status = 'Complete'
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

        public void LoadDoctorPatientsInSchedule(string doctor_first_name, string doctor_last_name, string specialization, DataGridView grid)
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
                                    DATE_FORMAT(birthday, '%a, %d %b %Y') AS 'Birthday',
                                    status AS 'Status'
                                    FROM pis_db.schedule
                                    WHERE 
                                    CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    = CONCAT('Dr.', ' ', @doctor_first_name, ' ', @doctor_last_name, ' ', '(',@specialization,')') AND
                                    status = 'Waiting' OR status = 'Consulting';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_first_name", doctor_first_name);
                        cmd.Parameters.AddWithValue("@doctor_last_name", doctor_last_name);
                        cmd.Parameters.AddWithValue("@specialization", specialization);

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
                Console.WriteLine("Error loading doctor's patients in schedule: " + ex.ToString());
            }
        }

        public void LoadDoctorPatients(string doctor_first_name, string doctor_last_name, string specialization, DataGridView grid)
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
                                    DATE_FORMAT(birthday, '%a, %d %b %Y') AS 'Birthday',
                                    DATE_FORMAT(pis_db.patients.date, '%a, %d %b %Y') AS 'Date Created'
                                    FROM pis_db.patients
                                    INNER JOIN pis_db.patient_doctor ON pis_db.patients.id = pis_db.patient_doctor.id
                                    WHERE
                                    CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    = CONCAT('Dr.', ' ', @doctor_first_name, ' ', @doctor_last_name, ' ', '(',@specialization,')') AND
                                    status = 'Complete';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_first_name", doctor_first_name);
                        cmd.Parameters.AddWithValue("@doctor_last_name", doctor_last_name);
                        cmd.Parameters.AddWithValue("@specialization", specialization);

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
                Console.WriteLine("Error loading doctor's patients: " + ex.ToString());
            }
        }

        public void LoadPatientDoctor(string full_name, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS 'Doctor',
                                    DATE_FORMAT(date, '%a, %d %b %Y') AS 'Date'
                                    FROM pis_db.patient_doctor
                                    WHERE CAST(AES_DECRYPT(full_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @full_name;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@full_name", full_name);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading patient doctor: " + ex.ToString());
            }
        }

        // Add patient

        public bool AddPatient(string patient_id, string first_name, string middle_name, string last_name, string gender, string age, string address, 
            DateTime birthday, string cellphone_number, string telephone_number, string email, string height, string weight, string temperature,
            string pulse_rate, string blood_pressure, string doctor, DateTime date, string vital_signs_id, string doctor_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.patients(patient_id, first_name, middle_name, last_name, gender, age, address, birthday, cellphone_number, telephone_number, 
                                    email)
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

                                    INSERT INTO pis_db.schedule(patient_id, first_name, middle_name, last_name, gender, birthday, doctor)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@first_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@middle_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@last_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@gender, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @birthday,
                                    AES_ENCRYPT(@doctor, 'j0v3ncut3gw4p0per0jok3l4ang')
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
                        cmd.Parameters.AddWithValue("@doctor", doctor);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"SELECT
                            id,
                            CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                            CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.patients ORDER BY id DESC LIMIT 1;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                        val.PatientFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        val.PatientMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        val.PatientLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                    }

                    sql = @"INSERT INTO pis_db.vital_signs(patient_fid, full_name, vital_signs_id, height, weight, temperature, pulse_rate, 
                            blood_pressure, status, date)
                            VALUES(
                            @patient_fid,
                            AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@vital_signs_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@height, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@weight, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@temperature, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@pulse_rate, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                            AES_ENCRYPT(@blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            'In Consultation',
                            @date
                            );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);
                        cmd.Parameters.AddWithValue("@full_name", val.PatientFullName);
                        cmd.Parameters.AddWithValue("@vital_signs_id", vital_signs_id);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@pulse_rate", pulse_rate);
                        cmd.Parameters.AddWithValue("@blood_pressure", blood_pressure);
                        cmd.Parameters.AddWithValue("@date", date);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"SELECT 
                            CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                            FROM pis_db.users
                            WHERE
                            CONCAT('Dr.', ' ', CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ' ', '(',CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR), ')') = @doctor
                            AND CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = 'Doctor';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor", doctor);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientDoctorID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        }
                        else
                        {
                            return false;
                        }
                    }

                    sql = @"INSERT INTO pis_db.patient_doctor(patient_fid, full_name, doctor_id, user_id, doctor, status, date)
                            VALUES(
                            @patient_fid,
                            AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@doctor_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@user_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            AES_ENCRYPT(@doctor, 'j0v3ncut3gw4p0per0jok3l4ang'),
                            'In Consultation',
                            @date
                            );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);
                        cmd.Parameters.AddWithValue("@full_name", val.PatientFullName);
                        cmd.Parameters.AddWithValue("@doctor_id", doctor_id);
                        cmd.Parameters.AddWithValue("@user_id", val.PatientDoctorID);
                        cmd.Parameters.AddWithValue("@doctor", doctor);
                        cmd.Parameters.AddWithValue("@date", date);

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

        // Save patient

        public bool SavePatientCompleteConsultation(int id, string patient_id, int patient_fid, string full_name, string prescription_id,
            string prescriptions, DateTime date)
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
                                    );

                                    INSERT INTO pis_db.number_of_patients(full_name)
                                    VALUES(
                                    AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.vital_signs
                                    SET status = 'Show'
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    status = 'In Consultation';

                                    UPDATE pis_db.patient_doctor
                                    SET status = 'Show'
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    status = 'In Consultation';

                                    UPDATE pis_db.diagnosis
                                    SET status = 'Show'
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    status = 'In Consultation';

                                    UPDATE pis_db.symptoms
                                    SET status = 'Show'
                                    WHERE
                                    patient_fid = @patient_fid AND
                                    status = 'In Consultation';

                                    UPDATE pis_db.patients
                                    SET status = 'Complete'
                                    WHERE id = @id;

                                    UPDATE pis_db.schedule
                                    SET status = 'Done'
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND 
                                    status = 'Consulting';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);
                        cmd.Parameters.AddWithValue("@prescription_id", prescription_id);
                        cmd.Parameters.AddWithValue("@prescriptions", prescriptions);
                        cmd.Parameters.AddWithValue("@date", date);

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
                Console.WriteLine("Error saving prescription and transferring patient to patient: " + ex.ToString());
                return false;
            }
        }

        // Update patient

        public bool UpdatePatient(int id, int patient_fid, string patient_id, string first_name, string middle_name, string last_name, 
            string gender, string age, string address, DateTime birthday, string cellphone_number, string telephone_number, 
            string email, string update_id, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history(update_id, user, description)
                                    VALUES(
                                    AES_ENCRYPT(@update_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
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
                                    WHERE
                                    id = @id AND
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
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
                        cmd.Parameters.AddWithValue("@update_id", update_id);
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@description", description);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"UPDATE pis_db.vital_signs
                            SET full_name = AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang')
                            WHERE patient_fid = @patient_fid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        if(String.IsNullOrWhiteSpace(middle_name))
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}", first_name, last_name));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name));
                        }

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"UPDATE pis_db.patient_doctor
                            SET full_name = AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang')
                            WHERE patient_fid = @patient_fid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        if (String.IsNullOrWhiteSpace(middle_name))
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}", first_name, last_name));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name));
                        }

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"UPDATE pis_db.diagnosis
                            SET full_name = AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang')
                            WHERE patient_fid = @patient_fid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        if (String.IsNullOrWhiteSpace(middle_name))
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}", first_name, last_name));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name));
                        }

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"UPDATE pis_db.symptoms
                            SET full_name = AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang')
                            WHERE patient_fid = @patient_fid;";

                    using(MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        if (String.IsNullOrWhiteSpace(middle_name))
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}", first_name, last_name));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name));
                        }

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"UPDATE pis_db.prescriptions
                            SET full_name = AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang')
                            WHERE patient_fid = @patient_fid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        if (String.IsNullOrWhiteSpace(middle_name))
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}", first_name, last_name));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name));
                        }

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"UPDATE pis_db.transactions
                             SET full_name = AES_ENCRYPT(@full_name, 'j0v3ncut3gw4p0per0jok3l4ang')
                             WHERE patient_fid = @patient_fid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        if (String.IsNullOrWhiteSpace(middle_name))
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}", first_name, last_name));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@full_name", string.Format("{0} {1}. {2}", first_name, middle_name[0], last_name));
                        }

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

        public bool CancelPatientInScheduleWithoutExistingFirstAccount(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.patients
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    status = 'In Consultation';

                                    UPDATE pis_db.schedule
                                    SET status = 'Cancelled'
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    status = 'Waiting';";

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

                    sql = @"UPDATE pis_db.patients
                            SET status = 'Removed'
                            WHERE
                            CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                            status = 'In Consultation';

                            UPDATE pis_db.vital_signs
                            SET status = 'Removed'
                            WHERE patient_fid = @patient_fid AND status = 'In Consultation';

                            UPDATE pis_db.patient_doctor
                            SET status = 'Removed'
                            WHERE patient_fid = @patient_fid AND status = 'In Consultation';

                            UPDATE pis_db.symptoms
                            SET status = 'Removed'
                            WHERE patient_fid = @patient_fid AND status = 'In Consultation';";

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

        public bool CancelPatientInScheduleWithExistingFirstAccount(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT *
                                    FROM pis_db.patients
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    status = 'Complete';

                                    UPDATE pis_db.schedule
                                    SET status = 'Cancelled'
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    status = 'Waiting';";

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

                    sql = @"UPDATE pis_db.vital_signs
                            SET status = 'Removed'
                            WHERE patient_fid = @patient_fid AND status = 'In Consultation';

                            UPDATE pis_db.patient_doctor
                            SET status = 'Removed'
                            WHERE patient_fid = @patient_fid AND status = 'In Consultation';

                            UPDATE pis_db.symptoms
                            SET status = 'Removed'
                            WHERE patient_fid = @patient_fid AND status = 'In Consultation';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
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
                    string sql = @"UPDATE pis_db.diagnosis
                                    SET status = 'Deleted'
                                    WHERE
                                    patient_fid = @patient_fid AND status = 'In Consultation';

                                    UPDATE pis_db.schedule 
                                    SET status = 'Waiting'
                                    WHERE
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    status = 'Consulting';";

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

        public bool GetPatientFromSchedule(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    pis_db.patients.id,
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
                                    CAST(AES_DECRYPT(blood_pressure, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(doctor, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.patients
                                    INNER JOIN pis_db.vital_signs ON pis_db.patients.id = pis_db.vital_signs.id
                                    INNER JOIN pis_db.patient_doctor ON pis_db.patients.id = pis_db.patient_doctor.id
                                    WHERE 
                                    CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    CONCAT(pis_db.vital_signs.status = 'In Consultation', ' ', pis_db.patient_doctor.status = 'In Consultation');

                                    UPDATE pis_db.schedule SET status = 'Consulting' 
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
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
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
                                    id,
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
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
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

        public bool GetPatientIDAndDateCreated(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT id, date
                                    FROM pis_db.patients
                                    WHERE CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @patient_id AND
                                    status = 'Complete';";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientInSchedulePrimaryID = dt.Rows[0].Field<int>("id");
                            val.PatientInScheduleDateCreated = dt.Rows[0].Field<DateTime>("date");

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
                Console.WriteLine("Error getting patient date: " + ex.ToString());
                return false;
            }
        }
    }
}
