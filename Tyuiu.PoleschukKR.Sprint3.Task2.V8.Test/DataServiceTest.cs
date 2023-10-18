using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint3.Task2.V8.Lib;

namespace Tyuiu.PoleschukKR.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 3;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.224;
            Assert.AreEqual(wait, res);
        }
    }
}
