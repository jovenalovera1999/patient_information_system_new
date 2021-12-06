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
        public static string user_age;
        public string UserAge
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

        public string UserFullName
        {
            get
            {
                if(String.IsNullOrWhiteSpace(user_middle_name))
                {
                    return string.Format("{0} {1}", user_first_name, user_last_name);
                }
                else
                {
                    return string.Format("{0} {1}. {2}", user_first_name, user_middle_name[0], user_last_name);
                }
            }
        }

        // Patient values
        public static int patient_primary_id;
        public int PatientPrimaryID
        {
            get { return patient_primary_id; }
            set { patient_primary_id = value; }
        }

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
        public static string patient_age;
        public string PatientAge
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
        public static string patient_height;
        public string PatientHeight
        {
            get { return patient_height; }
            set { patient_height = value; }
        }
        public static string patient_weight;
        public string PatientWeight
        {
            get { return patient_weight; }
            set { patient_weight = value; }
        }
        public static string patient_temperature;
        public string PatientTemperature
        {
            get { return patient_temperature; }
            set { patient_temperature = value; }
        }
        public static string patient_pulse_rate;
        public string PatientPulseRate
        {
            get { return patient_pulse_rate; }
            set { patient_pulse_rate = value; }
        }
        public static string patient_blood_pressure;
        public string PatientBloodPressure
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

        public static string patient_doctor_id;
        public string PatientDoctorID
        {
            get { return patient_doctor_id; }
            set { patient_doctor_id = value; }
        }

        public string PatientFullName
        {
            get
            {
                if(String.IsNullOrWhiteSpace(patient_middle_name))
                {
                    return string.Format("{0} {1}", patient_first_name, patient_last_name);
                }
                else
                {
                    return string.Format("{0} {1}. {2}", patient_first_name, patient_middle_name[0], patient_last_name);
                }
            }
        }

        // Doctor values
        public static int doctor_primary_id;
        public int DoctorPrimaryID
        {
            get { return doctor_primary_id; }
            set { doctor_primary_id = value; }
        }
        public static string doctor_id;
        public string DoctorID
        {
            get { return doctor_id; }
            set { doctor_id = value; }
        }
        public static byte[] doctor_profile_picture;
        public byte[] DoctorProfilePicture
        {
            get { return doctor_profile_picture; }
            set { doctor_profile_picture = value; }
        }
        public static string doctor_first_name;
        public string DoctorFirstName
        {
            get { return doctor_first_name; }
            set { doctor_first_name = value; }
        }
        public static string doctor_middle_name;
        public string DoctorMiddleName
        {
            get { return doctor_middle_name; }
            set { doctor_middle_name = value; }
        }
        public static string doctor_last_name;
        public string DoctorLastName
        {
            get { return doctor_last_name; }
            set { doctor_last_name = value; }
        }
        public static string doctor_gender;
        public string DoctorGender
        {
            get { return doctor_gender; }
            set { doctor_gender = value; }
        }
        public static string doctor_age;
        public string DoctorAge
        {
            get { return doctor_age; }
            set { doctor_age = doctor_age = value; }
        }
        public static string doctor_address;
        public string DoctorAddress
        {
            get { return doctor_address; }
            set { doctor_address = value; }
        }
        public static DateTime doctor_birthday;
        public DateTime DoctorBirthday
        {
            get { return doctor_birthday; }
            set { doctor_birthday = value; }
        }
        public static string doctor_cellphone_number;
        public string DoctorCellphoneNumber
        {
            get { return doctor_cellphone_number; }
            set { doctor_cellphone_number = value; }
        }
        public static string doctor_telephone_number;
        public string DoctorTelephoneNumber
        {
            get { return doctor_telephone_number; }
            set { doctor_telephone_number = value; }
        }
        public static string doctor_email;
        public string DoctorEmail
        {
            get { return doctor_email; }
            set { doctor_email = value; }
        }
        public static string doctor_role;
        public string DoctorRole
        {
            get { return doctor_role; }
            set { doctor_role = value; }
        }
        public static string doctor_specialization;
        public string DoctorSpecialization
        {
            get { return doctor_specialization; }
            set { doctor_specialization = value; }
        }

        // Prescription date
        public static DateTime prescription_date;
        public DateTime PrescriptionDate
        {
            get { return prescription_date; }
            set { prescription_date = value; }
        }

        // Inventory values

        public static string supply_quantity;
        public string SupplyQuantity
        {
            get { return supply_quantity; }
            set { supply_quantity = value; }
        }

        // Report values

        public static string count_total_patients_in_month;
        public string CountTotalPatientsInMonth
        {
            get { return count_total_patients_in_month;}
            set { count_total_patients_in_month = value; }
        }
        public static string count_total_patients_in_day;
        public string CountTotalPatientsInDay
        {
            get { return count_total_patients_in_day;}
            set { count_total_patients_in_day = value; }
        }
        public static string count_total_patients_in_year;
        public string CountTotalPatientsInYear
        {
            get { return count_total_patients_in_year; }
            set { count_total_patients_in_year = value; }
        }
        public static string count_overall_total_patients;
        public string CountOverallTotalPatients
        {
            get { return count_overall_total_patients; }
            set { count_overall_total_patients = value; }
        }
        public static string count_total_sales_in_month;
        public string CountTotalSalesInMonth
        {
            get { return count_total_sales_in_month; }
            set { count_total_sales_in_month = value; }
        }
        public static string count_total_sales_in_day;
        public string CountTotalSalesInDay
        {
            get { return count_total_sales_in_day; }
            set { count_total_sales_in_day = value; }
        }
        public static string count_total_sales_in_year;
        public string CountTotalSalesInYear
        {
            get { return count_total_sales_in_year; }
            set { count_total_sales_in_year = value; }
        }
        public static string count_overall_total_sales;
        public string CountOverallTotalSales
        {
            get { return count_overall_total_sales; }
            set { count_overall_total_sales = value; }
        }

        // Transaction values

        public static int patient_primary_id_for_payment_transaction;
        public int PatientPrimaryIDForPaymentTransaction
        {
            get { return patient_primary_id_for_payment_transaction; }
            set { patient_primary_id_for_payment_transaction = value; }
        }
    }
}
