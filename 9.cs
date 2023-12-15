using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 

            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());

            
            int[] vector = new int[n];

            Console.WriteLine($"Introduceti {n} elemente:");

            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Introduceti numarul de pozitii pentru rotirea spre stanga (k): ");
            int k = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Vectorul initial:");
            AfisareVector(vector);

            RotireSpreStanga(vector, k);

            
            Console.WriteLine($"Vectorul rotit spre stanga cu {k} pozitii:");
            AfisareVector(vector);
        }

        static void RotireSpreStanga(int[] vector, int k)
        {
            int n = vector.Length;
            k = k % n; // Asiguram ca k este mai mic decat lungimea vectorului

            // Cream un vector temporar pentru a stoca primele k elemente
            int[] temp = new int[k];
            Array.Copy(vector, temp, k);

            // Deplasam celelalte elemente la începutul vectorului
            Array.Copy(vector, k, vector, 0, n - k);

            // Copiem elementele temporare la sfarsitul vectorului
            Array.Copy(temp, 0, vector, n - k, k);
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
