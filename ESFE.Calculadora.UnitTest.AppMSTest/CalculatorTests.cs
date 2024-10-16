using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESFE.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Calculadora.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            Double result = calculator.Add(5, 3);

            //Asert
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            double result = calculator.Subtract(5, 3);

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            double result = calculator.Multiply(5, 3);

            //Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            double result = calculator.Divide(6, 2);

            //Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideByZeroTest()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act (Expecting an exception)
            double result = calculator.Divide(5, 0);
        }
    }
}