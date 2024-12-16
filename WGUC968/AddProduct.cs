using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WGUC968.Classes;

namespace WGUC968
{
    public partial class AddProduct : Form
    {
        private List<Product> parts = new List<Product>();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("PartID", "Part ID");
            dataGridView2.Columns.Add("Name", "Name");
            dataGridView2.Columns.Add("Stock", "Stock");
            dataGridView2.Columns.Add("Price", "Price");
            dataGridView2.Columns.Add("Min", "Min");
            dataGridView2.Columns.Add("Max", "Max");

            dataGridView2.Rows.Add(1, "Part 1", 5, 10.99m, 2, 10);
            dataGridView2.Rows.Add(2, "Part 1", 3, 15.99m, 1, 5);
            dataGridView2.Rows.Add(3, "Part 2", 3, 8.99m, 3, 15);

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
