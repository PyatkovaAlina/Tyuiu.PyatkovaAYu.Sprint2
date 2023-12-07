﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PyatkovaAYu.Sprint2.Task2.V26.Lib
{
    public class DataService : ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (x >= 3 && x <= 5 && (y >= 3 && y <= 7 || y == 11))
                return true;
            if (x >= 6 && x <= 9 && y >= 5 && y <= 11) 
                return true;
            if (x >= 7 && x <= 9 && y == 12)
                return true;
            if (x >= 9 && x <= 10 && y == 13 && x >= 10 && x <= 12 && y >= 11 && y <= 12)
                return true;
            if (x >= 10 && x <= 13 && y >= 6 && y <= 8)
                return true;
            if (x == 10 && y == 5)
                return true;
            if (x >= 9 && x <= 12 && y == 3)
                return true;
            if (x >= 9 && x <= 10 && y == 4)
                return true;

            return false;

            return res;
        }
    }
}
