using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PoleschukKR.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            
            double res = 1;
            while (startValue <= stopValue)
            {
                 res *=  Math.Pow(value, startValue);
                 startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
