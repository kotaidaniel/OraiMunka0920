using System;
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
            int index = 0;
            lista = new List<int>(); 
            while (index < 10) {
                Console.Write("Kérem adjon megy egy számot: ");
                int szam = Convert.ToInt32(Console.ReadLine());
                lista.Add(szam);
                index++;
            }
        }

        static void szamKiiras() {
            for (int i = 0; i < lista.Count-1; i++)
            {
                Console.Write(lista[i] + ", ");
            }
            Console.WriteLine(lista[lista.Count-1]);
        }

        static void Main(string[] args)
        {
            szamBekeres();
            szamKiiras();



            Console.ReadKey();
        }
    }
}
