using System;

namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            //romb

            //int h, h1, h2, h3, h4, h5, h6;
            //int s;
            //h = Int32.Parse(Console.ReadLine());

            //h /= 2;

            //h1 = h - (h - 1);
            //h2 = h;
            //h3 = h - (h - 1);
            //h4 = 2 * h;

            //s = h;
            //if (s == h) { h++; }

            //for (int c1 = 0; c1 < h; c1++, h2--, h1 += 2)
            //{
            //    for (int c2 = 0; c2 < h2; c2++)
            //    { Console.Write(" "); }
            //    for (int c3 = 0; c3 < h1; c3++)
            //    { Console.Write("*"); }
            //    Console.WriteLine();
            //}
            //for (int c4 = 0; c4 < h; c4++, h3++, h4 -= 2)
            //{
            //    for (int c5 = 0; c5 < h3; c5++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int c6 = 0; c6 < h4 - 1; c6++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //pryomo-ugolnik

            //var horizCount = 10;
            //var vertCount = 5;
            //var star = "*";
            //var whitespace = " ";

            //for (var i = 0; i < vertCount; ++i)
            //{
            //    var str = "";

            //    if (i == 0 || i == vertCount - 1)
            //    {
            //        for (var j = 0; j < horizCount; ++j)
            //        {
            //            str += star;
            //        }

            //    }
            //    else
            //    {
            //        str = star;
            //        for (var j = 0; j < horizCount - 2; ++j)
            //        {
            //            str += whitespace;
            //        }
            //        str += star;
            //    }
            //    Console.WriteLine(str);

            //}



            //pryamo-tr - ugolnik
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine("*");
            //    //Console.Write(" ");
            //}

            //rovnos- triugolnik

            int k = int.Parse(Console.ReadLine());
            int n = k - 1;
            int x = 2 * (k - 1) + 1;
            for (int p = 0; p <= n; p++)
            {
                for (int j = k - 1; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <= (x - 2 * (k - 1)); i++)
                {
                    if ((i % 2 == 1 && i == 1) || (i % 2 == 1 && i == (x - 2 * (k - 1))) || (i % 2 == 1 && p == n))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                k--;
            }


        }
    }
}
