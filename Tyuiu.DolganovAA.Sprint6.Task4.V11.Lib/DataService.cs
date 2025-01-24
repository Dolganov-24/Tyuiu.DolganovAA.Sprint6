﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.DolganovAA.Sprint6.Task4.V11.Lib
{
    public class DataService : ISprint6Task4V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[11];
            double j = startValue;
            for (int i = 0; i < res.Length; i++)
            {
                if ((2d - (2d * j)) != 0)
                {
                    res[i] = Math.Round(Math.Cos(j) + (Math.Sin(j) / (2d - (2d * j))) - 4d * j, 2);
                }
                else
                {
                    res[i] = 0;
                }
                j++;
            }
            return res;
        }
    }
}