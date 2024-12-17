using WGUC968.Classes;

namespace WGUC968
{
    public partial class MainForm : Form
    {

        private List<Part> partsList = new List<Part>();
        private List<Product> productsList = new List<Product>();

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            partsList.Add(new Inhouse(125, "Sprocket", 100.00m, 10, 1, 1232, 123));
            partsList.Add(new Outsourced(634, "Joint", 150.00m, 5, 1, 322, "Supplier X"));
            partsList.Add(new Inhouse(221, "Bearing", 200.00m, 20, 1, 2362, 456));

            dataGridView1.Columns.Add("PartID", "Part ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Stock", "Stock");
            dataGridView1.Columns.Add("Min", "Min");
            dataGridView1.Columns.Add("Max", "Max");

            foreach (var part in partsList)
            {
                dataGridView1.Rows.Add(part.PartID, part.Name, part.Price, part.InStock, part.Min, part.Max);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            productsList.Add(new Product(124, "Gears", 75, 100.00f, 1, 15));
            productsList.Add(new Product(151, "Belt", 25, 150.00f, 1, 18));
            productsList.Add(new Product(121, "Hub", 12, 200.00f, 1, 53));

            dataGridView2.Columns.Add("ProductID", "Product ID");
            dataGridView2.Columns.Add("Name", "Name");
            dataGridView2.Columns.Add("Price", "Price");
            dataGridView2.Columns.Add("Stock", "Stock");
            dataGridView2.Columns.Add("Min", "Min");
            dataGridView2.Columns.Add("Max", "Max");

            foreach (var product in productsList)
            {
                dataGridView2.Rows.Add(product.ProductID, product.Name, product.Price, product.InStock, product.Min, product.Max);
            }

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string searchQuery = partSearchBox.Text.ToLower();
            var filteredParts = partsList.Where(part =>
                part.PartID.ToString().Contains(searchQuery) ||
                part.Name.ToLower().Contains(searchQuery))
                .ToList();

            dataGridView1.Rows.Clear();

            foreach (var part in filteredParts)
            {
                dataGridView1.Rows.Add(part.PartID, part.Name, part.Price, part.InStock, part.Min, part.Max);
            }

            if (filteredParts.Count == 0)
            {
                RepopulateGridView(partsList);
                MessageBox.Show("No matching parts found.");
                this.StartPosition = FormStartPosition.CenterParent;
                partSearchBox.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //add part button
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (AddPart addPartForm = new AddPart())
            {
                addPartForm.StartPosition = FormStartPosition.CenterParent;

                // Show the AddPart form and check if the user clicked "Save" (DialogResult.OK)
                if (addPartForm.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the new part from the AddPart form
                    Part newPart = addPartForm.NewPart;

                    if (newPart != null)
                    {
                        // Add the new part to the parts list and the DataGridView
                        partsList.Add(newPart);
                        dataGridView1.Rows.Add(newPart.PartID, newPart.Name, newPart.Price, newPart.InStock, newPart.Min, newPart.Max);
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifyPart modifyPart = new ModifyPart();
            modifyPart.StartPosition = FormStartPosition.CenterParent;
            modifyPart.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.StartPosition = FormStartPosition.CenterParent;
            addProduct.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModifyProduct modifyProduct = new ModifyProduct();
            modifyProduct.StartPosition = FormStartPosition.CenterParent;
            modifyProduct.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                partsList.RemoveAt(selectedIndex);

                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please ensure the entire row is highlighted in order to properly delete.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //for testing remove later
        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedIndex2 = dataGridView2.SelectedRows[0].Index;

                productsList.RemoveAt(selectedIndex2);

                dataGridView2.Rows.RemoveAt(selectedIndex2);
            }
            else
            {
                MessageBox.Show("Please ensure the entire row is highlighted in order to properly delete.");
            }
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = productSearchBox.Text.ToLower();
            var filteredProducts = productsList.Where(part =>
                part.ProductID.ToString().Contains(searchQuery) ||
                part.Name.ToLower().Contains(searchQuery))
                .ToList();

            dataGridView2.Rows.Clear();

            foreach (var product in filteredProducts)
            {
                dataGridView2.Rows.Add(product.ProductID, product.Name, product.Price, product.InStock, product.Min, product.Max);
            }

            if (filteredProducts.Count == 0)
            {
                MessageBox.Show("No matching parts found.");
                RepopulateGridView(productsList);
                this.StartPosition = FormStartPosition.CenterParent;
                productSearchBox.Clear();
            }
        }
        private void RepopulateGridView(List<Product> productList)
        {
            dataGridView2.Rows.Clear();

            foreach (var product in productList)
            {
                dataGridView2.Rows.Add(product.ProductID, product.Name, product.Price, product.InStock, product.Min, product.Max);
            }

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RepopulateGridView(List<Part> partsList)
        {
            dataGridView1.Rows.Clear();

            foreach (var part in partsList)
            {
                dataGridView1.Rows.Add(part.PartID, part.Name, part.Price, part.InStock, part.Min, part.Max);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void clearPartSearch_Click(object sender, EventArgs e)
        {
            RepopulateGridView(partsList);
            partSearchBox.Clear();
        }

        private void clearProductSearch_Click(object sender, EventArgs e)
        {
            RepopulateGridView(productsList);
            productSearchBox.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
