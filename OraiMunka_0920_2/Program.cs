﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraiMunka_0920_2
{
    class Program
    {
        static List<int> lista;
        static void szamBekeres() {
            Console.WriteLine("Hány számot szeretne megadni?");
            int listadarab = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            lista = new List<int>(listadarab); 
            while (index < listadarab) {
                Console.Write("Kérem adjon megy egy számot: ");
                int szam = Convert.ToInt32(Console.ReadLine());
                lista.Add(szam);
                index++;
            }
        }

        static void szamKiiras() {
            int index = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > index)
                {
                    index = lista[i];
                }
            }
            Console.Write("A lista legnagyobb száma : " + index);
        }

        static void Main(string[] args)
        {
            szamBekeres();
            szamKiiras();



            Console.ReadKey();
        }
    }
}
