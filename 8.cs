using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga.
            // Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 

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

            
            RotireStanga(vector);

           
            Console.WriteLine("Vectorul rotit spre stanga:");
            AfisareVector(vector);
        }

        static void RotireStanga(int[] vector)
        {
            int temp = vector[0];
            for (int i = 0; i < vector.Length - 1; i++)
            {
               vector[i] = vector[i + 1];
            }
            vector[vector.Length - 1] = temp;
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
