using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex18
{
    internal class Program
    {

        // 18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector.
        // Cel mai putin semnificativ coeficient este pe pozitia zero in vector.
        // Se cere valoarea polinomului intr-un punct x. 

        static double CalculValoarePolinom(double[] coeficienti, double x)
        {
            double rezultat = 0;

            for (int i = 0; i < coeficienti.Length; i++)
            {
                rezultat += coeficienti[i] * Math.Pow(x, i);
            }

            return rezultat;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti gradul polinomului (n): ");
            int n = int.Parse(Console.ReadLine());

            // Initializarea vectorului de coeficienti
            double[] coeficienti = new double[n + 1];

            Console.WriteLine("Introduceti coeficientii polinomului de la cel mai mic la cel mai mare grad:");

            for (int i = 0; i <= n; i++)
            {
                Console.Write($"Coeficient pentru x^{i}: ");
                coeficienti[i] = double.Parse(Console.ReadLine());
            }

            // Citirea punctului in care sa se evalueze polinomul
            Console.Write("Introduceti punctul x in care sa se evalueze polinomul: ");
            double punctX = double.Parse(Console.ReadLine());

            // Calculul si afisarea rezultatului
            double rezultat = CalculValoarePolinom(coeficienti, punctX);
            Console.WriteLine($"Valoarea polinomului in punctul {punctX} este: {rezultat}");
        }

    }
}
