using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetTests.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Caling_FizzBuzz_With1_Should_Return_1(){
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.FizzBuzzTest(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Calling_FizzBuzzTest_With3_Should_Return_Fizz()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.FizzBuzzTest(3);
            Assert.AreEqual("Fizz", result);
        }
        [TestMethod]
        public void Calling_FizzBuzzTest_With5_Should_Return_Buzz()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.FizzBuzzTest(5);
            Assert.AreEqual("Buzz", result);
        }
        [TestMethod]
        public void Calling_FizzBuzzTest_With15_Should_Return_FizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.FizzBuzzTest(15);
            Assert.AreEqual("FizzBuzz", result);
        }


        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, "Fizz")]
        [DataRow(4, 4)]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        public void Calling_Division_With_Parameters_Should_Return_Expected_Result(int number1, object expected)
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.FizzBuzzTest(number1);
            Assert.AreEqual(expected, result);
        }


    }
}
