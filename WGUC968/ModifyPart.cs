using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WGUC968.Classes;

namespace WGUC968
{
    public partial class ModifyPart : Form
    {
        private DataGridView PartsDataGrid;
        public ModifyPart()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            idBox.ReadOnly = true;
            inOrOutLabel.Text = "Machine ID";
        }

        public ModifyPart(DataGridView datagrid)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            idBox.ReadOnly = true;
            inOrOutLabel.Text = "Machine ID";
            PartsDataGrid = datagrid;
        }

        public void PopulateForm(Part selectedPart)
        {
            idBox.Text = selectedPart.PartID.ToString();
            nameBox.Text = selectedPart.Name;
            inventoryBox.Text = selectedPart.InStock.ToString();
            priceBox.Text = selectedPart.Price.ToString();
            maxBox.Text = selectedPart.Max.ToString();
            minBox.Text = selectedPart.Min.ToString();

            if (selectedPart is Inhouse InHouse)
            {
                inHouseRadioButton.Checked = true;
                machineOrCompanyBox.Text = InHouse.MachineID.ToString();
            }
            else if (selectedPart is Outsourced Outsourced)
            {
                outsourcedRadioButton.Checked = true;
                machineOrCompanyBox.Text = Outsourced.CompanyName;
            }
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inOrOutLabel.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            inOrOutLabel.Text = "Company Name";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isValid() && isFormComplete())
            {
                int selectedPartID = int.Parse(idBox.Text);
                Part selectedPart = Inventory.AllParts.FirstOrDefault(p => p.PartID == selectedPartID);

                if (selectedPart != null)
                {
                    selectedPart.Name = nameBox.Text;
                    selectedPart.InStock = int.Parse(inventoryBox.Text);
                    selectedPart.Price = decimal.Parse(priceBox.Text);
                    selectedPart.Max = int.Parse(maxBox.Text);
                    selectedPart.Min = int.Parse(minBox.Text);

                    if (inHouseRadioButton.Checked)
                    {
                        Inhouse inHousePart = selectedPart as Inhouse;
                        inHousePart.MachineID = int.Parse(machineOrCompanyBox.Text);
                    }
                    else if (outsourcedRadioButton.Checked)
                    {
                        Outsourced outsourcedPart = selectedPart as Outsourced;
                        outsourcedPart.CompanyName = machineOrCompanyBox.Text;
                    }
                }
                PartsDataGrid.Refresh();
                this.Close();
            }
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

            if (inHouseRadioButton.Checked)
            {
                if (!int.TryParse(machineOrCompanyBox.Text, out int machineID) || machineID < 0)
                {
                    MessageBox.Show("Please enter a valid Machine ID.");
                    return false;
                }
            }
            else if (outsourcedRadioButton.Checked)
            {
                if (string.IsNullOrEmpty(machineOrCompanyBox.Text))
                {
                    MessageBox.Show("Please enter a valid Company Name.");
                    return false;
                }
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
                   !string.IsNullOrEmpty(minBox.Text) &&
                   !string.IsNullOrEmpty(machineOrCompanyBox.Text);
        }

    }
}