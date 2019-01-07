using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Factorizer.BLL;

namespace Factorizer.Tests
{
    [TestFixture]
    class FactorizerTests
    {

        [TestCase(7, true)]
        [TestCase(131, true)]
        [TestCase(6, false)]
        public void PrimeNumberTest(int number, bool expected)
        {
            PrimeChecker pc = new PrimeChecker();

            bool actual = pc.IsPrimeNumber(number);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(6, true)]
        [TestCase(496, true)]
        [TestCase(8, false)]
        public void PerfectNumberTest(int number, bool expected)
        {
            PerfectChecker pc = new PerfectChecker();

            bool actual = pc.IsPerfectNumber(number);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(120, new int[] { 1, 2, 3, 4, 5, 6, 8, 10, 12, 15, 20, 24, 30, 40, 60, 120 })]
        [TestCase(9, new int[] { 1, 3, 9 })]
        [TestCase(2, new int[] { 1, 2 })]
        [TestCase(0, new int[] { 0 })]
        public void FactorFinderTest(int number, int[] expected)
        {
            FactorFinder ff = new FactorFinder();

            int[] actual = ff.GetFactors2(number);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void FactorFinderTest1()
        {
            FactorFinder ff = new FactorFinder();

            List<int> actual = ff.GetFactors(120);
            Assert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 8, 10, 12, 15, 20, 24, 30, 40, 60, 120 }, actual);
        }

        [Test]
        public void FactorFinderTest2()
        {
            FactorFinder ff = new FactorFinder();

            List<int> actual = ff.GetFactors(9);
            Assert.AreEqual(new List<int> { 1, 3, 9 }, actual);
        }

        [Test]
        public void FactorFinderTest3()
        {
            FactorFinder ff = new FactorFinder();

            List<int> actual = ff.GetFactors(2);
            Assert.AreEqual(new List<int> { 1, 2 }, actual);
        }

        [Test]
        public void FactorFinderTest4()
        {
            FactorFinder ff = new FactorFinder();

            List<int> actual = ff.GetFactors(0);
            Assert.AreEqual(new List<int> { 0 }, actual);
        }

    }
}
