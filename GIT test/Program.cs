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
            for(int i = 0; i< v.Length;i++)
            {
                Console.WriteLine(v[i] + ",");
            }

        }

        static void ordina(int[] v)
        {
            Array.Sort(v);
        }
    }
}
