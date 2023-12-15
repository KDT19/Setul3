using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex29
{
    internal class Program
    {
        // 29. MergeSort. Sortati un vector folosind metoda MergeSort.

        static void Main()
        {
            // Citim vectorul de la utilizator
            Console.Write("Introduceti elementele vectorului separate prin spatiu: ");
            int[] vector = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // Apelam metoda MergeSort pentru a sorta vectorul
            MergeSort(vector, 0, vector.Length - 1);

            Console.WriteLine("Vectorul sortat folosind MergeSort: " + string.Join(" ", vector));
        }

        // Metoda MergeSort
        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        // Metoda pentru a uni doua parti sortate ale vectorului
        static void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, middle + 1, rightArray, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
