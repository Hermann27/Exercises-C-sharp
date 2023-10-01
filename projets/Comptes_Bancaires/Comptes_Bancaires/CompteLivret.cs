using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comptes_Bancaires
{
    class CompteLivret : Compte 
    {
        //attribut
        private double FTaux = 0.0;
        //constructeur
        public CompteLivret(string num, string nom, double depot, double taux) : base(num, nom, depot)
        {

        }
        //propriété
        public double Taux { get; set; }
        //méthodes
         
         public override void consulter()
         {

         }
         public override void deposer(double somme)
         {
         }
    }
}
