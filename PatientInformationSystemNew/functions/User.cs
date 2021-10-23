using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PatientInformationSystemNew.functions
{
    class User
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        // Sign up user with profile picture
        public bool signUpWithProfilePicture(string user_id, byte[] profile_picture, string username, string password, string first_name, 
            string middle_name, string last_name, string gender, int age, string address, DateTime birthday, string cellphone_number, 
            string telephone_number, string email, string role, string specialization)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.users(user_id, profile_picture, username, password, first_name, middle_name, 
                                    last_name, gender, age, address, birthday, cellphone_number, telephone_number, email, role, specialization)
                                    VALUES(
                                    AES_ENCRYPT(@user_id, 'jovencutegwapo123'),
                                    @profile_picture,
                                    AES_ENCRYPT(@username, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@password, 'jovencutegwapo123'),
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
                                    AES_ENCRYPT(@role, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@specialization, 'jovencutegwapo123')
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        cmd.Parameters.AddWithValue("@profile_picture", profile_picture);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
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
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@specialization", specialization);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding a user with profile picture: " + ex.ToString());
                return false;
            }
        }

        // Sign up user without profile picture
        public bool signUpWithoutProfilePicture(string user_id, string username, string password, string first_name, string middle_name,
            string last_name, string gender, int age, string address, DateTime birthday, string cellphone_number, string telephone_number,
            string email, string role, string specialization)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.users(user_id, username, password, first_name, middle_name, 
                                    last_name, gender, age, address, birthday, cellphone_number, telephone_number, email, role, specialization)
                                    VALUES(
                                    AES_ENCRYPT(@user_id, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@username, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@password, 'jovencutegwapo123'),
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
                                    AES_ENCRYPT(@role, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@specialization, 'jovencutegwapo123')
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
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
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@specialization", specialization);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding a user without profile picture: " + ex.ToString());
                return false;
            }
        }

        // User Authentication
        public bool userAuthentication(string username, string password)
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
                                    WHERE CAST(AES_DECRYPT(username, 'jovencutegwapo123') AS CHAR) = @username AND 
                                    CAST(AES_DECRYPT(password, 'jovencutegwapo123') AS CHAR) = @password;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.UserID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR)");
                            val.UserProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
                            val.UserUsername = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(username, 'jovencutegwapo123') AS CHAR)");
                            val.UserPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(password, 'jovencutegwapo123') AS CHAR)");
                            val.UserFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR)");
                            val.UserMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR)");
                            val.UserLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR)");
                            val.UserGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'jovencutegwapo123') AS CHAR)");
                            val.UserAge = dt.Rows[0].Field<int>("age");
                            val.UserAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'jovencutegwapo123') AS CHAR)");
                            val.UserBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.UserCellphoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'jovencutegwapo123') AS CHAR)");
                            val.UserTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'jovencutegwapo123') AS CHAR)");
                            val.UserEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'jovencutegwapo123') AS CHAR)");
                            val.UserRole = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(role, 'jovencutegwapo123') AS CHAR)");
                            val.UserSpecialization = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR)");

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
                Console.WriteLine("Error authenticating user: " + ex.ToString());
                return false;
            }
        }

        // User authentication for fixed Administrator only
        public bool userAuthenticationForAdministratorOnly(string username, string password)
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
                                    WHERE CAST(AES_DECRYPT(username, 'jovencutegwapo123') AS CHAR) = @username AND 
                                    CAST(AES_DECRYPT(password, 'jovencutegwapo123') AS CHAR) = @password;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.UserID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(user_id, 'jovencutegwapo123') AS CHAR)");
                            val.UserProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
                            val.UserUsername = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(username, 'jovencutegwapo123') AS CHAR)");
                            val.UserPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(password, 'jovencutegwapo123') AS CHAR)");
                            val.UserFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'jovencutegwapo123') AS CHAR)");
                            val.UserMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'jovencutegwapo123') AS CHAR)");
                            val.UserLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'jovencutegwapo123') AS CHAR)");
                            val.UserGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'jovencutegwapo123') AS CHAR)");
                            val.UserAge = dt.Rows[0].Field<int>("age");
                            val.UserAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'jovencutegwapo123') AS CHAR)");
                            val.UserBirthday = DateTime.Now;
                            val.UserCellphoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'jovencutegwapo123') AS CHAR)");
                            val.UserTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'jovencutegwapo123') AS CHAR)");
                            val.UserEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'jovencutegwapo123') AS CHAR)");
                            val.UserRole = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(role, 'jovencutegwapo123') AS CHAR)");
                            val.UserSpecialization = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(specialization, 'jovencutegwapo123') AS CHAR)");

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
                Console.WriteLine("Error authenticating user: " + ex.ToString());
                return false;
            }
        }
    }
}
