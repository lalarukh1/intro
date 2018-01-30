using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace myapp
{
    public class LinearSearch1
    {
        int[] searchArray = {4,10,3,9,2,7,5,0,11};
        int term = 11;
        public LinearSearch1()
        {
            int index = usingLinearSearch(searchArray,term);
            if (index != -1)
            {
                Console.WriteLine($"Your search was found at {index+1}th position");
            }
            else
            {
                Console.WriteLine("Search term not found");
            }
        
        }

        public int usingLinearSearch(int[] searchArray,int term)
        {
            for (int i=0; i < searchArray.Length; i++)
        {
            if(searchArray[i] == term)
            {
                return i;
            }
        }
        return -1;
        }
    }
}