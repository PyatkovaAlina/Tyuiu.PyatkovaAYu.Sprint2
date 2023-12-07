using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint2.Task4.V8.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint2.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 6;
            double y = -4;
            double res = ds.Calculate(x, y);
            double wait = 15712.007;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = -0.667;
            Assert.AreEqual(wait, res);
        }
    }
}
