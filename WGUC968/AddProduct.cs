using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private BindingList<Part> AssociatedPartsList = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            idBox.ReadOnly = true;

            candidatePartsGrid.DataSource = Inventory.AllParts;
            candidatePartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedPartsGrid.DataSource = AssociatedPartsList;
            associatedPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //this is the SEARCH button
        private void button3_Click(object sender, EventArgs e)
        {

        }

        //this is the save button <--------------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            {
                int min;
                int max;
                int inventory;
                decimal price;

                try
                {
                    min = int.Parse(minBox.Text);
                    max = int.Parse(maxBox.Text);
                    inventory = int.Parse(inventoryBox.Text);
                    price = decimal.Parse(priceBox.Text);
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

                Inventory.addProduct(new Product(
                    Inventory.ProductIDCalculation(),
                    name,
                    inventory,
                    price,
                    min,
                    max)
                { AssociatedParts = AssociatedPartsList });

                Close();
            }
        }

        //this is the ADD button for product <-----------
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRow = candidatePartsGrid.CurrentRow;
            if (selectedRow != null && selectedRow.Selected)
            {
                if (candidatePartsGrid.Rows.Count > 0)
                {
                    Part newPart = candidatePartsGrid.CurrentRow.DataBoundItem as Part;
                    AssociatedPartsList.Add(newPart);
                    candidatePartsGrid.ClearSelection();
                    associatedPartsGrid.ClearSelection();
                }
            }
        }

        //this is the DELETE button for product <----------- you should really start naming these dawg
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = associatedPartsGrid.CurrentRow;
            if (selectedRow != null && selectedRow.Selected)
            {
                if (associatedPartsGrid.Rows.Count > 0)
                {
                    Part selectedPart = associatedPartsGrid.CurrentRow.DataBoundItem as Part;
                    AssociatedPartsList.Remove(selectedPart);
                    candidatePartsGrid.ClearSelection();
                    associatedPartsGrid.ClearSelection();
                }
            }
        }
    }
}