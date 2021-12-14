using System;

namespace eve_2021_task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 reqemli eded daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            int c;
            int d;
            if (a >= 100 && a <= 999)
            {
                b = a / 100;
                c = a % 10;
                d = (a / 10) - (b * 10);
                if (b + c == d)
                {
                    Console.WriteLine("beli");
                }
                else
                {
                    Console.WriteLine("xeyir");
                }
            }
        }
    }
}
