namespace RootsNUnitTests
{
    using NUnit.Framework;
    using Roots;
    [TestFixture]
    public class FindNthRootNUnitTests
    {
        /// <summary>
        /// This NUnit test check correct value which calculated arithmetic roots
        /// by FindNthRoot.NthRoot method.
        /// </summary>
        /// <param name="numb">the base of the arithmetic root</param>
        /// <param name="exp">exponent of arithmetic root</param>
        /// <param name="accurancy">setted accurancy</param>
        /// <returns></returns>
        [TestCase(1, 5, 0.0001, ExpectedResult = 1)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        [TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        [TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        [TestCase(-0.008, 3, 0.1, ExpectedResult = -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]
        [TestCase(9, 2, 0.1, ExpectedResult = 3)]
        [TestCase(100, 2, 0.1, ExpectedResult = 10)]
        [TestCase(-27, 3, 0.1, ExpectedResult = -3)]
        [TestCase(-14, 5, 0.001, ExpectedResult = -1.695)]
        [TestCase(0.51, 4, 0.000001, ExpectedResult = 0.845)]
        [TestCase(2.811, 6, 0.0001, ExpectedResult = 1.188)]

        public double NthRootNUnitTests(double numb, double exp, double accurancy)
        { 
            return FindNthRoot.NthRoot(numb, exp, accurancy);
        }

        [Test]
        public void NthRootNUnitTests_WithNegativeArguments_ThrowsArgumentException()
        {
            Assert.That(() => FindNthRoot.NthRoot(-9, 2, 0.001),
                Throws.ArgumentException.With.Message
                    .EqualTo("Not execute even-numbered roots from negative number"));
        }

        [Test]
        public void NthRootNUnitTests_WithNegativeRootExponent_ThrowsArgumentException()
        {
            Assert.That(() => FindNthRoot.NthRoot(9, -2, 0.001),
                Throws.ArgumentException.With.Message
                    .EqualTo("Exponent should be only positive number"));
        }

        [Test]
        public void NthRootNUnitTests_WithNotValidAccurancy_ThrowsArgumentException()
        {
            Assert.That(() => FindNthRoot.NthRoot(9, 2, -1),
                Throws.ArgumentException.With.Message
                    .EqualTo("The accurancy is not valid"));
        }
    }
}
