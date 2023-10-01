using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miniProjet_voiture
{
   abstract class Vehicule
    {
        //les attributs
       protected int Acier_Kg=1;
       protected Moteur leMoteur;
       protected Roue lesRoues;
       protected Rivet lesRivets;
       protected Soudure lesSoudure;
       private string nomSerie;
       private int NumeroSerie;
       private const double prixAcier_Kg = 2.87;
       protected double prixRevient = 1;
       protected double prixVenteHT = 1;

       //propriétés
       public int Acier_kg
       {
           get { return Acier_Kg; }
           set { Acier_Kg = value; }
       }
       public Moteur LeMoteur
       {
           get { return leMoteur; }
           set { leMoteur = value; }
       }
       public Roue LesRoues
       {
           get { return lesRoues; }
           set { lesRoues = value; }
       }
       public Rivet LeRivet
       {
           get { return lesRivets; }
           set { lesRivets = value; }
       }
       public Soudure LesSoudure
       {
           get { return lesSoudure; }
           set { lesSoudure = value; }
       }
       public string NomSerie
       {
           get { return nomSerie; }
           set { nomSerie = value; }
       }
       
       public int NumeroSeries
       {
           get { return NumeroSerie; }
           set { NumeroSerie = value; }
       }
       public double PrixRevient
       {
           get { return prixRevient; }
           set { prixRevient = value; }
       }
       public double PrixVenteHT
       {
           get { return prixVenteHT; }
           set { prixVenteHT = value; }
       }
      
      
       //constructeur
       public Vehicule(string nom, string unMoteur)
       {
           nomSerie = nom;
           leMoteur = new Moteur(unMoteur);
           NumeroSerie = NumSerie.numero++;

       }
       
        //les méthodes abstraites
       protected abstract double coutRivets();
       protected abstract double coutSoudure();
       protected abstract void calculPrix();
       
        // méthode concrète
       public double coutTotal()
        {
             calculPrix();
            //return prixVenteHT + prixVenteHT * 0.33 = prixVenteHT * 1.33;
            return prixVenteHT * 1.33;
        }
       

    }
}
