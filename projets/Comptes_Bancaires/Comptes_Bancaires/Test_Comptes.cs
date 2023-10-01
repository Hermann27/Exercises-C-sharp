using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comptes_Bancaires
{
    class Test_Comptes
    {
        static void Main(string[] args)
        {
            GestionComptes cptSuisse = new GestionComptes("Johnny");
            cptSuisse.ouvrirCompte(10000, typeCompte.courant, "123456");
            cptSuisse.ouvrirCompte(200000, typeCompte.courant, "123457");
            cptSuisse.ouvrirCompte(10000, typeCompte.courant, "333456");
            cptSuisse.decouvertCompte(5000, "123456");
            cptSuisse.decouvertCompte(48000, "123457");
            cptSuisse.deposer(500, "123456");
            cptSuisse.deposer(1000, "333456");
            cptSuisse.retirer(210000, "123457");
            Console.WriteLine("----tous les comptes----");
            cptSuisse.consulter();
            Console.WriteLine("----le compte 123456----");
            cptSuisse.consulter("123456");
            Console.ReadLine();
        }
    }
}
