using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Int1 = 0;
            int Int2 = 0;
            int Int3 = 0;
            int Int4 = 0;

            while ((Int1 == Int2) || (Int1 == Int3) || (Int1 == Int4) || (Int2 == Int3) || (Int2 == Int4) || (Int3 == Int4)) ;
            {
                Random rnd = new Random();
                int Int11 = rnd.Next(1, 10);
                int Int22 = rnd.Next(0, 10);
                int Int33 = rnd.Next(0, 10);
                int Int44 = rnd.Next(0, 10);
            }

            Console.WriteLine("input a 4 digit number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int length = sizeof(int);

            while (length != 4)
            {
                Console.WriteLine("enter another guess, it's not the correct length");
            }

            while (Num < 1000 || Num > 9999)
            {
                Console.WriteLine("enter another guess, it's not within the correct range");
            }

            string strNum = Num.ToString();



        }
    }
}
