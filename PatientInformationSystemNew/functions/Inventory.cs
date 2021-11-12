﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace PatientInformationSystemNew.functions
{
    class Inventory
    {
        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        // Load

        public void loadInventory(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                CAST(AES_DECRYPT(supply_id, 'jovencutegwapo123') AS CHAR) AS 'Supply ID',
                                CAST(AES_DECRYPT(supply_name, 'jovencutegwapo123') AS CHAR) AS 'Supply Name',
                                CAST(AES_DECRYPT(quantity, 'jovencutegwapo123') AS CHAR) AS 'Quantity',
                                expiration_date AS 'Expiration Date'
                                FROM patient_information_db.inventory;";

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
                Console.WriteLine("Error loading supplies: " + ex.ToString());
            }
        }

        public void loadIncomingInventory(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                CAST(AES_DECRYPT(supply_id, 'jovencutegwapo123') AS CHAR) AS 'Supply ID',
                                CAST(AES_DECRYPT(supply_name, 'jovencutegwapo123') AS CHAR) AS 'Supply Name',
                                CAST(AES_DECRYPT(quantity, 'jovencutegwapo123') AS CHAR) AS 'Quantity',
                                DATE_FORMAT(expiration_date, '%M %d, %Y') AS 'Expiration Date',
                                CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left') AS 'Expire In',
                                DATE_FORMAT(arrive_date, '%M %d, %Y') AS 'Arrive Date',
                                CONCAT(DATEDIFF(arrive_date, NOW()), ' Days Left') AS 'Arrive In'
                                FROM patient_information_db.inventory_incoming;";

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
                Console.WriteLine("Error loading incoming supplies: " + ex.ToString());
            }
        }

        // Add

        public bool addIncomingSuppliesWithExpiration(string supply_id, string supply_name, string quantity, DateTime expiration_date, DateTime arrive_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.inventory_incoming(supply_id, supply_name, quantity, expiration_date, arrive_date)
                                    VALUES(
                                    AES_ENCRYPT(@supply_id, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@supply_name, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@quantity, 'jovencutegwapo123'),
                                    @expiration_date,
                                    @arrive_date
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);
                        cmd.Parameters.AddWithValue("@arrive_date", arrive_date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error adding incoming supply: " + ex.ToString());
                return false;
            }
        }

        public bool addIncomingSuppliesWithoutExpiration(string supply_id, string supply_name, string quantity, DateTime arrive_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO patient_information_db.inventory_incoming(supply_id, supply_name, quantity, arrive_date)
                                    VALUES(
                                    AES_ENCRYPT(@supply_id, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@supply_name, 'jovencutegwapo123'),
                                    AES_ENCRYPT(@quantity, 'jovencutegwapo123'),
                                    @arrive_date
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@arrive_date", arrive_date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding incoming supply: " + ex.ToString());
                return false;
            }
        }

        // Update

        public bool updateSupplyWithExpiration(string supply_id, string supply_name, string quantity, DateTime expiration_date, DateTime arrive_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE patient_information_db.inventory_incoming
                                    SET 
                                    supply_name = AES_ENCRYPT(@supply_name, 'jovencutegwapo123'),
                                    quantity = AES_ENCRYPT(@quantity, 'jovencutegwapo123'),
                                    expiration_date = @expiration_date,
                                    arrive_date = @arrive_date
                                    WHERE
                                    CAST(AES_DECRYPT(supply_id, 'jovencutegwapo123') AS CHAR) = @supply_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);
                        cmd.Parameters.AddWithValue("@arrive_date", arrive_date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating supply without expiration: " + ex.ToString());
                return false;
            }
        }

        public bool updateSupplyWithoutExpiration(string supply_id, string supply_name, string quantity, DateTime arrive_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"UPDATE patient_information_db.inventory_incoming
                                    SET 
                                    supply_name = AES_ENCRYPT(@supply_name, 'jovencutegwapo123'),
                                    quantity = AES_ENCRYPT(@quantity, 'jovencutegwapo123'),
                                    arrive_date = @arrive_date
                                    WHERE
                                    CAST(AES_DECRYPT(supply_id, 'jovencutegwapo123') AS CHAR) = @supply_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@arrive_date", arrive_date);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error updating supply without expiration: " + ex.ToString());
                return false;
            }
        }

        // Delete

        public bool deleteIncomingSupply(string supply_id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"DELETE FROM patient_information_db.inventory_incoming
                                    WHERE CAST(AES_DECRYPT(supply_id, 'jovencutegwapo123') AS CHAR) = @supply_id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);

                        connection.Open();
                        cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error canceling incoming supply: " + ex.ToString());
                return false;
            }
        }
    }
}