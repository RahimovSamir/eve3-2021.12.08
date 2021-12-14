using System;

namespace eve3_20211208_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 eded qeyd edin");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % b==0)
            {
                int c;
                c = a / b;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("bolunmur");
            }
        }
    }
}
 