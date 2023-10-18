using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PoleschukKR.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            do
            {
                res *= 1 / (Math.Pow(Math.Cos(5) + 1, 2));
                startValue++;

            } while (startValue <= stopValue);

            return Math.Round(res, 3);

        }
    }
}
