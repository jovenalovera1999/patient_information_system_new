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

        void autoGenNum()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while(generateID.Length < 8)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtSupplyID.Text = generateID.ToString();
            this.txtSupplyIDManageSupplies.Text = generateID.ToString();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            autoGenNum();

            inventory.loadInventory(this.gridSupplies);
            inventory.loadIncomingInventory(this.gridIncomingSupplies);
            inventory.loadInventory(this.gridManageSupplies);

            this.dateExpiration.Value = DateTime.Now.Date;
            this.dateArrive.Value = DateTime.Now.Date;
        }

        private void switchExpirationDate_CheckedChanged(object sender, EventArgs e)
        {
            if(this.switchExpirationDate.Checked)
            {
                this.dateExpiration.Enabled = true;
            }
            else
            {
                this.dateExpiration.Enabled = false;
            }
        }

        private void gridIncomingSupplies_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSupplyID.Text = this.gridIncomingSupplies.SelectedCells[0].Value.ToString();
            this.txtSupplyName.Text = this.gridIncomingSupplies.SelectedCells[1].Value.ToString();
            this.txtSupplyQuantity.Text = this.gridIncomingSupplies.SelectedCells[2].Value.ToString();
            this.dateArrive.Value = DateTime.Parse(this.gridIncomingSupplies.SelectedCells[5].Value.ToString());

            if(String.IsNullOrWhiteSpace(this.gridIncomingSupplies.SelectedCells[3].Value.ToString()))
            {
                this.switchExpirationDate.Checked = false;
                this.dateExpiration.Value = DateTime.Now.Date;
            }
            else
            {
                this.switchExpirationDate.Checked = true;
                this.dateExpiration.Value = DateTime.Parse(this.gridIncomingSupplies.SelectedCells[3].Value.ToString());
            }

            this.btnSaveIncomingSupplies.Enabled = true;
            this.btnSupplyArrived.Enabled = true;
            this.btnDeleteIncomingSupplies.Enabled = true;
        }

        private void btnAddIncomingSupplies_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtSupplyName.Text) && String.IsNullOrWhiteSpace(this.txtSupplyQuantity.Text))
            {
                MessageBox.Show("Supply name and quantity are required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtSupplyName.Text))
            {
                MessageBox.Show("Supply name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtSupplyQuantity.Text))
            {
                MessageBox.Show("Supply quantity is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyQuantity.Focus();
            }
            else if(this.switchExpirationDate.Checked == true)
            {
                if (inventory.addIncomingSuppliesWithExpiration(this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text,
                    this.dateExpiration.Value.Date, this.dateArrive.Value.Date))
                {
                    MessageBox.Show("Incoming supply successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    autoGenNum();
                    inventory.loadIncomingInventory(this.gridIncomingSupplies);

                    this.txtSupplyName.ResetText();
                    this.txtSupplyQuantity.ResetText();
                }
                else
                {
                    MessageBox.Show("Failed to add incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(this.dateExpiration.Checked == false)
            {
                if(duplicate.inventorySupplyDuplicate(this.txtSupplyName.Text))
                {
                    MessageBox.Show(string.Format("{0} is already in inventory!", this.txtSupplyName.Text), "Already Exist", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    this.txtSupplyName.ResetText();
                    this.txtSupplyQuantity.ResetText();

                    this.txtSupplyName.Focus();
                }
                else if (inventory.addIncomingSuppliesWithoutExpiration(this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text,
                    this.dateArrive.Value.Date))
                {
                    MessageBox.Show("Incoming supply successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    autoGenNum();
                    inventory.loadIncomingInventory(this.gridIncomingSupplies);

                    this.txtSupplyName.ResetText();
                    this.txtSupplyQuantity.ResetText();

                    this.txtSupplyName.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to add incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveIncomingSupplies_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSupplyName.Text))
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
                if (inventory.addIncomingSuppliesWithExpiration(this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text,
                    this.dateExpiration.Value.Date, this.dateArrive.Value.Date))
                {
                    MessageBox.Show("Incoming supply successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                    this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                    inventory.loadInventory(this.gridSupplies);
                    inventory.loadInventory(this.gridManageSupplies);

                    autoGenNum();

                    this.txtSupplyName.ResetText();
                    this.txtSupplyQuantity.ResetText();

                    this.btnAddIncomingSupplies.Visible = true;
                    this.btnEditIncomingSupplies.Enabled = true;

                    this.btnSaveIncomingSupplies.Visible = false;
                    this.btnSupplyArrived.Enabled = false;
                    this.btnDeleteIncomingSupplies.Visible = false;

                    this.txtSupplyName.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to update incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.dateExpiration.Checked == false)
            {
                if (inventory.updateSupplyWithoutExpiration(this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text,
                    this.dateArrive.Value.Date))
                {
                    MessageBox.Show("Incoming supply successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                    this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                    inventory.loadInventory(this.gridSupplies);
                    inventory.loadInventory(this.gridManageSupplies);

                    autoGenNum();

                    this.txtSupplyName.ResetText();
                    this.txtSupplyQuantity.ResetText();

                    this.btnAddIncomingSupplies.Visible = true;
                    this.btnEditIncomingSupplies.Enabled = true;

                    this.btnSaveIncomingSupplies.Visible = false;
                    this.btnSupplyArrived.Enabled = false;
                    this.btnDeleteIncomingSupplies.Visible = false;

                    this.txtSupplyName.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to update incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditIncomingSupplies_Click(object sender, EventArgs e)
        {
            if(this.gridIncomingSupplies.Rows.Count == 0)
            {
                MessageBox.Show("There are no incoming supplies to edit! Please add incoming supplies first", "Add First", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyName.Focus();
            }
            else if (this.txtSupplyID.Text == this.gridIncomingSupplies.SelectedCells[0].Value.ToString())
            {
                this.btnAddIncomingSupplies.Visible = false;
                this.btnEditIncomingSupplies.Enabled = false;

                this.btnSaveIncomingSupplies.Visible = true;
                this.btnDeleteIncomingSupplies.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select supply first in incoming supplies list!", "Select First", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSupplyArrived_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 50; ++i)
            {
                if (this.gridIncomingSupplies.SelectedCells[6].Value.ToString() != string.Format("{0} Days Left", i.ToString()))
                {
                    if(MessageBox.Show("This supply does not arrived yet according to arrive date it shows! Continue?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if(this.switchExpirationDate.Checked == true)
                        {
                            if(inventory.supplyArrivedWithExpiration(this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text,
                                this.dateExpiration.Value.Date))
                            {
                                MessageBox.Show("Supply has arrived and its been transferred!", "Transferred", MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);

                                this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                                this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                                inventory.loadInventory(this.gridSupplies);
                                inventory.loadIncomingInventory(this.gridIncomingSupplies);

                                this.btnSupplyArrived.Enabled = false;

                                autoGenNum();

                                this.txtSupplyName.ResetText();
                                this.txtSupplyQuantity.ResetText();

                                this.txtSupplyName.Focus();

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
                            if (inventory.supplyArrivedWithoutExpiration(this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text))
                            {
                                MessageBox.Show("Supply has arrived and its been transferred!", "Transferred", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                                this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                                inventory.loadInventory(this.gridSupplies);
                                inventory.loadIncomingInventory(this.gridIncomingSupplies);

                                this.btnSupplyArrived.Enabled = false;

                                autoGenNum();

                                this.txtSupplyName.ResetText();
                                this.txtSupplyQuantity.ResetText();

                                this.txtSupplyName.Focus();

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
                else
                {
                    if (this.switchExpirationDate.Checked == true)
                    {
                        if (inventory.supplyArrivedWithExpiration(this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text,
                            this.dateExpiration.Value.Date))
                        {
                            MessageBox.Show("Supply has arrived and its been transferred!", "Transferred", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                            this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                            inventory.loadInventory(this.gridSupplies);
                            inventory.loadIncomingInventory(this.gridIncomingSupplies);

                            this.btnSupplyArrived.Enabled = false;

                            autoGenNum();

                            this.txtSupplyName.ResetText();
                            this.txtSupplyQuantity.ResetText();

                            this.txtSupplyName.Focus();
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
                        if (inventory.supplyArrivedWithoutExpiration(this.txtSupplyID.Text, this.txtSupplyName.Text, this.txtSupplyQuantity.Text))
                        {
                            MessageBox.Show("Supply has arrived and its been transferred!", "Transferred", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                            this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                            inventory.loadInventory(this.gridSupplies);
                            inventory.loadIncomingInventory(this.gridIncomingSupplies);

                            this.btnSupplyArrived.Enabled = false;

                            autoGenNum();

                            this.txtSupplyName.ResetText();
                            this.txtSupplyQuantity.ResetText();

                            this.txtSupplyName.Focus();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(inventory.deleteIncomingSupply(this.txtSupplyID.Text))
            {
                MessageBox.Show(string.Format("{0} successfully deleted!", this.txtSupplyName.Text), "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.White;
                this.gridIncomingSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

                inventory.loadIncomingInventory(this.gridIncomingSupplies);

                this.switchExpirationDate.Checked = false;
                this.dateExpiration.Value = DateTime.Now.Date;

                this.btnAddIncomingSupplies.Visible = true;
                this.btnEditIncomingSupplies.Enabled = true;

                this.btnSaveIncomingSupplies.Visible = false;
                this.btnDeleteIncomingSupplies.Visible = false;
                this.btnSupplyArrived.Enabled = false;

                autoGenNum();

                this.txtSupplyName.ResetText();
                this.txtSupplyQuantity.ResetText();

                this.txtSupplyName.Focus();
            }
            else
            {
                MessageBox.Show(string.Format("Failed to delete {0}!", this.txtSupplyName.Text), "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAddManageSupplies_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(this.txtSupplyNameManageSupplies.Text) && 
                String.IsNullOrWhiteSpace(this.txtSupplyQuantityManageSupplies.Text))
            {
                MessageBox.Show("Supply name and quantity are required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyName.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtSupplyNameManageSupplies.Text))
            {
                MessageBox.Show("Supply name is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyNameManageSupplies.Focus();
            }
            else if(String.IsNullOrWhiteSpace(this.txtSupplyQuantityManageSupplies.Text))
            {
                MessageBox.Show("Quantity is required!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyQuantityManageSupplies.Focus();
            }
            else if(this.switchExpirationDateManageSupplies.Checked == true)
            {
                if(inventory.addSupplyWithExpiration(this.txtSupplyIDManageSupplies.Text, this.txtSupplyNameManageSupplies.Text,
                    this.txtSupplyQuantityManageSupplies.Text, this.dateExpirationManageSupplies.Value.Date))
                {
                    inventory.loadInventory(this.gridManageSupplies);

                    autoGenNum();

                    this.txtSupplyIDManageSupplies.ResetText();
                    this.txtSupplyQuantity.ResetText();

                    this.switchExpirationDateManageSupplies.Checked = false;
                    this.dateExpirationManageSupplies.Value = DateTime.Now.Date;

                    this.txtSupplyName.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to add supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (inventory.addSupplyWithoutExpiration(this.txtSupplyIDManageSupplies.Text, this.txtSupplyNameManageSupplies.Text,
                    this.txtSupplyQuantityManageSupplies.Text))
                {
                    inventory.loadInventory(this.gridManageSupplies);

                    autoGenNum();

                    this.txtSupplyIDManageSupplies.ResetText();
                    this.txtSupplyQuantity.ResetText();

                    this.txtSupplyName.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to add supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditManageSupplies_Click(object sender, EventArgs e)
        {
            if(this.gridManageSupplies.Rows.Count == 0)
            {
                MessageBox.Show("There are no supplies to edit! Please add supplies first!", "Add First",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSupplyNameManageSupplies.Focus();
            }
            if(this.txtSupplyIDManageSupplies.Text == this.gridManageSupplies.SelectedCells[0].Value.ToString())
            {
                this.btnAddManageSupplies.Visible = false;
                this.btnEditManageSupplies.Enabled = false;

                this.btnSaveManageSupplies.Visible = true;
                this.btnDeleteManageSupplies.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select supply first before clicking edit!", "Select First", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void switchExpirationDateManageSupplies_CheckedChanged(object sender, EventArgs e)
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

        private void gridManageSupplies_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridManageSupplies.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridManageSupplies.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            this.txtSupplyIDManageSupplies.Text = this.gridManageSupplies.SelectedCells[0].Value.ToString();
            this.txtSupplyNameManageSupplies.Text = this.gridManageSupplies.SelectedCells[1].Value.ToString();
            this.txtSupplyQuantityManageSupplies.Text = this.gridManageSupplies.SelectedCells[2].Value.ToString();

            if (String.IsNullOrWhiteSpace(this.gridManageSupplies.SelectedCells[3].Value.ToString()))
            {
                this.switchExpirationDateManageSupplies.Checked = false;
                this.dateExpirationManageSupplies.Value = DateTime.Now.Date;
            }
            else
            {
                this.switchExpirationDateManageSupplies.Checked = true;
                this.dateExpirationManageSupplies.Value = DateTime.Parse(this.gridManageSupplies.SelectedCells[3].Value.ToString());
            }
        }

        private void btnSaveManageSupplies_Click(object sender, EventArgs e)
        {
            if(this.switchExpirationDateManageSupplies.Checked == true)
            {
                if(inventory.saveManageSuppliesWithExpiration(this.txtSupplyIDManageSupplies.Text, this.txtSupplyNameManageSupplies.Text,
                    this.txtSupplyQuantityManageSupplies.Text, this.dateExpirationManageSupplies.Value.Date))
                {
                    MessageBox.Show("Supply successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    inventory.loadInventory(this.gridSupplies);
                    inventory.loadInventory(this.gridManageSupplies);

                    this.btnAddManageSupplies.Visible = true;
                    this.btnEditManageSupplies.Enabled = true;

                    this.btnSaveManageSupplies.Visible = false;

                    autoGenNum();

                    this.txtSupplyNameManageSupplies.ResetText();
                    this.txtSupplyQuantityManageSupplies.ResetText();

                    this.dateExpirationManageSupplies.Value = DateTime.Now.Date;

                    this.switchExpirationDateManageSupplies.Checked = false;
                    this.dateExpirationManageSupplies.Enabled = false;

                    this.txtSupplyNameManageSupplies.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to update supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (inventory.saveManageSuppliesWithoutExpiration(this.txtSupplyIDManageSupplies.Text, this.txtSupplyNameManageSupplies.Text,
                    this.txtSupplyQuantityManageSupplies.Text))
                {
                    MessageBox.Show("Supply successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    inventory.loadInventory(this.gridSupplies);
                    inventory.loadInventory(this.gridManageSupplies);

                    this.btnAddManageSupplies.Visible = true;
                    this.btnEditManageSupplies.Enabled = true;

                    this.btnSaveManageSupplies.Visible = false;

                    autoGenNum();

                    this.txtSupplyNameManageSupplies.ResetText();
                    this.txtSupplyQuantityManageSupplies.ResetText();

                    this.txtSupplyNameManageSupplies.Focus();
                }
                else
                {
                    MessageBox.Show("Failed to update supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
