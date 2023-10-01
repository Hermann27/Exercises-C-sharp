using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miniProjet_voiture
{
    class Rivet
    {
        //attributs
        private int nbrRivet;
        private double prixUnit = 1.2;
        //propriétés
        public int NbrRivet
        {
            get { return nbrRivet; }
            set { nbrRivet = value; }
        }
        public double PrixUnit
        {
            get { return prixUnit; }
            set { prixUnit = value; }
        }
        //constructeur
        public Rivet(int nbr)
        {
            this.nbrRivet = nbr;
        }
    }
}
