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
            int num1;
            string str1 = "";
            Console.WriteLine("Введи число");
            num1 = Convert.ToInt32(Console.ReadLine());
            str1 = num1.ToString();
            if (str1.Length > 2)
            {
                Console.WriteLine("\n Цифра " + str1[2]);
            }
            else {
                Console.WriteLine("\n Третьей цифры нет, попробуй другое число");
            }
            Console.ReadKey();
        }
    }
}
