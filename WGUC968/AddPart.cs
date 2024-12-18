using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            StartPosition = FormStartPosition.CenterScreen;
            idBox.ReadOnly = true;
            inOrOutLabel.Text = "Machine ID";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inOrOutLabel.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inOrOutLabel.Text = "Company Name";
        }

        //save button
        private void button2_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inventory;
            int machineID;
            decimal price;

            try
            {
                min = int.Parse(minBox.Text);
                max = int.Parse(maxBox.Text);
                inventory = int.Parse(inventoryBox.Text);
                price = decimal.Parse(priceBox.Text);
                machineID = int.Parse(machineOrCompanyBox.Text);
            }
            catch
            {
                MessageBox.Show("Please ensure proper data values are entered.\n" +
                    "Min/Max/Inventory = Numbers\n" +
                    "Price = Decimal");
                return;
            }

            string name = nameBox.Text;

            if (min > max)
            {
                MessageBox.Show("Minimum number cannot exceed maximum.");
                return;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be within minimum and maximum values.");
                return;
            }

            if (inHouseRadioButton.Checked)
            {
                machineID = int.Parse(machineOrCompanyBox.Text);
                Inventory.AddPart(new Inhouse { MachineID = machineID, InStock = inventory, Max = max, Min = min, Name = name, Price = price, PartID = Inventory.PartIDCalculation() });
            }
            else
            {
                string companyName = nameBox.Text;
                Inventory.AddPart(new Outsourced { CompanyName = companyName, InStock = inventory, Max = max, Min = min, Name = name, Price = price, PartID = Inventory.PartIDCalculation() });
            }
            Close();
        }
    }
}