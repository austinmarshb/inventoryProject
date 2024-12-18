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
    }
}