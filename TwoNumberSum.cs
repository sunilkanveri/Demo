using System;
namespace Programs
{
    public class Numbers
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // Write your code here.
            int[] ret = new int[0];
            for (int j = 0; j < array.Length; j++)
            {
                foreach (int i in array)
                {
                    if (i + array[j] == targetSum)
                    {
                        ret = new int[2];
                        ret[0] = i;
                        ret[1] = array[j];
                    }
                }
            }
            return ret;
        }
    }
}