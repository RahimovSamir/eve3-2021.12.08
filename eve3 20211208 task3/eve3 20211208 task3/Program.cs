using System;

namespace eve3_20211208_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iki reqemli eded yazin");
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            int c;
            int d;
            int e;

            if (a >= 10 && a <= 99)
            {
                b = a % 10;     
                d = (a / 10);
                c = b + d;

                if (c % 2 == 0)
                {
                    c = b * d;
                    Console.WriteLine(c);
                }
            }
            

        }
    }
}
