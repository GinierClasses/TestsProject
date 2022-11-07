
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjetTests.Tests
{
    [TestClass]
    public class CalculatriceTests
    {
        [TestMethod]
        public void Calling_Addition_With_3_And_5_Should_Return_8()
        {
            var calculatrice = new Calculatrice();
            var result = calculatrice.Addition(3, 5);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Calling_Soustraction_With_6_And_2_Should_Return_4()
        { 
            var calculatrice = new Calculatrice();
            var result = calculatrice.Soustraction(6, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Calling_Multiplication_With_6_And_2_Should_Return_12()
        {
            var calculatrice = new Calculatrice();
            var result = calculatrice.Multiplication(6, 2);
            Assert.AreEqual(12, result);
        }


        [TestMethod]
        public void Calling_Division_With_6_And_2_Should_Return_12()
        {
            var calculatrice = new Calculatrice();
            var result = calculatrice.Division(6, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Calling_Division_With_6_And_0_Should_Return_DividedByZeroException()
        {
            var calculatrice = new Calculatrice();
            Assert.ThrowsException<DivideByZeroException>(() => calculatrice.Division(6, 0));
        }


        [DataTestMethod]
        [DataRow(6, 3, 2)]
        [DataRow(10, 2, 5)]
        [DataRow(3, 1, 3)]
        [DataRow(3, 1, 4)]
        public void Calling_Division_With_Parameters_Should_Return_Expected_Result(int number1, int number2, int expected)
        {
            var calculatrice = new Calculatrice();
            var result = calculatrice.Division(number1, number2);
            Assert.AreEqual(expected, result);
        }
    }
}