using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex28
{
    internal class Program
    {
        // 28. Quicksort. Sortati un vector folosind metoda QuickSort. 
        static void Main()
        {
     
            Console.Write("Introduceti elementele vectorului separate prin spatiu: ");
            int[] vector = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // Apelam metoda Quicksort pentru a sorta vectorul
            QuickSort(vector, 0, vector.Length - 1);

           
            Console.WriteLine("Vectorul sortat folosind Quicksort: " + string.Join(" ", vector));
        }

        // Metoda Quicksort
        static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);

                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }

        // Metoda de partitionare
        static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);

            return i + 1;
        }

        // Metoda pentru interschimbarea a doua elemente intr-un vector
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
