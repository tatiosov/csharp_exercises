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
            int num1, num2;
            Console.WriteLine("Введи первое число");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи второе число");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " больше чем " + num2);
            }
            else {
                Console.WriteLine(num2 + " больше чем " + num1);
            }
            Console.ReadKey();
        }
    }
}
