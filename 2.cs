using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k.
            // Daca k nu apare in vector rezultatul va fi -1. 

            Console.Write("Introduceti numarul de elemente ale vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti valoarea k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] v = new int[n];
            int ok = 0, r = -1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                v[i] = Convert.ToInt32(Console.ReadLine());
                if (v[i] == k && ok == 0)
                {
                    ok = 1;
                    r = i + 1;
                }

            }
            Console.WriteLine($"Rezultatul este {r}");

        }
    }
}
