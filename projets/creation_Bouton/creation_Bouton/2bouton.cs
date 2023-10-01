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
    public partial class _2bouton : Form
    {
        public _2bouton()
        {
            InitializeComponent();
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
                int a = Int32.Parse(button1.Text);
                a++;
                button1.Text = a.ToString() ;
                button2.Enabled = true;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            button2.Enabled = false;
            button1.Text = "0";

        }

        private void _2bouton_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
