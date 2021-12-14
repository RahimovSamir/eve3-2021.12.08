using System;

namespace eve3_2021_task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("3 reqemli eded daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            int c;
            int d;
            int e;
            if(a>=100 && a<=999)
            {
                b = a / 100;
                c = a % 10;
                d = (a / 10) - (b * 10);
                e = b + c + d;
                if(b*b==e)
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
