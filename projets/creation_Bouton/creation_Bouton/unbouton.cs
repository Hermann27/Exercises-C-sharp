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
    public partial class unbouton : Form
    {
        public unbouton()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "Inactif";
        }

        
    }
}
