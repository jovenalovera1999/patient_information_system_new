using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystemNew.components
{
    class Values
    {
        // Server values
        public string server_name = "localhost";
        public string server_user = "root";
        public string server_pass = "";

        // User values
        public static string user_id;
        public string UserID
        {
            get { return user_id; }
            set { user_id = value; }
        }
        public static byte[] user_profile_picture;
        public byte[] UserProfilePicture
        {
            get { return user_profile_picture; }
            set { user_profile_picture = value; }
        }
        public static string user_username;
        public string UserUsername
        {
            get { return user_username; }
            set { user_username = value; }
        }
        public static string user_password;
        public string UserPassword
        {
            get { return user_password; }
            set { user_password = value; }
        }
        public static string user_first_name;
        public string UserFirstName
        {
            get { return user_first_name; }
            set { user_first_name = value; }
        }
        public static string user_middle_name;
        public string UserMiddleName
        {
            get { return user_middle_name; }
            set { user_middle_name = value; }
        }
        public static string user_last_name;
        public string UserLastName
        {
            get { return user_last_name; }
            set { user_last_name = value; }
        }
        public static string user_gender;
        public string UserGender
        {
            get { return user_gender; }
            set { user_gender = value; }
        }
        public static int user_age;
        public int UserAge
        {
            get { return user_age; }
            set { user_age = value; }
        }
        public static DateTime user_birthday;
        public DateTime UserBirthday
        {
            get { return user_birthday; }
            set { user_birthday = value; }
        }
        public static string user_address;
        public string UserAddress
        {
            get { return user_address; }
            set { user_address = value; }
        }
        public static string user_cellphone_number;
        public string UserCellphoneNumber
        {
            get { return user_cellphone_number; }
            set { user_cellphone_number = value; }
        }
        public static string user_telephone_number;
        public string UserTelephoneNumber
        {
            get { return user_telephone_number; }
            set { user_telephone_number = value; }
        }
        public static string user_email;
        public string UserEmail
        {
            get { return user_email; }
            set { user_email = value; }
        }
        public static string user_role;
        public string UserRole
        {
            get { return user_role; }
            set { user_role = value; }
        }
        public static string user_specialization;
        public string UserSpecialization
        {
            get { return user_specialization; }
            set { user_specialization = value; }
        }
    }
}
