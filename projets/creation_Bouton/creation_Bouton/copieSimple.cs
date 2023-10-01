using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace creation_Bouton
{
    public partial class copieSimple : Form
    {
        public copieSimple()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

    }
}
