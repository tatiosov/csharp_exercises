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
            int num1, result, i;
            string str1 = "";
            Console.WriteLine("Введи число");
            num1 = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < num1 + 1; i++) {
                result = i % 2;
                if (result == 0)
                {
                    str1 += i.ToString() + ", ";
                }
            }
            Console.WriteLine("\nЧетные числа от 1 до " + num1 + " это числа " + str1);
            Console.ReadKey();
        }
    }
}
