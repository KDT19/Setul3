using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex19
{
    internal class Program
    {
        // 19.Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s.
        // De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori.
        // (Problema este dificila doar daca o rezolvati cu un algoritm liniar).

        static int NumarAparitii(int[] s, int[] p)
        {
            int numarAparitii = 0;

            if (s.Length < p.Length)
            {
                return 0; // Nu se poate gasi vectorul p in vectorul s daca lungimea lui s este mai mica decat cea a lui p.
            }

            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                bool sePotriveste = true;

                // Verificam daca vectorul p se potriveste incepand cu pozitia i din vectorul s
                for (int j = 0; j < p.Length; j++)
                {
                    if (s[i + j] != p[j])
                    {
                        sePotriveste = false;
                        break;
                    }
                }

                if (sePotriveste)
                {
                    numarAparitii++;
                }
            }

            return numarAparitii;
        }
        static void Main(string[] args)
        {
            Console.Write("Introduceti vectorul s (separate prin spatii): ");
            int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Introduceti vectorul p (separate prin spatii): ");
            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // Calculul si afisarea rezultatului
            int rezultat = NumarAparitii(s, p);
            Console.WriteLine($"Vectorul p apare in vectorul s de {rezultat} ori.");
        }
    }
}
