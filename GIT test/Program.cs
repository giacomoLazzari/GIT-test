using System;

namespace GIT_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] v = new int[10]  { 4, 5, 7,2,9,4,7,44,12,23};
            ordina(v);
            int max = Massimo(v);
            Console.WriteLine("Il valore massimo è" + max);
            for(int i = 0; i< v.Length;i++)
            {
                Console.WriteLine(v[i] + ",");
            }

        }

        static void ordina(int[] v)
        {
            Array.Sort(v);
        }

        static int Massimo(int[] v)
        {
            return v[v.Length - 1];
        }
    }
}
