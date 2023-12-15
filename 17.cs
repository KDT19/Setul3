using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex17
{
    internal class Program
    {
        // 17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   
        static string ConvertToBase(int numar, int baza)
        {
            // Caracterele pentru cifrele peste 9
            char[] cifrePeste9 = "ABCDEF".ToCharArray();

            // Verifica daca baza este in intervalul specificat
            if (baza < 2 || baza > 16)
            {
                Console.WriteLine("Baza trebuie sa fie intre 2 si 16.");
                return "";
            }

            // Verifica daca numarul este pozitiv
            if (numar < 0)
            {
                Console.WriteLine("Numarul trebuie sa fie pozitiv.");
                return "";
            }

            // Verifica cazul in care numarul este 0
            if (numar == 0)
            {
                return "0";
            }

            // Construieste reprezentarea in baza specificata
            string rezultat = "";
            while (numar > 0)
            {
                int rest = numar % baza;
                if (rest > 9)
                {
                    rezultat = cifrePeste9[rest - 10] + rezultat;
                }
                else
                {
                    rezultat = rest + rezultat;
                }
                numar /= baza;
            }

            return rezultat;
        }

        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul in baza 10: ");
            int numar = int.Parse(Console.ReadLine());

            Console.Write("Introduceti baza (1 < b < 17): ");
            int baza = int.Parse(Console.ReadLine());

            // Convertirea si afisarea rezultatului
            string rezultat = ConvertToBase(numar, baza);
            Console.WriteLine($"Rezultatul conversiei: {rezultat}");

        }
    }
}
