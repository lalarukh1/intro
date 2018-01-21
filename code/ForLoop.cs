using System;
namespace myapp
{
class ForLoop
{
    public void third()
    {
int outer;
int inner;

for(outer = 2; outer < 100; outer++)
{
    for (inner = 2; inner < (outer/inner); inner++)
    {
        if ((outer % inner) == 0)
        {
            break;
        }
        if ((outer % inner) != 0)
        {  
            Console.WriteLine("{0} is Prime number", outer);
            break;
        }
        
    }

}
    }
}
}