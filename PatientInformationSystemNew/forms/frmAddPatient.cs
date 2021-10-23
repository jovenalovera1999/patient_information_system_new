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
    public partial class frmAddPatient : Form
    {
        public frmAddPatient()
        {
            InitializeComponent();
        }

        void autoGenNum()
        {
            Random number = new Random();
            var generateID = new StringBuilder();

            while (generateID.Length < 11)
            {
                generateID.Append(number.Next(10).ToString());
            }
            this.txtPatientID.Text = generateID.ToString();
        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            autoGenNum();
        }
    }
}
