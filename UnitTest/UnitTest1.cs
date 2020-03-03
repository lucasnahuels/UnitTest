using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void IsLeapYearSecondShot_YearNotDivisibleBy4InCommonYear()
        {
            var result = Year.IsLeapYearSecondShot(2015);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsLeapYearSecondShot_YearDivisibleBy4AndBy100NotBy400InCommonYear()
        {
            var result = Year.IsLeapYearSecondShot(1900);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsLeapYearSecondShot_YearDivisibleBy400InLeapYear()
        {
            var result = Year.IsLeapYearSecondShot(2000);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsLeapYearSecondShot_YearDivisibleBy200NotBy400InCommonYear_ReturnFalse()
        {
            var result = Year.IsLeapYearSecondShot(1800);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsLeapYearSecondShot_YearGreaterThan8000_ReturnArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => Year.IsLeapYearSecondShot(8001));
        }

        [TestMethod]
        public void IsLeapYearSecondShot_YearGreaterThan5000_ReturnArgumentExceptionMessage()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() => Year.IsLeapYearSecondShot(8001));

            Assert.AreEqual("El numero debe ser menor a 8000", ex.Message);
        }
    }
}
