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

namespace WGUC968
{

    public partial class ModifyProduct : Form

    {
        BindingList<Part> partslist = new BindingList<Part>();
        private DataGridView ProductsDataGrid;
        public DataGridView AssociatedParts;

        //not sure this constructor is needed anymore but leave it for now
        public ModifyProduct()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            idBox.ReadOnly = true;
            candidatePartsGrid.DataSource = Inventory.AllParts;
            candidatePartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public ModifyProduct(DataGridView datagrid)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            idBox.ReadOnly = true;
            ProductsDataGrid = datagrid;
            candidatePartsGrid.DataSource = Inventory.AllParts;
            candidatePartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssociatedParts = associatedPartsGrid;
            AssociatedParts.DataSource = partslist;
        }

        public void PopulateForm(Product selectedProduct)
        {
            idBox.Text = selectedProduct.ProductID.ToString();
            nameBox.Text = selectedProduct.Name;
            inventoryBox.Text = selectedProduct.InStock.ToString();
            priceBox.Text = selectedProduct.Price.ToString();
            maxBox.Text = selectedProduct.Max.ToString();
            minBox.Text = selectedProduct.Min.ToString();

            partslist.Clear();
            foreach (var part in selectedProduct.AssociatedParts)
            {
                partslist.Add(part);
            }
        }

        //cancel button to close out without saving
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool isValid()
        {
            if (!int.TryParse(inventoryBox.Text, out int inventory) || inventory < 0)
            {
                MessageBox.Show("Please enter a valid Inventory.");
                return false;
            }

            if (!decimal.TryParse(priceBox.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid Price/Cost.");
                return false;
            }

            if (!int.TryParse(maxBox.Text, out int max) || max < 0)
            {
                MessageBox.Show("Please enter a valid Max.");
                return false;
            }

            if (!int.TryParse(minBox.Text, out int min) || min < 0)
            {
                MessageBox.Show("Please enter a valid Min.");
                return false;
            }

            if (min >= max)
            {
                MessageBox.Show("Min must be less than Max.");
                return false;
            }

            if (inventory < min || inventory > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return false;
            }
            return true;
        }

        private bool isFormComplete()
        {
            return !string.IsNullOrEmpty(idBox.Text) &&
                   !string.IsNullOrEmpty(nameBox.Text) &&
                   !string.IsNullOrEmpty(inventoryBox.Text) &&
                   !string.IsNullOrEmpty(priceBox.Text) &&
                   !string.IsNullOrEmpty(maxBox.Text) &&
                   !string.IsNullOrEmpty(minBox.Text);
        }


        //this is the save button
        private void button5_Click(object sender, EventArgs e)
        {
            if (isValid() && isFormComplete())
            {
                int selectedProductID = int.Parse(idBox.Text);
                Product selectedProduct = Inventory.Products.FirstOrDefault(p => p.ProductID == selectedProductID);

                if (selectedProduct != null)
                {
                    // Update product details
                    selectedProduct.Name = nameBox.Text;
                    selectedProduct.InStock = int.Parse(inventoryBox.Text);
                    selectedProduct.Price = decimal.Parse(priceBox.Text);
                    selectedProduct.Max = int.Parse(maxBox.Text);
                    selectedProduct.Min = int.Parse(minBox.Text);

                    // Update associated parts
                    selectedProduct.AssociatedParts.Clear();
                    foreach (var part in partslist)
                    {
                        selectedProduct.AssociatedParts.Add(part);
                    }
                }

                // Refresh the DataGridView and close the form
                ProductsDataGrid.Refresh();
                this.Close();
            }
        }



        //this is the add button
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRow = candidatePartsGrid.CurrentRow;
            if (selectedRow != null)
            {
                var selectedPart = selectedRow.DataBoundItem as Part;
                partslist.Add(selectedPart);
            }
        }

        // this is the delete button
        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = associatedPartsGrid.CurrentRow;
            if (selectedRow != null)
            {
                var selectedPart = selectedRow.DataBoundItem as Part;
                partslist.Remove(selectedPart);
            }
        }


        // this is the search button
        private void button3_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[candidatePartsGrid.DataSource];
            cm.SuspendBinding();

            bool isNumber = int.TryParse(searchBox.Text, out int searchID);

            if (isNumber)
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if ((isNumber && searchID == Inventory.AllParts[i].PartID))
                    {
                        candidatePartsGrid.Rows[i].Visible = true;
                        //PartsDataGrid.Rows[i].Selected = true;
                    }
                    else
                    {
                        candidatePartsGrid.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                {
                    var userSearch = searchBox.Text;
                    for (int i = 0; i < Inventory.AllParts.Count; i++)
                    {
                        if (userSearch == Inventory.AllParts[i].Name.ToLower())
                        {
                            candidatePartsGrid.Rows[i].Visible = true;
                        }
                        else
                        {
                            candidatePartsGrid.Rows[i].Visible = false;
                        }
                    }
                }
            }
        }

        //clear button
        private void button4_Click(object sender, EventArgs e)
        {
            candidatePartsGrid.ClearSelection();
            searchBox.Text = "";
            foreach (DataGridViewRow row in candidatePartsGrid.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
