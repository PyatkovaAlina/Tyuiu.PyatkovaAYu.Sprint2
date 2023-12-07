using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.PyatkovaAYu.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= x * x - 2) && (y >= 0 && y <= x) && (y <= 0 && y >= -x))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
