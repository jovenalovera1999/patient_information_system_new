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

        // Sign Up User

        public bool SignUp(string user_id, byte[] profile_picture, string username, string password, string first_name, 
            string middle_name, string last_name, string gender, string age, string address, DateTime birthday, string cellphone_number, 
            string telephone_number, string email, string role, string specialization)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.users(user_id, profile_picture, username, password, first_name, middle_name, 
                                    last_name, gender, age, address, birthday, cellphone_number, telephone_number, email, role, specialization)
                                    VALUES(
                                    AES_ENCRYPT(@user_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @profile_picture,
                                    AES_ENCRYPT(@username, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@password, 'j0v3ncut3gw4p0per0jok3l4ang'),
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
                                    AES_ENCRYPT(@role, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@specialization, 'j0v3ncut3gw4p0per0jok3l4ang')
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
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

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

        // User Authentication

        public bool UserAuthentication(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    id,
                                    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    profile_picture,
                                    CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
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
                                    CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.users
                                    WHERE CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @username AND 
                                    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @password;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.UserPrimaryID = dt.Rows[0].Field<int>("id");
                            val.UserID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
                            val.UserUsername = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserAge = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.UserCellphoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserRole = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserSpecialization = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");

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

        // User Authentication for Fixed Administrator Only
        public bool UserAuthenticationForAdministratorOnly(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    id,
                                    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    profile_picture,
                                    CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
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
                                    CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.users
                                    WHERE CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @username AND 
                                    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @password;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.UserPrimaryID = dt.Rows[0].Field<int>("id");
                            val.UserID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
                            val.UserUsername = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserAge = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserBirthday = DateTime.Now.Date;
                            val.UserCellphoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserRole = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserSpecialization = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");

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

        // Get User

        public bool GetUser(string user_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT 
                                    id,
                                    CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    profile_picture,
                                    CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
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
                                    CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)
                                    FROM pis_db.users
                                    WHERE CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @user_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.UserPrimaryID = dt.Rows[0].Field<int>("id");
                            val.UserID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(user_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserProfilePicture = dt.Rows[0].Field<byte[]>("profile_picture");
                            val.UserUsername = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(username, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserPassword = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(password, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserMiddleName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserGender = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserAge = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(age, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserAddress = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(address, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserBirthday = dt.Rows[0].Field<DateTime>("birthday");
                            val.UserCellphoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(cellphone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserTelephoneNumber = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(telephone_number, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserEmail = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(email, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserRole = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(role, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.UserSpecialization = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");

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

        //  Update User

        public bool UpdateUser(int id, byte[] profile_picture, string username, string password, string first_name, string middle_name, 
            string last_name, string gender, string age, string address, DateTime birthday, string cellphone_number, string telephone_number,
            string email, string update_id, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history(update_id, user, description)
                                    VALUES
                                    (
                                    AES_ENCRYPT(@update_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.users
                                    SET 
                                    profile_picture = @profile_picture,
                                    username = AES_ENCRYPT(@username, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    password = AES_ENCRYPT(@password, 'j0v3ncut3gw4p0per0jok3l4ang'),
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
                                    id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
                        cmd.Parameters.AddWithValue("@update_id", update_id);
                        cmd.Parameters.AddWithValue("@user", user);
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
                Console.WriteLine("Error updating user: " + ex.ToString());
                return false;
            }
        }
    }
}
