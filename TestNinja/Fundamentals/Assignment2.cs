﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment2
    {
        /// <summary>
        /// Функция получает число и возвращает десятичные числа в числовом интервале
        /// </summary>
        /// <param name="year">конечное число</param>
        /// <returns></returns>
        public IEnumerable<int> GetNumbersDivedBy100(int year)
        {
            for (int i = 1; i <= year; i++)
            {
                if (i % 100 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
