using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miniProjet_voiture
{
    class TestVoitures
    {
        static void Main(string[] args)
        {
            Voiture voiture1 = new Voiture("axxon", "v12 en biais", "radial", 12000, 7500, 1100);
            Voiture voiture2 = new Voiture("Tomaschi", "v16 en travers", "lisse", 9000, 8500, 950);
            Voiture voiture3 = new Voiture("Giat", "v8 en long", "cranté", 2000, 6250, 810);
            voiture1.afficherInfoVehicule();
            System.Console.WriteLine("\n ");
            voiture2.afficherInfoVehicule();
            System.Console.WriteLine("\n ");
            voiture3.afficherInfoVehicule();
            System.Console.ReadLine();
        }
    }
}
