using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RechercheDe_Points_cols
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, m=0,i,s,sc;
            int cptL, cptC;
            string l,c;
            int [,] A = new int [n,m];
            Console.WriteLine("Entrer le nombre de lignes:");
            n = Int32.Parse( Console.ReadLine());
            Console.WriteLine("Entrer le nombre de colonnes:");
            m = Int32.Parse(Console.ReadLine());
            Console.WriteLine(n + " " + m);
            for (i = 0; i < n - 1; i++)
            {
                Console.WriteLine("Entrer les éléments de la ligne:");
                l = Console.ReadLine();
                string[] t = l.Split(' ');
                foreach (string en in t)
                    Console.WriteLine(en);
                s =Int32.Parse( t[i]);
                Console.WriteLine(s);
                //Console.Read();
            }
            for (i = 0; i < m - 1; i++)
            {
                Console.WriteLine("Entrer les éléments de la colonne:");
                c = Console.ReadLine();
                string[] tc = c.Split(' ');
                foreach (string en in tc)
                    Console.WriteLine(en);
                sc = Int32.Parse(tc[i]);
                Console.WriteLine(sc);
                //Console.Read();
            }
            Console.Read();


        }
    }
}
