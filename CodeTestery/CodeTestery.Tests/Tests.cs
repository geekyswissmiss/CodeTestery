using System;
using System.Collections.Generic;
using NUnit.Framework;
using Deem.Internal.Tests;
using Playground;

namespace CodeTestery.Tests
{
    public class Tests : BaseTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        [Test]
        public void CountBALLOONTestMethod1()
        {
            String letters = "BLONDGALO";            
            Playground.WordFinder2 wordFinder2 = new Playground.WordFinder2();
            var wordCount = wordFinder2.CountBALLOON(letters);
            var expectedCount = 1;

            Assert.AreEqual(expectedCount, wordCount);
        }

        [Test]
        public void CountBALLOONTestMethod2()
        {
            String letters = "BERSDLNOBL";
            Playground.WordFinder2 wordFinder2 = new Playground.WordFinder2();
            var wordCount = wordFinder2.CountBALLOON(letters);
            var expectedCount = 0;

            Assert.AreEqual(expectedCount, wordCount);
        }

        [Test]
        public void CountBALLOONTestMethod3()
        {
            String letters = "LLMNOOABBAJNKLOLOPBLLANQW";
            Playground.WordFinder2 wordFinder2 = new Playground.WordFinder2();
            var wordCount = wordFinder2.CountBALLOON(letters);
            var expectedCount = 2;

            Assert.AreEqual(expectedCount, wordCount);
        }
        [Test]
        public void WordCalcTestMethod1()
        {
            var numberOne = 2;
            var numberTwo = "four";
            WordCalc.WordCalc wordCalc = new WordCalc.WordCalc(numberOne, numberTwo);
            var product = wordCalc.Multiply();
            var expectedProduct = 8;

            Assert.AreEqual(expectedProduct, product);
        }

        [Test]
        public void WordCalcTestMethod2()
        {
            var numberOne = 4;
            var numberTwo = "five";
            WordCalc.WordCalc wordCalc = new WordCalc.WordCalc(numberOne, numberTwo);
            var product = wordCalc.Multiply();
            var expectedProduct = 20;

            Assert.AreEqual(expectedProduct, product);
        }

        [Test]
        public void WordCalcTestMethod3()
        {
            var numberOne = 7;
            var numberTwo = "seven";
            WordCalc.WordCalc wordCalc = new WordCalc.WordCalc(numberOne, numberTwo);
            var product = wordCalc.Multiply();
            var expectedProduct = 49;

            Assert.AreEqual(expectedProduct, product);
        }

        [Test]
        public void WordFinderTestMethod1()
        {
            String letters = "BLONDGALO";
            String findMe = "BALLOON";
            var wordCount = WordFinder.WordFinder.WordCount(letters, findMe);
            var expectedCount = 1;

            Assert.AreEqual(expectedCount, wordCount);
        }

        [Test]
        public void WordFinderTestMethod2()
        {
            String letters = "BERSDLNOBL";
            String findMe = "BALLOON";
            var wordCount = WordFinder.WordFinder.WordCount(letters, findMe);
            var expectedCount = 0;

            Assert.AreEqual(expectedCount, wordCount);
        }

        [Test]
        public void WordFinderTestMethod3()
        {
            String letters = "LLMNOOABBAJNKLOLOPBLLANQW";
            String findMe = "BALLOON";
            var wordCount = WordFinder.WordFinder.WordCount(letters, findMe);
            var expectedCount = 2;

            Assert.AreEqual(expectedCount, wordCount);
        }
    }
}
