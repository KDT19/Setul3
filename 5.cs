using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
            // Se cere sa se insereze valoarea e in vector pe pozitia k.
            // Primul element al vectorului se considera pe pozitia zero. 

            Console.Write("Introduceti numarul de elemente ale vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Introduceti valoarea pentru inserare: ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti pozitia pentru inserare: ");
            int k = Convert.ToInt32(Console.ReadLine());

            // Verifica daca pozitia k este valida
            if (k < 0 || k > n)
            {
                Console.WriteLine("Pozitia specificata pentru inserare nu este valida.");
                return;
            }

            // Realizeaza inserarea valorii la pozitia k
            int[] vectorNou = new int[n + 1];

            for (int i = 0; i < k; i++)
            {
                vectorNou[i] = vector[i];
            }

            vectorNou[k] = e;

            for (int i = k + 1 ; i < n + 1; i++)
            {
                vectorNou[i] = vector[i - 1];
            }

            Console.WriteLine("Vectorul rezultat dupa inserare:");
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(vectorNou[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
