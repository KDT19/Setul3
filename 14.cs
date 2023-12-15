using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit.
            // (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient -
            // se va face o singura parcugere a vectorului). 

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
            AfiseazaVector(vector);

            SorteazaVector(vector);

            Console.WriteLine("\nVectorul sortat:");
            AfiseazaVector(vector);



        }

        static void SorteazaVector(int[] vector)
        {
            int n = vector.Length;
            int index = 0;

            // Parcurge vectorul si muta valorile nenule la inceput
            for (int i = 0; i < n; i++)
            {
                if (vector[i] != 0)
                {
                    // Schimba elementul nenul cu primul element din vector
                    int temp = vector[i];
                    vector[i] = vector[index];
                    vector[index] = temp;

                    index++;
                }
            }
        }

        static void AfiseazaVector(int[] vector)
        {
            foreach (var element in vector)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
