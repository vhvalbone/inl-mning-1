using System;
using System.Collections.Generic;

namespace Uppgift_9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Här får du skriva in valfritt antal namn, avsluta med tom rad");

            List<string> namnLista = new List<string>();

            string nyttNamn = " ";
            while (nyttNamn != "")
            {
                Console.WriteLine("Skriv in ett namn");
                nyttNamn = Console.ReadLine();
                if (nyttNamn != "")
                {
                    namnLista.Add(nyttNamn);
                }
            }

            namnLista.Sort();

            Console.WriteLine("Här är namnen i omvänd bokstavsordning");
            for (int i = namnLista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(namnLista[i]);
            }

        }
    }
}
