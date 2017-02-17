using System;
namespace Library
{
    public static class LinSearch
    {
        public static int Lin (IComparable [] array, IComparable target)
        {
            int length = array.Length - 1;

            for (int i = 0; i <= length; i++)
            {
                if (array[i].CompareTo(target)==0) 
                {
                    return i;
                }


            }
            return -1;
        }
    }
}
