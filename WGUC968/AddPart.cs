using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WGUC968.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WGUC968
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        public Part NewPart { get; private set; }
        //this is the cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //seems like I don't need these if statements...
            //if (radioButton1.Checked)
            //{
            label8.Text = "         Machine ID";
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //commenting out if statements, logic works without due to winforms built in functionality?..
            //if (radioButton2.Checked)
            //{
            label8.Text = "Company Name";
            //}
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //this is the save button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect input data
                int id = int.Parse(idBox.Text);
                string name = nameBox.Text;
                decimal price = decimal.Parse(priceBox.Text);
                int stock = int.Parse(inventoryBox.Text);
                int min = int.Parse(minBox.Text);
                int max = int.Parse(maxBox.Text);

                if (min > max)
                {
                    MessageBox.Show("Min cannot be greater than Max.");
                    return;
                }

                if (stock < min || stock > max)
                {
                    MessageBox.Show("Inventory must be within Min and Max bounds.");
                    return;
                }

                if (inHouseRadioButton.Checked) // Inhouse
                {
                    int machineID = int.Parse(machineOrCompanyBox.Text);
                    NewPart = new Inhouse(id, name, price, stock, min, max, machineID);
                }
                else if (outsourcedRadioButton.Checked) // Outsourced
                {
                    string companyName = machineOrCompanyBox.Text;
                    NewPart = new Outsourced(id, name, price, stock, min, max, companyName);
                }   
                else
                {
                    MessageBox.Show("Please select a part type.");
                    return;
                }

                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddPart_Load_1(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void minBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void machineOrCompanyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
