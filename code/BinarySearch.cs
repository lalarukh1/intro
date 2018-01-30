using System;
namespace myapp
{
    public class BinarySearch
    {
        int[] arr1 = {3,4,5,6,7,8,9};
        int term = 7;

        public BinarySearch()
        {
            int result = usingBinarySearch(arr1, term, 0, arr1.Length-1);

            if (result != -1)
            {
                Console.WriteLine($"The search term was found at {result+1}th position");
            }
            else
            {
                Console.WriteLine("Search term not found");
            }

        }

        public static int usingBinarySearch(int[] arr, int key, int first, int last)
        {
            while (first <= last)
            {
                int mid = (first + last)/2;

                if (key == arr[mid])
                {
                    return mid;
                }

                else if (key < arr[mid])
                {
                    last = mid - 1;
                }
                else 
                {
                    first = mid + 1;  
                }

            } 
            return -1;
        }
    }
}