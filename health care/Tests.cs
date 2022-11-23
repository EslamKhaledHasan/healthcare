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
    public partial class TestsList : Form
    {
        functions Con;
        public TestsList()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTest();
        }
        private void ShowTest()
        {
            string Query = "select * from Testtbl";
            Tests.DataSource = Con.GetData(Query);
        }
        private void Clear()
        {
            TName.Text = "";
            TCcost.Text = "";
        }
        private void SaveBtn_click(object sender ,EventArgs r)
        {
            if (TName.Text == "" || TCcost.Text == "" ||)
            {
                MessageBox.Show("Missing Dadta!!");
            }
            else
            {
                string TName = TName.Text;
                int Cost = Convert.ToInt32(TCcost.Text);
               
                string Query = "insert into TsttTb1 valuues('{0}','{1}')";
                Query = string.Format(Query, TName, Cost);
                Con.SetData(Query);
                ShowTest();
                Clear();
                MessageBox.Show("Patient Adress!!!");
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void l_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
