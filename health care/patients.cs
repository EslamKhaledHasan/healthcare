using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace health_care
{
    public partial class patients : Form
    {
        functions Con;


        public patients()
        {
            InitializeComponent();
            Con = new functions();
            ShowPatients();
        }
        private void ShowPatients()
        {
            string Query = "Select from PatientTbl";
            PatientLst.DataSource = Con.GetData(Query);
            PatientLst.DataSource ource = PatientLst.DataSource = Con.GetDatCon.GetData(Query);
        }
        private void patients_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
