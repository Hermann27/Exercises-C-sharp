using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace controles_et_parents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                this.Controls.Add(textBox1);
                this.Controls.Add(textBox2);

                i = 1;
            }
            else {
                panel1.Controls.Add(textBox1);
                panel1.Controls.Add(textBox2);
                i = 0;
            }
            
            
        }

        private void btnctrlsFm_Click(object sender, EventArgs e)
        {
            txtctrls.Clear();
            foreach (Control ctrl in this.Controls)
            {
                txtctrls.Text += ctrl.Name + "\r\n";

            }
           
        }

        private void btnctrlsPanel_Click(object sender, EventArgs e)
        {
            txtctrls.Clear();
            foreach (Control ctrl in this.panel1.Controls)
            {
                txtctrls.Text += ctrl.Name + "\r\n";

            }
            
        }
    }
}
