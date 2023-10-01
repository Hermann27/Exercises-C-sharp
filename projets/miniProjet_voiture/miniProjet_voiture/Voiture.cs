using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miniProjet_voiture
{
    class Voiture : Vehicule
    {
        //constructeurs
        public Voiture(string marque, string moteur, string typRoues, int nbrRivet, int nbrSoudure, int masseAcier) :base(marque,moteur)
        {
            lesRivets = new Rivet(nbrRivet);
            lesSoudure = new Soudure(nbrSoudure);
            Acier_Kg = masseAcier;
            lesRoues = new Roue(typRoues);
            calculPrix();
        }
        //méthodes
        public void afficherInfoVehicule()
        {
            Console.WriteLine("marque de la voiture : "+NomSerie);
            Console.WriteLine("numéro de série de la voiture : "+NumeroSeries);
            Console.WriteLine("type du moteur : "+LeMoteur.TypeMoteur);
            Console.WriteLine("type des roues : "+LesRoues.TypeRoues);
            Console.WriteLine("nombre de rivets : "+lesRivets.NbrRivet);
            Console.WriteLine("nombre de soudures : "+LesSoudure.NbrSoudure);
            Console.WriteLine("cout des rivets = "+coutRivets());
            Console.WriteLine("cout des soudures = " + coutSoudure());
            Console.WriteLine("prix de revient = "+prixRevient);
            Console.WriteLine("prix Hors taxes = " + prixVenteHT);
            Console.WriteLine("prix client TTC = " + coutTotal() );

        }
        protected  override void calculPrix()
        {
            this.prixRevient = coutRivets() + coutSoudure() + (2.87 * Acier_Kg);
            this.prixVenteHT = prixRevient*1.5;
        }
       protected  override double coutRivets()
        {
            return lesRivets.NbrRivet * lesRivets.PrixUnit;
        }

       protected  override double coutSoudure()
        {
            return LesSoudure.NbrSoudure  *LesSoudure.PrixUnit;
        }
       
    }
}
