using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit_1;

namespace calculator_test
{
    [TestFixture]
    class TestCalculator
    {
        string name;
        Calculator calculator;
        [SetUp]
        public void SetUp()
        {
            name = "CTS";
            Assert.AreEqual("CTS", name);
            calculator = new Calculator();

        }
        [Test] 
        [Repeat(2)]
        [MaxTime(100)]
        public void AddMethodTest() 
        {
 
            int result = calculator.Add(25, 65);
            Assert.AreEqual(90, result);
        }
        [Test]
        [TestCase(125,65,60)]
        [TestCase(120, 60, 60)]
        [TestCase(120, 65, 55)]




        public void Subtractmethodtest(int num1,int num2,int expected)
        {
            
            int result = calculator.Subtract(num1, num2);
            Assert.AreEqual(expected, result);
        }



        [Test]
        [Ignore("Don't run this test as duplicate")]
        public void AddMethodTest2()
        {
            int result = calculator.Add(-125, 65);
            Assert.AreEqual(-60, result);
        }
    }
}
