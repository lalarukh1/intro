using System;
namespace myapp
{
class IfCheck 
{
public void check() {

Console.WriteLine("Please enter integer value.");
int input = Int32.Parse(Console.ReadLine());

if (input % 2 == 0)
{
    Console.WriteLine("It is an even number");
}
    else
    {
        Console.WriteLine("It is an odd number");
    }
}

}

    }
