using System.ComponentModel;
using System.Windows.Forms;
using WGUC968.Classes;

namespace WGUC968
{
    public partial class MainForm : Form
    {
        private BindingSource productsBindingList;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //parts grid settings

            //setting data source
            PartsDataGrid.DataSource = Inventory.AllParts;

            //full select mode
            PartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //create default parts list
            Inventory.AllParts.Add(new Outsourced { CompanyName = "Test1", InStock = 152, Max = 5000, Min = 1, Name = "spring", Price = 2.95m, PartID = Inventory.PartIDCalculation() });
            Inventory.AllParts.Add(new Inhouse { MachineID = 5, InStock = 474, Max = 2500, Min = 1, Name = "strut", Price = 8.50m, PartID = Inventory.PartIDCalculation() });
            Inventory.AllParts.Add(new Outsourced { CompanyName = "Test2", InStock = 742, Max = 7500, Min = 1, Name = "bolt", Price = 0.95m, PartID = Inventory.PartIDCalculation() });
            Inventory.AllParts.Add(new Inhouse { MachineID = 10, InStock = 236, Max = 2500, Min = 1, Name = "wire", Price = 8.50m, PartID = Inventory.PartIDCalculation() });
            Inventory.AllParts.Add(new Inhouse { MachineID = 15, InStock = 215, Max = 2500, Min = 1, Name = "bearing", Price = 4.25m, PartID = Inventory.PartIDCalculation() });

            //products grid settings
            productsBindingList = new BindingSource { DataSource = Inventory.Products };
            ProductsDataGrid.DataSource = productsBindingList;
            ProductsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //create default products list?...
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "hub", 44, 35.00m, 1, 99));
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "axle", 26, 15.00m, 1, 99));
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "chain", 252, 12.00m, 1, 99));
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "sprocket", 346, 8.00m, 1, 99));
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "clamp", 124, 14.00m, 1, 99));

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            AddPart addpart = new AddPart();
            addpart.Show();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (PartsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PartsDataGrid.SelectedRows[0];

                int selectedPartID = (int)selectedRow.Cells[0].Value;

                Part selectedPart = Inventory.AllParts.FirstOrDefault(p => p.PartID == selectedPartID);

                if (selectedPart != null)
                {
                    ModifyPart modifyForm = new ModifyPart(PartsDataGrid);
                    modifyForm.PopulateForm(selectedPart);
                    modifyForm.Show();
                }
            }
        }


        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addproduct = new AddProduct();
            addproduct.Show();
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductsDataGrid.SelectedRows[0];

                int selectedProductID = (int)selectedRow.Cells[0].Value;

                Product selectedProduct = Inventory.Products.FirstOrDefault(p => p.ProductID == selectedProductID);
                if (selectedProduct != null)
                {
                    ModifyProduct modifyForm = new ModifyProduct(ProductsDataGrid);
                    modifyForm.PopulateForm(selectedProduct);
                    modifyForm.Show();
                }
            }
        }

        //feed this data to modify form?
        //use it to delete parts/products? + deleting worked below, use again for product logic?
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (PartsDataGrid.Rows.Count > 0)
            {
                var selectedRow = PartsDataGrid.CurrentRow;
                if (selectedRow != null && selectedRow.Selected)
                {
                    Part selectedPart = selectedRow.DataBoundItem as Part;

                    if (selectedPart != null)
                    {
                        Inventory.deletePart(selectedPart);
                    }
                    else
                    {
                        MessageBox.Show("Selected row is not a valid part.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            else
            {
                MessageBox.Show("No parts available to delete.");
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGrid.Rows.Count > 0)
            {
                var selectedRow = ProductsDataGrid.CurrentRow;
                if (selectedRow != null && selectedRow.Selected)
                {
                    var selectedProduct = selectedRow.Index;

                    if (selectedProduct != null)
                    {
                        Inventory.removeProduct(selectedProduct);
                    }
                    else
                    {
                        MessageBox.Show("Selected row is not a valid part.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            else
            {
                MessageBox.Show("No parts available to delete.");
            }
        }



        public void partSearchBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void partSearchButton_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[PartsDataGrid.DataSource];
            cm.SuspendBinding();

            bool isNumber = int.TryParse(partSearchBox.Text, out int searchID);

            if (isNumber)
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if ((isNumber && searchID == Inventory.AllParts[i].PartID))
                    {
                        PartsDataGrid.Rows[i].Visible = true;
                        //PartsDataGrid.Rows[i].Selected = true;
                    }
                    else
                    {
                        PartsDataGrid.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                {
                    var userSearch = partSearchBox.Text;
                    for (int i = 0; i < Inventory.AllParts.Count; i++)
                    {
                        if (userSearch == Inventory.AllParts[i].Name.ToLower())
                        {
                            PartsDataGrid.Rows[i].Visible = true;
                        }
                        else
                        {
                            PartsDataGrid.Rows[i].Visible = false;
                        }
                    }
                }
            }

            cm.ResumeBinding();

            if (partSearchBox.Text == "" || partSearchBox == null)
            {
                MessageBox.Show("Please enter PartID or Part Name to search.");
                foreach (DataGridViewRow row in PartsDataGrid.Rows)
                {
                    row.Visible = true;
                }
            }

            //for (int j = 0; j < Inventory.AllParts.Count; j++)
            //{
            //    if (partSearchBox.Text != Inventory.AllParts[j].PartID.ToString())
            //    {
            //        PartsDataGrid.Rows[j].
            //    }
        }

        private void clearPartSearch_Click(object sender, EventArgs e)
        {
            PartsDataGrid.ClearSelection();
            partSearchBox.Text = "";
            foreach (DataGridViewRow row in PartsDataGrid.Rows)
            {
                row.Visible = true;
            }
        }

        private void productSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[ProductsDataGrid.DataSource];
            cm.SuspendBinding();

            bool isNumber = int.TryParse(productSearchBox.Text, out int searchID);

            if (isNumber)
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if ((isNumber && searchID == Inventory.Products[i].ProductID))
                    {
                        ProductsDataGrid.Rows[i].Visible = true;
                    }
                    else
                    {
                        ProductsDataGrid.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                {
                    var userSearch = productSearchBox.Text;
                    for (int i = 0; i < Inventory.Products.Count; i++)
                    {
                        if (userSearch == Inventory.Products[i].Name.ToLower())
                        {
                            ProductsDataGrid.Rows[i].Visible = true;
                        }
                        else
                        {
                            ProductsDataGrid.Rows[i].Visible = false;
                        }
                    }
                }
            }

            cm.ResumeBinding();

            if (productSearchBox.Text == "" || productSearchBox.Text == null)
            {
                MessageBox.Show("Please enter Product ID or Product Name to search.");
                foreach (DataGridViewRow row in ProductsDataGrid.Rows)
                {
                    row.Visible = true;
                    ProductsDataGrid.ClearSelection();
                }
            }
        }

        private void clearProductSearch_Click(object sender, EventArgs e)
        {
            ProductsDataGrid.ClearSelection();
            productSearchBox.Text = "";
            foreach (DataGridViewRow row in ProductsDataGrid.Rows)
            {
                row.Visible = true;
            }
        }
        public void RefreshPartsDataGrid()
        {
            PartsDataGrid.Refresh(); // This will refresh the DataGridView
        }
    }
}