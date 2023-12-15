using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex24
{
    internal class Program
    {
        // 24. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate
        // ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector (valori binare, separate prin spatiu): ");
            int[] v1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.Write("Introduceti al doilea vector (valori binare, separate prin spatiu): ");
            int[] v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Intersectia
            int[] intersectie = Intersectie(v1, v2);

            // Reuniunea
            int[] reuniune = Reuniune(v1, v2);

            // Diferenta v1 - v2
            int[] diferentaV1V2 = Diferenta(v1, v2);

            // Diferenta v2 - v1
            int[] diferentaV2V1 = Diferenta(v2, v1);

            // Afisarea rezultatelor
            Console.WriteLine("Intersectia: " + string.Join(" ", intersectie));
            Console.WriteLine("Reuniunea: " + string.Join(" ", reuniune));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(" ", diferentaV1V2));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(" ", diferentaV2V1));
        }

        static int[] Intersectie(int[] v1, int[] v2)
        {
            int n = Math.Min(v1.Length, v2.Length);
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = v1[i] & v2[i];
            }

            return result;
        }

        static int[] Reuniune(int[] v1, int[] v2)
        {
            int n = Math.Max(v1.Length, v2.Length);
            int[] result = new int[n];

            for (int i = 0; i < v1.Length; i++)
            {
                result[i] = v1[i] | v2[i];
            }

            for (int i = v1.Length; i < v2.Length; i++)
            {
                result[i] = v2[i];
            }

            return result;
        }

        static int[] Diferenta(int[] v1, int[] v2)
        {
            int n = Math.Max(v1.Length, v2.Length);
            int[] result = new int[n];

            for (int i = 0; i < v1.Length; i++)
            {
                result[i] = v1[i] & ~v2[i];
            }

            for (int i = v1.Length; i < v2.Length; i++)
            {
                result[i] = 0; // Elemente in plus din v2
            }

            return result;
        }
    }
}
