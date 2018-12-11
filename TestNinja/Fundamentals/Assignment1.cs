using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment1
    {
        /// <summary>
        /// Возвращает степень числа
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="count">Степень</param>
        /// <returns></returns>
        public string PowerOfNumber(double number,int count)
        {
            number = Math.Pow(number, count);
            return Convert.ToString(number);
        } 
    }
}
