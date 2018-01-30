using System;
namespace myapp
{
    public class bubbleSort
    {
        int [] nums = {6,8,2,10,4};
        bool swapped;
        public bubbleSort()
        {
            Console.WriteLine("Before: 6,8,2,10,4");
            do
            {
            swapped = false;
            for (int i=0; i<nums.Length-1; i++)
            {
                if (nums[i] > nums [i+1])
                {
                    int temp = nums[i+1];
                    nums[i+1] = nums[i];
                    nums[i] = temp;
                    swapped = true;
                }
            }
            }

                while (swapped==true);
                
                    Console.Write("After:");
                    for(int i=0; i < nums.Length; i++)
                    {
                        Console.Write("{0},", nums[i]);
                    }
                
            
        }
    }
}
