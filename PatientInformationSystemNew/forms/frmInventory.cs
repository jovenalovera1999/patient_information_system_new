using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientInformationSystemNew.forms
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.Inventory inventory = new functions.Inventory();
        functions.Duplicate duplicate = new functions.Duplicate();

        void AutoGenNum()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 8)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtSupplyID.Text = generateID.ToString();
            this.txtSupplyIDManageSupplies.Text = generateID.ToString();
        }

        void SetDateTimeToTodayInIncomingSupplies()
        {
            this.dateExpiration.Value = DateTime.Now;
            this.dateArrive.Value = DateTime.Now;
        }

        void IncomingSuppliesArrivedMessage()
        {
            for (int i = 0; i < this.gridIncomingSupplies.Rows.Count; i++)
            {
                if (this.gridIncomingSupplies.Rows[i].Cells[8].Value.ToString() == "0 Days Left")
                {
                    MessageBox.Show("One or more incoming supply/supplies will arrived today!", "Reminder", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                }
            }
        }

        void LoadForm()
        {
            AutoGenNum();
            SetDateTimeToTodayInIncomingSupplies();
            this.dateExpirationManageSupplies.Value = DateTime.Now;

            inventory.LoadInventory(this.gridSupplies);
            inventory.LoadIncomingInventory(this.gridIncomingSupplies);
            inventory.LoadInventory(this.gridManageSupplies);

            IncomingSuppliesArrivedMessage();
        }

        void ExpirationDateEnabledInIncomingSupplies()
        {
            if (this.switchExpirationDate.Checked)
            {
                this.dateExpiration.Enabled = true;
            }
            else
            {
                this.dateExpiration.Enabled = false;
            }
        }

        void SelectIncomingSupply()
        {
            this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSupplier.Text = this.gridIncomingSupplies.SelectedCells[2].Value.ToString();
            this.txtSupplyID.Text = this.gridIncomingSupplies.SelectedCells[1].Value.ToString();
            this.txtSupplyName.Text = this.gridIncomingSupplies.SelectedCells[3].Value.ToString();
            this.txtSupplyQuantity.Text = this.gridIncomingSupplies.SelectedCells[4].Value.ToString();
            this.dateArrive.Value = DateTime.Parse(this.gridIncomingSupplies.SelectedCells[7].Value.ToString());

            if (String.IsNullOrWhiteSpace(this.gridIncomingSupplies.SelectedCells[5].Value.ToString()))
            {
                this.switchExpirationDate.Checked = false;
                this.dateExpiration.Value = DateTime.Now;
            }
            else
            {
                this.switchExpirationDate.Checked = true;
                this.dateExpiration.Value = DateTime.Parse(this.gridIncomingSupplies.SelectedCells[5].Value.ToString());
            }

            this.btnEditIncomingSupplies.Enabled = true;
            this.btnSaveIncomingSupplies.Enabled = true;
            this.btnSupplyArrived.Enabled = true;
            this.btnDeleteIncomingSupplies.Enabled = true;

            this.btnAddIncomingSupplies.Enabled = false;

            this.txtSupplier.Focus();
        }

        void ResetTextInIncomingSupplies()
        {
            this.txtSupplier.ResetText();
            this.txtSupplyName.ResetText();
            this.txtSupplyQuantity.ResetText();
        }

        void AddIncomingSupply()
        {
            if(String.IsNullOrWhiteSpace(this.txtSupplier.Text) && String.IsNullOrWhiteSpace(this.txtSupplyName.Text) && String.IsNullOrWhiteSpace(this.txtSupplyQuantity.Text))
            {
                MessageBox.Show("Supplier, supply name and quantity are required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplier.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyName.Text) && String.IsNullOrWhiteSpace(this.txtSupplyQuantity.Text))
            {
                MessageBox.Show("Supply name and quantity are required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtSupplier.Text))
            {
                MessageBox.Show("Supply name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplier.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyName.Text))
            {
                MessageBox.Show("Supply name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyQuantity.Text))
            {
                MessageBox.Show("Supply quantity is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyQuantity.Focus();
            }
            else if (this.switchExpirationDate.Checked == true)
            {
                if (inventory.AddIncomingSuppliesWithExpiration(this.txtSupplier.Text, this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text,
                    this.dateExpiration.Value, this.dateArrive.Value, val.UserFullName,
                    string.Format("Added incoming supply with expiration!\r\n" +
                    "Supply ID: {0}\r\n" +
                    "Supplier: {1}\r\n" +
                    "Supply Name: {2}\r\n" +
                    "Quantity: {3}\r\n" +
                    "Expiration Date: {4}\r\n" +
                    "Arrive Date: {5}",
                    this.txtSupplyID.Text,
                    this.txtSupplier.Text,
                    this.txtSupplyName.Text,
                    this.txtSupplyQuantity.Text,
                    this.dateExpiration.Value.ToString("D"),
                    this.dateArrive.Value.ToString("D"))))
                {
                    MessageBox.Show("Incoming supply successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    inventory.LoadIncomingInventory(this.gridIncomingSupplies);

                    AutoGenNum();
                    ResetTextInIncomingSupplies();
                    SetDateTimeToTodayInIncomingSupplies();

                    this.switchExpirationDate.Checked = false;
                    this.txtSupplier.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to add incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.dateExpiration.Checked == false)
            {
                if (inventory.AddIncomingSuppliesWithoutExpiration(this.txtSupplier.Text, this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text,
                    this.dateArrive.Value, val.UserFullName,
                    string.Format("Added incoming supply without expiration!\r\n" +
                    "Supply ID: {0}\r\n" +
                    "Supplier: {1}\r\n" +
                    "Supply Name: {2}\r\n" +
                    "Quantity: {3}\r\n" +
                    "Arrive Date: {4}",
                    this.txtSupplyID.Text,
                    this.txtSupplier.Text,
                    this.txtSupplyName.Text,
                    this.txtSupplyQuantity.Text,
                    this.dateArrive.Value.ToString("D"))))

                {
                    MessageBox.Show("Incoming supply successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    inventory.LoadIncomingInventory(this.gridIncomingSupplies);

                    AutoGenNum();
                    ResetTextInIncomingSupplies();

                    this.dateArrive.Value = DateTime.Now;
                    this.txtSupplier.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to add incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void ResetAllInIncomingSupplies()
        {
            AutoGenNum();
            ResetTextInIncomingSupplies();
            SetDateTimeToTodayInIncomingSupplies();

            this.btnAddIncomingSupplies.Visible = true;
            this.btnAddIncomingSupplies.Enabled = true;

            this.btnEditIncomingSupplies.Enabled = false;
            this.btnSaveIncomingSupplies.Visible = false;
            this.btnSupplyArrived.Enabled = false;
            this.btnDeleteIncomingSupplies.Enabled = false;

            this.switchExpirationDate.Checked = false;
            this.dateExpiration.Value = DateTime.Now;

            inventory.LoadIncomingInventory(this.gridIncomingSupplies);
            inventory.LoadInventory(this.gridSupplies);
            inventory.LoadInventory(this.gridManageSupplies);

            this.txtSupplier.Focus();
        }

        void SaveIncomingSupply()
        {
            DateTime arrive_date = DateTime.Parse(this.gridIncomingSupplies.SelectedCells[7].Value.ToString());

            if(String.IsNullOrWhiteSpace(this.txtSupplier.Text))
            {
                MessageBox.Show("Supplier is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplier.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyName.Text))
            {
                MessageBox.Show("Supply name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyName.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyQuantity.Text))
            {
                MessageBox.Show("Supply quantity is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyQuantity.Focus();
            }
            else if (this.switchExpirationDate.Checked == true)
            {
                DateTime expiration_date = DateTime.Parse(this.gridIncomingSupplies.SelectedCells[5].Value.ToString());

                if (inventory.UpdateIncomingSupplyWithExpiration(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), this.txtSupplier.Text,
                    this.txtSupplyName.Text, this.txtSupplyQuantity.Text, this.dateExpiration.Value, this.dateArrive.Value, val.UserFullName,
                    string.Format("Updated incoming supply with expiration!\r\n" +
                    "Supply ID: {0}\r\n" +
                    "Supplier: from ({1}) to ({2})\r\n" +
                    "Supply Name: from ({3}) to ({4})\r\n" +
                    "Quantity: from ({5}) to ({6})\r\n" +
                    "Expiration Date: from ({7}) to ({8})\r\n" +
                    "Arrive Date: from ({9}) to ({10})",
                    this.gridIncomingSupplies.SelectedCells[1].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[2].Value.ToString(), this.txtSupplier.Text,
                    this.gridIncomingSupplies.SelectedCells[3].Value.ToString(), this.txtSupplyName.Text,
                    this.gridIncomingSupplies.SelectedCells[4].Value.ToString(), this.txtSupplyQuantity.Text,
                    expiration_date.ToString("D"), this.dateExpiration.Value.ToString("D"),
                    arrive_date.ToString("D"), this.dateArrive.Value.ToString("D"))))
                {
                    MessageBox.Show("Incoming supply successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInIncomingSupplies();
                }
                else
                {
                    MessageBox.Show("Failed to update incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.dateExpiration.Checked == false)
            {
                if (inventory.UpdateIncomingSupplyWithoutExpiration(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), this.txtSupplier.Text,
                    this.txtSupplyName.Text, this.txtSupplyQuantity.Text, this.dateArrive.Value, val.UserFullName,
                    string.Format("Updated incoming supply without expiration!\r\n" +
                    "Supply ID: {0}\r\n" +
                    "Supplier: from ({1}) to ({2})\r\n" +
                    "Supply Name: from ({3}) to ({4})\r\n" +
                    "Quantiy: from ({5}) to ({6})\r\n" +
                    "Expiration Date: None\r\n" +
                    "Arrive Date: from ({7}) to ({8})",
                    this.gridIncomingSupplies.SelectedCells[1].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[2].Value.ToString(), this.txtSupplier.Text,
                    this.gridIncomingSupplies.SelectedCells[3].Value.ToString(), this.txtSupplyName.Text,
                    this.gridIncomingSupplies.SelectedCells[4].Value.ToString(), this.txtSupplyQuantity.Text,
                    arrive_date.ToString("D"), this.dateArrive.Value.ToString("D"))))
                {
                    MessageBox.Show("Incoming supply successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInIncomingSupplies();
                }
                else
                {
                    MessageBox.Show("Failed to update incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void EditIncomingSupply()
        {
            if (this.gridIncomingSupplies.Rows.Count == 0)
            {
                MessageBox.Show("There are no incoming supplies to edit! Please add incoming supplies first", "Add First",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplier.Focus();
            }
            else if (this.txtSupplyID.Text == this.gridIncomingSupplies.SelectedCells[1].Value.ToString())
            {
                this.btnAddIncomingSupplies.Visible = false;
                this.btnEditIncomingSupplies.Enabled = false;

                this.btnSaveIncomingSupplies.Visible = true;

                this.txtSupplyQuantity.Focus();
            }
            else
            {
                MessageBox.Show("Please select supply first in incoming supplies list!", "Select First", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        void SupplyArrived()
        {
            for (int i = 0; i < 50; ++i)
            {
                if (this.gridIncomingSupplies.SelectedCells[8].Value.ToString() != string.Format("{0} Days Left", i.ToString()))
                {
                    if (MessageBox.Show("This supply does not arrived yet according to arrive date it shows! Continue?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (this.switchExpirationDate.Checked == true)
                        {
                            if (inventory.SupplyArrivedWithExpiration(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), this.txtSupplier.Text,
                                this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text, this.dateExpiration.Value))
                            {
                                MessageBox.Show("Supply has arrived and its been transferred!", "Transferred", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ResetAllInIncomingSupplies();

                                break;
                            }
                            else
                            {
                                MessageBox.Show("Failed to transfer supply that has arrived!", "Failed", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                break;
                            }
                        }
                        else
                        {
                            if (duplicate.DuplicateSupplyNameWithoutExpirationDate(this.gridIncomingSupplies.SelectedCells[2].Value.ToString(), this.gridIncomingSupplies.SelectedCells[3].Value.ToString()))
                            {
                                int total = (int.Parse(val.SupplyQuantity) + int.Parse(this.gridIncomingSupplies.SelectedCells[4].Value.ToString()));

                                if (inventory.UpdateQuantityOfSupplyFromIncomingSupply(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), gridIncomingSupplies.SelectedCells[2].Value.ToString(),
                                    this.gridIncomingSupplies.SelectedCells[3].Value.ToString(), total.ToString(), val.UserFullName,
                                    string.Format("Updated supply quantity from incoming supplies into already existing supplies in inventory!\r\n" +
                                    "Supplier: from ({0}) to ({1})\r\n" +
                                    "Supply Name: {2}\r\n" +
                                    "Quantity: from ({3}) to ({4})\r\n" +
                                    "Total Added: {5}",
                                    this.gridIncomingSupplies.SelectedCells[2].Value.ToString(), this.txtSupplier.Text,
                                    this.gridIncomingSupplies.SelectedCells[3].Value.ToString(),
                                    val.SupplyQuantity, total.ToString(),
                                    this.gridIncomingSupplies.SelectedCells[4].Value.ToString())))
                                {
                                    MessageBox.Show("Supply has been updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ResetAllInIncomingSupplies();

                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    break;
                                }
                            }
                            else if (inventory.SupplyArrivedWithoutExpiration(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), this.gridIncomingSupplies.SelectedCells[2].Value.ToString(),
                                this.gridIncomingSupplies.SelectedCells[1].Value.ToString(), this.gridIncomingSupplies.SelectedCells[3].Value.ToString(),
                                this.gridIncomingSupplies.SelectedCells[4].Value.ToString()))
                            {
                                MessageBox.Show("Supply has arrived and its been transferred!", "Transferred", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ResetAllInIncomingSupplies();

                                break;
                            }
                            else
                            {
                                MessageBox.Show("Failed to transfer supply that has arrived!", "Failed", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                break;
                            }
                        }
                    }
                    else
                    {
                        ResetAllInIncomingSupplies();
                        break;
                    }
                }
                else
                {
                    if (this.switchExpirationDate.Checked == true)
                    {
                        if (inventory.SupplyArrivedWithExpiration(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), this.gridIncomingSupplies.SelectedCells[2].Value.ToString(),
                            this.gridIncomingSupplies.SelectedCells[1].Value.ToString(), this.gridIncomingSupplies.SelectedCells[3].Value.ToString(),
                            this.gridIncomingSupplies.SelectedCells[4].Value.ToString(),
                            DateTime.Parse(this.gridIncomingSupplies.SelectedCells[5].Value.ToString())))
                        {
                            MessageBox.Show("Supply has arrived and its been transferred!", "Transferred", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ResetAllInIncomingSupplies();

                            break;
                        }
                        else
                        {
                            MessageBox.Show("Failed to transfer supply that has arrived!", "Failed", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            break;
                        }
                    }
                    else
                    {
                        if (duplicate.DuplicateSupplyNameWithoutExpirationDate(this.gridIncomingSupplies.SelectedCells[2].Value.ToString(), this.gridIncomingSupplies.SelectedCells[3].Value.ToString()))
                        {
                            int total = (int.Parse(val.SupplyQuantity) + int.Parse(this.gridIncomingSupplies.SelectedCells[4].Value.ToString()));

                            if (inventory.UpdateQuantityOfSupplyFromIncomingSupply(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), this.gridIncomingSupplies.SelectedCells[2].Value.ToString(),
                                this.gridIncomingSupplies.SelectedCells[3].Value.ToString(), total.ToString(), val.UserFullName,
                                    string.Format("Updated supply quantity from incoming supplies into already existing supplies in inventory!\r\n" +
                                    "Supplier: {0}\r\n" +
                                    "Supply Name: {1}\r\n" +
                                    "Quantity: from ({2}) to ({3})\r\n" +
                                    "Total Added: {4}",
                                    this.gridIncomingSupplies.SelectedCells[2].Value.ToString(),
                                    this.gridIncomingSupplies.SelectedCells[3].Value.ToString(),
                                    val.SupplyQuantity, total.ToString(),
                                    this.gridIncomingSupplies.SelectedCells[4].Value.ToString())))
                            {
                                MessageBox.Show("Supply has been updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetAllInIncomingSupplies();

                                break;
                            }
                            else
                            {
                                MessageBox.Show("Failed to update supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                        else if (inventory.SupplyArrivedWithoutExpiration(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), this.gridIncomingSupplies.SelectedCells[2].Value.ToString(),
                            this.gridIncomingSupplies.SelectedCells[1].Value.ToString(), this.gridIncomingSupplies.SelectedCells[3].Value.ToString(),
                            this.gridIncomingSupplies.SelectedCells[4].Value.ToString()))
                        {
                            MessageBox.Show("Supply has arrived and its been transferred!", "Transferred", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ResetAllInIncomingSupplies();

                            break;
                        }
                        else
                        {
                            MessageBox.Show("Failed to transfer supply that has arrived!", "Failed", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            break;
                        }
                    }
                }
            }
        }

        void DeleteIncomingSupply()
        {
            DateTime arrive_date = DateTime.Parse(this.gridIncomingSupplies.SelectedCells[7].Value.ToString());

            if (String.IsNullOrWhiteSpace(this.gridIncomingSupplies.SelectedCells[5].Value.ToString()))
            {
                if (inventory.DeleteIncomingSupply(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), val.UserFullName,
                    string.Format("{0} has been removed from incoming supplies!\r\n" +
                    "Details:\r\n" +
                    "Supply ID: {1}\r\n" +
                    "Supplier: {2}\r\n" +
                    "Supply Name: {3}\r\n" +
                    "Quantity: {4}\r\n" +
                    "Expiration Date: None\r\n" +
                    "Arrive Date: {5}",
                    this.gridIncomingSupplies.SelectedCells[3].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[1].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[2].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[3].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[4].Value.ToString(),
                    arrive_date.ToString("D"))))

                {
                    MessageBox.Show(string.Format("{0} successfully deleted!", this.gridIncomingSupplies.SelectedCells[3].Value.ToString()), "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInIncomingSupplies();
                }
                else
                {
                    MessageBox.Show(string.Format("Failed to delete {0}!", this.gridIncomingSupplies.SelectedCells[3].Value.ToString()), "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DateTime expiration_date = DateTime.Parse(this.gridIncomingSupplies.SelectedCells[5].Value.ToString());

                if (inventory.DeleteIncomingSupply(int.Parse(this.gridIncomingSupplies.SelectedCells[0].Value.ToString()), val.UserFullName,
                    string.Format("{0} has been removed from incoming supplies!\r\n" +
                    "Details:\r\n" +
                    "Supply ID: {1}\r\n" +
                    "Supplier: {2}" +
                    "Supply Name: {3}\r\n" +
                    "Quantity: {4}\r\n" +
                    "Expiration Date: {5}\r\n" +
                    "Arrive Date: {6}",
                    this.gridIncomingSupplies.SelectedCells[3].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[1].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[2].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[3].Value.ToString(),
                    this.gridIncomingSupplies.SelectedCells[4].Value.ToString(),
                    expiration_date.ToString("D"),
                    arrive_date.ToString("D"))))

                {
                    MessageBox.Show(string.Format("{0} successfully deleted!", this.gridIncomingSupplies.SelectedCells[3].Value.ToString()), "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInIncomingSupplies();
                }
                else
                {
                    MessageBox.Show(string.Format("Failed to delete {0}!", this.gridIncomingSupplies.SelectedCells[3].Value.ToString()), "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void SelectManageSupply()
        {
            this.gridManageSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.gridManageSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSupplyIDManageSupplies.Text = this.gridManageSupplies.SelectedCells[1].Value.ToString();
            this.txtSupplierManageSupplies.Text = this.gridManageSupplies.SelectedCells[2].Value.ToString();
            this.txtSupplyNameManageSupplies.Text = this.gridManageSupplies.SelectedCells[3].Value.ToString();
            this.txtSupplyQuantityManageSupplies.Text = this.gridManageSupplies.SelectedCells[4].Value.ToString();

            if (String.IsNullOrWhiteSpace(this.gridManageSupplies.SelectedCells[5].Value.ToString()))
            {
                this.switchExpirationDateManageSupplies.Checked = false;
                this.dateExpirationManageSupplies.Value = DateTime.Now;
            }
            else
            {
                this.switchExpirationDateManageSupplies.Checked = true;
                this.dateExpirationManageSupplies.Value = DateTime.Parse(this.gridManageSupplies.SelectedCells[5].Value.ToString());
            }

            this.btnEditManageSupplies.Enabled = true;
            this.btnDeleteManageSupplies.Enabled = true;
            this.btnDeductItem.Enabled = true;

            this.btnAddManageSupplies.Enabled = false;

            this.txtSupplierManageSupplies.Focus();
        }

        void ResetTextInManageSupplies()
        {
            this.txtSupplierManageSupplies.ResetText();
            this.txtSupplyNameManageSupplies.ResetText();
            this.txtSupplyQuantityManageSupplies.ResetText();
            this.txtItemUsed.ResetText();
        }

        void ResetAllInManageSupplies()
        {
            AutoGenNum();
            ResetTextInManageSupplies();

            this.btnAddManageSupplies.Visible = true;
            this.btnAddManageSupplies.Enabled = true;

            this.btnEditManageSupplies.Enabled = false;
            this.btnSaveManageSupplies.Visible = false;
            this.btnDeleteManageSupplies.Enabled = false;
            this.btnDeductItem.Enabled = false;

            this.switchExpirationDateManageSupplies.Checked = false;
            this.dateExpirationManageSupplies.Value = DateTime.Now;

            inventory.LoadInventory(this.gridSupplies);
            inventory.LoadInventory(this.gridManageSupplies);

            this.txtSupplierManageSupplies.Focus();
        }

        void AddInManageSupply()
        {
            if(String.IsNullOrWhiteSpace(this.txtSupplierManageSupplies.Text) && String.IsNullOrWhiteSpace(this.txtSupplyNameManageSupplies.Text) && String.IsNullOrWhiteSpace(this.txtSupplyQuantityManageSupplies.Text))
            {
                MessageBox.Show("Supplier, supply name and quantity are required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplierManageSupplies.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyNameManageSupplies.Text) && String.IsNullOrWhiteSpace(this.txtSupplyQuantityManageSupplies.Text))
            {
                MessageBox.Show("Supply name and quantity are required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyNameManageSupplies.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtSupplierManageSupplies.Text))
            {
                MessageBox.Show("Supplier is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplierManageSupplies.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyNameManageSupplies.Text))
            {
                MessageBox.Show("Supply name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplierManageSupplies.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyQuantityManageSupplies.Text))
            {
                MessageBox.Show("Quantity is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyQuantityManageSupplies.Focus();
            }
            else if (this.switchExpirationDateManageSupplies.Checked == true)
            {
                if (inventory.AddSupplyWithExpiration(this.txtSupplierManageSupplies.Text, this.txtSupplyIDManageSupplies.Text, this.txtSupplyNameManageSupplies.Text,
                    this.txtSupplyQuantityManageSupplies.Text, this.dateExpirationManageSupplies.Value, val.UserFullName,
                    string.Format("Added supply in inventory with expiration!\r\n" +
                    "Supply ID: {0}\r\n" +
                    "Supplier: {1}\r\n" +
                    "Supply Name: {2}\r\n" +
                    "Quantity: {3}\r\n" +
                    "Expiration Date: {4}",
                    this.txtSupplyIDManageSupplies.Text,
                    this.txtSupplierManageSupplies.Text,
                    this.txtSupplyNameManageSupplies.Text,
                    this.txtSupplyQuantityManageSupplies.Text,
                    this.dateExpirationManageSupplies.Value.ToString("D"))))
                {
                    AutoGenNum();
                    ResetTextInManageSupplies();

                    this.switchExpirationDateManageSupplies.Checked = false;
                    this.dateExpirationManageSupplies.Value = DateTime.Now;

                    inventory.LoadInventory(this.gridSupplies);
                    inventory.LoadInventory(this.gridManageSupplies);

                    this.txtSupplierManageSupplies.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to add supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (duplicate.DuplicateSupplyNameWithoutExpirationDate(this.txtSupplierManageSupplies.Text, this.txtSupplyNameManageSupplies.Text))
                {
                    int total_quantity_manage_supplies = (int.Parse(val.SupplyQuantity) +
                        int.Parse(this.txtSupplyQuantityManageSupplies.Text));

                    if (inventory.UpdateQuantityOfExistingSupplyWithoutExpiration(this.txtSupplierManageSupplies.Text, this.txtSupplyNameManageSupplies.Text,
                        total_quantity_manage_supplies.ToString(), val.UserFullName,
                        string.Format("Updated supply quantity in inventory!\r\n" +
                        "Supplier: {0}\r\n" +
                        "Supply Name: {1}\r\n" +
                        "Quantiy: from ({2}) to ({3})\r\n" +
                        "Total Added: {4}",
                        this.txtSupplierManageSupplies.Text,
                        this.txtSupplyNameManageSupplies.Text,
                        val.SupplyQuantity, total_quantity_manage_supplies.ToString(),
                        this.txtSupplyQuantityManageSupplies.Text)))
                    {
                        MessageBox.Show("Supply has been updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AutoGenNum();
                        ResetTextInManageSupplies();

                        inventory.LoadInventory(this.gridSupplies);
                        inventory.LoadInventory(this.gridManageSupplies);

                        this.txtSupplierManageSupplies.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update existing supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (inventory.AddSupplyWithoutExpiration(this.txtSupplierManageSupplies.Text, this.txtSupplyIDManageSupplies.Text, this.txtSupplyNameManageSupplies.Text,
                    this.txtSupplyQuantityManageSupplies.Text, val.UserFullName,
                    string.Format("Added supply in inventory without expiration!\r\n" +
                    "Supply ID: {0}\r\n" +
                    "Supplier: {1}\r\n" +
                    "Supply Name: {2}\r\n" +
                    "Quantity: {3}",
                    this.txtSupplyIDManageSupplies.Text,
                    this.txtSupplierManageSupplies.Text,
                    this.txtSupplyNameManageSupplies.Text,
                    this.txtSupplyQuantityManageSupplies.Text)))
                {
                    AutoGenNum();
                    ResetTextInManageSupplies();

                    inventory.LoadInventory(this.gridSupplies);
                    inventory.LoadInventory(this.gridManageSupplies);

                    this.txtSupplierManageSupplies.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to add supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void EditManageSupplies()
        {
            if (this.gridManageSupplies.Rows.Count == 0)
            {
                MessageBox.Show("There are no supplies to edit! Please add supplies first!", "Add First",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplierManageSupplies.Focus();
            }
            if (this.txtSupplyIDManageSupplies.Text == this.gridManageSupplies.SelectedCells[1].Value.ToString())
            {
                this.btnAddManageSupplies.Visible = false;
                this.btnEditManageSupplies.Enabled = false;

                this.btnSaveManageSupplies.Visible = true;

                this.txtSupplierManageSupplies.Focus();
            }
            else
            {
                MessageBox.Show("Please select supply first before clicking edit!", "Select First", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        void ExpirationDateInManageSuppliesEnabled()
        {
            if (this.switchExpirationDateManageSupplies.Checked)
            {
                this.dateExpirationManageSupplies.Enabled = true;
            }
            else
            {
                this.dateExpirationManageSupplies.Enabled = false;
            }
        }

        void SaveManageSupply()
        {
            if (String.IsNullOrWhiteSpace(this.txtSupplierManageSupplies.Text))
            {
                MessageBox.Show("Supplier is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplierManageSupplies.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyNameManageSupplies.Text))
            {
                MessageBox.Show("Supply name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyNameManageSupplies.Focus();
            }
            else if (String.IsNullOrWhiteSpace(this.txtSupplyQuantityManageSupplies.Text))
            {
                MessageBox.Show("Supply quantity is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyQuantityManageSupplies.Focus();
            }
            else if (this.switchExpirationDateManageSupplies.Checked == true)
            {
                DateTime expiration_date = DateTime.Parse(this.gridManageSupplies.SelectedCells[5].Value.ToString());

                if (inventory.SaveManageSuppliesWithExpiration(int.Parse(this.gridManageSupplies.SelectedCells[0].Value.ToString()), this.txtSupplierManageSupplies.Text,
                    this.txtSupplyNameManageSupplies.Text, this.txtSupplyQuantityManageSupplies.Text, this.dateExpirationManageSupplies.Value, val.UserFullName,
                    string.Format("Updated supply with expiration!\r\n" +
                    "Supply ID: {0}\r\n" +
                    "Supplier: from ({1}) to ({2})\r\n" +
                    "Supply Name: from ({3}) to ({4})\r\n" +
                    "Quantity: from ({5}) to ({6})\r\n" +
                    "Expiration Date: from ({7}) to ({8})",
                    this.gridManageSupplies.SelectedCells[1].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[2].Value.ToString(), this.txtSupplierManageSupplies.Text,
                    this.gridManageSupplies.SelectedCells[3].Value.ToString(), this.txtSupplyNameManageSupplies.Text,
                    this.gridManageSupplies.SelectedCells[4].Value.ToString(), this.txtSupplyQuantityManageSupplies.Text,
                    expiration_date.ToString("D"), this.dateExpirationManageSupplies.Value.ToString("D"))))
                {
                    MessageBox.Show("Supply successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInManageSupplies();
                }
                else
                {
                    MessageBox.Show("Failed to update supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(this.switchExpirationDateManageSupplies.Checked == false)
            {
                if (inventory.SaveManageSuppliesWithoutExpiration(int.Parse(this.gridManageSupplies.SelectedCells[0].Value.ToString()), this.txtSupplierManageSupplies.Text,
                    this.txtSupplyNameManageSupplies.Text, this.txtSupplyQuantityManageSupplies.Text, val.UserFullName,
                    string.Format("Updated supply in inventory without expiration!\r\n" +
                    "Supply ID: {0}\r\n" +
                    "Supplier: from ({1}) to ({2})\r\n" +
                    "Supply Name: from ({3}) to ({4})\r\n" +
                    "Quantity: from ({5}) to ({6})",
                    this.gridManageSupplies.SelectedCells[1].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[2].Value.ToString(), this.txtSupplierManageSupplies.Text,
                    this.gridManageSupplies.SelectedCells[3].Value.ToString(), this.txtSupplyNameManageSupplies.Text,
                    this.gridManageSupplies.SelectedCells[4].Value.ToString(), this.txtSupplyQuantityManageSupplies.Text)))
                {
                    MessageBox.Show("Supply successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInManageSupplies();
                }
                else
                {
                    MessageBox.Show("Failed to update supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void DeductItem()
        {
            int total_deduct_items = (int.Parse(this.gridManageSupplies.SelectedCells[4].Value.ToString()) -
                int.Parse(this.txtItemUsed.Text));

            if (String.IsNullOrWhiteSpace(this.gridManageSupplies.SelectedCells[5].Value.ToString()))
            {
                if (String.IsNullOrWhiteSpace(this.txtItemUsed.Text))
                {
                    MessageBox.Show("Item used is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtItemUsed.Focus();
                }
                else if (inventory.ItemUsed(int.Parse(this.gridManageSupplies.SelectedCells[0].Value.ToString()), total_deduct_items.ToString(), val.UserFullName,
                    string.Format("{0} has beed deducted!\r\n" +
                    "Details:\r\n" +
                    "Supply ID: {1}\r\n" +
                    "Supplier: {2}\r\n" +
                    "Supply Name: {3}\r\n" +
                    "Quantity: from ({4}) to ({5})\r\n" +
                    "Expiration date: None",
                    this.gridManageSupplies.SelectedCells[3].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[1].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[2].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[3].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[4].Value.ToString(), this.txtItemUsed.Text)))
                {
                    MessageBox.Show("Selected item has been deducted!", "Deducted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInManageSupplies();
                }
                else
                {
                    MessageBox.Show("Failed to deduct selected item!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DateTime expiration_date = DateTime.Parse(this.gridManageSupplies.SelectedCells[5].Value.ToString());

                if (String.IsNullOrWhiteSpace(this.txtItemUsed.Text))
                {
                    MessageBox.Show("Item used is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtItemUsed.Focus();
                }
                else if (inventory.ItemUsed(int.Parse(this.gridManageSupplies.SelectedCells[0].Value.ToString()), total_deduct_items.ToString(), val.UserFullName,
                    string.Format("{0} has beed deducted!\r\n" +
                    "Details:\r\n" +
                    "Supply ID: {1}\r\n" +
                    "Supplier: {2}\r\n" +
                    "Supply Name: {3}\r\n" +
                    "Quantity: from ({4}) to ({5})\r\n" +
                    "Expiration Date: {6}",
                    this.gridManageSupplies.SelectedCells[3].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[1].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[2].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[3].Value.ToString(),
                    this.gridManageSupplies.SelectedCells[4].Value.ToString(), this.txtItemUsed.Text,
                    expiration_date.ToString("D"))))
                {
                    MessageBox.Show("Selected item has been deducted!", "Deducted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInManageSupplies();
                }
                else
                {
                    MessageBox.Show("Failed to deduct selected item!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void DeleteManageSupply()
        {
            if (String.IsNullOrWhiteSpace(this.gridManageSupplies.SelectedCells[5].Value.ToString()))
            {
                if (inventory.DeleteSupply(int.Parse(this.gridManageSupplies.SelectedCells[0].Value.ToString()), val.UserFullName,
                string.Format("{0} has been removed!\r\n" +
                "Details:\r\n" +
                "Supply ID: {1}\r\n" +
                "Supplier: {2}\r\n" +
                "Supply Name: {3}\r\n" +
                "Quantity: {4}\r\n" +
                "Expiration date: None",
                this.gridManageSupplies.SelectedCells[3].Value.ToString(),
                this.gridManageSupplies.SelectedCells[1].Value.ToString(),
                this.gridManageSupplies.SelectedCells[2].Value.ToString(),
                this.gridManageSupplies.SelectedCells[3].Value.ToString(),
                this.gridManageSupplies.SelectedCells[4].Value.ToString())))
                {
                    MessageBox.Show(string.Format("{0} successfully deleted!", this.gridManageSupplies.SelectedCells[3].Value.ToString()), "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInManageSupplies();
                }
                else
                {
                    MessageBox.Show(string.Format("Failed to delete {0}!", this.gridManageSupplies.SelectedCells[3].Value.ToString()), "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DateTime expiration_date = DateTime.Parse(this.gridManageSupplies.SelectedCells[5].Value.ToString());

                if (inventory.DeleteSupply(int.Parse(this.gridManageSupplies.SelectedCells[0].Value.ToString()), val.UserFullName,
                string.Format("{0} has been removed!\r\n" +
                "Details:\r\n" +
                "Supply ID: {1}\r\n" +
                "Supplier: {2}" +
                "Supply Name: {3}\r\n" +
                "Quantity: {4}\r\n" +
                "Expiration Date: {5}",
                this.gridManageSupplies.SelectedCells[3].Value.ToString(),
                this.gridManageSupplies.SelectedCells[1].Value.ToString(),
                this.gridManageSupplies.SelectedCells[2].Value.ToString(),
                this.gridManageSupplies.SelectedCells[3].Value.ToString(),
                this.gridManageSupplies.SelectedCells[4].Value.ToString(),
                expiration_date.ToString("D"))))
                {
                    MessageBox.Show(string.Format("{0} successfully deleted!", this.gridManageSupplies.SelectedCells[3].Value.ToString()), "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAllInManageSupplies();
                }
                else
                {
                    MessageBox.Show(string.Format("Failed to delete {0}!", this.gridManageSupplies.SelectedCells[3].Value.ToString()), "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabControlInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlInventory.SelectedIndex == 1)
            {
                this.txtSupplier.Focus();
            }
            else
            {
                this.txtSupplierManageSupplies.Focus();
            }
        }

        private void txtItemUsed_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSupplyQuantityManageSupplies_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSupplyQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows 0-9 and backspace
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void switchExpirationDate_CheckedChanged(object sender, EventArgs e)
        {
            ExpirationDateEnabledInIncomingSupplies();
        }

        private void gridIncomingSupplies_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectIncomingSupply();
        }

        private void btnAddIncomingSupplies_Click(object sender, EventArgs e)
        {
            AddIncomingSupply();
        }

        private void btnSaveIncomingSupplies_Click(object sender, EventArgs e)
        {
            SaveIncomingSupply();
        }

        private void btnEditIncomingSupplies_Click(object sender, EventArgs e)
        {
            EditIncomingSupply();
        }

        private void btnSupplyArrived_Click(object sender, EventArgs e)
        {
            SupplyArrived();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteIncomingSupply();
        }

        // Manage Supplies

        private void gridManageSupplies_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectManageSupply();
        }

        private void btnAddManageSupplies_Click(object sender, EventArgs e)
        {
            AddInManageSupply();
        }

        private void btnEditManageSupplies_Click(object sender, EventArgs e)
        {
            EditManageSupplies();
        }

        private void switchExpirationDateManageSupplies_CheckedChanged(object sender, EventArgs e)
        {
            ExpirationDateInManageSuppliesEnabled();
        }

        private void btnSaveManageSupplies_Click(object sender, EventArgs e)
        {
            SaveManageSupply();
        }

        private void btnDeductItem_Click(object sender, EventArgs e)
        {
            DeductItem();
        }

        private void btnDeleteManageSupplies_Click(object sender, EventArgs e)
        {
            DeleteManageSupply();
        }
    }
}
