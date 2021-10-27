using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PatientInformationSystemNew.forms
{
    public partial class frmCreatePrescription : Form
    {
        public frmCreatePrescription()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Diagnosis diagnosis = new functions.Diagnosis();
        functions.Symptoms symptom = new functions.Symptoms();

        private void frmCreatePrescription_Load(object sender, EventArgs e)
        {
            this.dateRecords.Value = DateTime.Now;
            
        }
    }
}
