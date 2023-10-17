using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint3.Task1.V13.Lib;

namespace Tyuiu.PoleschukKR.Sprint3.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;
            double value  = 1.2;
            

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 164.845;
            Assert.AreEqual(wait, res);
        }
    }
}
