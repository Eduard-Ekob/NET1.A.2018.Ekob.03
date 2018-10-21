namespace Roots
{
    using System;

    /// <summary>
    /// This class find n-th exponent arithmetic root by Newthon method.
    /// </summary>
    public static class FindNthRoot
    {
        /// <summary>
        /// This method calculate arithmetic root n-th exponent with setted accurancy.
        /// </summary>
        /// <param name="numb">The base of the arithmetic root</param>
        /// <param name="exp">exponent of arithmetic root</param>
        /// <param name="accurancy">setted accurancy</param>
        /// <returns>Executed value of arithmetic rootsroot</returns>
        /// <exception cref="ArgumentException">If base of roots is negative number
        /// and exponent is even number </exception>
        /// <exception cref="ArgumentException">If exponent is negative or zero number</exception>
        /// <exception cref="ArgumentException">If accurancy is negative or zero number </exception>
        public static double NthRoot(double numb, double exp, double accurancy)
        {
            if ((numb < 0) && (exp % 2 == 0))
                throw new ArgumentException("Not execute even-numbered roots from negative number");
            if (exp <= 0)
                throw new ArgumentException("Exponent should be only positive number");
            if (accurancy <= 0)
                throw new ArgumentException("The accurancy is not valid");

            const int PRECISION = 1000;
            accurancy = accurancy / PRECISION;
            double approxRoot = numb / (exp * Math.Pow(numb, exp - 1));
            while (true)
            {
                double interp = Math.Pow(approxRoot, exp) - numb;
                if (Math.Abs(interp) < accurancy)
                    break;
                double dx = (-interp) / (exp * Math.Pow(approxRoot, exp - 1));
                approxRoot += dx;
            }
            return Math.Round(approxRoot, 3);
        }
    }
}
