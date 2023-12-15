using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex20
{
    internal class Program
    {
        // 20. Se dau doua siraguri de margele formate din margele albe si negre,
        // notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea)
        // a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare.
        // Siragurile de margele se pot roti atunci cand le suprapunem. 
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul sir de margele: ");
            string s1 = Console.ReadLine().ToUpper(); // Converteste toate caracterele la majuscule
            Console.Write("Introduceti al doilea sir de margele: ");
            string s2 = Console.ReadLine().ToUpper(); // Converteste toate caracterele la majuscule

            // Calculeaza si afiseaza numarul de suprapuneri
            int numarSuprapuneri = NumarSuprapuneri(s1, s2);
            Console.WriteLine($"Numarul de suprapuneri posibile este: {numarSuprapuneri}");


        }

        static int NumarSuprapuneri(string s1, string s2)
        {
            int numarTotalSuprapuneri = 0;

            // Roteste sirul s1 si verifica suprapunerile
            for (int rotatie = 0; rotatie < s1.Length; rotatie++)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    // Realizeaza suprapunerea la fiecare pas
                    string suprapunere = s1.Substring(i) + s1.Substring(0, i);

                    // Verifica daca suprapunerea este valida
                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (suprapunere[j] == s2[j])
                        {
                            // Margelele au aceeasi culoare
                            numarTotalSuprapuneri++;
                        }
                        else
                        {
                            // Margelele au culori diferite, deci nu se potrivesc
                            break;
                        }
                    }
                }
            }

            return numarTotalSuprapuneri;
        }
    }
}
