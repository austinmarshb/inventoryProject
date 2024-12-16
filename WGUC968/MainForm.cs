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
            // Populate the list with test data
            partsList.Add(new Inhouse(125, "Sprocket", 100.00m, 10, 1, 100, 123));
            partsList.Add(new Outsourced(634, "Joint", 150.00m, 5, 1, 50, "Supplier X"));
            partsList.Add(new Inhouse(221, "Bearing", 200.00m, 20, 1, 100, 456));

            // Populate the DataGridView
            dataGridView1.Columns.Add("PartID", "Part ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Stock", "Stock");
            dataGridView1.Columns.Add("Min", "Min");
            dataGridView1.Columns.Add("Max", "Max");

            // Add each part to the DataGridView
            foreach (var part in partsList)
            {
                dataGridView1.Rows.Add(part.PartID, part.Name, part.Price, part.Stock, part.Min, part.Max);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Populate the list with test data
            productsList.Add(new Product(124, "Gears", 75, 100.00f, 1, 100));
            productsList.Add(new Product(151, "Belt", 25, 150.00f, 1, 50));
            productsList.Add(new Product(121, "Hub", 12, 200.00f, 1, 100));

            // Populate the DataGridView
            dataGridView2.Columns.Add("ProductID", "Product ID");
            dataGridView2.Columns.Add("Name", "Name");
            dataGridView2.Columns.Add("Price", "Price");
            dataGridView2.Columns.Add("Stock", "Stock");
            dataGridView2.Columns.Add("Min", "Min");
            dataGridView2.Columns.Add("Max", "Max");

            // Add each part to the DataGridView
            foreach (var product in productsList)
            {
                dataGridView2.Rows.Add(product.ProductID, product.Name, product.Price, product.Stock, product.Min, product.Max);
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
            string searchQuery = partSearchBox.Text.ToLower(); // Get search query and convert it to lowercase
            var filteredParts = partsList.Where(part =>
                part.PartID.ToString().Contains(searchQuery) || // Check if the PartID contains the search query
                part.Name.ToLower().Contains(searchQuery))     // Check if the Name contains the search query
                .ToList(); // Create a filtered list

            // Clear existing rows in DataGridView
            dataGridView1.Rows.Clear();

            // Add the filtered rows back to the DataGridView
            foreach (var part in filteredParts)
            {
                dataGridView1.Rows.Add(part.PartID, part.Name, part.Price, part.Stock, part.Min, part.Max);
            }

            // If no results, show a message
            if (filteredParts.Count == 0)
            {
                MessageBox.Show("No matching parts found.");
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
            AddPart addPart = new AddPart();
            addPart.StartPosition = FormStartPosition.CenterParent;
            addPart.ShowDialog();
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
            //// Create an Inhouse part
            //Inhouse inhousePart = new Inhouse(1, "Inhouse Part", 100.00m, 20, 5, 50, 12345);

            //MessageBox.Show($"Inhouse Part ID: {inhousePart.PartID}, Name: {inhousePart.Name}, Machine ID: {inhousePart.MachineID}");
            //// Call DisplayInfo for the Inhouse part
            //inhousePart.DisplayInfo(); // This will show a MessageBox

            //// Create an Outsourced part
            ////Outsourced outsourcedPart = new Outsourced(2, "Outsourced Part", 150.00m, 10, 3, 30, "XYZ Supplier");

            ////// Call DisplayInfo for the Outsourced part
            ////outsourcedPart.DisplayInfo(); // This will show a MessageBox
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
            string searchQuery = productSearchBox.Text.ToLower(); // Get search query and convert it to lowercase
            var filteredProducts = productsList.Where(part =>
                part.ProductID.ToString().Contains(searchQuery) || // Check if the PartID contains the search query
                part.Name.ToLower().Contains(searchQuery))     // Check if the Name contains the search query
                .ToList(); // Create a filtered list

            // Clear existing rows in DataGridView
            dataGridView2.Rows.Clear();

            // Add the filtered rows back to the DataGridView
            foreach (var product in filteredProducts)
            {
                dataGridView2.Rows.Add(product.ProductID, product.Name, product.Price, product.Stock, product.Min, product.Max);
            }

            // If no results, show a message
            if (filteredProducts.Count == 0)
            {
                MessageBox.Show("No matching parts found.");
            }
        }
    }
}
