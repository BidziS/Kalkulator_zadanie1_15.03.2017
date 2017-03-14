using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kalkulator.Tests
{
    [TestFixture]
    class KalkulatorTests
    {
        [Test]
        public void Add_AddsTwoPositiveNumbers_Calculated()
        {
            var calc = new Kalkulator();
            int sum = calc.Add(2, 2);
            Assert.AreEqual(4, sum);
        }
        [Test]
        public void Add_AddPositiveNumberToNegativeNumber_Calculated()
        {
            var calc = new Kalkulator(); 
            int sum = calc.Add(2, -3);
            Assert.AreEqual(-1, sum);
        }
        [Test]
        public void Add_AddNegativeNumberToPositiveNumber_Calculated()
        {
            var calc = new Kalkulator();
            int sum = calc.Add(-2, 3);
            Assert.AreEqual(1, sum);
        }
        [Test]
        public void Add_AddsTwoNegativeNumbers_Calculated()
        {
            var calc = new Kalkulator();
            int sum = calc.Add(-2, -2);
            Assert.AreEqual(-4, sum);
        }
        /********************************************************************/
        [Test]
        public void DivideNumbers_DivideTwoPossitiveNumbers_Calculated()
        {
            var calc = new Kalkulator();
            double div = calc.DivideNumbers(2, 2);
            Assert.AreEqual(1, div);
        }
        [Test]
        public void DivideNumbers_DivideTwoNegativeNumbers_Calculated()
        {
            var calc = new Kalkulator();
            double div = calc.DivideNumbers(-2, -2);
            Assert.AreEqual(1, div);
        }
        [Test]
        public void DivideNumbers_DivideNegativeNumberToPositiveNumber_Calculated()
        {
            var calc = new Kalkulator();
            double div = calc.DivideNumbers(-2, 2);
            Assert.AreEqual(-1, div);
        }
        [Test]
        public void DivideNumbers_DividePositiveNumberToNegativeNumber_Calculated()
        {
            var calc = new Kalkulator();
            double div = calc.DivideNumbers(2, -2);
            Assert.AreEqual(-1, div);
        }
        [Test]
        public void DivideNumbers_DivideSmallerNumberToBiggerNumber_Calculated()
        {
            var calc = new Kalkulator();
            double div = calc.DivideNumbers(2, 4);
            Assert.AreEqual(0.5, div);
        }
        [Test]
        public void DivideNumbers_DivideZeroToAnyNumber_Calculated()
        {
            var calc = new Kalkulator();
            double div = calc.DivideNumbers(0, 2);
            Assert.AreEqual(0, div);
        }
        public void DivideNumbers_DividebyZero_Calculated()
        {
            var calc = new Kalkulator();
            Assert.Throws<DivideByZeroException>(() => calc.DivideNumbers(2, 0));
        }
    }
}
