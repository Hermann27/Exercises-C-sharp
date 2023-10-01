using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ////string phrase;
            //string s;
            // int i=0,j;
            //Console.WriteLine("Entrer une phrase:");
            //s=Console.ReadLine();
            ////t1[i] = Console.ReadLine();
            //string [] motblanc = s.Split(' ');
            //foreach (string mot in motblanc)
            //{
            //    Console.WriteLine(mot);
            //}
            //Console.WriteLine("effacons les blancs au debut et fin de chaine ");
            //string s1 = s.Trim();
            //Console.WriteLine("avant: ["+s+"], après: ["+s1+"]");
            //Console.WriteLine("avant: [" + s.Length + "], après: [" + s1.Length + "]");
            ////Console.ReadLine();
            //string []tab=new string [s.Length];
            ////tab = s1[];
            //j=s1.Length;
            //for (i = 0; i < j; i++)
            //{
            //    tab[i]=s1;
            //    for (j =s1.Length; j < i;j-- )
            //    {
            //        if(tab[i]==tab[j])
            //        {
            //            Console.WriteLine("bon");
            //            Console.ReadLine();
            //        }
            //    }
                
            //}
            string []tab =new string[200];
            int i = 0,j;
            Console.WriteLine("Entrer une phrase:");
            tab[i] = Console.ReadLine();
            Console.WriteLine("l'ordre inverse est:");
            for (i = 0; i <tab.Length-1; i++)
            {
                for (j = tab.Length - 1; j>=0; j--)
                {
                    //Console.WriteLine("bbbbbb:" + tab[i]);
                    //Console.Read();
                    if(tab[i]==tab[j])
                    {
                        Console.WriteLine("vrai");
                        Console.Read();
                    }
                }
            }
         }


        }
    }

