using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint2.Task6.V2.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint2.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2| Выполнил: Пяткова А. Ю. | ИИПб-23-2";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                         *");
            Console.WriteLine("* Тема: Оператор switch                                                             *");
            Console.WriteLine("* Задание #6                                                                        *");
            Console.WriteLine("* Вариант #2                                                                        *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch, *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* По данному месяцу, определите в какую пору года попадает этот месяц.              *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int numMonth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Это сезон: " + ds.FindMonthSeason(numMonth);
            }

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
