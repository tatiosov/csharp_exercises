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
            int num1, result;
            string str1;
            Console.WriteLine("Введи число");
            num1 = Convert.ToInt32(Console.ReadLine());
            result = num1 % 2;
            if (result == 0)
            {
                str1 = num1.ToString() + " четное";
            }
            else {
                str1 = num1.ToString() + " нечетное";
            }
            Console.WriteLine("\n" + str1);
            Console.ReadKey();
        }
    }
}
