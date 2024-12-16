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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        //this is the cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //seems like I don't need these if statements...
            //if (radioButton1.Checked)
            //{
            label8.Text = "         Machine ID";
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //commenting out if statements, logic works without due to winforms built in functionality?..
            //if (radioButton2.Checked)
            //{
            label8.Text = "Company Name";
            //}
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //this is the save button
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
