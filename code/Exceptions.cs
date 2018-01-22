using System;

namespace myapp
{
    class Exceptions
    {
        static int divide(int first, int second)
        {
            int result = first / second;
            return result;
        }

        static int divideExceptionHandling(int first, int second)
        {
            int result = 0;
            try{
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero is not allowed");
                Console.WriteLine(ex);
            }
            return result;
        }

        public void usingExceptions()
        {
            int first = 0;
            int second = 0;
            Console.WriteLine("Enter first number:");
            first = System.Int32.Parse( Console.ReadLine());
            Console.WriteLine("Enter second number");
            second = System.Int32.Parse( Console.ReadLine());
            if (first >= second)
            {
            int result = divideExceptionHandling(first,second);
            Console.WriteLine("The result of dividing {0} by {1} is {2}", first,second,result); 
            }
            if (first < second)
            {
                Console.WriteLine("Please divide a bigger number by a smaller number");
            }
        }




    }
}