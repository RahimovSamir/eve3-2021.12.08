using System;

namespace eve3_2021_task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 ve 8 arasinda bir eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 1 && a <= 7)
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("1-ci gün");
                        break;
                    case 2:
                        Console.WriteLine("2-ci gün");
                        break;
                    case 3:
                        Console.WriteLine("3-cü gün");
                        break;
                    case 4:
                        Console.WriteLine("4-cü gün");
                        break;
                    case 5:
                        Console.WriteLine("5-ci gün");
                        break;
                    case 6:
                        Console.WriteLine("6-cı gün");
                        break;
                    case 7:
                        Console.WriteLine("7-ci gün");
                        break;
                }
            }
            
            {
                
            }
        }
    }
}
