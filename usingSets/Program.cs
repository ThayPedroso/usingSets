using System;
using System.Collections.Generic;

namespace usingSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            HashSet<int> ALL = new HashSet<int>();

            Console.WriteLine("Total students in course a: ");
            int qtdA = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdA; i++)
            {
                int stdA = int.Parse(Console.ReadLine());
                A.Add(stdA);
            }

            Console.WriteLine("Total students in course b: ");
            int qtdB = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdB; i++)
            {
                int stdB = int.Parse(Console.ReadLine());
                B.Add(stdB);
            }

            Console.WriteLine("Total students in course c: ");
            int qtdC = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdC; i++)
            {
                int stdC = int.Parse(Console.ReadLine());
                C.Add(stdC);
            }

            ALL.UnionWith(A);
            ALL.UnionWith(B);
            ALL.UnionWith(C);

            Console.WriteLine("Total students: " + ALL.Count);
        }
    }
}
