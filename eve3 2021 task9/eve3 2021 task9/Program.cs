using System;

namespace eve3_2021_task9
{
    class Program
    {
        static void Main(string[] args)
        {   

            step1:
            Console.WriteLine("0 ile 12 arasinda eded daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a>0 && a<=12)
            {
                switch (a) 
                {
                    case 1:
                 Console.WriteLine("yanvar");
                    break;

                    case 2:
                 Console.WriteLine("fevral");
                    break;

                    case 3:
                 Console.WriteLine("mart");
                    break;

                    case 4:
                 Console.WriteLine("aprel");
                    break;

                    case 5:
                 Console.WriteLine("may");
                     break;

                    case 6:
                 Console.WriteLine("iyun");
                    break;

                    case 7:
                 Console.WriteLine("iyul");
                    break;

                    case 8:
                 Console.WriteLine("avqust");
                     break;

                    case 9:
                 Console.WriteLine("sentyabr");
                     break;

                    case 10:
                 Console.WriteLine("oktyabr");
                     break;

                    case 11:
                 Console.WriteLine("noyabr");
                     break;

                    case 12:
                 Console.WriteLine("dekabr");
                     break;
                }             













            }


                
                

        }
    }
}
