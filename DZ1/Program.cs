using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());

            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            int sum = 0;

            for (int i = min; i < max; i++)
            {
                sum += i;
            }
            sum = (a + b) * (b - a - 1) / 2
;
            Console.WriteLine(sum);
        }
    }
}
