namespace RootsMSTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Roots;
    using System;
    [TestClass]
    public class FindNthRootMSTests
    {
        /// <summary>
        /// This MSTest test check correct value which calculated arithmetic roots
        /// by FindNthRoot.NthRoot method.
        /// </summary>
        
        [TestMethod]
        public void NthRoot_TakesArguments_ReturnCalculatedRoots()
        {
            //< param name = "result" > It's array wich contains testcases for FindNthRoot.NthRoot method.
            //</ param >
            double[,] result = new double[,]
            {
                // Format {numb, exp, accurancy, expected value}. Where "numb" is the base of the arithmetic root,
                // "exp" is the exponent of arithmetic root, accurancy is the setted accurancy
                { 1, 5, 0.0001, 1 },
                { 8, 3, 0.0001, 2 }, 
                { 0.001, 3, 0.00010, 0.1 },
                { 0.04100625, 4, 0.0001, 0.45 },
                { 8, 3, 0.0001, 2 },
                { 0.0279936, 7, 0.0001, 0.6 },
                { 0.0081, 4, 0.1, 0.3 },
                { -0.008, 3, 0.1, -0.2 },
                { 0.004241979, 9, 0.00000001, 0.545 },
                { 9, 2, 0.1, 3 },
                { 100, 2, 0.1, 10 },
                { -27, 3, 0.1, -3 },
                { -14, 5, 0.001, -1.695 },
                { 0.51, 4, 0.000001, 0.845 },
                { 2.811, 6, 0.0001, 1.188 }
            };
            for (int i = 0; i < result.GetLength(0); i++)
            {
                Assert.AreEqual(FindNthRoot.NthRoot(result[i, 0], result[i, 1], result[i, 2]),result[i, 3]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NthRoot_WithNegativeRootExponent_ThrowsArgumentException()
            => FindNthRoot.NthRoot(-9, 2, 0.001);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NthRoot_WithNegativeRootExponent_ThrowsArgumentExceptio()
            => FindNthRoot.NthRoot(9, -2, 0.001);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NthRoot_WithNotValidAccurancy_ThrowsArgumentException()
            => FindNthRoot.NthRoot(9, 2, -1);


    }
}