﻿using System;

namespace Library
{
    public static class Search
    {
        public static int Binary (IComparable[] array, IComparable target)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                IComparable midVal = array[mid];
                int relation = midVal.CompareTo (target);
                ComparisonCountedInt.CountComparisons++;// Er det her den der counter ting skal være fra opgave 5.13???
                if (relation < 0)
                {
                    low = mid + 1;
                }
                else if (relation > 0)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}