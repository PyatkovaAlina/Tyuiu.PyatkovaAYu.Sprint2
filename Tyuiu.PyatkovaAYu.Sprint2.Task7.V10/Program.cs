﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint2.Task7.V10.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint2.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2| Выполнил: Пяткова А. Ю. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y                      *");
            Console.WriteLine("* в заштрихованной области                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Введите значение переменной Х: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
