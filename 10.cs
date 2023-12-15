using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k.
            // Daca elementul nu se gaseste in vector rezultatul va fi -1. 

            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());

            
            int[] vector = new int[n];

            Console.WriteLine($"Introduceti {n} elemente (sortate in ordine crescatoare):");

           
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti elementul pentru care doriti sa gasiti pozitia (k): ");
            int k = int.Parse(Console.ReadLine());

            
            int pozitie = CautareBinara(vector, k);

            
            if (pozitie != -1)
            {
                Console.WriteLine($"Elementul {k} se afla la pozitia {pozitie + 1} in vector.");
            }
            else
            {
                Console.WriteLine($"Rezultatul este -1 ");
            }
        }

        static int CautareBinara(int[] vector, int k)
        {
            int stanga = 0;
            int dreapta = vector.Length - 1;

            while (stanga <= dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;

                // Verificam daca elementul este pe mijloc
                if (vector[mijloc] == k)
                {
                    return mijloc;
                }

                // Daca elementul este mai mic decat mijlocul, il cautam in partea stanga
                if (vector[mijloc] > k)
                {
                    dreapta = mijloc - 1;
                }
                // Altfel, il cautam in partea dreapta
                else
                {
                    stanga = mijloc + 1;
                }
            }

            // Elementul nu a fost gasit
            return -1;
        }


    }
}
