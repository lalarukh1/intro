using System;
namespace myapp
{
class Switch
{
    public void second()
    {
    Console.WriteLine(" ");    
    Console.WriteLine("Coffee 1=small 2=medium 3=large");
    Console.WriteLine("Enter your selection, you coffee freak!");
    
    String str = Console.ReadLine();
    int cost = 0;

    switch(str)
    {
        case "1":
        case "small":
        cost +=25;
        break;

        case "2":
        case "medium":
        cost +=50;
        break;

        case "3":
        case "large":
        cost +=75;
        break;

        default:
        Console.WriteLine("Please enter a valid value");
        break;
    }

    if (cost !=0)
    {
        Console.WriteLine("You owe me {0} pounds", cost);

    }
    }
    
}
}