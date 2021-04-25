using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit_1;

namespace CalculatorAssertTest
{
    public class TestCalulatorAssert
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
        [TestCase(125, 65, 190)]
        [TestCase(120, 60, 180)]
        [TestCase(120, 65, 185)]
        public void AddmethodTest(int num1, int num2, int expected)
        {
            int result = calculator.Add(num1, num2);
            Assert.True(expected==result);
            Assert.IsTrue(expected == result);
            Assert.IsFalse(expected > result);
        }
        [Test]
         [TestCase(41, 41, 82)]
        //[TestCase(120, 60, 180)]
        //[TestCase(120, 65, 185)]
        public void AddConstrainTest(int num1, int num2, int expected)
        {
            int result = calculator.Add(num1, num2);
            Assert.That(result, Is.EqualTo(expected));
            Assert.That(name, Is.EqualTo("CTS"));             
            Assert.That(result, Is.GreaterThan ( 0));             
            Assert.That(result, Is.GreaterThanOrEqualTo(80));             
            Assert.That(result, Is.LessThan(100));             
            Assert.That(result, Is.LessThanOrEqualTo(1000));

            // Assert.That(result, Is.InRange(60, 100));             
            //Assert.That(name, Contains.Substring("Cognizant"));             
            //Assert.That(name, Contains.Substring("cognizant").IgnoreCase);             
            // Assert.That(name, Does.Contain("cognizant").IgnoreCase);             
            //string pattern = @"C*s";             
            //pattern = @"^[0-9]{6}$";             
            //Assert.That("1987658", Does.Match(pattern));             
            //Assert.That(Name, Does.Contain("Tech"));
        }
    }
}
