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
                        cmd.Parameters.AddWithValue("@address", age);
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
    }
}
