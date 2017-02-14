using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery.models;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            Factorial factorial = new Factorial();

            Assert.IsNotNull(factorial);
        }

        [TestMethod]
        public void EnsureFactorialCalcInterative()
        {
            Factorial factorial = new Factorial();
            
            int expectedResult = 120;

            int actualResult = factorial.Iterative(5);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFactorialCalcRecursive()
        {
            Factorial factorial = new Factorial();

            int expectedResult = 120;

            int actualResult = factorial.Recursive(5);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void EnsureFactorialCalcRecursiveFails()
        {
        }

        [TestMethod]
        //Hint: what goes here to say an exception is expected?
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void EnsureFactorialCalcIterativeFails()
        {
        }
    }
}
