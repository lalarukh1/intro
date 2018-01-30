using System;
namespace myapp
{
    public class InsertionSort
    {
        int [] arr = {0,8,6,3,10,20,4,5};
        int newValue;

        public InsertionSort()
        {
            Console.WriteLine("Before: 0,8,6,3,10,20,4,5");
            for (int i=1; i <arr.Length; i++)
            {
                newValue = arr[i];
                int j = i;

                while (j > 0 && arr[j-1] > newValue)
                {
                    arr[j] = arr[j-1];
                    j--;
                }
                arr[j] = newValue;
            }

            Console.Write("After: ");
            foreach (int val in arr)
            {
                Console.Write(val + ",");
            }
        }
    }
}