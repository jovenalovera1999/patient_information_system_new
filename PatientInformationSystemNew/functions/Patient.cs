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
        public void loadPatientInSchedule(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) AS 'Patient ID',
                                    CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR) AS 'First Name', 
                                    CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR) AS 'Middle Name',
                                    CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR) AS 'Last Name',
                                    CAST(AES_DECRYPT(gender, 'jovencutegwapo123') AS CHAR) AS 'Gender',
                                    birthday AS 'Birthday',
                                    status AS 'Status'
                                    FROM patient_information_db.schedule";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
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

        // Add patient
        public bool addPatient(string patient_id, string first_name, string middle_name, string last_name, string gender, int age, string address, 
            DateTime birthday, string cellphone_number, string telephone_number, string email, double height, double weight, double temperature, 
            double pulse_rate, double blood_pressure, string doctor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.schedule(patient_id, first_name, middle_name, last_name, gender, age, 
                                    address, birthday, cellphone_number, telephone_number, email, height, weight, temperature, pulse_rate, 
                                    blood_pressure, doctor)
                                    VALUES(
                                    AES_ENCRYPT(@patient_id, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@first_name, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@middle_name, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@last_name, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@gender, 'jovencutegwapo123'), 
                                    @age, 
                                    AES_ENCRYPT(@address, 'jovencutegwapo123'), 
                                    @birthday, 
                                    AES_ENCRYPT(@cellphone_number, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@telephone_number, 'jovencutegwapo123'), 
                                    AES_ENCRYPT(@email, 'jovencutegwapo123'), 
                                    @height, 
                                    @weight, 
                                    @temperature, 
                                    @pulse_rate, 
                                    @blood_pressure, 
                                    AES_ENCRYPT(@doctor, 'jovencutegwapo123')
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

        public bool getPatientFromSchedule(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(gender, 'jovencutegwapo123') AS CHAR),
                                    age,
                                    CAST(AES_DECRYPT(address, 'jovencutegwapo123') AS CHAR),
                                    birthday,
                                    CAST(AES_DECRYPT(cellphone_number, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(telephone_number, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(email, 'jovencutegwapo123') AS CHAR),
                                    height,
                                    weight,
                                    temperature,
                                    pulse_rate,
                                    blood_pressure,
                                    CAST(AES_DECRYPT(doctor, 'jovencutegwapo123') AS CHAR)
                                    FROM patient_information_db.schedule 
                                    WHERE CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id;

                                    UPDATE patient_information_db.schedule SET status = 'Consulting' 
                                    WHERE CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR)");
                            val.PatientFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR)");
                            val.PatientMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR)");
                            val.PatientLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR)");
                            val.PatientGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'jovencutegwapo123') AS CHAR)");
                            val.PatientAge = dt.Rows[0].Field<int>("age");
                            val.PatientAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'jovencutegwapo123') AS CHAR)");
                            val.PatientBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.PatientCellphoneNumer = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'jovencutegwapo123') AS CHAR)");
                            val.PatientTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'jovencutegwapo123') AS CHAR)");
                            val.PatientEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'jovencutegwapo123') AS CHAR)");
                            val.PatientHeight = dt.Rows[0].Field<double>("height");
                            val.PatientWeight = dt.Rows[0].Field<double>("weight");
                            val.PatientTemperature = dt.Rows[0].Field<double>("temperature");
                            val.PatientPulseRate = dt.Rows[0].Field<double>("pulse_rate");
                            val.PatientBloodPressure = dt.Rows[0].Field<double>("blood_pressure");
                            val.PatientDoctor = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(doctor, 'jovencutegwapo123') AS CHAR)");

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

        public bool cancelPatientInSchedule(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE 
                                    FROM patient_information_db.users 
                                    WHERE CAST(AES_DECRYPT(patient_id, 'jovencutegwapo123') AS CHAR) = @patient_id;";

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
                Console.WriteLine("Error deleting patient in schedule: " + ex.ToString());
                return false;
            }
        }
    }
}
