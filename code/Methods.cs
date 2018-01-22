using System;

namespace myapp
{
    class Methods
    {
        static void sum (int first, int second)
        {
            int sum = first + second;
            Console.WriteLine("Sum of {0} and {1} is {2}", first,second,sum);
        }

        static int sum1 (int first, int second)
        {
            int sum = first + second;
            Console.WriteLine("Sum1 of {0} and {1} is {2}", first,second,sum);
            return sum;
        }

        static int sum1 (int first, int second, int third)
        {
            int sum = first + second + third;
            Console.WriteLine("Sum of {0}, {1} and {2} is {3}", first,second,third,sum);
            return sum;
        }

        static double sum1(double first, double second)
        {
            double sum = first + second;
            Console.WriteLine("Sum1 of {0} and {1} is {2}, double", first,second,sum);
            return sum;
        }

        public void usingMethods()
        {
            sum(20,30);
            int result1 = sum1(20,30);
            Console.WriteLine("using two integers {0}", result1);
            int result2 = sum1(20,30,40);
            Console.WriteLine("Using three integers {0}", result2);
            double result3 = sum1(20.5,29.5);
            Console.WriteLine("Using two doubles {0}", result3);
        }




    }
}