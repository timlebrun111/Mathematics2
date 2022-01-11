using System;
using System.Collections.Generic;
using System.Text;

namespace Mathmatics2
{
    public class BasicMath
    {
        /// <summary>
        /// This is a function that adds two numbers together
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        public double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        public double DivideNumbers(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
