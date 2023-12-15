using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
            // Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());

           
            int[] vector = new int[n];

            Console.WriteLine($"Introduceti {n} elemente:");

            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("Vectorul initial:");
            AfisareVector(vector);

            
            InverseazaVector(vector);

            
            Console.WriteLine("Vectorul inversat:");
            AfisareVector(vector);
        }

        static void InverseazaVector(int[] vector)
        {
            int n = vector.Length;
            for (int i = 0; i < n / 2; i++)
            {
               
                int temp = vector[i];
                vector[i] = vector[n - i - 1];
                vector[n - i - 1] = temp;
            }
        }

        static void AfisareVector(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }


   
    }
}
