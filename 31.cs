using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3ex31
{
    internal class Program
    {
        // 31. (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai
        // mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).
        // Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 
        static void Main()
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"vector[{i}] = ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            int majorityElement = FindMajorityElement(vector);

            Console.WriteLine("Elementul majoritate:");
            if (majorityElement != int.MinValue)
            {
                Console.WriteLine(majorityElement);
            }
            else
            {
                Console.WriteLine("<nu exista>");
            }
        }

        static int FindMajorityElement(int[] vector)
        {
            int candidate = int.MinValue;
            int count = 0;

            foreach (int num in vector)
            {
                if (count == 0)
                {
                    candidate = num;
                    count = 1;
                }
                else if (candidate == num)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            // Verificare daca elementul gasit este cu adevarat majoritar
            count = 0;
            foreach (int num in vector)
            {
                if (num == candidate)
                {
                    count++;
                }
            }

            return count > vector.Length / 2 ? candidate : int.MinValue;
        }
    }
}
