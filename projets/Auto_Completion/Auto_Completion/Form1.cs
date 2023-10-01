using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auto_Completion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonCompletionPerso_Click(object sender, EventArgs e)
        {
            comboBoxMode.Text = AutoCompleteMode.Suggest.ToString();
            comboBoxSource.Text = AutoCompleteSource.CustomSource.ToString();
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMode.SelectedItem = textBoxAuto.AutoCompleteMode.ToString();
           
        }

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSource.SelectedItem = textBoxAuto.AutoCompleteSource.ToString();
        }
    }
}
