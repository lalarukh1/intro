using System;
namespace myapp
{
    public class SelectionSort
    {
        int [] arr = {3,9,1,4,8,1,10,7};
        
        int pos;
        int temp;

        public SelectionSort()
        {
            Console.WriteLine("Before: 3,9,1,4,8,1,10,7");
            for(int i =0; i < arr.Length-1; i++)
            {
                
                pos = i;
                for (int j=i+1; j<arr.Length; j++)
                {
                    if(arr[j] < arr[pos])
                    {
                        pos = j;
                    }
                }

                    if (pos != i)
                    {
                        temp = arr[i];
                        arr[i] = arr[pos];
                        arr[pos] = temp;
                    }       

            }
            Console.Write("After: ");

            foreach (int arr1 in arr)
            {
                Console.Write(arr1 + ",");
            }
        }
    }
}