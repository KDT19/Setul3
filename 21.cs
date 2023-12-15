using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex21
{
    internal class Program
    {
        // 21. Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul vector: ");
            string vector1 = Console.ReadLine();

            Console.Write("Introduceti al doilea vector: ");
            string vector2 = Console.ReadLine();

            // Compararea lexicografic
            int rezultatComparare = string.Compare(vector1, vector2);

            // Afisarea rezultatului
            if (rezultatComparare < 0)
            {
                Console.WriteLine($"Vectorul '{vector1}' este inainte de '{vector2}' in ordinea lexicografica.");
            }
            else if (rezultatComparare > 0)
            {
                Console.WriteLine($"Vectorul '{vector2}' este inainte de '{vector1}' in ordinea lexicografica.");
            }
            else
            {
                Console.WriteLine("Vectorii sunt identici din punct de vedere lexicografic.");
            }
        }
    
    }
}
