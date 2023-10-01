using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace LiaisonDoé_DisplayMber
{
    class Articles
    {
        private string nom;
        private string prix;
        public string Nom { get { return nom; } }
        public string Prix { get{ return prix; } }
        public Articles(string nom, string prix)
        {
            this.nom = nom;
            this.prix = prix;
        }
       
    }
}
