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
        public void LoadPatientsInSchedule(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_patient_in_schedule();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["doctor_fid"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(birthday, '%d %b %Y')"].HeaderText = "Birthday";
                        grid.Columns["CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Status";

                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading patient in schedule: " + ex.ToString());
            }
        }

        public void LoadPatients(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_patients();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(pis_db.patients.date, '%Y/%m/%d')"].HeaderText = "Date Updated";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading patients in patients: " + ex.ToString());
            }
        }

        public void LoadPatientsByDate(DateTime from, DateTime to, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_patients_by_date(@from, @to);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(pis_db.patients.gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(pis_db.patients.date, '%Y/%m/%d')"].HeaderText = "Date Updated";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading patients by date in patients: " + ex.ToString());
            }
        }

        public void LoadDoctorPatientsByDate(int doctor_fid, DateTime from, DateTime to, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_doctor_patients_by_date(@doctor_fid, @from, @to);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);
                        cmd.Parameters.AddWithValue("@from", from);
                        cmd.Parameters.AddWithValue("@to", to);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(date, '%Y/%m/%d')"].HeaderText = "Date Updated";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading doctor's patients: " + ex.ToString());
            }
        }

        public void LoadDoctorPatientsInSchedule(int doctor_fid, DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_doctor_patients_in_schedule(@doctor_fid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["doctor_fid"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(birthday, '%d %b %Y')"].HeaderText = "Birthday";
                        grid.Columns["CAST(AES_DECRYPT(status, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Status";

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading doctor's patients in schedule: " + ex.ToString());
            }
        }

        public void LoadDoctorPatients(int doctor_fid, DataGridView grid)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL load_doctor_patients(@doctor_fid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Patient ID";
                        grid.Columns["CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "First Name";
                        grid.Columns["CAST(AES_DECRYPT(middle_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Middle Name";
                        grid.Columns["CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Last Name";
                        grid.Columns["CAST(AES_DECRYPT(gender, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Gender";
                        grid.Columns["DATE_FORMAT(date, '%Y/%m/%d')"].HeaderText = "Date Updated";

                        connection.Close();
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
            string pulse_rate, string blood_pressure, string doctor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL get_doctor_primary_id_for_add_patient(@doctor);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor", doctor);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientDoctorPrimaryID = dt.Rows[0].Field<int>("id");
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                    
                    sql = @"CALL add_patient(@doctor_fid, @patient_id, @first_name, @middle_name, @last_name, @gender, @age, @address, @birthday, @cellphone_number, @telephone_number, @email);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", val.PatientDoctorPrimaryID);
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

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"CALL get_patient_primary_id_in_add_patient();";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                    }

                    sql = @"CALL add_vital_signs_in_add_patient(@patient_fid, @height, @weight, @temperature, @pulse_rate, @blood_pressure);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@pulse_rate", pulse_rate);
                        cmd.Parameters.AddWithValue("@blood_pressure", blood_pressure);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

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

        public bool AddPatientWithFirstAccountExisting(string patient_id, string first_name, string middle_name, string last_name, string gender,
            string age, string address, DateTime birthday, string cellphone_number, string telephone_number, string email, string height,
            string weight, string temperature, string pulse_rate, string blood_pressure, string doctor)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL get_doctor_primary_id_for_add_patient(@doctor);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor", doctor);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientDoctorPrimaryID = dt.Rows[0].Field<int>("id");
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                    
                    sql = @"CALL add_patient_duplicate(@doctor_fid, @patient_id, @first_name, @middle_name, @last_name, @gender, @age, @address, @birthday, @cellphone_number, @telephone_number, @email);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", val.PatientDoctorPrimaryID);
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

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"CALL get_patient_primary_id_complete_for_add_patient(@doctor_fid, @patient_id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor_fid", val.PatientDoctorPrimaryID);
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
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL add_vital_signs_in_add_patient(@patient_fid, @height, @weight, @temperature, @pulse_rate, @blood_pressure);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@temperature", temperature);
                        cmd.Parameters.AddWithValue("@pulse_rate", pulse_rate);
                        cmd.Parameters.AddWithValue("@blood_pressure", blood_pressure);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding patient to schedule with first account existing: " + ex.ToString());
                return false;
            }
        }

        // Save patient

        public bool DoneConsulting(string patient_id, int patient_fid, int doctor_fid, string full_name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL done_consulting(@patient_id, @patient_fid, @doctor_fid, @full_name)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating patient to done consulting or complete: " + ex.ToString());
                return false;
            }
        }

        public bool DoneConsultingWithFirstAccountExisting(string patient_id, int patient_fid, int doctor_fid, string full_name)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL done_consulting_with_first_account_existing(@patient_id, @patient_fid, @doctor_fid, @full_name);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);
                        cmd.Parameters.AddWithValue("@doctor_fid", doctor_fid);
                        cmd.Parameters.AddWithValue("@full_name", full_name);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"CALL update_existing_first_account_delete_duplicate(@patient_id, @first_name, @middle_name, @last_name, @gender, @age, @address, @birthday, @cellphone_number, @telephone_number,
                            @email);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@first_name", val.PatientFirstName);
                        cmd.Parameters.AddWithValue("@middle_name", val.PatientMiddleName);
                        cmd.Parameters.AddWithValue("@last_name", val.PatientLastName);
                        cmd.Parameters.AddWithValue("@gender", val.PatientGender);
                        cmd.Parameters.AddWithValue("@age", val.PatientAge);
                        cmd.Parameters.AddWithValue("@address", val.PatientAddress);
                        cmd.Parameters.AddWithValue("@birthday", val.PatientBirthday.Date);
                        cmd.Parameters.AddWithValue("@cellphone_number", val.PatientCellphoneNumer);
                        cmd.Parameters.AddWithValue("@telephone_number", val.PatientTelephoneNumber);
                        cmd.Parameters.AddWithValue("@email", val.PatientEmail);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating patient to done consulting or complete with first account existing: " + ex.ToString());
                return false;
            }
        }

        // Update patient

        public bool UpdatePatient(int id, string first_name, string middle_name, string last_name, string gender, string age, string address, DateTime birthday, string cellphone_number, string telephone_number, 
            string email, string user, string patient, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL update_patient(@id, @first_name, @middle_name, @last_name, @gender, @age, @address, @birthday, @cellphone_number, @telephone_number, @email, @user, @patient,
                                    @description);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@patient", patient);
                        cmd.Parameters.AddWithValue("@description", description);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

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

        public bool CancelPatientInSchedule(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL get_patient_primary_id_and_delete_patient_in_schedule(@patient_id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        connection.Open();
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
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL delete_patient_vital_signs_symptoms(@patient_id, @patient_fid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

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

        public bool CancelPatientInScheduleWithFirstAccountExisting(string patient_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL get_patient_primary_id_complete_and_delete_patient_in_schedule(@patient_id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        connection.Open();
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
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL delete_duplicate_patient_vital_signs_symptoms(@patient_id, @patient_fid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

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
                    string sql = @"CALL back_patient_to_schedule_from_consultation(@patient_id, @patient_fid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@patient_fid", patient_fid);

                        connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

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

        public bool GetPatientFromSchedule(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL get_patient_id_in_schedule(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL get_patient_in_schedule(@patient_id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", val.PatientID);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                            val.PatientDoctorPrimaryID = dt.Rows[0].Field<int>("doctor_fid");
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
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL update_patient_in_schedule_to_consulting(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error getting a patient from schedule: " + ex.ToString());
                return false;
            }
        }

        public bool GetPatientFromScheduleWithFirstAccountExisting(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL get_patient_id_in_schedule(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.PatientID = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(patient_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL get_patient_primary_id_from_patients(@patient_id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", val.PatientID);

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
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL get_patient_first_account_existing_for_consulting(@patient_id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", val.PatientID);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
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
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL get_patient_vital_signs_with_first_account_existing(@patient_fid);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@patient_fid", val.PatientPrimaryID);

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
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL update_patient_in_schedule_to_consulting(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                        connection.Close();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting a patient from schedule: " + ex.ToString());
                return false;
            }
        }

        public bool GetPatient(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"CALL get_patient(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            val.PatientPrimaryID = dt.Rows[0].Field<int>("id");
                            val.PatientDoctorPrimaryID = dt.Rows[0].Field<int>("doctor_fid");
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
                            connection.Close();
                            return false;
                        }
                    }

                    sql = @"CALL get_patient_doctor(@id);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", val.PatientDoctorPrimaryID);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if(dt.Rows.Count == 1)
                        {
                            val.DoctorFirstName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(first_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.DoctorLastName = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(last_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.DoctorSpecialization = dt.Rows[0].Field<string>("CAST(AES_DECRYPT(specialization, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)");
                            val.PatientDoctor = string.Format("Dr. {0} {1} ({2})", val.DoctorFirstName, val.DoctorLastName, val.DoctorSpecialization);
                            connection.Close();

                            return true;
                        }
                        else
                        {
                            connection.Close();
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
