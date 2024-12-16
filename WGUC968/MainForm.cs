namespace WGUC968
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
