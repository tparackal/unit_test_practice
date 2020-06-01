using NUnit.Framework;
using Services;

namespace Tests
{
    [TestFixture]
    public class Calculate
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Should_Add()
        {
            var result = _calculator.Add(1, 1);
            Assert.AreEqual(result, 2, "1 + 1 = 2");
        }

        [Test]
        public void Should_Subtract()
        {
            var result = _calculator.Subtract(1, 1);
            Assert.AreEqual(result, 0, "1 - 1 = 0");
        }

        [Test]
        public void Should_Divide()
        {
            var result = _calculator.Divide(15, 3);
            Assert.AreEqual(result, 5, "15 / 3 = 5");
        }

        [Test]
        public void Should_Multiply()
        {
            var result = _calculator.Multiply(3, 3);
            Assert.AreEqual(result, 9, "3 * 3 = 9");
        }

        [Test]
        public void Should_Mod()
        {
            var result = _calculator.Mod(9, 2);
            Assert.AreEqual(result, 1, "9 % 2 = 1");
        }

        [Test]
        public void Should_DecimalDivide()
        {
            var result = _calculator.DecimalDivide(7.0, 2.0);
            Assert.AreEqual(result, 3.5, "7 / 2 = 3.5");
        }

        [Test]
        public void Should_Average()
        {
            var result = _calculator.Average(3, 7);
            Assert.AreEqual(result, 5, "(3 + 7) / 2 = 5");
        }

        [Test]
        public void Should_DecimalAverage()
        {
            var result = _calculator.DecimalAverage(3.5, 7.5);
            Assert.AreEqual(result, 5.5, "(3.5 + 7.5) / 2");
        }

        [Test]
        public void Should_DecimalPower()
        {
            var result = _calculator.DecimalPower(2, 3);
            Assert.AreEqual(result, 8.0, "2^3 = 8");
        }

        [Test]
        public void Should_Power()
        {
            var result = _calculator.Power(2, 3);
            Assert.AreEqual(result, 8, "2^3 = 8");
        }

        [Test]
        public void Should_Power0()
        {
            var result = _calculator.Power(5, 0);
            Assert.AreEqual(result, 1, "5^0 = 1");
        }

        [Test]
        public void ShouldPower1()
        {
            var result = _calculator.Power(5, 1);
            Assert.AreEqual(result, 5, "5^1 = 5");
        }
    }
}