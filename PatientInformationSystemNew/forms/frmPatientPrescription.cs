﻿using System;
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
    public partial class frmPatientPrescription : Form
    {
        public frmPatientPrescription()
        {
            InitializeComponent();
        }

        private void frmPatientPrescription_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}