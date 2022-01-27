using System;
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

        public void LoadInventory(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    id,
                                    CAST(AES_DECRYPT(supply_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    DATE_FORMAT(expiration_date, '%Y/%m/%d'),
                                    CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left')
                                    FROM pis_db.inventory
                                    ORDER BY CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(supply_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Supply ID";
                        grid.Columns["CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Supply Name";
                        grid.Columns["CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Quantity";
                        grid.Columns["DATE_FORMAT(expiration_date, '%Y/%m/%d')"].HeaderText = "Expire On";
                        grid.Columns["CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left')"].HeaderText = "Expired In";
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading supplies: " + ex.ToString());
            }
        }

        public void LoadIncomingInventory(DataGridView grid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT
                                    id,
                                    CAST(AES_DECRYPT(supply_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR),
                                    DATE_FORMAT(expiration_date, '%Y/%m/%d'),
                                    CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left'),
                                    DATE_FORMAT(arrive_date, '%Y/%m/%d'),
                                    CONCAT(DATEDIFF(arrive_date, NOW()), ' Days Left')
                                    FROM pis_db.inventory_incoming
                                    ORDER BY CONCAT(DATEDIFF(arrive_date, NOW()), ' Days Left') ASC;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        grid.DataSource = dt;
                        grid.ClearSelection();

                        grid.Columns["id"].Visible = false;
                        grid.Columns["CAST(AES_DECRYPT(supply_id, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Supply ID";
                        grid.Columns["CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Supply Name";
                        grid.Columns["CAST(AES_DECRYPT(quantity, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR)"].HeaderText = "Quantity";
                        grid.Columns["DATE_FORMAT(expiration_date, '%Y/%m/%d')"].HeaderText = "Expiration Date";
                        grid.Columns["CONCAT(DATEDIFF(expiration_date, NOW()), ' Days Left')"].HeaderText = "Expired In";
                        grid.Columns["DATE_FORMAT(arrive_date, '%Y/%m/%d')"].HeaderText = "Arrive On";
                        grid.Columns["CONCAT(DATEDIFF(arrive_date, NOW()), ' Days Left')"].HeaderText = "Arrived In";
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error loading incoming supplies: " + ex.ToString());
            }
        }

        // Transfer

        public bool SupplyArrivedWithExpiration(int id, string supply_id, string supply_name, string quantity, DateTime expiration_date)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.inventory(supply_id, supply_name, quantity, expiration_date)
                                    VALUES(
                                    AES_ENCRYPT(@supply_id, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    @expiration_date);

                                    DELETE FROM pis_db.inventory_incoming
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);

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
                Console.WriteLine("Error transferring supply with expiration date: " + ex.ToString());
                return false;
            }
        }

        public bool SupplyArrivedWithoutExpiration(int id, string supply_id, string supply_name, string quantity)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.inventory(supply_id, supply_name, quantity)
                                    VALUES(
                                    AES_ENCRYPT(@supply_id, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'), 
                                    AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang'));

                                    DELETE FROM pis_db.inventory_incoming
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

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
                Console.WriteLine("Error transferring supply without expiration date: " + ex.ToString());
                return false;
            }
        }

        // Add

        public bool AddIncomingSuppliesWithExpiration(string supply_id, string supply_name, string quantity, DateTime expiration_date,
            DateTime arrive_date, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    INSERT INTO pis_db.inventory_incoming(supply_id, supply_name, quantity, expiration_date, arrive_date)
                                    VALUES(
                                    AES_ENCRYPT(@supply_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
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
                Console.WriteLine("Error adding incoming supply: " + ex.ToString());
                return false;
            }
        }

        public bool AddIncomingSuppliesWithoutExpiration(string supply_id, string supply_name, string quantity, DateTime arrive_date, string user,
            string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    INSERT INTO pis_db.inventory_incoming(supply_id, supply_name, quantity, arrive_date)
                                    VALUES(
                                    AES_ENCRYPT(@supply_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @arrive_date
                                    );";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@arrive_date", arrive_date);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error adding incoming supply: " + ex.ToString());
                return false;
            }
        }

        public bool AddSupplyWithExpiration(string supply_id, string supply_name, string quantity, DateTime expiration_date, string user,
            string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    INSERT INTO pis_db.inventory(supply_id, supply_name, quantity, expiration_date)
                                    VALUES(
                                    AES_ENCRYPT(@supply_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    @expiration_date);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);
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
                Console.WriteLine("Error adding supply with expiration date: " + ex.ToString());
                return false;
            }
        }

        public bool AddSupplyWithoutExpiration(string supply_id, string supply_name, string quantity, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    INSERT INTO pis_db.inventory(supply_id, supply_name, quantity)
                                    VALUES(
                                    AES_ENCRYPT(@supply_id, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang'));";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_id", supply_id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
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
                Console.WriteLine("Error adding supply without expiration: " + ex.ToString());
                return false;
            }
        }

        // Update

        public bool UpdateIncomingSupplyWithExpiration(int id, string supply_name, string quantity, DateTime expiration_date,
            DateTime arrive_date, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.inventory_incoming
                                    SET 
                                    supply_name = AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    quantity = AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    expiration_date = @expiration_date,
                                    arrive_date = @arrive_date
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);
                        cmd.Parameters.AddWithValue("@arrive_date", arrive_date);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error updating supply without expiration: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateIncomingSupplyWithoutExpiration(int id, string supply_name, string quantity, DateTime arrive_date, string user,
            string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.inventory_incoming
                                    SET 
                                    supply_name = AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    quantity = AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    arrive_date = @arrive_date
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@arrive_date", arrive_date);
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
                Console.WriteLine("Error updating supply without expiration: " + ex.ToString());
                return false;
            }
        }

        public bool SaveManageSuppliesWithExpiration(int id, string supply_name, string quantity, DateTime expiration_date, string user,
            string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.inventory
                                    SET 
                                    supply_name = AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    quantity = AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    expiration_date = @expiration_date
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@expiration_date", expiration_date);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error saving updated supply with expiration in manage supplies: " + ex.ToString());
                return false;
            }
        }

        public bool SaveManageSuppliesWithoutExpiration(int id, string supply_name, string quantity, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.inventory
                                    SET 
                                    supply_name = AES_ENCRYPT(@supply_name, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    quantity = AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error saving updated supply without expiration in manage supplies: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateQuantityOfSupplyFromIncomingSupply(int id, string supply_name, string quantity, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.inventory
                                    SET quantity = AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @supply_name;

                                    DELETE FROM pis_db.inventory_incoming
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
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
                Console.WriteLine("Error updating supply quantity from incoming supplies: " + ex.ToString());
                return false;
            }
        }

        public bool UpdateQuantityOfExistingSupplyWithoutExpiration(string supply_name, string quantity, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );  

                                    UPDATE pis_db.inventory
                                    SET quantity = AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE CAST(AES_DECRYPT(supply_name, 'j0v3ncut3gw4p0per0jok3l4ang') AS CHAR) = @supply_name;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@supply_name", supply_name);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
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
                Console.WriteLine("Error updating the existing supply in manage supplies: " + ex.ToString());
                return false;
            }
        }

        public bool ItemUsed(int id, string quantity, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    UPDATE pis_db.inventory
                                    SET quantity = AES_ENCRYPT(@quantity, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
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
                Console.WriteLine("Error updating supply by deducting quantity: " + ex.ToString());
                return false;
            }
        }

        // Delete

        public bool DeleteIncomingSupply(int id, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );

                                    DELETE FROM pis_db.inventory_incoming
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
                Console.WriteLine("Error updating incoming supply to removed: " + ex.ToString());
                return false;
            }
        }

        public bool DeleteSupply(int id, string user, string description)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"INSERT INTO pis_db.update_history_inventory(user, description)
                                    VALUES(
                                    AES_ENCRYPT(@user, 'j0v3ncut3gw4p0per0jok3l4ang'),
                                    AES_ENCRYPT(@description, 'j0v3ncut3gw4p0per0jok3l4ang')
                                    );
   
                                    DELETE FROM pis_db.inventory
                                    WHERE id = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error updating supply to removed: " + ex.ToString());
                return false;
            }
        }
    }
}
