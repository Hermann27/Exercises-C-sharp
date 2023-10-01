using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiaisonDeDonnee
{
    public partial class Form1 : Form
    {
        private string[] tableau = { "lapin", "paon", "renard", "faucon", "poule" };

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonTextBox_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = textBoxSource.AutoCompleteCustomSource;
        }

        private void ButtonTableauString_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = tableau;
        }

    }
}
