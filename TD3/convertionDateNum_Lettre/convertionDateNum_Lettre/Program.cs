using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace convertionDateNum_Lettre
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch;
            int s,j,m ;
            string chain = "";
            Console.WriteLine("Entrer une date sous la forme numerique(ex:3/2/5)");
            ch = Console.ReadLine();
            string []  pr = ch.Split('/');
            s = Int32.Parse(pr[0]);
            j = Int32.Parse(pr[1]);
            m = Int32.Parse(pr[2]);
            switch(s)
            {
                case 1: chain = "Lundi  "; break;
                case 2: chain = "Mardi  "; break;
                case 3: chain = "Mercredi  "; break;
                case 4: chain = "Jeudi  "; break;
                case 5: chain = "Vendredi  "; break;
                case 6: chain = "Samedi  "; break;
                case 7: chain = "Dimanche  "; break;
                default: chain = ""; break;

            }
            if (chain.Length == 0)
            {
                Console.WriteLine("ce jour n'existe pas");
            }
            else
            {
                //chain += j;
                switch (m)
                {
                    case 1:
                        if (j > 31)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Janvier";break;
                    case 2:
                        if (j > 29)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Février"; break;
                    case 3: 
                        if (j > 31)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Mars"; break;
                    case 4: 
                        if (j > 30)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Avril"; break;
                    case 5: 
                        if (j > 30)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Mai"; break;
                    case 6:
                        if (j > 31)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Juin"; break;
                    case 7: 
                        if (j > 30)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Juillet"; break;
                    case 8:
                        if (j > 31)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Aout"; break;
                    case 9:
                        if (j > 30)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Septembre"; break;
                    case 10:
                        if (j > 31)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Octobre"; break;
                    case 11:
                        if (j > 30)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Novembre"; break;
                    case 12:
                        if (j > 31)
                        {
                            Console.WriteLine("ce jour ne correspond pas à ce mois");
                            Console.ReadLine();
                        }
                        else chain += " Décembre"; break;
                    default: chain = ""; break;

                }
                if (chain.Length == 0)
                {
                    Console.WriteLine("ce mois n'existe pas");
                }
                else
                {
                    Console.WriteLine(chain);
                }
               
            }
            Console.ReadLine();
          
        }
    }
}
