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
            dt.Rows.Add(comboBox1.Text, " ", " ", " ", " ", 120);
            this.dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);

                    }
                    catch (Exception) 
                    {
                        MessageBox.Show("Pizzaerne i din kurv er blevet købt.");

                    }
                }
            } while (dataGridView1.Rows.Count > 1);


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
            dt.Columns.AddRange(new DataColumn[6] { 
                new DataColumn(" ", typeof(string)),
                new DataColumn("  ",typeof(string)),
                new DataColumn("   ",typeof(string)),
                new DataColumn("    ",typeof(string)),
                new DataColumn("      ",typeof(string)),
                new DataColumn("Total",typeof(string))



            });

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text, 100);
            this.dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {


            dt.Rows.Add(comboBox7.Text," "," ", " ", " " , 50);

            this.dataGridView1.DataSource = dt;


        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                price += row.Cells["Total"] != null ? Convert.ToDecimal(row.Cells["Total"].Value) : 0;
            }

            textBox1.Text = "Total Cost: $" + price.ToString("n2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
