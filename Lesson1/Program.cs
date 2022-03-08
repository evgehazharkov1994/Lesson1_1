using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"Hello, {name}[{DateTime.Now}]!");
            Console.ReadKey();
        }
    }
}