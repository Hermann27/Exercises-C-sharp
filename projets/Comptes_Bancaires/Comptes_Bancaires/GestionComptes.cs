using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Comptes_Bancaires
{
    class GestionComptes : ArrayList
    {
        //attributs
        private string FnomClient;
        private const double TauxActu=0.02;
        //constructeur
        public GestionComptes(string nom)
        {
            FnomClient = nom;
        }
        //propriétés
        public string nomClient { get; set; }
        //méthodes
        public void consulter()
        {

        }
        public void consulter(string num)
        {

        }
        public virtual void decouvertCompte(double decouv,string num)
        {
        }
        public void deposer(double somme,string num)
        {
        }
        public virtual void fermerCompte(string num)
        {
        }
        public virtual void ouvrirCompte(double somme,typeCompte genre, string num)
        {
        }
        public void retirer(double somme, string num)
        {
        }
    }
}
