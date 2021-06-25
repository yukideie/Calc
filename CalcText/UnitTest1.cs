using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Calc.Other;

namespace CalcText
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Plus()
        {
            //не получается <3
            double num1 = 12;
            double num2 = 21;
            double ex = 33;
            double res = Calc.Plus(num1, num2);
        }
    }
}
