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
    class Doctor
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();


        // Load Doctor
        
        public void loadDoctors(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR) AS 'Doctor ID',
                                    CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR) AS 'First Name',
                                    CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR) AS 'Middle Name',
                                    CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR) AS 'Last Name',
                                    CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR) AS 'Specialization'
                                    FROM patient_information_db.users
                                    WHERE
                                    CAST(AES_DECRYPT(role, 'jovencutegwapo123') AS CHAR) = 'Doctor'";

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
                Console.WriteLine("Error loading doctors: " + ex.ToString());
            }
        }

        // Get Doctor

        public bool getDoctor(string user_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR),
                                    profile_picture,
                                    CAST(AES_DECRYPT(username, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(password, 'jovencutegwapo123') AS CHAR),
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
                                    CAST(AES_DECRYPT(role, 'jovencutegwapo123') AS CHAR),
                                    CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR)
                                    FROM patient_information_db.users
                                    WHERE CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR) = @user_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.DoctorID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
                            val.DoctorFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorAge = dt.Rows[0].Field<int>("age");
                            val.DoctorAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.DoctorCellphoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorRole = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(role, 'jovencutegwapo123') AS CHAR)");
                            val.DoctorSpecialization = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR)");

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
                Console.WriteLine("Error getting doctor: " + ex.ToString());
                return false;
            }
        }

        // Update Doctor

        public bool updateDoctor(string user_id, string first_name, string middle_name, string last_name, string gender, int age, string address, 
            DateTime birthday, string cellphone_number, string telephone_number, string email, string specialization)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE patient_information_db.users
                                    SET
                                    user_id = AES_ENCRYPT(@user_id, 'jovencutegwapo123'),
                                    first_name = AES_ENCRYPT(@first_name, 'jovencutegwapo123'),
                                    middle_name = AES_ENCRYPT(@middle_name, 'jovencutegwapo123'),
                                    last_name = AES_ENCRYPT(@last_name, 'jovencutegwapo123'),
                                    gender = AES_ENCRYPT(@gender, 'jovencutegwapo123'),
                                    age = @age,
                                    address = AES_ENCRYPT(@address, 'jovencutegwapo123'),
                                    birthday = @birthday,
                                    cellphone_number = AES_ENCRYPT(@cellphone_number, 'jovencutegwapo123'),
                                    telephone_number = AES_ENCRYPT(@telephone_number, 'jovencutegwapo123'),
                                    email = AES_ENCRYPT(@email, 'jovencutegwapo123'),
                                    specialization = AES_ENCRYPT(@specialization, 'jovencutegwapo123')
                                    WHERE
                                    CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR) = @user_id OR
                                    CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR) = @first_name AND 
                                    CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR) = @middle_name AND
                                    CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR) = @last_name OR
                                    CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR) = @first_name AND
                                    CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR) = @last_name;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
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
                        cmd.Parameters.AddWithValue("@specialization", specialization);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating doctor: " + ex.ToString());
                return false;
            }
        }
    }
}
