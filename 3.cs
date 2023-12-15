using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
            // Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 

            Console.Write("Introduceti numarul de elemente ale vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            int pozitieMin = 0, pozitieMax = 0;

            
            if (vector[0] < vector[1])
            {
                pozitieMin = 0;
                pozitieMax = 1;
            }
            else
            {
                pozitieMin = 1;
                pozitieMax = 0;
            }

            
            for (int i = 2; i < n - 1; i += 2)
            {
                if (vector[i] < vector[i + 1])
                {
                    if (vector[i] < vector[pozitieMin])
                    {
                        pozitieMin = i;
                    }

                    if (vector[i + 1] > vector[pozitieMax])
                    {
                        pozitieMax = i + 1;
                    }
                }
                else
                {
                    if (vector[i + 1] < vector[pozitieMin])
                    {
                        pozitieMin = i + 1;
                    }

                    if (vector[i] > vector[pozitieMax])
                    {
                        pozitieMax = i;
                    }
                }
            }

            // Daca numarul de elemente este impar, compara ultimul element cu minimul si maximul
            if (n % 2 != 0)
            {
                if (vector[n - 1] < vector[pozitieMin])
                {
                    pozitieMin = n - 1;
                }
                else if (vector[n - 1] > vector[pozitieMax])
                {
                    pozitieMax = n - 1;
                }
            }

            Console.WriteLine($"Pozitia celui mai mic element: {pozitieMin + 1}");
            Console.WriteLine($"Pozitia celui mai mare element: {pozitieMax + 1}");
        }
    }
}
