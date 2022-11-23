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
            Con = new Functions();
            ShowPaints();
        }
        private void ShowPaints()
        {
            string Query = "select * from patientstbl";
            PatientsList.DataSource = Con.GetData(Query);
        }
        private void PatientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(PatNameTb.Text == "" || PatAddTb.Text == "" || GenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Dadta!!");
            }
            else
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
        int key = 0;
        private void PacientList(object sender, DataColumnChangeEventArgs e)
        {
            PatNameTb.Text = PatientsList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.SelectedItem = PatientsList.SelectedRows[0].Cells[2].Value.ToString();
            DOBTb.Text = PatientsList.SelectedRows[0].Cells[3].Value.ToString();
            PatPhoneTb.Text = PatientsList.SelectedRows[0].Cells[4].Value.ToString();
            PatAddTb.Text = PatientsList.SelectedRows[0].Cells[5].Value.ToString();
            if(PatNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
