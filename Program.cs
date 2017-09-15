using System;

namespace git2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        private static string IsPrime(int a)
        {
            string o = "";
            int k = 0;
            if (a != 2 && a % 2 == 0)
            {
                o = "composite";
                return o;
            }
            for (int i = 1; i < Math.Pow(a, 0.5); i++)
            {
                if (a % i == 0)
                {
                    k++;
                }
                if (k > 1)
                {
                    o = "composite";
                    return o;
                }
            }
            if (k == 1)
            {
                o = "prime";
            }
            else
            {
                o = "composite";
            }
            return o;
        }
    }
}
