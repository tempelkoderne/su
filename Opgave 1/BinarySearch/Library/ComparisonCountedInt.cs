using System;

namespace Library
{
    public class ComparisonCountedInt : IComparable
    {
        private int value;
        private int comparisonCount;
        public static int HardComparisonIntBin;
        public static int HardComparisonIntLin;


        // ComparisonCountedInt.CountComparisons++;//5.13 adding the int CountComparisons.

        public ComparisonCountedInt (int value)
        {
            this.value = value;
            this.comparisonCount = 0;
        }

        public int CompareTo(object other)
        {
            this.comparisonCount++;
            return this.value.CompareTo (other);
        }

        public int ComparisonCount 
        {
            get 
            {
                return this.comparisonCount;
            }
        }

        // 5.13
        public static int CountComparisons (ComparisonCountedInt [] array)
        {
            int sum = 0;
            foreach (ComparisonCountedInt comp in array) {
                sum += comp.ComparisonCount;
            }
            return sum;
        }

    }

}

