using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mathmatics2
{
    public class AdvMath
    {
        public double calcArea(double Height, double Width)
        {
            return Height*Width;
        }

        public double avgOfList(double num1, double num2, double num3, double num4)
        {
            List<double> doubleList = new List<double>();

            doubleList.Add(num1);
            doubleList.Add(num2);
            doubleList.Add(num3);
            doubleList.Add(num4);

            double avg = Queryable.Average(doubleList.AsQueryable());


            return avg;
        }

        public double calcSqr(double num1)
        {
            return Math.Pow(num1, 2);
        }

        public double CalcPathag(double a, double b)
        {       
            
            double c = Math.Pow(a, 2) + Math.Pow(b, 2); 

            return Math.Sqrt(c);
        }


    }
}
