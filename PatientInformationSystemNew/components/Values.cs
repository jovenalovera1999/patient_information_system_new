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

        // Patient values
        public static string patient_id;
        public string PatientID
        {
            get { return patient_id; }
            set { patient_id = value; }
        }
        public static string patient_first_name;
        public string PatientFirstName
        {
            get { return patient_first_name; }
            set { patient_first_name = value; }
        }
        public static string patient_middle_name;
        public string PatientMiddleName
        {
            get { return patient_middle_name; }
            set { patient_middle_name = value; }
        }
        public static string patient_last_name;
        public string PatientLastName
        {
            get { return patient_last_name; }
            set { patient_last_name = value; }
        }
        public static string patient_gender;
        public string PatientGender
        {
            get { return patient_gender; }
            set { patient_gender = value; }
        }
        public static int patient_age;
        public int PatientAge
        {
            get { return patient_age; }
            set { patient_age = value; }
        }
        public static string patient_address;
        public string PatientAddress
        {
            get { return patient_address; }
            set { patient_address = value; }
        }

        public static DateTime patient_birthday;
        public DateTime PatientBirthday
        {
            get { return patient_birthday; }
            set { patient_birthday = value; }
        }
        public static string patient_cellphone_number;
        public string PatientCellphoneNumer
        {
            get { return patient_cellphone_number; }
            set { patient_cellphone_number = value; }
        }
        public static string patient_telephone_number;
        public string PatientTelephoneNumber
        {
            get { return patient_telephone_number; }
            set { patient_telephone_number = value; }
        }
        public static string patient_email;
        public string PatientEmail
        {
            get { return patient_email; }
            set { patient_email = value; }
        }
        public static double patient_height;
        public double PatientHeight
        {
            get { return patient_height; }
            set { patient_height = value; }
        }
        public static double patient_weight;
        public double PatientWeight
        {
            get { return patient_weight; }
            set { patient_weight = value; }
        }
        public static double patient_temperature;
        public double PatientTemperature
        {
            get { return patient_temperature; }
            set { patient_temperature = value; }
        }
        public static double patient_pulse_rate;
        public double PatientPulseRate
        {
            get { return patient_pulse_rate; }
            set { patient_pulse_rate = value; }
        }
        public static double patient_blood_pressure;
        public double PatientBloodPressure
        {
            get { return patient_blood_pressure; }
            set { patient_blood_pressure = value; }
        }
        public static string patient_doctor;
        public string PatientDoctor
        {
            get { return patient_doctor; }
            set { patient_doctor = value; }
        }
    }
}
