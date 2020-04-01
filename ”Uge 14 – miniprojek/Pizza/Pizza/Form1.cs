using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pizza
{
    public partial class Form1 : Form
    {

        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(comboBox1.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MessageBox.Show("Pizzaerne i din kurv er blevet købt.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.AddRange(new DataColumn[5] { 
                    new DataColumn("Brød", typeof(string)),
                    new DataColumn("Sovs",typeof(string)),
                new DataColumn("Kød",typeof(string)),
                new DataColumn("Ost",typeof(string)),
               new DataColumn("Størrelse",typeof(string))


            });

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text);
            this.dataGridView1.DataSource = dt;

        }
    }
}
