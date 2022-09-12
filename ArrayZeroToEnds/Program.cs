
using System;
using System.Collections.Generic;

namespace ArrayZeroToEnd;

public static class Program
{
    public static void Main()
    {

    }

    public static int[] MoveZeroes(int[] arr)
    {
        List<int> sortArray = new List<int>();
        int zeroCount = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                zeroCount += 1;
            }
            else
            {
                sortArray.Add(arr[i]);
            }

        }

        while (zeroCount != 0)
        {
            sortArray.Add(0);
            zeroCount -= 1;
        }

        return sortArray.ToArray();
    }
}
