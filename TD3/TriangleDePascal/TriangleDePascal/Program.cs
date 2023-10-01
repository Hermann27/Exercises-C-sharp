using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleDePascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,]tab=new int [12,12];
            int i, j, taille;
            Console.WriteLine("Entrer votre taille pour l'affichage du triangle de pascal");
            taille =Int32.Parse( Console.ReadLine());
            for (i = 0; i < taille - 1; i++)
            {
                for (j = 0; j < taille; j++)
                {
                    tab[i,j] = 0;
                }
            }
            for (i = 0; i < taille - 1; i++)
            {
                tab[i,0] = 1;
                tab[0,0] = 1; 
            }
           
            for (i = 1; i < taille-1;i++ )
            {
                for (j = 1; j <= i + 1; j++)
                {
                    tab[i,j] = tab[(i - 1),j] + tab[(i - 1),(j - 1)];
                }
            }
            for (i = 0; i < taille - 1; i++)
            {
                for (j = 0; j <= i + 1; j++)
                {
                    Console.WriteLine(tab[i,j]);
                   
                }
                Console.ReadLine();
            }
            

        }
    }
}
