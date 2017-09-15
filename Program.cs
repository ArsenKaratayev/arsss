using System;

namespace git2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void isPrime(int n)
        {
            int k = 0;
            if (n < 3)
            {
                System.Console.WriteLine("prime");
            }
            for (int i = 0; i < Math.Pow(n, 0.5); i++)
            {
                if (n % i == 0)
                {
                    k++;
                    if (k > 1)
                    {
                        System.Console.WriteLine("composite");
                    }
                }
            }
            if (k == 1)
            {
                System.Console.WriteLine("prime");
            }else
            {
                System.Console.WriteLine("composite");
            }
        }
    }
}
