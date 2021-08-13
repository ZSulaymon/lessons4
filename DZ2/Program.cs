using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1, B = 10;
            for (int i = A + 1; i < B; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
