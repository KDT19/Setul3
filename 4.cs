using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex4
{
    internal class Program
    {
        // 4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 

        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente ale vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

           
            int celMaiMic = vector[0];
            int celMaiMare = vector[0];

            
            int contorCelMaiMic = 1;
            int contorCelMaiMare = 1;

            
            for (int i = 1; i < n; i++)
            {
                if (vector[i] < celMaiMic)
                {
                    celMaiMic = vector[i];
                    contorCelMaiMic = 1; 
                }
                else if (vector[i] == celMaiMic)
                {
                    contorCelMaiMic++;
                }

                if (vector[i] > celMaiMare)
                {
                    celMaiMare = vector[i];
                    contorCelMaiMare = 1; // 
                }
                else if (vector[i] == celMaiMare)
                {
                    contorCelMaiMare++;
                }
            }

            Console.WriteLine($"Cea mai mica valoare: {celMaiMic}, apare de {contorCelMaiMic} ori.");
            Console.WriteLine($"Cea mai mare valoare: {celMaiMare}, apare de {contorCelMaiMare} ori.");
        }
    }
}
