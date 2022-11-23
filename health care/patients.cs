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
        Functions Con;
        public patients()
        {
            InitializeComponent();
            Con = new functions();
            ShowPatients();
        }
        private void ShowPatients()
        {
            string Query = "select * from patientstbl";
            PatientsList.DataSource = Con.GetData(Query);
        }
        private void patients_Load(object sender, EventArgs e)
        {
            if(PatNameTb.Text == "" || PatAddTb.Text == "" || GenCb.SelectedIndex == -1)
        {
                MessageBox.Show("Missing Dadta!!");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
                string Patient = PatNameTb.Text;
                string Gender = GenCb.SelectedItem.ToString();
                string BDate = DOBTb.Value.Date.ToString();
                string Phone = PatPhoneTb.Text;
                string Address = PatAddTb.Text;
                string Query = "insert into PatientTb1 valuues('{0}','{1}','{2}','{3}','{4}')";
                Query = string.Format(Query, Patient, Gender, BDate, Phone, Address);
                Con.SetData(Query);
                ShowPaints();
                MessageBox.Show("Patient Adress!!!");
        }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
