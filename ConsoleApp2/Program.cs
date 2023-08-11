using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, result;
            Console.WriteLine("Введи первое число");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи второе число");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи третье число");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    result = num1;
                }
                else {
                    result = num3;
                } 
            }
            else {
                if (num2 < num3)
                {
                    result = num3;
                }
                else
                {
                    result = num2;
                }
            }
            Console.WriteLine("\nСамое большое число = " + result);
            Console.ReadKey();
        }
    }
}
