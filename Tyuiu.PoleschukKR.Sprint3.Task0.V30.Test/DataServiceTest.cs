using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint3.Task0.V30.Lib;

namespace Tyuiu.PoleschukKR.Sprint3.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 2;
            double value = 1;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.063;

            Assert.AreEqual(wait, res);

        }
    }
}
