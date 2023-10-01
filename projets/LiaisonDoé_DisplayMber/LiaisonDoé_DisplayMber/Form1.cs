using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace LiaisonDoé_DisplayMber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArrayList_Click(object sender, EventArgs e)
        {
             
        }

        private void listboxArticles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btndetails.Enabled = true;
            txtresultat.Text = ((Articles)listboxArticles.SelectedItem).Nom;
            txtresultatprix.Text = ((Articles)listboxArticles.SelectedItem).Prix;
        }

        private void buttonArrayList1_Click(object sender, EventArgs e)
        {
            ArrayList ListArticles = new ArrayList();

            ListArticles.Add(new Articles(txt1.Text, txtp1.Text));
            ListArticles.Add(new Articles(txt2.Text, txtp2.Text));
            ListArticles.Add(new Articles(txt3.Text, txtp3.Text));
            ListArticles.Add(new Articles(txt4.Text, txtp4.Text));
            ListArticles.Add(new Articles(txt5.Text, txtp5.Text));
            ListArticles.Add(new Articles(txt6.Text, txtp6.Text));
            listboxArticles.DataSource = ListArticles;
            listboxArticles.DisplayMember = "Nom";
            listboxArticles.ValueMember = "Prix";
            timer1.Start();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            double Somme=0.0;
            foreach(var  elt in listboxArticles.Items) 
            {
               Somme+=  Convert.ToDouble(((Articles)elt).Prix);              
            }
            txtprixTaux.Text = Somme.ToString();
            txtmax.Text = listboxArticles.Items.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblsms.Visible == false)
            {
                lblsms.Visible = true;
                lblsms.Text = "Article ayant le prix le plus coûteux : " + txt5.Text;

            }
            else
            {
                lblsms.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
