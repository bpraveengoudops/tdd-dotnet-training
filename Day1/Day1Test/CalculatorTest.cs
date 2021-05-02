using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

using Day1;

namespace Day1Test
{
    class CalculatorTest
    {

        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {
            Assert.AreEqual(0, Calculator.Add(string.Empty));
        }

        public void Add_StringContainingSingleNumber_ReturnsTheNumberItself()
        {
            Assert.AreEqual(5, Calculator.Add("5"));
        }

        [Test]
        public void Add_TwoNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "7,8";
            var expectedResult = 15;
            Assert.AreEqual(expectedResult, Calculator.Add(numbers));
        }

        [Test]
        public void Add_ThreeNumbersSeparatedByComma_ReturnsTheirSum()
        {
            var numbers = "1, 2, 3";
            var expected = 6;
            Assert.AreEqual(expected, Calculator.Add(numbers));
        }

        [TestCase("1,2,3,4", 10)]
        [TestCase("8,7,20", 35)]
        [TestCase("5,0,4,1001", 9)]
        [TestCase("5,0,4,1000", 1009)]
        [TestCase("26,6,90", 122)]
        public void Add_MoreThanThreeNumbersSeparatedByComma_ReturnsTheirSum(
    string input, int result)
        {
            Assert.AreEqual(result, Calculator.Add(input));
        }


        [TestCase("1,2,3,4,5,-5")]
        [TestCase("-1,1,2,9")]
        [TestCase("5,6,8,-5")]
        public void Add_StringContainingNegativeNumbers_Throws(string numbers)
        {
            Assert.Throws<ArgumentException>(() => Calculator.Add(numbers));
        }


       
    }
}
