namespace NumberCombinationMSTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NumberCombination;
    [TestClass]
    public class CombinatonsMSTests
    {
        [TestMethod]
        public void FindNextBiggerNumber_TakeSourceNumer_ReturnFirstGreateNumber()
        {
            int[,] result = new int[,]
            {
                // Format {sourcenumber, expected number}
                { 12, 21 },
                { 513, 531 },
                { 2017, 2071 },
                { 414, 441 },
                { 144, 414 },
                { 1234321, 1241233 },
                { 3456432, 3462345 },
                { 10, -1 },
                { 20, -1 },
                { 1234126, 1234162 }
            };
            for (int i = 0; i < result.GetLength(0); i++)
            {
                Assert.AreEqual(Combinations.FindNextBiggerNumber(result[i, 0]), result[i, 1]);
            }

        }

    }
}
