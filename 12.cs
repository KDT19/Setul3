using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 

            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine($"Introduceti {n} elemente:");


            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            
            SelectionSortAlgorithm(arr);

            
            Console.WriteLine("Array-ul sortat:");
            PrintArray(arr);
        }

        static void SelectionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

           
            for (int i = 0; i < n - 1; i++)
            {
                
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
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
