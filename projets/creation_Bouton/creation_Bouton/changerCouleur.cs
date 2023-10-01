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
    public partial class changerCouleur : Form
    {
        public changerCouleur()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            if (button1.Text == "Changer de couleur")
            {
                radioButton1.Enabled = true; ;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
                button1.Text = "Interdire le changement";
            }
            else
            {
                if (button1.Text == "Interdire le changement")
                {
                    radioButton1.Enabled = false; ;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    radioButton5.Enabled = false;
                    button1.Text = "Changer de couleur";
                }
            }
        }


        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Changement de couleur du fond", "Message provenant du textBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.BackColor = Color.Blue;
            
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_BackColorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour etes vous pret ?","Laboratoire UPC",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

       
    }
}
