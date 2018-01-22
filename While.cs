using System;

namespace myapp
{
    class While {
        public void fourth()
        {
            int n = 0;
            while (n < 6)
            {
                Console.WriteLine("The number in while loop is {0}", n);
                n++;
            }

            int x = 0;
            do{
                Console.WriteLine("The number in do while loop is {0}", x);
                x++;
            }
            while (x < 6);

        }







    }
}