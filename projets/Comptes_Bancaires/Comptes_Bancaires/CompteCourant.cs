using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comptes_Bancaires
{
    class CompteCourant : Compte
    {
        //attribut
        private double FdecouvertAutorise;
        //construteurs
        public CompteCourant(string num, string nom): base(num, nom)
        {
          
        }
        public CompteCourant(string num, string nom, double depot) : base(num, nom, depot)
        {

        }
        public CompteCourant(string num, string nom, double depot, double decouv): base(num, nom, depot)
        {

        }
        //propriétés
        public double decouvertAutorise { get; set; }
        //méthodes
       
        public override void consulter()
        {

        }
        public override void retirer(double somme)
        {
        }

    }
}
