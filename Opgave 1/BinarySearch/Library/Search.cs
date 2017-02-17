using System;

namespace Library
{
    public static class Search
    {
        public static int Binary (IComparable[] array, IComparable target)
        {
            // Checks if the target is lesser or greater than the smallest
            // and greatest value in the array.
            if (array.Length > 0)
            {
                IComparable first = array [0];
                IComparable last = array [(array.Length - 1)];
                if ((target.CompareTo (first) < 0) || (target.CompareTo (last) > 0)) {
                    Console.WriteLine ("Target is lesser or greater than " +
                                       "the first or last element in the array.");
                }
            }

            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                ComparisonCountedInt.HardComparisonIntBin++;// This is where we count!
                int mid = low + (high - low) / 2;
                IComparable midVal = array[mid];
                int relation = midVal.CompareTo (target);
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

        public static int Linear (IComparable [] array, IComparable target)
        {
            int length = array.Length - 1;

            for (int i = 0; i <= length; i++) {
                if (array [i].CompareTo (target) == 0) {
                    return i;
                }
                ComparisonCountedInt.HardComparisonIntLin++;

            }
            return -1;
        }


    }
}