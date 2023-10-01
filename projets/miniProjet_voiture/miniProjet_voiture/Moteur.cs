using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miniProjet_voiture
{
    class Moteur
    {
        //atributs
        private string typeMoteur;
        //constructeurs
        public Moteur(string nom)
        {
            this.typeMoteur = nom;
        }
        //propriétés
        public string TypeMoteur
        {
            get { return typeMoteur; }
            set { typeMoteur = value; }
        }
        //méthodes
        
    }
}
