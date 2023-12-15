using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace s3ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Se da un vector cu n elemente si o pozitie din vector k.Se cere sa se stearga din vector elementul de pe pozitia k.
            // Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.

            // Primul element se afla pe pozitia 0

            Console.Write("Introduceti numarul de elemente ale vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Introduceti pozitia pentru stergere: ");
            int k = Convert.ToInt32(Console.ReadLine());

            // Verifica daca pozitia k este valida
            if (k < 0 || k >= n)
            {
                Console.WriteLine("Pozitia specificata pentru stergere nu este valida.");
                return;
            }

            // Realizeaza stergerea elementului de pe pozitia k
            for (int i = k; i < n - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            // Redimensioneaza vectorul pentru a elimina ultimul element
            Array.Resize(ref vector, n - 1);

            // Afiseaza vectorul rezultat
            Console.WriteLine("Vectorul rezultat dupa stergere:");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
