using System;

namespace GIT_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] v = new int[10]  { 4, 5, 7,2,9,4,7,44,12,23};
            int n;
            for(int i = 0;i< v.Length-1; i ++)
            {
                if(v[i]> v[i+1])
                {
                    n = v[i];
                    v[i] = v[i + 1];
                    v[i + 1] = n;
                }
                Console.WriteLine(v[i] + ",");
            }
            

        }
    }
}
