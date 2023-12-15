using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex11
{
    internal class Program
    {
        // 11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar natural n:");
            int n = int.Parse(Console.ReadLine());

            AfisareNumerePrime(n);
        }

        static void AfisareNumerePrime(int n)
        {
            // Initializam un vector de booleani pentru a tine evidenta numerelor prime
            bool[] estePrim = new bool[n + 1];

            // Initializam toate elementele vectorului cu true
            for (int i = 0; i <= n; i++)
            {
                estePrim[i] = true;
            }

            // Ciurul lui Eratostene
            for (int p = 2; p * p <= n; p++)
            {
                // Daca p este prim
                if (estePrim[p] == true)
                {
                    // Actualizam toate multiplele lui p ca fiind compuse
                    for (int i = p * p; i <= n; i += p)
                    {
                        estePrim[i] = false;
                    }
                }
            }

            // Afisam numerele prime
            Console.WriteLine($"Numerele prime mai mici sau egale cu {n} sunt:");
            for (int i = 2; i <= n; i++)
            {
                if (estePrim[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
