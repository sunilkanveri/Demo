using System;
using System.Collections.Generic;

namespace Programs
{
    class ValidSubsequence
    {
        bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int arrIdx = 0;
            int seqIdx = 0;
            while (seqIdx < sequence.Count && arrIdx < array.Count)
            {
                if (array[arrIdx] == sequence[seqIdx])
                {
                    arrIdx++;
                }
                seqIdx++;
            }
            return seqIdx == sequence.Count;
        }
    }
}

