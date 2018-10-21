namespace NumberCombination
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// This class search all combinations of digits from number.
    /// And find first entry greater than source number
    /// </summary>
    public static class Combinations
    {
        private static int result;
        private static int sourceNumb;
        private static int previous;
        private static int index;
        /// <summary>
        /// This method take integer positiv number like a source number.
        /// </summary>
        /// <param name="numb">Source number</param>
        /// <returns>If doesnt exist return -1 value</returns>
        public static int FindNextBiggerNumber(int numb)
        {
            sourceNumb = numb;
            previous = numb;
            result = -1;
            index = 0;
            
            char[] strChars = numb.ToString().ToCharArray();
            int[] sourceArr = new int[strChars.Length];
            for(int i = 0; i < strChars.Length; i++)
            {
                sourceArr[i] = int.Parse(strChars[i].ToString());
            }

            GetCombinations(sourceArr);

                return result;            
        }
        private static void GetCombinations(int[] permutArr)
        {
            int m = permutArr.Length - 1;
            GetCombinations(permutArr, 0, m);
        }
        private static void GetCombinations(int[] permutArr, int k, int m)
        {
            int i;            
            string tempConcat = string.Empty;
            if (k == m)
            {
                //collect number from array and convert to string 
                for (i = 0; i <= m; i++)
                {
                    tempConcat += permutArr[i].ToString();
                }
                //convert number from string format to integer
                int next = int.Parse(tempConcat);
                // skip first entry
                if(sourceNumb < next)
                {
                    if (index < 1)
                    {
                        index++;
                        previous = next;
                        result = next;
                    }
                    // compare i and i+1
                    else if (previous > next)
                    {
                        previous = next;
                        result = previous;
                    }
                    
                }
            }
            else
                for (i = k; i <= m; i++)
                {
                    Swap(ref permutArr[k], ref permutArr[i]);
                    GetCombinations(permutArr, k + 1, m);
                    Swap(ref permutArr[k], ref permutArr[i]);
                }            
        }
        private static void Swap(ref int a, ref int b)
        {
            if (a == b) return;
            int temp = a;
            a = b;
            b = temp;            
        }


    }
}
