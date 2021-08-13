using System;

namespace DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            //// DZ -4
            double proc;
            Console.WriteLine("Введите процент по вкладу(>0 <25) :");
            proc = Convert.ToDouble(Console.ReadLine());
            if (proc < 0 || proc > 25)
            {
                Console.WriteLine("Нереальный процент :)");
                Console.ReadKey();
                Environment.Exit(0);
            }
            double deposit = 1000;
            int count = 0;
            while (deposit < 1100)
            {
                deposit += deposit * proc / 100;
                count++;
            }
            Console.WriteLine("До превышения лимита вклада на сумму 1100р. понадобится: {0} месяца \nсумма вклада составит: {1} руб.", count, deposit);
            Console.ReadKey();

        }
    }
    }
