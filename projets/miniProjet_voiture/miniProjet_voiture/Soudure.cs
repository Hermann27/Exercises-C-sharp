using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miniProjet_voiture
{
    class Soudure
    {
        //attributs
        private int nbrSoudure;
        private double prixUnit = 0.8;
        //propriétés
        public int NbrSoudure
        {
            get { return nbrSoudure; }
            set { nbrSoudure = value; }
        }
        public double PrixUnit
        {
            get { return prixUnit; }
            set { prixUnit = value; }
        }
        //constructeur
        public Soudure(int nbr)
        {
            this.nbrSoudure = nbr;
        }
    }
}
