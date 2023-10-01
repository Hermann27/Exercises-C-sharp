using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comptes_Bancaires
{
    enum typeCompte
    {
        courant,
        livret,
        titre

    }
    abstract class Compte : Icompte
    {
        //attributs
        private string Fnumero = "000000";
        private double Fsolde = 0;
        private string Ftitulaire = "***";
        private typeCompte FgenreCompte;
        //constructeurs
        public Compte(string num, string nom)
        {
            Fnumero = num;
            Ftitulaire = nom;
        }
        public Compte(string num, string nom, double depot)
            : this(num, nom)
        {
            Fnumero = num;
            Ftitulaire = nom;
        }
        //propriétés
        public string numero { get; set; }
        public virtual double solde { get; set; }
        public string titulaire { get; set; }
        public typeCompte genreCompte { get; set; }
        //méthodes

        public virtual void consulter()
        {

        }
        public virtual void deposer(double somme)
        {
        }
        public virtual void retirer(double somme)
        {
        }
    }
}

