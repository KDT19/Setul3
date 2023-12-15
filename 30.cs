using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex30
{
    internal class Program
    {
        // 30. Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i].
        // Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
        static void Main()
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] E = new int[n];
            int[] W = new int[n];

            Console.WriteLine("Introduceti elementele vectorului E:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"E[{i}] = ");
                E[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceti ponderile vectorului W:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"W[{i}] = ");
                W[i] = int.Parse(Console.ReadLine());
            }

            // Sortarea bicriteriala
            BicriteriaSort(E, W);

            // Afisarea rezultatului
            Console.WriteLine("Vectorii sortati:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"E[{i}] = {E[i]}, W[{i}] = {W[i]}");
            }
        }

        static void BicriteriaSort(int[] E, int[] W)
        {
            int n = E.Length;

            // Sortarea folosind un algoritm de sortare (Bubble Sort)
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Sortare dupa E[i] in ordine crescatoare
                    // Pentru valori egale, sortare dupa W[i] in ordine descrescatoare
                    if (E[j] > E[j + 1] || (E[j] == E[j + 1] && W[j] < W[j + 1]))
                    {
                        // Schimbare de pozitii
                        int tempE = E[j];
                        int tempW = W[j];

                        E[j] = E[j + 1];
                        W[j] = W[j + 1];

                        E[j + 1] = tempE;
                        W[j + 1] = tempW;
                    }
                }
            }
        }
    }
}
