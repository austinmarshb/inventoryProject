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
        public ModifyProduct()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            idBox.ReadOnly = true;

            candidatePartsGrid.DataSource = Inventory.AllParts;
            candidatePartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
