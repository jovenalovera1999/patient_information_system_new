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
    public partial class frmUpdateHistory : Form
    {
        public frmUpdateHistory()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();

        functions.UpdateHistory update_history = new functions.UpdateHistory();

        private void frmUpdateHistory_Load(object sender, EventArgs e)
        {
            update_history.LoadUpdateHistory(this.gridUpdateHistory);
        }

        private void gridUpdateHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.gridUpdateHistory.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
            this.gridUpdateHistory.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            DateTime date = DateTime.Parse(this.gridUpdateHistory.SelectedCells[3].Value.ToString());

            this.txtUpdateID.Text = this.gridUpdateHistory.SelectedCells[0].Value.ToString();
            this.txtEditedBy.Text = this.gridUpdateHistory.SelectedCells[1].Value.ToString();
            this.txtDescription.Text = this.gridUpdateHistory.SelectedCells[2].Value.ToString();
            this.txtDate.Text = date.ToString("D");
        }
    }
}
