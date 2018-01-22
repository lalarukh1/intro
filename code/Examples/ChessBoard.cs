using System;

namespace myapp
{
class ChessBoard{
    public void boardDisplay()
    {
    for (int i=1; i<9; i++)
    {
        for (int j=0; j<4; j++)
        {
            if ((i % 2) == 0)
            {
            Console.Write("X");
            Console.Write("O");
            }
            else{
            Console.Write("O");
            Console.Write("X");
            }
                       
        }
        Console.WriteLine();
    }
    }
}
}