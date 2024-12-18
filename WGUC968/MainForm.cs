using System.ComponentModel;
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
            Inventory.AllParts.Add(new Outsourced { CompanyName = "Test1", InStock = 152, Max = 5000, Min = 1, Name = "Spring", Price = 2.95m, PartID = Inventory.PartIDCalculation() });
            Inventory.AllParts.Add(new Inhouse { MachineID = 5, InStock = 474, Max = 2500, Min = 1, Name = "Strut", Price = 8.50m, PartID = Inventory.PartIDCalculation() });
            Inventory.AllParts.Add(new Outsourced { CompanyName = "Test2", InStock = 742, Max = 7500, Min = 1, Name = "Bolt", Price = 0.95m, PartID = Inventory.PartIDCalculation() });
            Inventory.AllParts.Add(new Inhouse { MachineID = 10, InStock = 236, Max = 2500, Min = 1, Name = "Wire", Price = 8.50m, PartID = Inventory.PartIDCalculation() });
            Inventory.AllParts.Add(new Outsourced { CompanyName = "Test3", InStock = 125, Max = 1250, Min = 1, Name = "Shim", Price = 1.95m, PartID = Inventory.PartIDCalculation() });
            Inventory.AllParts.Add(new Inhouse { MachineID = 15, InStock = 215, Max = 2500, Min = 1, Name = "Bearing", Price = 4.25m, PartID = Inventory.PartIDCalculation() });

            //products grid settings
            productsBindingList = new BindingSource { DataSource = Inventory.Products };
            ProductsDataGrid.DataSource = productsBindingList;
            ProductsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //create default products list?...
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "Hub", 44, 35.00m, 1, 99));
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "Axle", 26, 15.00m, 1, 99));
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "Post", 322, 25.00m, 1, 99));
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "Chain", 252, 12.00m, 1, 99));
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "Sprocket", 346, 8.00m, 1, 99));
            Inventory.Products.Add(new Product(Inventory.ProductIDCalculation(), "Clamp", 124, 14.00m, 1, 99));

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
            ModifyPart modifypart = new ModifyPart();
            modifypart.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addproduct = new AddProduct();
            addproduct.Show();
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            ModifyProduct modifyproduct = new ModifyProduct();
            modifyproduct.Show();
        }

        //feed this data to modify form?
        //use it to delete parts/products? + deleting worked below, use again for product logic?
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (PartsDataGrid.Rows.Count > 0)
            {
                if (PartsDataGrid.CurrentRow.Selected)
                {
                    Part selectedPart = PartsDataGrid.CurrentRow.DataBoundItem as Part;
                    Inventory.DeletePart(selectedPart);
                }
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (ProductsDataGrid.Rows.Count > 0)
            {
                if (ProductsDataGrid.CurrentRow.Selected)
                {
                    int indexOfProduct = ProductsDataGrid.CurrentCell.RowIndex;
                    Inventory.RemoveProduct(indexOfProduct);
                }
            }
        }


        public void partSearchBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void partSearchButton_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[PartsDataGrid.DataSource];
            cm.SuspendBinding();
            for (int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (partSearchBox.Text == Inventory.AllParts[i].PartID.ToString())
                {
                    PartsDataGrid.Rows[i].Visible = true;
                }
                else
                {
                    PartsDataGrid.Rows[i].Visible = false;
                }
            }
            cm.ResumeBinding();

            if (partSearchBox.Text == "")
            {
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
            foreach (DataGridViewRow row in PartsDataGrid.Rows)
            {
                row.Visible = true;
                partSearchBox.Text = "";
            }
        }

        private void productSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[ProductsDataGrid.DataSource];
            cm.SuspendBinding();
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (productSearchBox.Text == Inventory.Products[i].ProductID.ToString())
                {
                    ProductsDataGrid.Rows[i].Visible = true;
                }
                else
                {
                    ProductsDataGrid.Rows[i].Visible = false;
                }
            }
            cm.ResumeBinding();

            if (productSearchBox.Text == "")
            {
                foreach (DataGridViewRow row in ProductsDataGrid.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void clearProductSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ProductsDataGrid.Rows)
            {
                row.Visible = true;
                productSearchBox.Text = "";
            }
        }
    }
}