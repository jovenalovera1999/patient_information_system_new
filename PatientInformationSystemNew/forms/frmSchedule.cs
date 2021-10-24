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
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
        }

        components.Connections con = new components.Connections();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            patient.loadPatientInSchedule(this.gridSchedule);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
