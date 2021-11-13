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
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            autoGenNum();

            inventory.loadIncomingInventory(this.gridIncomingSupplies);

            this.dateExpiration.Value = DateTime.Now.Date;
            this.dateArrive.Value = DateTime.Now.Date;
        }

        private void txtSupplyName_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(this.txtSupplyName.Text) && String.IsNullOrWhiteSpace(this.txtSupplyQuantity.Text))
            {
                this.btnAddIncomingSupplies.Enabled = false;
            }
            else
            {
                this.btnAddIncomingSupplies.Enabled = true;
            }
        }

        private void txtSupplyQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.txtSupplyQuantity.Text) && String.IsNullOrWhiteSpace(this.txtSupplyName.Text))
            {
                this.btnAddIncomingSupplies.Enabled = false;
            }
            else
            {
                this.btnAddIncomingSupplies.Enabled = true;
            }
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
            if(String.IsNullOrWhiteSpace(this.txtSupplyName.Text))
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

                    autoGenNum();
                    inventory.loadIncomingInventory(this.gridIncomingSupplies);

                    this.txtSupplyName.ResetText();
                    this.txtSupplyQuantity.ResetText();

                    this.btnAddIncomingSupplies.Visible = true;
                    this.btnEditIncomingSupplies.Enabled = true;
                    this.btnCancelIncomingSupplies.Visible = true;

                    this.btnSaveIncomingSupplies.Visible = false;
                    this.btnSupplyArrived.Enabled = false;
                    this.btnDeleteIncomingSupplies.Visible = false;
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

                    autoGenNum();
                    inventory.loadIncomingInventory(this.gridIncomingSupplies);

                    this.txtSupplyName.ResetText();
                    this.txtSupplyQuantity.ResetText();

                    this.btnAddIncomingSupplies.Visible = true;
                    this.btnEditIncomingSupplies.Enabled = true;
                    this.btnCancelIncomingSupplies.Visible = true;

                    this.btnSaveIncomingSupplies.Visible = false;
                    this.btnSupplyArrived.Enabled = false;
                    this.btnDeleteIncomingSupplies.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to update incoming supply!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditIncomingSupplies_Click(object sender, EventArgs e)
        {
            this.btnAddIncomingSupplies.Visible = false;
            this.btnCancelIncomingSupplies.Visible = false;
            this.btnEditIncomingSupplies.Enabled = false;

            this.btnSaveIncomingSupplies.Visible = true;
            this.btnDeleteIncomingSupplies.Visible = true;
        }

        private void btnCancelIncomingSupplies_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(inventory.deleteIncomingSupply(this.txtSupplyID.Text))
            {
                MessageBox.Show(string.Format("{0} successfully deleted!", this.txtSupplyName.Text), "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

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
    }
}
