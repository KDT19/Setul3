using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13. Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 

            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine($"Introduceti {n} elemente:");


            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            InsertionSortAlgorithm(arr);

            
            Console.WriteLine("Array-ul sortat:");
            PrintArray(arr);
        }

        static void InsertionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Muta elementele mai mari decat key cu o pozitie inainte
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                // Plaseaza key in pozitia sa corecta
                arr[j + 1] = key;
            }
        }

        
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
