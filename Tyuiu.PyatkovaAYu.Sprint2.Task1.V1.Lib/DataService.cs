using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PyatkovaAYu.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a & b) == (b & a);
            res[1] = (a & b) != (b & a);
            res[2] = (c ^ a) < (b ^ d);
            res[3] = (c ^ a) > (b ^ d);
            res[4] = (a & c) <= (b & d);
            res[5] = (c ^ a) >= (b ^ d);

            return res;
        }
    }
}
