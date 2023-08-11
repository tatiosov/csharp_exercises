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
            Console.WriteLine("Введи цифру деня недели");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 5)
            {
                Console.WriteLine("\n Выходной ");
            }
            else {
                Console.WriteLine("\n Не выходной");
            }
            Console.ReadKey();
        }
    }
}
