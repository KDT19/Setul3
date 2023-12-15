﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex23
{
    internal class Program
    {
        // 23. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector (elemente separate prin spatiu, ordine crescatoare): ");
            int[] v1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Citeste al doilea vector de la utilizator
            Console.Write("Introduceti al doilea vector (elemente separate prin spatiu, ordine crescatoare): ");
            int[] v2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Intersectia
            List<int> intersectie = Intersectie(v1, v2);

            // Reuniunea
            List<int> reuniune = Reuniune(v1, v2);

            // Diferenta v1 - v2
            List<int> diferentaV1V2 = Diferenta(v1, v2);

            // Diferenta v2 - v1
            List<int> diferentaV2V1 = Diferenta(v2, v1);

            // Afisarea rezultatelor
            Console.WriteLine("Intersectia: " + string.Join(" ", intersectie));
            Console.WriteLine("Reuniunea: " + string.Join(" ", reuniune));
            Console.WriteLine("Diferenta v1 - v2: " + string.Join(" ", diferentaV1V2));
            Console.WriteLine("Diferenta v2 - v1: " + string.Join(" ", diferentaV2V1));
        }

        static List<int> Intersectie(int[] v1, int[] v2)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    result.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return result;
        }

        static List<int> Reuniune(int[] v1, int[] v2)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    result.Add(v1[i]);
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    result.Add(v1[i]);
                    i++;
                }
                else
                {
                    result.Add(v2[j]);
                    j++;
                }
            }

            while (i < v1.Length)
            {
                result.Add(v1[i]);
                i++;
            }

            while (j < v2.Length)
            {
                result.Add(v2[j]);
                j++;
            }

            return result;
        }

        static List<int> Diferenta(int[] v1, int[] v2)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] == v2[j])
                {
                    i++;
                    j++;
                }
                else if (v1[i] < v2[j])
                {
                    result.Add(v1[i]);
                    i++;
                }
                else
                {
                    j++;
                }
            }

            while (i < v1.Length)
            {
                result.Add(v1[i]);
                i++;
            }

            return result;
        }
    
    }
}
