using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя минимальную и максимальную температуру за сутки
            Console.WriteLine("Пожалуйста напишите минимальную температуру за сутки");
            string mintemp = Console.ReadLine();

            Console.WriteLine("Пожалуйста напишите максимальную температуру за сутки");
            string maxtemp = Console.ReadLine();
            
            int temp1 = Convert.ToInt32(mintemp);
            int temp2 = Convert.ToInt32(maxtemp);

            int result = (temp1 + temp2) / 2;

            Console.WriteLine("Средняя суточная температура");
            Console.WriteLine(result);

        }
    }
}