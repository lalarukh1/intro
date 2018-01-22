using System;

namespace myapp
{
    class MultipleReturn
    {
        int age;
        string name;
        public void returnMultiOut(out int i, out string s)
        {
            i = 26;
            s = "lalarukh";
        }

        public void returnMultiRef(ref int i, ref string s)
        {
            i = 56;
            s = "Stevejobs";
        }

        public void useReturns()
        {
            returnMultiOut(out age, out name);
            Console.WriteLine("{0} is {1} years old", name, age);

            age = 0;
            name = " ";
            returnMultiRef(ref age, ref name);
            Console.WriteLine("{0} is {1} years old", name, age);
        }
    }
}