using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit_1;

namespace CalculatorExceptionTest
{
    public class ExceptionTest
    {
        [Test]
        [TestCase(12, 2, 6)]
        [TestCase(12, 0, 6)]
        public void CalculateDivideExceptionTest(int num1, int num2, int expected)
        {
            Calculator calculator = new Calculator();
            int result;
            //Assert.Throws<DivideByZeroException>(() => result = calculator.Divide(num1, num2));

            //exception testing using try catch
            try {
                result = calculator.Divide(num1, num2);
                Assert.AreEqual(expected, result);
                //Assert.Fail();
            }
            catch (DivideByZeroException e)
            {
                List<string> messages = new List<string> {​ e.Message }​;
                Assert.Contains("Attempted to divide by zero.", messages);
            }
        }
    }
}
