using System;

namespace GIT_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10] { 4, 5, 7, 2, 9, 4, 7, 44, 12, 23 };
            Ordina(v);
            Console.WriteLine("L' array ordinato è: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.WriteLine("Il minimo tra questi valori è: " + Minimo(v));

        }
        static void Ordina(int[] v)
        {
            Array.Sort(v);
        }

        static int Minimo(int[] v)
        {
            return v[0];
        }
    }
}
