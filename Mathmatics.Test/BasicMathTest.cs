using Mathmatics2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mathmatics.Test
{
    public class BasicMathTest
    {
        [Fact]
        public void TestAddNumbers()
        {
            var math = new BasicMath();
            var results =  math.AddNumbers(5,5);
            Assert.True(results == 10);


        }

        [Fact]
        public void TestSubtractNumbers()
        {
            var math = new BasicMath();
            var results = math.SubtractNumbers(5, 5);
            Assert.True(results == 0);


        }

        [Fact]
        public void TestMultiplyNumbers()
        {
            var math = new BasicMath();
            var results = math.MultiplyNumbers(5, 5);
            Assert.True(results == 25);


        }

        [Fact]
        public void TestDivideNumbers()
        {
            var math = new BasicMath();
            var results = math.DivideNumbers(5, 5);
            Assert.True(results == 1);


        }

        [Fact]
        public void TestCalcArea()
        {
            var math = new AdvMath();
            var results = math.calcArea(5, 5);
            Assert.True(results == 25);


        }

        [Fact]
        public void TestCalcAvgList()
        {
            var math = new AdvMath();
            var results = math.avgOfList(100, 50, 60, 70);
            Assert.True(results == 70);


        }

        [Fact]
        public void TestCalcSquared()
        {
            var math = new AdvMath();
            var results = math.calcSqr(10);
            Assert.True(results == 100);


        }

        [Fact]
        public void TestCalcPathag()
        {
            var math = new AdvMath();
            var results = math.CalcPathag(6,6);
            Assert.True(results == 8.48528137423857);


        }


    }
}
